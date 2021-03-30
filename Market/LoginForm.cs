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
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.None;
            loader.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            loader.Hide();

            var userName = txtboxUsername.Text.ToLower().Trim();
            var password = txtboxPassword.Text.Trim();

            if(string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("يجب ادخال اسم المستخدم وكلمه المرور اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loader.Show();
            btnLogin.Enabled = false;
            User user = null;
            await Task.Run(() => {
                using (var db = new MarketDbContext())
                {
                    user = db.Users.FirstOrDefault(x => x.UserName.ToLower().Trim() == userName && x.Password.Trim() == password);
                }
            });
            btnLogin.Enabled = true;
            loader.Hide();

            if (user == null)
            {
                MessageBox.Show("اسم المستخدم او كلمه السر غير صحيحه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();

            HomeForm homeForm = new HomeForm(user);
            homeForm.ShowDialog();
        }

    }
}
