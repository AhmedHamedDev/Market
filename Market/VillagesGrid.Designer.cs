
using Infragistics.Win.Misc;

namespace Market
{
    partial class VillagesGrid
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
            this.btnVillageNameSearch = new System.Windows.Forms.Button();
            this.txtboxVillageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteVillage = new System.Windows.Forms.Button();
            this.btnEditVillage = new System.Windows.Forms.Button();
            this.btnAddVillage = new System.Windows.Forms.Button();
            this.VillagesDataGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VillagesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVillageNameSearch);
            this.panel1.Controls.Add(this.txtboxVillageName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnVillageNameSearch
            // 
            this.btnVillageNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVillageNameSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVillageNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVillageNameSearch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnVillageNameSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVillageNameSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVillageNameSearch.Location = new System.Drawing.Point(335, 11);
            this.btnVillageNameSearch.Name = "btnVillageNameSearch";
            this.btnVillageNameSearch.Size = new System.Drawing.Size(93, 45);
            this.btnVillageNameSearch.TabIndex = 3;
            this.btnVillageNameSearch.Text = "بحث";
            this.btnVillageNameSearch.UseVisualStyleBackColor = false;
            this.btnVillageNameSearch.Click += new System.EventHandler(this.btnVillageSearch_Click);
            // 
            // txtboxVillageName
            // 
            this.txtboxVillageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxVillageName.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxVillageName.Location = new System.Drawing.Point(445, 11);
            this.txtboxVillageName.Name = "txtboxVillageName";
            this.txtboxVillageName.Size = new System.Drawing.Size(357, 45);
            this.txtboxVillageName.TabIndex = 4;
            this.txtboxVillageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(808, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(173, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم القريه :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleteVillage);
            this.panel2.Controls.Add(this.btnEditVillage);
            this.panel2.Controls.Add(this.btnAddVillage);
            this.panel2.Location = new System.Drawing.Point(1024, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 675);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteVillage
            // 
            this.btnDeleteVillage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteVillage.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVillage.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteVillage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteVillage.Location = new System.Drawing.Point(16, 179);
            this.btnDeleteVillage.Name = "btnDeleteVillage";
            this.btnDeleteVillage.Size = new System.Drawing.Size(217, 52);
            this.btnDeleteVillage.TabIndex = 2;
            this.btnDeleteVillage.Text = "حذف قريه";
            this.btnDeleteVillage.UseVisualStyleBackColor = false;
            this.btnDeleteVillage.Click += new System.EventHandler(this.btnDeleteVillage_Click);
            // 
            // btnEditVillage
            // 
            this.btnEditVillage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditVillage.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVillage.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditVillage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditVillage.Location = new System.Drawing.Point(16, 93);
            this.btnEditVillage.Name = "btnEditVillage";
            this.btnEditVillage.Size = new System.Drawing.Size(217, 52);
            this.btnEditVillage.TabIndex = 1;
            this.btnEditVillage.Text = "تعديل قريه";
            this.btnEditVillage.UseVisualStyleBackColor = false;
            this.btnEditVillage.Click += new System.EventHandler(this.btnEditVillage_Click);
            // 
            // btnAddVillage
            // 
            this.btnAddVillage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVillage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddVillage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVillage.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddVillage.Location = new System.Drawing.Point(16, 14);
            this.btnAddVillage.Name = "btnAddVillage";
            this.btnAddVillage.Size = new System.Drawing.Size(217, 52);
            this.btnAddVillage.TabIndex = 0;
            this.btnAddVillage.Text = "اضافه قريه جديد";
            this.btnAddVillage.UseVisualStyleBackColor = false;
            this.btnAddVillage.Click += new System.EventHandler(this.btnAddVillage_Click);
            // 
            // VillagesDataGrid
            // 
            this.VillagesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VillagesDataGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.VillagesDataGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.VillagesDataGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.VillagesDataGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.VillagesDataGrid.DisplayLayout.MaxRowScrollRegions = 1;
            this.VillagesDataGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            this.VillagesDataGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.VillagesDataGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.VillagesDataGrid.DisplayLayout.Override.CellPadding = 3;
            this.VillagesDataGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.VillagesDataGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            this.VillagesDataGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.VillagesDataGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.VillagesDataGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.VillagesDataGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.VillagesDataGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.VillagesDataGrid.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.VillagesDataGrid.Location = new System.Drawing.Point(21, 111);
            this.VillagesDataGrid.Name = "VillagesDataGrid";
            this.VillagesDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VillagesDataGrid.Size = new System.Drawing.Size(997, 675);
            this.VillagesDataGrid.TabIndex = 2;
            this.VillagesDataGrid.Text = "ultraGrid1";
            this.VillagesDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.VillagesDataGrid_CellChange);
            // 
            // VillagesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1294, 797);
            this.Controls.Add(this.VillagesDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Cairo", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VillagesGrid";
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VillagesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddVillage;
        private System.Windows.Forms.Button btnDeleteVillage;
        private System.Windows.Forms.Button btnEditVillage;
        private System.Windows.Forms.TextBox txtboxVillageName;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinGrid.UltraGrid VillagesDataGrid;
        private System.Windows.Forms.Button btnVillageNameSearch;
    }
}