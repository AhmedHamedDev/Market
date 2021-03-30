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
    public partial class VillagesGrid : MetroForm
    {
        private User user;
        private List<Village> Villages;
        public DataTable myDataTable;
        private UltraGridRow selectedRow;
        public VillagesGrid(User _user)
        {
            user = _user;

            InitializeComponent();

            PrepareColumns();
            FillWithData();

            // all columns auto resize
            VillagesDataGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

            // hide id column
            this.VillagesDataGrid.DisplayLayout.Bands[0].Columns[1].Hidden = true;

            // hide drag header area
            VillagesDataGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            // center content
            this.VillagesDataGrid.DisplayLayout.Bands[0].Columns[0].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.VillagesDataGrid.DisplayLayout.Bands[0].Columns[1].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.VillagesDataGrid.DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.VillagesDataGrid.DisplayLayout.Bands[0].Columns[3].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

            // first column as checkbox
            UltraGridColumn ugc = VillagesDataGrid.DisplayLayout.Bands[0].Columns["Selected"];
            ugc.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ugc.CellActivation = Activation.AllowEdit;

            // stop confirmation message on delete
            VillagesDataGrid.DisplayLayout.ShowDeleteRowsPrompt = false;
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

            DataColumn villageIdColumn = new DataColumn();
            villageIdColumn = new DataColumn();
            villageIdColumn.DataType = System.Type.GetType("System.String");
            villageIdColumn.ColumnName = "VillageId";
            villageIdColumn.Caption = "رقم";
            villageIdColumn.ReadOnly = true;
            villageIdColumn.Unique = false;

            DataColumn villageNameColumn = new DataColumn();
            villageNameColumn = new DataColumn();
            villageNameColumn.DataType = System.Type.GetType("System.String");
            villageNameColumn.ColumnName = "VillageName";
            villageNameColumn.Caption = "اسم القريه";
            villageNameColumn.ReadOnly = true;
            villageNameColumn.Unique = false;

            DataColumn deliveryCostColumn = new DataColumn();
            deliveryCostColumn = new DataColumn();
            deliveryCostColumn.DataType = System.Type.GetType("System.Decimal");
            deliveryCostColumn.ColumnName = "DeliveryCost";
            deliveryCostColumn.Caption = "تكلفه التوصيل";
            deliveryCostColumn.ReadOnly = true;
            deliveryCostColumn.Unique = false;

            myDataTable.Columns.Add(selectedColumn);
            myDataTable.Columns.Add(villageIdColumn);
            myDataTable.Columns.Add(villageNameColumn);
            myDataTable.Columns.Add(deliveryCostColumn);
        }

        private void FillWithData()
        {
            using (var db = new MarketDbContext())
            {
                Villages = db.Villages.ToList();
            }

            foreach (var village in Villages)
            {
                DataRow theDataRow = myDataTable.NewRow();
                theDataRow[0] = false;
                theDataRow[1] = village.VillageId;
                theDataRow[2] = village.VillageName;
                theDataRow[3] = village.DeliveryCost;
                myDataTable.Rows.Add(theDataRow);
            }

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(myDataTable);

            VillagesDataGrid.DataSource = dataSet;
        }

        private void VillagesDataGrid_CellChange(object sender, CellEventArgs e)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(e.Cell.Column.Key, "Selected"))
            {
                foreach (var row in VillagesDataGrid.Rows)
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

        private void btnVillageSearch_Click(object sender, EventArgs e)
        {
            VillagesDataGrid.DisplayLayout.Bands[0].ColumnFilters["VillageName"].ClearFilterConditions();
            string search = txtboxVillageName.Text.Trim();
            if (!string.IsNullOrWhiteSpace(search))
                VillagesDataGrid.DisplayLayout.Bands[0].ColumnFilters["VillageName"].FilterConditions.Add(FilterComparisionOperator.Contains, search);
        }

        private void btnDeleteVillage_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == null)
                {
                    MessageBox.Show("اختر قريه للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(" هل تريد حذف " + selectedRow.Cells[2].Value + " ؟ ", "تأكيد", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MarketDbContext())
                    {
                        var id = int.Parse(selectedRow.Cells[1].Value.ToString());

                        if (db.Clients.Any(x=>x.VillageId == id))
                        {
                            MessageBox.Show("لا يمكن حذف هذه القريه فهيه مرتبطه بعملاء", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        db.Villages.Remove(db.Villages.FirstOrDefault(x => x.VillageId == id));
                        btnDeleteVillage.Enabled = false;
                        db.SaveChanges();
                    }
                    btnDeleteVillage.Enabled = true;
                    VillagesDataGrid.Rows[selectedRow.Index].Delete();
                    MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddVillage_Click(object sender, EventArgs e)
        {
            VillagesForm villagesForm = new VillagesForm(user, this, selectedRow, true);
            villagesForm.ShowDialog();
        }

        private void btnEditVillage_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("يجب اختيار قريه للتعديل اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                VillagesForm villagesForm = new VillagesForm(user, this, selectedRow, false);
                villagesForm.ShowDialog();
            }
        }

        private void VillagesGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm(user);
            homeForm.ShowDialog();
        }
    }
}
