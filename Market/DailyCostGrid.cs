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
    public partial class DailyCostGrid : MetroForm
    {
        private User user;
        private List<DailyCost> DailyCosts;
        public DataTable myDataTable;
        private UltraGridRow selectedRow;
        public DailyCostGrid(User _user)
        {
            user = _user;

            InitializeComponent();

            PrepareColumns();

            refresh();

            FillWithData(this.DailyCosts);

            // all columns auto resize
            DailyCostDataGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

            // hide id column
            this.DailyCostDataGrid.DisplayLayout.Bands[0].Columns[1].Hidden = true;

            // hide drag header area
            DailyCostDataGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            // center content
            this.DailyCostDataGrid.DisplayLayout.Bands[0].Columns[0].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.DailyCostDataGrid.DisplayLayout.Bands[0].Columns[1].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.DailyCostDataGrid.DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.DailyCostDataGrid.DisplayLayout.Bands[0].Columns[3].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.DailyCostDataGrid.DisplayLayout.Bands[0].Columns[4].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

            // first column as checkbox
            UltraGridColumn ugc = DailyCostDataGrid.DisplayLayout.Bands[0].Columns["Selected"];
            ugc.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ugc.CellActivation = Activation.AllowEdit;

            // stop confirmation message on delete
            DailyCostDataGrid.DisplayLayout.ShowDeleteRowsPrompt = false;

            this.btnVillageSearch_Click(null, null);
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

            DataColumn dailyCostIdColumn = new DataColumn();
            dailyCostIdColumn = new DataColumn();
            dailyCostIdColumn.DataType = System.Type.GetType("System.String");
            dailyCostIdColumn.ColumnName = "DailyCostId";
            dailyCostIdColumn.Caption = "رقم";
            dailyCostIdColumn.ReadOnly = true;
            dailyCostIdColumn.Unique = false;

            DataColumn descriptionColumn = new DataColumn();
            descriptionColumn = new DataColumn();
            descriptionColumn.DataType = System.Type.GetType("System.String");
            descriptionColumn.ColumnName = "Description";
            descriptionColumn.Caption = "الوصف";
            descriptionColumn.ReadOnly = true;
            descriptionColumn.Unique = false;

            DataColumn costColumn = new DataColumn();
            costColumn = new DataColumn();
            costColumn.DataType = System.Type.GetType("System.Decimal");
            costColumn.ColumnName = "Cost";
            costColumn.Caption = "التكلفه";
            costColumn.ReadOnly = true;
            costColumn.Unique = false;

            DataColumn insertTimeColumn = new DataColumn();
            insertTimeColumn = new DataColumn();
            insertTimeColumn.DataType = System.Type.GetType("System.String");
            insertTimeColumn.ColumnName = "InsertTime";
            insertTimeColumn.Caption = "التاريخ";
            insertTimeColumn.ReadOnly = true;
            insertTimeColumn.Unique = false;

            myDataTable.Columns.Add(selectedColumn);
            myDataTable.Columns.Add(dailyCostIdColumn);
            myDataTable.Columns.Add(descriptionColumn);
            myDataTable.Columns.Add(costColumn);
            myDataTable.Columns.Add(insertTimeColumn);

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(myDataTable);

            DailyCostDataGrid.DataSource = dataSet;
        }

        private void FillWithData(List<DailyCost> DailyCosts)
        {
            myDataTable.Rows.Clear();

            foreach (var dailyCost in DailyCosts)
            {
                DataRow theDataRow = myDataTable.NewRow();
                theDataRow[0] = false;
                theDataRow[1] = dailyCost.DailyCostId;
                theDataRow[2] = dailyCost.Description;
                theDataRow[3] = dailyCost.Cost;
                theDataRow[4] = dailyCost.InsertTime.ToString("dd/MM/yyyy");
                myDataTable.Rows.Add(theDataRow);
            }

        }

        private void DailyCostDataGrid_CellChange(object sender, CellEventArgs e)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(e.Cell.Column.Key, "Selected"))
            {
                foreach (var row in DailyCostDataGrid.Rows)
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
            var filterd = DailyCosts.ToList();

            if (dateTimeFrom.DateTime.Year > 1900)
                filterd = filterd.Where(x => x.InsertTime.Date >= dateTimeFrom.DateTime.Date).ToList();

            if (dateTimeTo.DateTime.Year > 1900)
                filterd = filterd.Where(x => x.InsertTime.Date <= dateTimeTo.DateTime.Date).ToList();

            FillWithData(filterd);
            calcToltalDailyCost();
        }

        private void btnDeleteVillage_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == null)
                {
                    MessageBox.Show("اختر مصروف للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("هل تريد المتابعه فى الحذف ؟", "تأكيد", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MarketDbContext())
                    {
                        var id = int.Parse(selectedRow.Cells[1].Value.ToString());

                        db.DailyCosts.Remove(db.DailyCosts.FirstOrDefault(x => x.DailyCostId == id));
                        btnDeleteDailyCost.Enabled = false;
                        db.SaveChanges();
                    }
                    btnDeleteDailyCost.Enabled = true;
                    DailyCostDataGrid.Rows[selectedRow.Index].Delete();
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
            DailyCostForm dailyCostForm = new DailyCostForm(user, this, selectedRow, true);
            dailyCostForm.ShowDialog();
        }

        private void btnEditVillage_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("يجب اختيار مصروف للتعديل اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DailyCostForm dailyCostForm = new DailyCostForm(user, this, selectedRow, false);
                dailyCostForm.ShowDialog();
            }
        }

        public decimal calcToltalDailyCost()
        {
            decimal total = 0;

            var dateFrom = dateTimeFrom.DateTime.Date;
            var dateTo = dateTimeTo.DateTime.Date;

            foreach (var row in this.DailyCostDataGrid.Rows)
                total += decimal.Parse(row.Cells[3].Value.ToString());

            this.TotalDailyCostLable.Text = total.ToString();
            return total;
        }


        public void refresh()
        {
            using (var db = new MarketDbContext())
            {
                DailyCosts = db.DailyCosts.ToList();
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
