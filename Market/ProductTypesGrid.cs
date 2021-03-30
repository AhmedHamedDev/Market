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
    public partial class ProductTypesGrid : MetroForm
    {
        private User user;
        public List<ProductType> ProductTypes;
        public DataTable myDataTable;
        private UltraGridRow selectedRow;
        public ProductTypesGrid(User _user)
        {
            user = _user;

            InitializeComponent();

            PrepareColumns();

            using (var db = new MarketDbContext())
            {
                ProductTypes = db.ProductTypes.Include("GeneralProductTypes").ToList();
                FillWithData(ProductTypes);
            }

            // all columns auto resize
            ProductsTypesDataGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

            // hide id column
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[1].Hidden = true;

            // hide drag header area
            ProductsTypesDataGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            // center content
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[0].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[1].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[3].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[4].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[5].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[6].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns[7].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

            // first column as checkbox
            UltraGridColumn ugc = ProductsTypesDataGrid.DisplayLayout.Bands[0].Columns["Selected"];
            ugc.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ugc.CellActivation = Activation.AllowEdit;

            // stop confirmation message on delete
            ProductsTypesDataGrid.DisplayLayout.ShowDeleteRowsPrompt = false;
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

            DataColumn productTypeIdColumn = new DataColumn();
            productTypeIdColumn = new DataColumn();
            productTypeIdColumn.DataType = System.Type.GetType("System.String");
            productTypeIdColumn.ColumnName = "ProductTypeId";
            productTypeIdColumn.Caption = "رقم";
            productTypeIdColumn.ReadOnly = true;
            productTypeIdColumn.Unique = false;

            DataColumn productNameColumn = new DataColumn();
            productNameColumn = new DataColumn();
            productNameColumn.DataType = System.Type.GetType("System.String");
            productNameColumn.ColumnName = "ProductTypeName";
            productNameColumn.Caption = "اسم الصنف";
            productNameColumn.ReadOnly = true;
            productNameColumn.Unique = false;

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
            quantityColumn.Caption = "الكميه المتاحه";
            quantityColumn.ReadOnly = true;
            quantityColumn.Unique = false;

            DataColumn generalTypeColumn = new DataColumn();
            generalTypeColumn = new DataColumn();
            generalTypeColumn.DataType = System.Type.GetType("System.String");
            generalTypeColumn.ColumnName = "GeneralType";
            generalTypeColumn.Caption = "النوع";
            generalTypeColumn.ReadOnly = true;
            generalTypeColumn.Unique = false;

            DataColumn descriptionColumn = new DataColumn();
            descriptionColumn = new DataColumn();
            descriptionColumn.DataType = System.Type.GetType("System.String");
            descriptionColumn.ColumnName = "Description";
            descriptionColumn.Caption = "الوصف";
            descriptionColumn.ReadOnly = true;
            descriptionColumn.Unique = false;

            myDataTable.Columns.Add(selectedColumn);
            myDataTable.Columns.Add(productTypeIdColumn);
            myDataTable.Columns.Add(productNameColumn);
            myDataTable.Columns.Add(costPriceColumn);
            myDataTable.Columns.Add(sellPriceColumn);
            myDataTable.Columns.Add(quantityColumn);
            myDataTable.Columns.Add(generalTypeColumn);
            myDataTable.Columns.Add(descriptionColumn);


            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(myDataTable);

            ProductsTypesDataGrid.DataSource = dataSet;
        }

        private void FillWithData(List<ProductType> productTypes)
        {
            myDataTable.Clear();

            foreach (var productType in productTypes)
            {
                DataRow theDataRow = myDataTable.NewRow();
                theDataRow[0] = false;
                theDataRow[1] = productType.ProductTypeId;
                theDataRow[2] = productType.TypeName;
                theDataRow[3] = productType.CostPrice;
                theDataRow[4] = productType.SellPrice;
                theDataRow[5] = productType.Quantity;
                theDataRow[6] = productType.GeneralProductTypes.Name;
                theDataRow[7] = productType.Description;
                myDataTable.Rows.Add(theDataRow);
            }
        }

        private void ProductsTypesDataGrid_CellChange(object sender, CellEventArgs e)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(e.Cell.Column.Key, "Selected"))
            {
                foreach (var row in ProductsTypesDataGrid.Rows)
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

        public void btnProductNameSearch_Click(object sender, EventArgs e)
        {
            this.btnProductNameSearch.Enabled = false;
            string productTypeName = txtboxProductTypeName.Text.Trim();
            int generalProductTypeId = comboGeneralProductType.SelectedItem == null ? 0 : int.Parse(comboGeneralProductType.SelectedItem.DataValue.ToString());

            var filterd = ProductTypes.ToList();

            if (!string.IsNullOrWhiteSpace(productTypeName))
                filterd = filterd.Where(x => x.TypeName.Contains(productTypeName)).ToList();

            if (generalProductTypeId != 0)
                filterd = filterd.Where(x => x.GeneralProductTypeId == generalProductTypeId).ToList();

            FillWithData(filterd);
            this.btnProductNameSearch.Enabled = true;
        }

        private void btnDeleteProductType_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow == null)
                {
                    MessageBox.Show("اختر صنف للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(" هل تريد حذف " + selectedRow.Cells[2].Value + " ؟ ", "تأكيد", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    using (var db = new MarketDbContext())
                    {
                        var id = int.Parse(selectedRow.Cells[1].Value.ToString());

                        if (db.OrderDetails.Any(x=>x.ProductTypeId == id))
                        {
                            MessageBox.Show("لا يمكن حذف هذا الصنف فهو مرتبط بأوردرات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var recordToDelete = db.ProductTypes.FirstOrDefault(x => x.ProductTypeId == id);
                        db.ProductTypes.Remove(recordToDelete);
                        btnDeleteProductType.Enabled = false;
                        db.SaveChanges();

                        ProductTypes.Remove(ProductTypes.FirstOrDefault(x=>x.ProductTypeId == recordToDelete.ProductTypeId));
                    }

                    btnDeleteProductType.Enabled = true;
                    ProductsTypesDataGrid.Rows[selectedRow.Index].Delete();
                    MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            ProductTypesForm productTypesForm = new ProductTypesForm(user, this, selectedRow, true);
            productTypesForm.ShowDialog();
        }

        private void btnEditProductType_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
                MessageBox.Show("يجب اختيار صنف للتعديل اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ProductTypesForm productTypesForm = new ProductTypesForm(user, this, selectedRow, false);
                productTypesForm.ShowDialog();
            }
        }

        private void ProductTypesGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm(user);
            homeForm.ShowDialog();
        }
    }
}
