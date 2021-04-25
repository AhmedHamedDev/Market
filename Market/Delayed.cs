using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Market.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Delayed : MetroForm
    {
        private User user;
        private List<Order> Orders;
        public DataTable myDataTable;
        private UltraGridRow selectedRow;

        private List<Client> Clients;
        private List<Village> Villages;

        public Delayed(User _user)
        {
            user = _user;

            InitializeComponent();

            PrepareColumns();
            using (var db = new MarketDbContext())
            {
                Orders = db.Orders.Include("Client.Village").Include("OrderDetails.ProductType.GeneralProductTypes").ToList();
                Clients = db.Clients.Include("Village").ToList();
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
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[8].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[9].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[10].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[11].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrdersDataGrid.DisplayLayout.Bands[0].Columns[12].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

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

            this.comboVillage.DataSource = Villages;
            this.comboVillage.DisplayMember = "VillageName";
            this.comboVillage.Name = "VillageName";
            this.comboVillage.ValueMember = "VillageId";

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

            DataColumn discoundColumn = new DataColumn();
            discoundColumn = new DataColumn();
            discoundColumn.DataType = System.Type.GetType("System.String");
            discoundColumn.ColumnName = "Discound";
            discoundColumn.Caption = "الخصم";
            discoundColumn.ReadOnly = true;
            discoundColumn.Unique = false;

            DataColumn orderDetailsTotalColumn = new DataColumn();
            orderDetailsTotalColumn = new DataColumn();
            orderDetailsTotalColumn.DataType = System.Type.GetType("System.Decimal");
            orderDetailsTotalColumn.ColumnName = "orderDetailsTotal";
            orderDetailsTotalColumn.Caption = "اجمالى الاوردر";
            orderDetailsTotalColumn.ReadOnly = true;
            orderDetailsTotalColumn.Unique = false;

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

            DataColumn DeliveryCostForOwnerColumn = new DataColumn();
            DeliveryCostForOwnerColumn = new DataColumn();
            DeliveryCostForOwnerColumn.DataType = System.Type.GetType("System.Decimal");
            DeliveryCostForOwnerColumn.ColumnName = "DeliveryCostForOwner";
            DeliveryCostForOwnerColumn.Caption = "التوصيل للمطعم";
            DeliveryCostForOwnerColumn.ReadOnly = true;
            DeliveryCostForOwnerColumn.Unique = false;

            DataColumn DeliveryCostForPilotColumn = new DataColumn();
            DeliveryCostForPilotColumn = new DataColumn();
            DeliveryCostForPilotColumn.DataType = System.Type.GetType("System.Decimal");
            DeliveryCostForPilotColumn.ColumnName = "DeliveryCostForPilot";
            DeliveryCostForPilotColumn.Caption = "التوصيل للطيار";
            DeliveryCostForPilotColumn.ReadOnly = true;
            DeliveryCostForPilotColumn.Unique = false;

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

            DataColumn totalSellColumn = new DataColumn();
            totalSellColumn = new DataColumn();
            totalSellColumn.DataType = System.Type.GetType("System.Decimal");
            totalSellColumn.ColumnName = "TotalSell";
            totalSellColumn.Caption = "الاجمالى";
            totalSellColumn.ReadOnly = true;
            totalSellColumn.Unique = false;

            DataColumn isDelayedColumn = new DataColumn();
            isDelayedColumn = new DataColumn();
            isDelayedColumn.DataType = System.Type.GetType("System.Boolean");
            isDelayedColumn.ColumnName = "IsDelayed";
            isDelayedColumn.Caption = "مؤجل";
            isDelayedColumn.ReadOnly = true;
            isDelayedColumn.Unique = false;

            myDataTable.Columns.Add(selectedColumn);
            myDataTable.Columns.Add(orderIdColumn);
            myDataTable.Columns.Add(orderNumberColumn);
            myDataTable.Columns.Add(discoundColumn);
            myDataTable.Columns.Add(insertTimeColumn);
            myDataTable.Columns.Add(orderDetailsTotalColumn);
            myDataTable.Columns.Add(isDeliveryColumn);
            myDataTable.Columns.Add(DeliveryCostForOwnerColumn);
            myDataTable.Columns.Add(DeliveryCostForPilotColumn);
            myDataTable.Columns.Add(clientNameColumn);
            myDataTable.Columns.Add(villageColumn);
            myDataTable.Columns.Add(isDelayedColumn);
            myDataTable.Columns.Add(totalSellColumn);


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
                theDataRow[3] = ((1 - order.Discound) * 100).ToString() + "%";
                theDataRow[4] = order.InsertTime.ToString("hh-mm  dd/MM/yyyy");
                theDataRow[5] = order.TotalSell - order.DeliveryCost;
                theDataRow[6] = order.IsDelivery;
                theDataRow[7] = order.DeliveryCost * (decimal)0.9;
                theDataRow[8] = order.DeliveryCost * (decimal)0.1;
                theDataRow[9] = order.Client?.Name;
                theDataRow[10] = order.Client?.Village?.VillageName;
                theDataRow[11] = order.IsDelayed;
                theDataRow[12] = order.TotalSell;

                myDataTable.Rows.Add(theDataRow);
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

            var filterd = Orders.Where(x => x.IsDelayed == true).ToList();

            if (radioDelivery.Checked)
                filterd = filterd.Where(x => x.IsDelivery == true).ToList();
            else if (radioWithoutDelivery.Checked)
                filterd = filterd.Where(x => x.IsDelivery == false).ToList();

            if (!string.IsNullOrWhiteSpace(orderNumber))
                filterd = filterd.Where(x => x.OrderNumber.Contains(orderNumber)).ToList();

            if (ClientId != 0)
                filterd = filterd.Where(x => x.ClientId == ClientId).ToList();

            if (VillageId != 0)
                filterd = filterd.Where(x => x.Client?.VillageId == VillageId).ToList();

            FillWithData(filterd);
            this.btnSearch.Enabled = true;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("يجب اختيار اوردر اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var order = Orders.FirstOrDefault(x => x.OrderId == (int)selectedRow.Cells[1].Value);
            OrderDetailsForm OrderDetailsForm = new OrderDetailsForm(user, order);
            OrderDetailsForm.ShowDialog();
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == null)
                {
                    MessageBox.Show("يجب اختيار اوردر اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(" هل تريد الدفع ؟ ", "تأكيد", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    var id = int.Parse(selectedRow.Cells[1].Value.ToString());
                    using (var db = new MarketDbContext())
                    {
                        db.Orders.FirstOrDefault(x => x.OrderId == id).IsDelayed = false;
                        await Task.Run(() =>
                        {
                            db.SaveChanges();
                        });
                    }
                    Orders.FirstOrDefault(x => x.OrderId == id).IsDelayed = false;
                    btnSearch_Click(null, null);
                    MessageBox.Show("تم الدفع بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
;