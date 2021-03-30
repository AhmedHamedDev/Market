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
    public partial class OrderGrid : MetroForm
    {
        private User user;
        private List<Order> Orders;
        public DataTable myDataTable;
        private UltraGridRow selectedRow;

        private List<Client> Clients;
        private List<ProductType> ProductTypes;
        private List<Village> Villages;

        public OrderGrid(User _user)
        {
            user = _user;

            InitializeComponent();

            PrepareColumns();
            using (var db = new MarketDbContext())
            {
                Orders = db.Orders.Include("Client.Village").Include("OrderDetails.ProductType.GeneralProductTypes").ToList();
                Clients = db.Clients.Include("Village").ToList();
                ProductTypes = db.ProductTypes.ToList();
                Villages = db.Villages.ToList();
            }
            FillWithData(Orders);

            // all columns auto resize
            OrdersDataGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

            // hide drag header area
            OrdersDataGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            // center content
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[0].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[1].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[3].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[4].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[5].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[6].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[7].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

            // first column as checkbox
            UltraGridColumn ugc = OrdersDataGrid.DisplayLayout.Bands[0].Columns["Selected"];
            ugc.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ugc.CellActivation = Activation.AllowEdit;

            // stop confirmation message on delete
            OrdersDataGrid.DisplayLayout.ShowDeleteRowsPrompt = false;

            // hide id column
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[1].Hidden = true;

            this.comboClient.DataSource = Clients.Select(x => new { Name = x.Name + " - " + x.Number, ClientId = x.ClientId }).ToList();
            this.comboClient.DisplayMember = "Name";
            this.comboClient.Name = "Name";
            this.comboClient.ValueMember = "ClientId";

            this.comboProductType.DataSource = ProductTypes;
            this.comboProductType.DisplayMember = "TypeName";
            this.comboProductType.Name = "TypeName";
            this.comboProductType.ValueMember = "ProductTypeId";

            this.comboVillage.DataSource = Villages;
            this.comboVillage.DisplayMember = "VillageName";
            this.comboVillage.Name = "VillageName";
            this.comboVillage.ValueMember = "VillageId";

            if (!user.IsAdmin)
            {
                DeliveryLable.Visible = false;
                OrderSellLable.Visible = false;
                TotalLable.Visible = false;

                delivery.Visible = false;
                OrderSell.Visible = false;
                Total.Visible = false;
            }

            dateTimeFrom.DateTime = DateTime.Today;
            dateTimeTo.DateTime = DateTime.Today.AddDays(1);

            btnSearch_Click(null, null);
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

            DataColumn orderIdColumn = new DataColumn();
            orderIdColumn = new DataColumn();
            orderIdColumn.DataType = System.Type.GetType("System.Int32");
            orderIdColumn.ColumnName = "OrderId";
            orderIdColumn.Caption = "رقم";
            orderIdColumn.ReadOnly = false;
            orderIdColumn.Unique = false;

            DataColumn orderNumberColumn = new DataColumn();
            orderNumberColumn = new DataColumn();
            orderNumberColumn.DataType = System.Type.GetType("System.String");
            orderNumberColumn.ColumnName = "OrderNumber";
            orderNumberColumn.Caption = "رقم الاوردر";
            orderNumberColumn.ReadOnly = true;
            orderNumberColumn.Unique = false;

            DataColumn totalSellColumn = new DataColumn();
            totalSellColumn = new DataColumn();
            totalSellColumn.DataType = System.Type.GetType("System.Decimal");
            totalSellColumn.ColumnName = "TotalSell";
            totalSellColumn.Caption = "الاجمالى";
            totalSellColumn.ReadOnly = true;
            totalSellColumn.Unique = false;

            DataColumn insertTimeColumn = new DataColumn();
            insertTimeColumn = new DataColumn();
            insertTimeColumn.DataType = System.Type.GetType("System.String");
            insertTimeColumn.ColumnName = "InsertTime";
            insertTimeColumn.Caption = "التاريخ";
            insertTimeColumn.ReadOnly = true;
            insertTimeColumn.Unique = false;

            DataColumn isDeliveryColumn = new DataColumn();
            isDeliveryColumn = new DataColumn();
            isDeliveryColumn.DataType = System.Type.GetType("System.Boolean");
            isDeliveryColumn.ColumnName = "IsDelivery";
            isDeliveryColumn.Caption = "مع التوصيل";
            isDeliveryColumn.ReadOnly = true;
            isDeliveryColumn.Unique = false;

            DataColumn clientNameColumn = new DataColumn();
            clientNameColumn = new DataColumn();
            clientNameColumn.DataType = System.Type.GetType("System.String");
            clientNameColumn.ColumnName = "ClientName";
            clientNameColumn.Caption = "العميل";
            clientNameColumn.ReadOnly = true;
            clientNameColumn.Unique = false;

            DataColumn villageColumn = new DataColumn();
            villageColumn = new DataColumn();
            villageColumn.DataType = System.Type.GetType("System.String");
            villageColumn.ColumnName = "Village";
            villageColumn.Caption = "القريه";
            villageColumn.ReadOnly = true;
            villageColumn.Unique = false;

            myDataTable.Columns.Add(selectedColumn);
            myDataTable.Columns.Add(orderIdColumn);
            myDataTable.Columns.Add(orderNumberColumn);
            myDataTable.Columns.Add(totalSellColumn);
            myDataTable.Columns.Add(insertTimeColumn);
            myDataTable.Columns.Add(isDeliveryColumn);
            myDataTable.Columns.Add(clientNameColumn);
            myDataTable.Columns.Add(villageColumn);

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(myDataTable);

            OrdersDataGrid.DataSource = dataSet;

        }

        private void FillWithData(List<Order> Orders)
        {
            myDataTable.Rows.Clear();

            foreach (var order in Orders)
            {
                DataRow theDataRow = myDataTable.NewRow();
                theDataRow[0] = false;
                theDataRow[1] = order.OrderId;
                theDataRow[2] = order.OrderNumber;
                theDataRow[3] = order.TotalSell;
                theDataRow[4] = order.InsertTime.ToString("hh-mm  dd/MM/yyyy");
                theDataRow[5] = order.IsDelivery;
                theDataRow[6] = order.Client?.Name;
                theDataRow[7] = order.Client?.Village?.VillageName;
                myDataTable.Rows.Add(theDataRow);
            }

        }

        private void comboGeneralProductType_ValueChanged(object sender, EventArgs e)
        {
            if (comboGeneralProductType.SelectedItem != null)
            {
                int selectedId = (int)comboGeneralProductType.SelectedItem.DataValue;
                if (selectedId == 0)
                    this.comboProductType.DataSource = ProductTypes;
                else
                    this.comboProductType.DataSource = ProductTypes.Where(x => x.GeneralProductTypeId == selectedId).ToList();
            }
        }

        private void VillagesDataGrid_CellChange(object sender, CellEventArgs e)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(e.Cell.Column.Key, "Selected"))
            {
                foreach (var row in OrdersDataGrid.Rows)
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

        private void VillagesGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm(user);
            homeForm.ShowDialog();
        }

        private void comboClient_TextChanged(object sender, EventArgs e)
        {
            if (comboClient.SelectedItem == null)
                this.comboClient.DataSource = Clients.Where(x => x.Name.Contains(comboClient.Text.ToLower().Trim()) || x.Number.Contains(comboClient.Text.ToLower().Trim())).Select(x => new { Name = x.Name + " - " + x.Number, ClientId = x.ClientId }).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = false;
            string orderNumber = txtboxOrderNumber.Text.Trim();
            int ClientId = comboClient.SelectedItem == null ? 0 : int.Parse(comboClient.SelectedItem.DataValue.ToString());
            int VillageId = comboVillage.SelectedItem == null ? 0 : int.Parse(comboVillage.SelectedItem.DataValue.ToString());
            int ProductTypeId = comboProductType.SelectedItem == null ? 0 : int.Parse(comboProductType.SelectedItem.DataValue.ToString());
            int GeneralProductTypeId = comboGeneralProductType.SelectedItem == null ? 0 : int.Parse(comboGeneralProductType.SelectedItem.DataValue.ToString());
            DateTime From = dateTimeFrom.DateTime;
            DateTime To = dateTimeTo.DateTime;

            var filterd = Orders.ToList();

            if (radioDelivery.Checked)
                filterd = filterd.Where(x => x.IsDelivery == true).ToList();
            else if(radioWithoutDelivery.Checked)
                filterd = filterd.Where(x => x.IsDelivery == false).ToList();

            if (From.Year > 1900)
                filterd = filterd.Where(x => x.InsertTime >= From).ToList();

            if (To.Year > 1900)
                filterd = filterd.Where(x => x.InsertTime <= To).ToList();

            if (!string.IsNullOrWhiteSpace(orderNumber))
                filterd = filterd.Where(x => x.OrderNumber.Contains(orderNumber)).ToList();

            if(ClientId != 0)
                filterd = filterd.Where(x => x.ClientId == ClientId).ToList();

            if (VillageId != 0)
                filterd = filterd.Where(x => x.Client.VillageId == VillageId).ToList();

            if (ProductTypeId != 0)
                filterd = filterd.Where(x => x.OrderDetails.Where(y=>y.ProductTypeId == ProductTypeId).Count() > 0).ToList();

            if (GeneralProductTypeId != 0)
                filterd = filterd.Where(x => x.OrderDetails.Where(y => y.ProductType.GeneralProductTypeId == GeneralProductTypeId).Count() > 0).ToList();

            FillWithData(filterd);
            CalcTotal(filterd);
            this.btnSearch.Enabled = true;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var order = Orders.FirstOrDefault(x => x.OrderId == (int)selectedRow.Cells[1].Value);
            OrderDetailsForm OrderDetailsForm = new OrderDetailsForm(user, order);
            OrderDetailsForm.ShowDialog();
        }

        private decimal CalcTotal(List<Order> orders)
        {
            decimal sum = 0;
            decimal deliverySum = 0;
            foreach (var order in orders)
            {
                foreach (var item in order.OrderDetails)
                {
                    sum += item.Price * item.Quantity;
                }

                if (order.IsDelivery)
                    deliverySum += order.Client.Village.DeliveryCost;
            }

            OrderSellLable.Text = sum.ToString();
            DeliveryLable.Text = deliverySum.ToString();
            TotalLable.Text = (sum + deliverySum).ToString();
            return sum;
        }

        private void btnExtractData_Click(object sender, EventArgs e)
        {
            btnExtractData.Enabled = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.ultraGridExcelExporter1.Export(this.OrdersDataGrid, path+"\\Orders "+DateTime.Now.ToString("dd-MM-yyyy")+".xls");
            btnExtractData.Enabled = true;
            MessageBox.Show("تم استخراج الملف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
;