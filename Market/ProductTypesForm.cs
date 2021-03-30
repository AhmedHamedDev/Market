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
    public partial class ProductTypesForm : MetroForm
    {
        private User user;
        private ProductTypesGrid productTypesGrid;
        private bool IsAdd;
        private UltraGridRow selectedRow;
        private List<GeneralProductType> GeneralProductTypes;

        public ProductTypesForm(User _user, ProductTypesGrid _productTypesGrid, UltraGridRow _selectedRow, bool _IsAdd)
        {
            user = _user;
            productTypesGrid = _productTypesGrid;
            IsAdd = _IsAdd;
            selectedRow = _selectedRow;
            GeneralProductTypes = new List<GeneralProductType>() { 
                new GeneralProductType() {GeneralProductTypeId = 1, Name = "مأكولات" } ,
                new GeneralProductType() {GeneralProductTypeId = 2, Name = "مشروبات" } ,
                new GeneralProductType() {GeneralProductTypeId = 3, Name = "شيشه" } ,
            };

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.None;

            loader.Hide();

            if (!IsAdd)
            {
                txtboxProductTypeName.Text = selectedRow.Cells[2].Value?.ToString();
                txtboxCostPrice.Text = selectedRow.Cells[3].Value?.ToString();
                txtboxSellPrice.Text = selectedRow.Cells[4].Value?.ToString();
                txtboxQuantity.Text = selectedRow.Cells[5].Value?.ToString();
                comboBoxGeneralType.SelectedItem = selectedRow.Cells[6].Value?.ToString();
                txtboxDescription.Text = selectedRow.Cells[7].Value?.ToString();
            }
            else
            {
                txtboxCostPrice.Text = "0";
                txtboxSellPrice.Text = "0";
                txtboxQuantity.Text = "0";
                comboBoxGeneralType.SelectedIndex = 0;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                loader.Hide();

                int Quantity;
                decimal costPrice, sellPrice;
                string productTypeName = txtboxProductTypeName.Text.Trim();
                string productTypeDescription = txtboxDescription.Text.Trim();
                var canParseCostPrice = decimal.TryParse(txtboxCostPrice.Text.Trim(), out costPrice);
                var canParseSellPrice = decimal.TryParse(txtboxSellPrice.Text.Trim(), out sellPrice);
                var canParseQuantity = int.TryParse(txtboxQuantity.Text.Trim(), out Quantity);

                if (string.IsNullOrWhiteSpace(productTypeName))
                {
                    MessageBox.Show("يجب ادخال الاسم بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!canParseCostPrice || costPrice < 0)
                {
                    MessageBox.Show("يجب ادخال سعر التكلفه بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!canParseSellPrice || sellPrice < 0)
                {
                    MessageBox.Show("يجب ادخال سعر البيع بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (costPrice > sellPrice)
                {
                    MessageBox.Show("سعر التكلفه يجب ان لا يزيد عن سعر البيع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!canParseQuantity || Quantity < 0)
                {
                    MessageBox.Show("يجب ادخال الكميه بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loader.Show();
                ProductType productType = null;

                if (IsAdd)
                {
                    productType = new ProductType()
                    {
                        TypeName = productTypeName,
                        CostPrice = costPrice,
                        SellPrice = sellPrice,
                        Quantity = Quantity,
                        InsertTime = DateTime.Now,
                        GeneralProductTypeId = comboBoxGeneralType.SelectedIndex + 1,
                        Description = productTypeDescription,
                    };

                    btnSubmit.Enabled = false;
                    await Task.Run(() =>
                    {
                        using (var db = new MarketDbContext())
                        {
                            db.ProductTypes.Add(productType);
                            db.SaveChanges();
                        }
                    });
                    btnSubmit.Enabled = true;
                    loader.Hide();

                    productTypesGrid.myDataTable.Rows.Add(false, productType.ProductTypeId, productType.TypeName, productType.CostPrice, productType.SellPrice, productType.Quantity, comboBoxGeneralType.Items[productType.GeneralProductTypeId - 1].ToString(), productType.Description);
                    productType.GeneralProductTypes = GeneralProductTypes.FirstOrDefault(x => x.GeneralProductTypeId == productType.GeneralProductTypeId);
                    productTypesGrid.ProductTypes.Add(productType);
                    productTypesGrid.btnProductNameSearch_Click(null, null);
                    MessageBox.Show("تم الاضافه بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var id = int.Parse(selectedRow.Cells[1].Value.ToString());

                    ProductType rowToEdit = null;
                    using (var db = new MarketDbContext())
                    {
                        rowToEdit = db.ProductTypes.Include("GeneralProductTypes").FirstOrDefault(x => x.ProductTypeId == id);

                        rowToEdit.TypeName = productTypeName;
                        rowToEdit.CostPrice = costPrice;
                        rowToEdit.SellPrice = sellPrice;
                        rowToEdit.Quantity = Quantity;
                        rowToEdit.GeneralProductTypeId = comboBoxGeneralType.SelectedIndex + 1;
                        rowToEdit.Description = productTypeDescription;

                        btnSubmit.Enabled = false;
                        await Task.Run(() =>
                        {
                            db.SaveChanges();
                        });
                    }

                    btnSubmit.Enabled = true;
                    loader.Hide();

                    productTypesGrid.myDataTable.Columns[2].ReadOnly = false;
                    productTypesGrid.myDataTable.Columns[3].ReadOnly = false;
                    productTypesGrid.myDataTable.Columns[4].ReadOnly = false;
                    productTypesGrid.myDataTable.Columns[5].ReadOnly = false;
                    productTypesGrid.myDataTable.Columns[6].ReadOnly = false;
                    productTypesGrid.myDataTable.Columns[7].ReadOnly = false;

                    selectedRow.Cells[2].Value = productTypeName;
                    selectedRow.Cells[3].Value = costPrice;
                    selectedRow.Cells[4].Value = sellPrice;
                    selectedRow.Cells[5].Value = Quantity;
                    selectedRow.Cells[6].Value = comboBoxGeneralType.Items[rowToEdit.GeneralProductTypeId - 1].ToString();
                    selectedRow.Cells[7].Value = productTypeDescription;

                    productTypesGrid.myDataTable.Columns[2].ReadOnly = true;
                    productTypesGrid.myDataTable.Columns[3].ReadOnly = true;
                    productTypesGrid.myDataTable.Columns[4].ReadOnly = true;
                    productTypesGrid.myDataTable.Columns[5].ReadOnly = true;
                    productTypesGrid.myDataTable.Columns[6].ReadOnly = true;
                    productTypesGrid.myDataTable.Columns[7].ReadOnly = true;

                    MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
