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
    public partial class DailyCostForm : MetroForm
    {
        private User user;
        private DailyCostGrid dailyCostGrid;
        private bool IsAdd;
        private UltraGridRow selectedRow;

        public DailyCostForm(User _user, DailyCostGrid _dailyCostGrid, UltraGridRow _selectedRow, bool _IsAdd)
        {
            user = _user;
            dailyCostGrid = _dailyCostGrid;
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
                txtboxDescription.Text = selectedRow.Cells[2].Value?.ToString();
                txtboxCost.Text = selectedRow.Cells[3].Value?.ToString();
            }
            else
            {
                txtboxCost.Text = "0";
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                loader.Hide();

                decimal cost;
                string description = txtboxDescription.Text.Trim();
                var canParseCost = decimal.TryParse(txtboxCost.Text.Trim(), out cost);

                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("يجب ادخال الوصف بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!canParseCost || cost < 0)
                {
                    MessageBox.Show("يجب ادخال التكلفه بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loader.Show();
                DailyCost dailyCost = null;

                if (IsAdd)
                {
                    dailyCost = new DailyCost()
                    {
                        Description = description,
                        Cost = cost,
                        InsertTime = DateTime.Now,
                    };

                    btnSubmit.Enabled = false;
                    await Task.Run(() => {
                        using (var db = new MarketDbContext())
                        {
                            db.DailyCosts.Add(dailyCost);
                            db.SaveChanges();
                        }
                    });
                    btnSubmit.Enabled = true;
                    loader.Hide();

                    dailyCostGrid.myDataTable.Rows.Add(false, dailyCost.DailyCostId, dailyCost.Description, dailyCost.Cost, dailyCost.InsertTime.ToString("dd/MM/yyyy"));
                    MessageBox.Show("تم الاضافه بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var id = int.Parse(selectedRow.Cells[1].Value.ToString());
                    using (var db = new MarketDbContext())
                    {
                        var rowToEdit = db.DailyCosts.FirstOrDefault(x => x.DailyCostId == id);

                        rowToEdit.Description = description;
                        rowToEdit.Cost = cost;

                        btnSubmit.Enabled = false;
                        await Task.Run(() =>
                        {
                            db.SaveChanges();
                        });
                    }
                    btnSubmit.Enabled = true;
                    loader.Hide();

                    this.dailyCostGrid.myDataTable.Columns[2].ReadOnly = false;
                    this.dailyCostGrid.myDataTable.Columns[3].ReadOnly = false;

                    selectedRow.Cells[2].Value = description;
                    selectedRow.Cells[3].Value = cost;

                    this.dailyCostGrid.myDataTable.Columns[2].ReadOnly = true;
                    this.dailyCostGrid.myDataTable.Columns[3].ReadOnly = true;

                    MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.dailyCostGrid.refresh();
                this.dailyCostGrid.calcToltalDailyCost();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("عذرا حدث خطأ ما", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
