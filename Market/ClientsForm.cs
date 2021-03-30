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
    public partial class ClientsForm : MetroForm
    {
        private User user;
        private OrderForm orderForm;
        private UltraGridRow selectedRow;
        private ClientsGrid clientsGrid;
        private List<Village> Villages;
        bool isAdd;

        public ClientsForm(User _user, OrderForm _orderForm, ClientsGrid _clientsGrid, UltraGridRow _selectedRow, bool _isAdd)
        {
            user = _user;
            orderForm = _orderForm;
            isAdd = _isAdd;
            selectedRow = _selectedRow;
            clientsGrid = _clientsGrid;

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.None;

            using (var db = new MarketDbContext())
            {
                this.comboVillage.DataSource = Villages = db.Villages.ToList();
            }
            this.comboVillage.DisplayMember = "VillageName";
            this.comboVillage.Name = "Name";
            this.comboVillage.ValueMember = "VillageId";

            if (!isAdd)
            {
                txtboxAddress.Text = selectedRow.Cells[4].Value?.ToString();
                txtboxClientName.Text = selectedRow.Cells[2].Value?.ToString();
                txtboxClientNumber.Text = selectedRow.Cells[3].Value?.ToString();
                comboVillage.SelectedText = selectedRow.Cells[5].Value?.ToString();
            }

            loader.Hide();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                loader.Hide();

                if(comboVillage.SelectedItem == null)
                {
                    MessageBox.Show("يجب اختيار قريه العميل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int villageId = int.Parse(comboVillage.SelectedItem.DataValue.ToString());
                string clientName = txtboxClientName.Text.Trim();
                string clientNumber = txtboxClientNumber.Text.Trim();
                string clientAddress = txtboxAddress.Text.Trim();

                if (string.IsNullOrWhiteSpace(clientName))
                {
                    MessageBox.Show("يجب ادخال الاسم بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(clientNumber))
                {
                    MessageBox.Show("يجب ادخال رقم العميل بطريقه صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loader.Show();
                Client client = null;

                if (isAdd)
                {
                    client = new Client()
                    {
                        Name = clientName,
                        Number = clientNumber,
                        VillageId = villageId,
                        Address = clientAddress,
                        InsertTime = DateTime.Now
                    };

                    btnSubmit.Enabled = false;
                    await Task.Run(() =>
                    {
                        using (var db = new MarketDbContext())
                        {
                            db.Clients.Add(client);
                            db.SaveChanges();
                        }
                    });
                    btnSubmit.Enabled = true;
                    loader.Hide();

                    if (orderForm != null)
                        orderForm.RefreshComboClient();

                    if (clientsGrid != null)
                    {
                        client.Village = Villages.FirstOrDefault(x => x.VillageId == client.VillageId);
                        clientsGrid.myDataTable.Rows.Add(false, client.ClientId, client.Name, client.Number, client.Address, comboVillage.Items[client.VillageId - 1].ToString());
                        clientsGrid.Clients.Add(client);
                        clientsGrid.btnClientSearch_Click(null, null);
                    }

                    MessageBox.Show("تم الاضافه بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var id = int.Parse(selectedRow.Cells[1].Value.ToString());

                    Client rowToEdit = null;
                    using (var db = new MarketDbContext())
                    {
                        rowToEdit = db.Clients.FirstOrDefault(x => x.ClientId == id);

                        rowToEdit.Name = clientName;
                        rowToEdit.Number = clientNumber;
                        rowToEdit.Address = clientAddress;
                        rowToEdit.VillageId = comboVillage.SelectedIndex + 1;

                        btnSubmit.Enabled = false;
                        await Task.Run(() =>
                        {
                            db.SaveChanges();
                        });
                    }

                    btnSubmit.Enabled = true;
                    loader.Hide();

                    clientsGrid.myDataTable.Columns[2].ReadOnly = false;
                    clientsGrid.myDataTable.Columns[3].ReadOnly = false;
                    clientsGrid.myDataTable.Columns[4].ReadOnly = false;
                    clientsGrid.myDataTable.Columns[5].ReadOnly = false;

                    selectedRow.Cells[2].Value = clientName;
                    selectedRow.Cells[3].Value = clientNumber;
                    selectedRow.Cells[4].Value = clientAddress;
                    selectedRow.Cells[5].Value = comboVillage.Items[rowToEdit.VillageId - 1].ToString();

                    clientsGrid.myDataTable.Columns[2].ReadOnly = true;
                    clientsGrid.myDataTable.Columns[3].ReadOnly = true;
                    clientsGrid.myDataTable.Columns[4].ReadOnly = true;
                    clientsGrid.myDataTable.Columns[5].ReadOnly = true;

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
