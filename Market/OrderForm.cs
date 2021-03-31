using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Market.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class OrderForm : MetroForm
    {
        private User user;
        public DataTable myDataTable;
        private UltraGridRow selectedRow;

        private List<Client> Clients;
        private List<ProductType> ProductTypes;

        private Order Order = new Order();

        public OrderForm(User _user)
        {
            user = _user;

            Order.OrderDetails = new List<OrderDetails>();

            InitializeComponent();

            PrepareColumns();

            // hide drag header area
            OrderDetailsDataGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            // all columns auto resize
            OrderDetailsDataGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

            // center content
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[0].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[1].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[3].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[4].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[5].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

            // first column as checkbox
            UltraGridColumn ugc = OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns["Selected"];
            ugc.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ugc.CellActivation = Activation.AllowEdit;

            // stop confirmation message on delete
            OrderDetailsDataGrid.DisplayLayout.ShowDeleteRowsPrompt = false;

            clientLable.Visible = false;
            comboClient.Visible = false;
            btnAddClient.Visible = false;

            using (var db = new MarketDbContext())
            {
                Clients = db.Clients.Include("Village").ToList();
                ProductTypes = db.ProductTypes.ToList();
            }

            this.comboClient.DataSource = Clients.Select(x=>new { Name = x.Name + " - " + x.Number, ClientId = x.ClientId}).ToList();
            this.comboClient.DisplayMember = "Name";
            this.comboClient.Name = "Name";
            this.comboClient.ValueMember = "ClientId";

            this.comboProductType.DataSource = ProductTypes;
            this.comboProductType.DisplayMember = "TypeName";
            this.comboProductType.Name = "TypeName";
            this.comboProductType.ValueMember = "ProductTypeId";

        }

        private void PrepareColumns()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            myDataTable = new DataTable("My Table");

            DataColumn selectedColumn = new DataColumn();
            selectedColumn = new DataColumn();
            selectedColumn.DataType = System.Type.GetType("System.Boolean");
            selectedColumn.ColumnName = "Selected";
            selectedColumn.Caption = "اختر";
            selectedColumn.ReadOnly = false;
            selectedColumn.Unique = false;

            DataColumn productTypeNameColumn = new DataColumn();
            productTypeNameColumn = new DataColumn();
            productTypeNameColumn.DataType = System.Type.GetType("System.String");
            productTypeNameColumn.ColumnName = "ProductTypeName";
            productTypeNameColumn.Caption = "اسم الصنف";
            productTypeNameColumn.ReadOnly = true;
            productTypeNameColumn.Unique = false;

            DataColumn costPriceColumn = new DataColumn();
            costPriceColumn = new DataColumn();
            costPriceColumn.DataType = System.Type.GetType("System.Decimal");
            costPriceColumn.ColumnName = "CostPrice";
            costPriceColumn.Caption = "سعر التكلفه";
            costPriceColumn.ReadOnly = true;
            costPriceColumn.Unique = false;

            DataColumn sellPriceColumn = new DataColumn();
            sellPriceColumn = new DataColumn();
            sellPriceColumn.DataType = System.Type.GetType("System.Decimal");
            sellPriceColumn.ColumnName = "SellPrice";
            sellPriceColumn.Caption = "سعر البيع";
            sellPriceColumn.ReadOnly = true;
            sellPriceColumn.Unique = false;

            DataColumn quantityColumn = new DataColumn();
            quantityColumn = new DataColumn();
            quantityColumn.DataType = System.Type.GetType("System.Int32");
            quantityColumn.ColumnName = "Quantity";
            quantityColumn.Caption = "الكميه";
            quantityColumn.ReadOnly = true;
            quantityColumn.Unique = false;

            DataColumn totalColumn = new DataColumn();
            totalColumn = new DataColumn();
            totalColumn.DataType = System.Type.GetType("System.Decimal");
            totalColumn.ColumnName = "Total";
            totalColumn.Caption = "المجموع";
            totalColumn.ReadOnly = true;
            totalColumn.Unique = false;

            myDataTable.Columns.Add(selectedColumn);
            myDataTable.Columns.Add(productTypeNameColumn);
            myDataTable.Columns.Add(costPriceColumn);
            myDataTable.Columns.Add(sellPriceColumn);
            myDataTable.Columns.Add(quantityColumn);
            myDataTable.Columns.Add(totalColumn);

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(myDataTable);

            OrderDetailsDataGrid.DataSource = dataSet;
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm(user);
            homeForm.ShowDialog();
        }

        private void checkBoxIsDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                clientLable.Visible = true;
                comboClient.Visible = true;
                btnAddClient.Visible = true;
            }
            else
            {
                clientLable.Visible = false;
                comboClient.Visible = false;
                btnAddClient.Visible = false;
            }

            CalcTotal();
        }

        private void comboGeneralProductType_ValueChanged(object sender, EventArgs e)
        {
            if(comboGeneralProductType.SelectedItem != null)
            {
                int selectedId = (int)comboGeneralProductType.SelectedItem.DataValue;
                if (selectedId == 0)
                    this.comboProductType.DataSource = ProductTypes;
                else
                    this.comboProductType.DataSource = ProductTypes.Where(x => x.GeneralProductTypeId == selectedId).ToList();
            }
        }

        private void btnAddOrderDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboProductType.SelectedItem == null)
                {
                    MessageBox.Show("يجب اختيار صنف اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int Quantity;
                ProductType product = ProductTypes.FirstOrDefault(x=>x.ProductTypeId == (int)comboProductType.SelectedItem.DataValue);
                var canParseQuantity = int.TryParse(txtboxQuantity.Text.Trim(), out Quantity);

                if (!canParseQuantity || Quantity < 0)
                {
                    MessageBox.Show("يجب ادخال الكميه بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (product.Quantity < Quantity)
                {
                    MessageBox.Show("الكميه التى ادخلتها اكبر من الكميه المتاحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var old = Order.OrderDetails.FirstOrDefault(x => x.ProductType.TypeName == product.TypeName);
                if (old == null)
                {
                    this.Order.OrderDetails.Add(new OrderDetails() { CostPrice = product.CostPrice, SellPrice = product.SellPrice, Quantity = Quantity, InsertTime = DateTime.Now, ProductType = product, ProductTypeId = product.ProductTypeId });
                    this.myDataTable.Rows.Add(false, product.TypeName, product.CostPrice, product.SellPrice, Quantity, Quantity * product.SellPrice);
                    
                }
                else
                {
                    old.Quantity += Quantity;

                    this.myDataTable.Columns[4].ReadOnly = false;
                    this.myDataTable.Columns[5].ReadOnly = false;

                    foreach (var row in OrderDetailsDataGrid.Rows)
                    {
                        if(row.Cells[1].Value.ToString() == product.TypeName)
                        {
                            row.Cells[4].Value = old.Quantity;
                            row.Cells[5].Value = old.Quantity * old.SellPrice;
                        }
                    }

                    this.myDataTable.Columns[4].ReadOnly = true;
                    this.myDataTable.Columns[5].ReadOnly = true;

                }

                product.Quantity -= Quantity;
                LableAvailableQuantity.Text = product.Quantity.ToString();

                CalcTotal();
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == null)
                {
                    MessageBox.Show("اختر منتج للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(" هل تريد حذف " + selectedRow.Cells[1].Value + " ؟ ", "تأكيد", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    var productToDelete = Order.OrderDetails.FirstOrDefault(x => x.ProductType.TypeName == selectedRow.Cells[1].Value.ToString());
                    var product = ProductTypes.FirstOrDefault(x => x.ProductTypeId == productToDelete.ProductTypeId);
                    product.Quantity += int.Parse(selectedRow.Cells[4].Value.ToString());
                    LableAvailableQuantity.Text = product.Quantity.ToString();
                    Order.OrderDetails.Remove(productToDelete);
                    OrderDetailsDataGrid.Rows[selectedRow.Index].Delete();
                    CalcTotal();
                    MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderDetailsDataGrid_CellChange(object sender, CellEventArgs e)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(e.Cell.Column.Key, "Selected"))
            {
                foreach (var row in OrderDetailsDataGrid.Rows)
                {
                    if (row.Index != e.Cell.Row.Index)
                    {
                        row.Cells[0].Value = false;
                    }
                    else
                        selectedRow = row;
                }
            }
        }

        private decimal CalcTotal()
        {
            decimal sum = 0;
            foreach (var item in Order.OrderDetails)
            {
                sum += item.SellPrice * item.Quantity;
            }

            if (checkBoxIsDelivery.Checked && comboClient.SelectedItem != null)
                sum += Clients.FirstOrDefault(x => x.ClientId == int.Parse(comboClient.SelectedItem.DataValue.ToString())).Village.DeliveryCost;

            TotalLable.Text = sum.ToString();
            return sum;
        }

        private void comboProductType_ValueChanged(object sender, EventArgs e)
        {
            if (comboProductType.SelectedItem != null)
            {
                int selectedId = (int)comboProductType.SelectedItem.DataValue;
                LableAvailableQuantity.Text = ProductTypes.FirstOrDefault(x => x.ProductTypeId == selectedId).Quantity.ToString();
                lableSellPrice.Text = ProductTypes.FirstOrDefault(x => x.ProductTypeId == selectedId).SellPrice.ToString();
            }
        }

        public void RefreshComboClient()
        {
            using (var db = new MarketDbContext())
            {
                var all = db.Clients.Include("Village").ToList();
                this.comboClient.DataSource = all.Select(x => new { Name = x.Name + " - " + x.Number, ClientId = x.ClientId }).ToList();
                Clients = all;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm(user, this, null, null, true);
            clientsForm.ShowDialog();
        }

        private void comboClient_TextChanged(object sender, EventArgs e)
        {
            if (comboClient.SelectedItem == null)
                this.comboClient.DataSource = Clients.Where(x => x.Name.Contains(comboClient.Text.ToLower().Trim()) || x.Number.Contains(comboClient.Text.ToLower().Trim())).Select(x => new { Name = x.Name + " - " + x.Number, ClientId = x.ClientId }).ToList();
            else
                CalcTotal();
        }

        private async void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {

                if (Order.OrderDetails.Count() < 1)
                {
                    MessageBox.Show("حط اى حاجه يبنى الاوردر فاضى ازاى يعنى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string orderNumber = txtboxOrderNumber.Text;

                if (string.IsNullOrWhiteSpace(orderNumber))
                {
                    MessageBox.Show("يجب ادخال رقم الاوردر بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new MarketDbContext())
                {
                    if (db.Orders.Any(x => x.OrderNumber == orderNumber))
                    {
                        MessageBox.Show("تم ادخال رقم الاوردر هذا من قبل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Order.InsertTime = DateTime.Now;
                Order.OrderNumber = orderNumber;

                if (checkBoxIsDelivery.Checked)
                {
                    Order.IsDelivery = true;
                    if (comboClient.SelectedItem != null)
                        Order.ClientId = int.Parse(comboClient.SelectedItem.DataValue.ToString());
                    else
                    {
                        MessageBox.Show("يجب اختيار عميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Order.TotalSell = CalcTotal();

                foreach (var item in Order.OrderDetails)
                {
                    item.ProductType = null;
                }

                btnSaveOrder.Enabled = false;
                await Task.Run(() =>
                {
                    using (var db = new MarketDbContext())
                    {
                        db.Orders.Add(Order);
                        db.SaveChanges();
                    }
                });
                btnSaveOrder.Enabled = true;

                MessageBox.Show("تم الاضافه بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
