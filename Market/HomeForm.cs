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
    public partial class HomeForm : MetroForm
    {
        private User user;

        public HomeForm(User _user)
        {
            user = _user;

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.None;
            btnProductTypesFormShow.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnProductTypesFormShow_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProductTypesGrid productTypesGrid = new ProductTypesGrid(user);
            productTypesGrid.ShowDialog();
        }

        private void btnReportsFormShow_Click(object sender, EventArgs e)
        {
            this.Hide();

            OrderGrid orderGrid = new OrderGrid(user);
            orderGrid.ShowDialog();
        }

        private void brnOrdersFormShow_Click(object sender, EventArgs e)
        {
            this.Hide();

            OrderForm orderForm = new OrderForm(user);
            orderForm.ShowDialog();
        }

        private void btnVillagesFormShow_Click(object sender, EventArgs e)
        {
            this.Hide();

            VillagesGrid villagesGrid = new VillagesGrid(user);
            villagesGrid.ShowDialog();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnClientsFormShow_Click(object sender, EventArgs e)
        {
            this.Hide();

            ClientsGrid ClientsGrid = new ClientsGrid(user);
            ClientsGrid.ShowDialog();
        }

        private void btnDelayedFormShow_Click(object sender, EventArgs e)
        {
            this.Hide();

            Delayed delayed = new Delayed(user);
            delayed.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            DailyCostGrid dailyCostGrid = new DailyCostGrid(user);
            dailyCostGrid.ShowDialog();
        }
    }
}
