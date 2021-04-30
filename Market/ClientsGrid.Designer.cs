
using Infragistics.Win.Misc;

namespace Market
{
    partial class ClientsGrid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboVillage = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.ClientsDataGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboVillage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtClientNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtboxClientName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 66);
            this.panel1.TabIndex = 0;
            // 
            // comboVillage
            // 
            this.comboVillage.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            this.comboVillage.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboVillage.Location = new System.Drawing.Point(160, 12);
            this.comboVillage.Name = "comboVillage";
            this.comboVillage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboVillage.Size = new System.Drawing.Size(215, 44);
            this.comboVillage.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 18F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(381, 2);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(113, 56);
            this.label5.TabIndex = 44;
            this.label5.Text = "القريه :";
            // 
            // txtClientNumber
            // 
            this.txtClientNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtClientNumber.Location = new System.Drawing.Point(540, 11);
            this.txtClientNumber.Name = "txtClientNumber";
            this.txtClientNumber.Size = new System.Drawing.Size(229, 45);
            this.txtClientNumber.TabIndex = 6;
            this.txtClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(775, 2);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(86, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "رقم :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(12, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnClientSearch_Click);
            // 
            // txtboxClientName
            // 
            this.txtboxClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxClientName.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxClientName.Location = new System.Drawing.Point(917, 11);
            this.txtboxClientName.Name = "txtboxClientName";
            this.txtboxClientName.Size = new System.Drawing.Size(207, 45);
            this.txtboxClientName.TabIndex = 4;
            this.txtboxClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(1130, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(98, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = " اسم :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleteClient);
            this.panel2.Controls.Add(this.btnEditClient);
            this.panel2.Controls.Add(this.btnAddClient);
            this.panel2.Location = new System.Drawing.Point(1006, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 675);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClient.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteClient.Location = new System.Drawing.Point(16, 179);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(217, 52);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.Text = "حذف عميل";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditClient.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditClient.Location = new System.Drawing.Point(16, 93);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(217, 52);
            this.btnEditClient.TabIndex = 1;
            this.btnEditClient.Text = "تعديل عميل";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddClient.Location = new System.Drawing.Point(16, 14);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(217, 52);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "اضافه عميل جديد";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // ClientsDataGrid
            // 
            this.ClientsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsDataGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ClientsDataGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.ClientsDataGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ClientsDataGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.ClientsDataGrid.DisplayLayout.MaxRowScrollRegions = 1;
            this.ClientsDataGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            this.ClientsDataGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ClientsDataGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ClientsDataGrid.DisplayLayout.Override.CellPadding = 3;
            this.ClientsDataGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ClientsDataGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            this.ClientsDataGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ClientsDataGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ClientsDataGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ClientsDataGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ClientsDataGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ClientsDataGrid.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.ClientsDataGrid.Location = new System.Drawing.Point(21, 111);
            this.ClientsDataGrid.Name = "ClientsDataGrid";
            this.ClientsDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClientsDataGrid.Size = new System.Drawing.Size(979, 675);
            this.ClientsDataGrid.TabIndex = 2;
            this.ClientsDataGrid.Text = "ultraGrid1";
            this.ClientsDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ClientsDataGrid_CellChange);
            // 
            // ClientsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1276, 797);
            this.Controls.Add(this.ClientsDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Cairo", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientsGrid";
            this.Padding = new System.Windows.Forms.Padding(18, 30, 18, 30);
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "الرئيسيه";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VillagesGrid_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.TextBox txtboxClientName;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ClientsDataGrid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtClientNumber;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor comboVillage;
        private System.Windows.Forms.Label label5;
    }
}