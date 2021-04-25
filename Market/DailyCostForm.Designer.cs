
namespace Market
{
    partial class DailyCostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyCostForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtboxDescription
            // 
            resources.ApplyResources(this.txtboxDescription, "txtboxDescription");
            this.txtboxDescription.Name = "txtboxDescription";
            // 
            // txtboxCost
            // 
            resources.ApplyResources(this.txtboxCost, "txtboxCost");
            this.txtboxCost.Name = "txtboxCost";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // loader
            // 
            this.loader.Image = global::Market.Properties.Resources.loader;
            resources.ApplyResources(this.loader, "loader");
            this.loader.Name = "loader";
            this.loader.TabStop = false;
            // 
            // DailyCostForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSubmit;
            this.Controls.Add(this.loader);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Name = "DailyCostForm";
            this.ShowIcon = false;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox loader;
    }
}

