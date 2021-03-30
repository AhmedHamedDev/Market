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
    public partial class VillagesForm : MetroForm
    {
        private User user;
        private VillagesGrid villagesGrid;
        private bool IsAdd;
        private UltraGridRow selectedRow;

        public VillagesForm(User _user, VillagesGrid _villagesGrid, UltraGridRow _selectedRow, bool _IsAdd)
        {
            user = _user;
            villagesGrid = _villagesGrid;
            IsAdd = _IsAdd;
            selectedRow = _selectedRow;

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.None;

            loader.Hide();

            if (!IsAdd)
            {
                txtboxVillageName.Text = selectedRow.Cells[2].Value?.ToString();
                txtboxDeliveryCost.Text = selectedRow.Cells[3].Value?.ToString();
            }
            else
            {
                txtboxDeliveryCost.Text = "0";
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                loader.Hide();

                decimal deliveryCost;
                string villageName = txtboxVillageName.Text.Trim();
                var canParseDeliveryCost = decimal.TryParse(txtboxDeliveryCost.Text.Trim(), out deliveryCost);

                if (string.IsNullOrWhiteSpace(villageName))
                {
                    MessageBox.Show("يجب ادخال الاسم بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!canParseDeliveryCost || deliveryCost < 0)
                {
                    MessageBox.Show("يجب ادخال تكلفه التوصيل بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loader.Show();
                Village village = null;

                if (IsAdd)
                {
                    village = new Village()
                    {
                        VillageName = villageName,
                        DeliveryCost = deliveryCost,
                        InsertTime = DateTime.Now,
                    };

                    btnSubmit.Enabled = false;
                    await Task.Run(() => {
                        using (var db = new MarketDbContext())
                        {
                            db.Villages.Add(village);
                            db.SaveChanges();
                        }
                    });
                    btnSubmit.Enabled = true;
                    loader.Hide();

                    villagesGrid.myDataTable.Rows.Add(false, village.VillageId, village.VillageName, village.DeliveryCost);
                    MessageBox.Show("تم الاضافه بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var id = int.Parse(selectedRow.Cells[1].Value.ToString());
                    using (var db = new MarketDbContext())
                    {
                        var rowToEdit = db.Villages.FirstOrDefault(x => x.VillageId == id);

                        rowToEdit.VillageName = villageName;
                        rowToEdit.DeliveryCost = deliveryCost;

                        btnSubmit.Enabled = false;
                        await Task.Run(() =>
                        {
                            db.SaveChanges();
                        });
                    }
                    btnSubmit.Enabled = true;
                    loader.Hide();

                    villagesGrid.myDataTable.Columns[2].ReadOnly = false;
                    villagesGrid.myDataTable.Columns[3].ReadOnly = false;

                    selectedRow.Cells[2].Value = villageName;
                    selectedRow.Cells[3].Value = deliveryCost;

                    villagesGrid.myDataTable.Columns[2].ReadOnly = true;
                    villagesGrid.myDataTable.Columns[3].ReadOnly = true;

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
