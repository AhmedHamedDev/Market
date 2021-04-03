
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;

namespace Market
{
    partial class Delayed
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
            this.components = new System.ComponentModel.Container();
            this.OrdersDataGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioWithoutDelivery = new System.Windows.Forms.RadioButton();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.radioAllDeliveryNotDelivery = new System.Windows.Forms.RadioButton();
            this.btnDetails = new System.Windows.Forms.Button();
            this.comboVillage = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.comboClient = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.clientLable = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClient)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersDataGrid
            // 
            this.OrdersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.OrdersDataGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.OrdersDataGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.OrdersDataGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.OrdersDataGrid.DisplayLayout.MaxRowScrollRegions = 1;
            this.OrdersDataGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            this.OrdersDataGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.OrdersDataGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.OrdersDataGrid.DisplayLayout.Override.CellPadding = 3;
            this.OrdersDataGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.OrdersDataGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            this.OrdersDataGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.OrdersDataGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.OrdersDataGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.OrdersDataGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.OrdersDataGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.OrdersDataGrid.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.OrdersDataGrid.Location = new System.Drawing.Point(21, 182);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrdersDataGrid.Size = new System.Drawing.Size(1344, 604);
            this.OrdersDataGrid.TabIndex = 2;
            this.OrdersDataGrid.Text = "ultraGrid1";
            this.OrdersDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.VillagesDataGrid_CellChange);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.comboVillage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboClient);
            this.panel1.Controls.Add(this.clientLable);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtboxOrderNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 143);
            this.panel1.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPay.Location = new System.Drawing.Point(1197, 84);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(139, 45);
            this.btnPay.TabIndex = 64;
            this.btnPay.Text = "دفع";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWithoutDelivery);
            this.groupBox1.Controls.Add(this.radioDelivery);
            this.groupBox1.Controls.Add(this.radioAllDeliveryNotDelivery);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 54);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioWithoutDelivery
            // 
            this.radioWithoutDelivery.AutoSize = true;
            this.radioWithoutDelivery.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWithoutDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioWithoutDelivery.Location = new System.Drawing.Point(111, 17);
            this.radioWithoutDelivery.Name = "radioWithoutDelivery";
            this.radioWithoutDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioWithoutDelivery.Size = new System.Drawing.Size(123, 36);
            this.radioWithoutDelivery.TabIndex = 55;
            this.radioWithoutDelivery.TabStop = true;
            this.radioWithoutDelivery.Text = "بدون دليفري";
            this.radioWithoutDelivery.UseVisualStyleBackColor = true;
            // 
            // radioDelivery
            // 
            this.radioDelivery.AutoSize = true;
            this.radioDelivery.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioDelivery.Location = new System.Drawing.Point(265, 17);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioDelivery.Size = new System.Drawing.Size(86, 36);
            this.radioDelivery.TabIndex = 54;
            this.radioDelivery.TabStop = true;
            this.radioDelivery.Text = "دليفري";
            this.radioDelivery.UseVisualStyleBackColor = true;
            // 
            // radioAllDeliveryNotDelivery
            // 
            this.radioAllDeliveryNotDelivery.AutoSize = true;
            this.radioAllDeliveryNotDelivery.Checked = true;
            this.radioAllDeliveryNotDelivery.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAllDeliveryNotDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioAllDeliveryNotDelivery.Location = new System.Drawing.Point(8, 17);
            this.radioAllDeliveryNotDelivery.Name = "radioAllDeliveryNotDelivery";
            this.radioAllDeliveryNotDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioAllDeliveryNotDelivery.Size = new System.Drawing.Size(67, 36);
            this.radioAllDeliveryNotDelivery.TabIndex = 56;
            this.radioAllDeliveryNotDelivery.TabStop = true;
            this.radioAllDeliveryNotDelivery.Text = "الكل";
            this.radioAllDeliveryNotDelivery.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDetails.Location = new System.Drawing.Point(1046, 84);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(139, 45);
            this.btnDetails.TabIndex = 49;
            this.btnDetails.Text = "تفاصيل";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // comboVillage
            // 
            this.comboVillage.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            this.comboVillage.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboVillage.Location = new System.Drawing.Point(12, 12);
            this.comboVillage.Name = "comboVillage";
            this.comboVillage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboVillage.Size = new System.Drawing.Size(252, 44);
            this.comboVillage.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 18F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(270, 5);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(113, 56);
            this.label5.TabIndex = 42;
            this.label5.Text = "القريه :";
            // 
            // comboClient
            // 
            this.comboClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboClient.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            this.comboClient.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboClient.Location = new System.Drawing.Point(459, 11);
            this.comboClient.Name = "comboClient";
            this.comboClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboClient.Size = new System.Drawing.Size(252, 44);
            this.comboClient.TabIndex = 34;
            this.comboClient.TextChanged += new System.EventHandler(this.comboClient_TextChanged);
            // 
            // clientLable
            // 
            this.clientLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientLable.AutoSize = true;
            this.clientLable.Font = new System.Drawing.Font("Cairo", 18F);
            this.clientLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientLable.Location = new System.Drawing.Point(717, 1);
            this.clientLable.Name = "clientLable";
            this.clientLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientLable.Size = new System.Drawing.Size(125, 56);
            this.clientLable.TabIndex = 33;
            this.clientLable.Text = "العميل :";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(918, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxOrderNumber
            // 
            this.txtboxOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxOrderNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxOrderNumber.Location = new System.Drawing.Point(918, 11);
            this.txtboxOrderNumber.Name = "txtboxOrderNumber";
            this.txtboxOrderNumber.Size = new System.Drawing.Size(250, 45);
            this.txtboxOrderNumber.TabIndex = 4;
            this.txtboxOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(1175, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(171, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الاوردر :";
            // 
            // Delayed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.OrdersDataGrid);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Cairo", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Delayed";
            this.Padding = new System.Windows.Forms.Padding(18, 30, 18, 30);
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "الرئيسيه";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VillagesGrid_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.UltraWinGrid.UltraGrid OrdersDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetails;
        private UltraComboEditor comboVillage;
        private System.Windows.Forms.Label label5;
        private UltraComboEditor comboClient;
        private System.Windows.Forms.Label clientLable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAllDeliveryNotDelivery;
        private System.Windows.Forms.RadioButton radioWithoutDelivery;
        private System.Windows.Forms.RadioButton radioDelivery;
        private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter ultraGridExcelExporter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPay;
    }
}