
namespace Market
{
    partial class ClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtboxClientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loader = new System.Windows.Forms.PictureBox();
            this.comboVillage = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.txtboxClientNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 18F);
            this.label1.Location = new System.Drawing.Point(917, 107);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(185, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Cairo", 12F);
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(509, 390);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 59);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "حفظ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtboxClientName
            // 
            this.txtboxClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxClientName.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxClientName.Location = new System.Drawing.Point(629, 117);
            this.txtboxClientName.Name = "txtboxClientName";
            this.txtboxClientName.Size = new System.Drawing.Size(282, 45);
            this.txtboxClientName.TabIndex = 2;
            this.txtboxClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 18F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(917, 203);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(113, 56);
            this.label4.TabIndex = 9;
            this.label4.Text = "القريه :";
            // 
            // loader
            // 
            this.loader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loader.Image = global::Market.Properties.Resources.loader;
            this.loader.Location = new System.Drawing.Point(534, 472);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(82, 61);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loader.TabIndex = 15;
            this.loader.TabStop = false;
            // 
            // comboVillage
            // 
            this.comboVillage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboVillage.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.comboVillage.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboVillage.Location = new System.Drawing.Point(629, 215);
            this.comboVillage.Name = "comboVillage";
            this.comboVillage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboVillage.Size = new System.Drawing.Size(282, 44);
            this.comboVillage.TabIndex = 30;
            // 
            // txtboxClientNumber
            // 
            this.txtboxClientNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxClientNumber.Location = new System.Drawing.Point(68, 117);
            this.txtboxClientNumber.Name = "txtboxClientNumber";
            this.txtboxClientNumber.Size = new System.Drawing.Size(284, 45);
            this.txtboxClientNumber.TabIndex = 32;
            this.txtboxClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 18F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(358, 107);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(180, 56);
            this.label2.TabIndex = 31;
            this.label2.Text = "رقم العميل :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 18F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(358, 215);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(127, 56);
            this.label3.TabIndex = 33;
            this.label3.Text = "العنوان :";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxAddress.Location = new System.Drawing.Point(68, 226);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(284, 135);
            this.txtboxAddress.TabIndex = 34;
            this.txtboxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 575);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxClientNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboVillage);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxClientName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "ClientsForm";
            this.ShowIcon = false;
            this.Text = "العملاء";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtboxClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox loader;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor comboVillage;
        private System.Windows.Forms.TextBox txtboxClientNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxAddress;
    }
}

