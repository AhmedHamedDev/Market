
namespace Market
{
    partial class ProductTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTypesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtboxProductTypeName = new System.Windows.Forms.TextBox();
            this.txtboxCostPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxSellPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGeneralType = new System.Windows.Forms.ComboBox();
            this.loader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtboxProductTypeName
            // 
            resources.ApplyResources(this.txtboxProductTypeName, "txtboxProductTypeName");
            this.txtboxProductTypeName.Name = "txtboxProductTypeName";
            // 
            // txtboxCostPrice
            // 
            resources.ApplyResources(this.txtboxCostPrice, "txtboxCostPrice");
            this.txtboxCostPrice.Name = "txtboxCostPrice";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtboxSellPrice
            // 
            resources.ApplyResources(this.txtboxSellPrice, "txtboxSellPrice");
            this.txtboxSellPrice.Name = "txtboxSellPrice";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtboxQuantity
            // 
            resources.ApplyResources(this.txtboxQuantity, "txtboxQuantity");
            this.txtboxQuantity.Name = "txtboxQuantity";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtboxDescription
            // 
            resources.ApplyResources(this.txtboxDescription, "txtboxDescription");
            this.txtboxDescription.Name = "txtboxDescription";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboBoxGeneralType
            // 
            resources.ApplyResources(this.comboBoxGeneralType, "comboBoxGeneralType");
            this.comboBoxGeneralType.FormattingEnabled = true;
            this.comboBoxGeneralType.Items.AddRange(new object[] {
            resources.GetString("comboBoxGeneralType.Items"),
            resources.GetString("comboBoxGeneralType.Items1"),
            resources.GetString("comboBoxGeneralType.Items2")});
            this.comboBoxGeneralType.Name = "comboBoxGeneralType";
            // 
            // loader
            // 
            this.loader.Image = global::Market.Properties.Resources.loader;
            resources.ApplyResources(this.loader, "loader");
            this.loader.Name = "loader";
            this.loader.TabStop = false;
            // 
            // ProductTypesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSubmit;
            this.Controls.Add(this.loader);
            this.Controls.Add(this.comboBoxGeneralType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxSellPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxCostPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxProductTypeName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Name = "ProductTypesForm";
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtboxProductTypeName;
        private System.Windows.Forms.TextBox txtboxCostPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxSellPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGeneralType;
        private System.Windows.Forms.PictureBox loader;
    }
}

