
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillagesGrid));
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVillageNameSearch);
            this.panel1.Controls.Add(this.txtboxVillageName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // btnVillageNameSearch
            // 
            resources.ApplyResources(this.btnVillageNameSearch, "btnVillageNameSearch");
            this.btnVillageNameSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVillageNameSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVillageNameSearch.Name = "btnVillageNameSearch";
            this.btnVillageNameSearch.UseVisualStyleBackColor = false;
            this.btnVillageNameSearch.Click += new System.EventHandler(this.btnVillageSearch_Click);
            // 
            // txtboxVillageName
            // 
            resources.ApplyResources(this.txtboxVillageName, "txtboxVillageName");
            this.txtboxVillageName.Name = "txtboxVillageName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleteVillage);
            this.panel2.Controls.Add(this.btnEditVillage);
            this.panel2.Controls.Add(this.btnAddVillage);
            this.panel2.Name = "panel2";
            // 
            // btnDeleteVillage
            // 
            resources.ApplyResources(this.btnDeleteVillage, "btnDeleteVillage");
            this.btnDeleteVillage.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteVillage.Name = "btnDeleteVillage";
            this.btnDeleteVillage.UseVisualStyleBackColor = false;
            this.btnDeleteVillage.Click += new System.EventHandler(this.btnDeleteVillage_Click);
            // 
            // btnEditVillage
            // 
            resources.ApplyResources(this.btnEditVillage, "btnEditVillage");
            this.btnEditVillage.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditVillage.Name = "btnEditVillage";
            this.btnEditVillage.UseVisualStyleBackColor = false;
            this.btnEditVillage.Click += new System.EventHandler(this.btnEditVillage_Click);
            // 
            // btnAddVillage
            // 
            resources.ApplyResources(this.btnAddVillage, "btnAddVillage");
            this.btnAddVillage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddVillage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddVillage.Name = "btnAddVillage";
            this.btnAddVillage.UseVisualStyleBackColor = false;
            this.btnAddVillage.Click += new System.EventHandler(this.btnAddVillage_Click);
            // 
            // VillagesDataGrid
            // 
            resources.ApplyResources(this.VillagesDataGrid, "VillagesDataGrid");
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
            this.VillagesDataGrid.Name = "VillagesDataGrid";
            this.VillagesDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.VillagesDataGrid_CellChange);
            // 
            // VillagesGrid
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VillagesDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Name = "VillagesGrid";
            this.Resizable = false;
            this.ShowIcon = false;
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