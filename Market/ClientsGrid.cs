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
    public partial class ClientsGrid : MetroForm
    {
        private User user;
        public List<Client> Clients;
        private List<Village> Villages;
        public DataTable myDataTable;
        private UltraGridRow selectedRow;
        public ClientsGrid(User _user)
        {
            user = _user;

            InitializeComponent();
            PrepareColumns();

            using (var db = new MarketDbContext())
            {
                Clients = db.Clients.Include("Village").ToList();
                FillWithData(Clients);
            }


            using (var db = new MarketDbContext())
            {
                Villages = db.Villages.ToList();
            }

            // all columns auto resize
            ClientsDataGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

            // hide id column
            this.ClientsDataGrid.DisplayLayout.Bands[0].Columns[1].Hidden = true;

            // hide drag header area
            ClientsDataGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            // center content
            this.ClientsDataGrid.DisplayLayout.Bands[0].Columns[0].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ClientsDataGrid.DisplayLayout.Bands[0].Columns[1].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ClientsDataGrid.DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ClientsDataGrid.DisplayLayout.Bands[0].Columns[3].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ClientsDataGrid.DisplayLayout.Bands[0].Columns[4].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ClientsDataGrid.DisplayLayout.Bands[0].Columns[5].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

            // first column as checkbox
            UltraGridColumn ugc = ClientsDataGrid.DisplayLayout.Bands[0].Columns["Selected"];
            ugc.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ugc.CellActivation = Activation.AllowEdit;

            // stop confirmation message on delete
            ClientsDataGrid.DisplayLayout.ShowDeleteRowsPrompt = false;

            this.comboVillage.DataSource = Villages;
            this.comboVillage.DisplayMember = "VillageName";
            this.comboVillage.Name = "VillageName";
            this.comboVillage.ValueMember = "VillageId";
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

            DataColumn clientIdColumn = new DataColumn();
            clientIdColumn = new DataColumn();
            clientIdColumn.DataType = System.Type.GetType("System.Int32");
            clientIdColumn.ColumnName = "ClientId";
            clientIdColumn.Caption = "رقم";
            clientIdColumn.ReadOnly = true;
            clientIdColumn.Unique = false;

            DataColumn clientNameColumn = new DataColumn();
            clientNameColumn = new DataColumn();
            clientNameColumn.DataType = System.Type.GetType("System.String");
            clientNameColumn.ColumnName = "ClientName";
            clientNameColumn.Caption = "اسم العميل";
            clientNameColumn.ReadOnly = true;
            clientNameColumn.Unique = false;

            DataColumn numberColumn = new DataColumn();
            numberColumn = new DataColumn();
            numberColumn.DataType = System.Type.GetType("System.String");
            numberColumn.ColumnName = "Number";
            numberColumn.Caption = "رقم العميل";
            numberColumn.ReadOnly = true;
            numberColumn.Unique = false;

            DataColumn addressColumn = new DataColumn();
            addressColumn = new DataColumn();
            addressColumn.DataType = System.Type.GetType("System.String");
            addressColumn.ColumnName = "Address";
            addressColumn.Caption = "العنوان";
            addressColumn.ReadOnly = true;
            addressColumn.Unique = false;

            DataColumn villageNameColumn = new DataColumn();
            villageNameColumn = new DataColumn();
            villageNameColumn.DataType = System.Type.GetType("System.String");
            villageNameColumn.ColumnName = "VillageName";
            villageNameColumn.Caption = "القريه";
            villageNameColumn.ReadOnly = true;
            villageNameColumn.Unique = false;

            myDataTable.Columns.Add(selectedColumn);
            myDataTable.Columns.Add(clientIdColumn);
            myDataTable.Columns.Add(clientNameColumn);
            myDataTable.Columns.Add(numberColumn);
            myDataTable.Columns.Add(addressColumn);
            myDataTable.Columns.Add(villageNameColumn);

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(myDataTable);

            ClientsDataGrid.DataSource = dataSet;
        }

        private void FillWithData(List<Client> clients)
        {
            myDataTable.Clear();

            foreach (var client in clients)
            {
                DataRow theDataRow = myDataTable.NewRow();
                theDataRow[0] = false;
                theDataRow[1] = client.ClientId;
                theDataRow[2] = client.Name;
                theDataRow[3] = client.Number;
                theDataRow[4] = client.Address;
                theDataRow[5] = client.Village.VillageName;
                myDataTable.Rows.Add(theDataRow);
            }
        }

        public void btnClientSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = false;
            string clientName = txtboxClientName.Text.Trim();
            string clientNumber = txtClientNumber.Text.Trim();
            int VillageId = comboVillage.SelectedItem == null ? 0 : int.Parse(comboVillage.SelectedItem.DataValue.ToString());

            var filterd = Clients.ToList();

            if (!string.IsNullOrWhiteSpace(clientName))
                filterd = filterd.Where(x => x.Name.Contains(clientName)).ToList();

            if (!string.IsNullOrWhiteSpace(clientNumber))
                filterd = filterd.Where(x => x.Number.Contains(clientNumber)).ToList();

            if (VillageId != 0)
                filterd = filterd.Where(x => x.VillageId == VillageId).ToList();

            FillWithData(filterd);
            this.btnSearch.Enabled = true;
        }

        private void VillagesGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm(user);
            homeForm.ShowDialog();
        }

        private void ClientsDataGrid_CellChange(object sender, CellEventArgs e)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(e.Cell.Column.Key, "Selected"))
            {
                foreach (var row in ClientsDataGrid.Rows)
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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm(user,null, this, selectedRow, true);
            clientsForm.ShowDialog();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("يجب اختيار قريه للتعديل اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ClientsForm clientsForm = new ClientsForm(user, null, this, selectedRow, false);
                clientsForm.ShowDialog();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == null)
                {
                    MessageBox.Show("اختر عميل للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(" هل تريد حذف " + selectedRow.Cells[2].Value + " ؟ ", "تأكيد", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MarketDbContext())
                    {
                        var id = int.Parse(selectedRow.Cells[1].Value.ToString());

                        if (db.Orders.Any(x=>x.ClientId == id))
                        {
                            MessageBox.Show("لا يمكن حذف هذا العميل فهو مرتبط بأوامر اخري", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var clientToDelete = db.Clients.FirstOrDefault(x => x.ClientId == id);
                        db.Clients.Remove(clientToDelete);
                        btnDeleteClient.Enabled = false;
                        db.SaveChanges();

                        Clients.Remove(Clients.FirstOrDefault(x=>x.ClientId == clientToDelete.ClientId));
                    }
                    btnDeleteClient.Enabled = true;
                    ClientsDataGrid.Rows[selectedRow.Index].Delete();
                    MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
