
using Infragistics.Win.Misc;

namespace Market
{
    partial class DailyCostGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyCostGrid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeTo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalDailyCostLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteDailyCost = new System.Windows.Forms.Button();
            this.btnEditDailyCost = new System.Windows.Forms.Button();
            this.btnAddDailyCost = new System.Windows.Forms.Button();
            this.DailyCostDataGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFrom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyCostDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimeTo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TotalDailyCostLable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeFrom);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // dateTimeTo
            // 
            resources.ApplyResources(this.dateTimeTo, "dateTimeTo");
            this.dateTimeTo.FormatProvider = new System.Globalization.CultureInfo("ar-EG");
            this.dateTimeTo.MaskInput = "{date}";
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Name = "label3";
            // 
            // TotalDailyCostLable
            // 
            resources.ApplyResources(this.TotalDailyCostLable, "TotalDailyCostLable");
            this.TotalDailyCostLable.ForeColor = System.Drawing.Color.Gold;
            this.TotalDailyCostLable.Name = "TotalDailyCostLable";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Name = "label2";
            // 
            // dateTimeFrom
            // 
            resources.ApplyResources(this.dateTimeFrom, "dateTimeFrom");
            this.dateTimeFrom.FormatProvider = new System.Globalization.CultureInfo("ar-EG");
            this.dateTimeFrom.MaskInput = "{date}";
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnVillageSearch_Click);
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
            this.panel2.Controls.Add(this.btnDeleteDailyCost);
            this.panel2.Controls.Add(this.btnEditDailyCost);
            this.panel2.Controls.Add(this.btnAddDailyCost);
            this.panel2.Name = "panel2";
            // 
            // btnDeleteDailyCost
            // 
            resources.ApplyResources(this.btnDeleteDailyCost, "btnDeleteDailyCost");
            this.btnDeleteDailyCost.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteDailyCost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteDailyCost.Name = "btnDeleteDailyCost";
            this.btnDeleteDailyCost.UseVisualStyleBackColor = false;
            this.btnDeleteDailyCost.Click += new System.EventHandler(this.btnDeleteVillage_Click);
            // 
            // btnEditDailyCost
            // 
            resources.ApplyResources(this.btnEditDailyCost, "btnEditDailyCost");
            this.btnEditDailyCost.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditDailyCost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditDailyCost.Name = "btnEditDailyCost";
            this.btnEditDailyCost.UseVisualStyleBackColor = false;
            this.btnEditDailyCost.Click += new System.EventHandler(this.btnEditVillage_Click);
            // 
            // btnAddDailyCost
            // 
            resources.ApplyResources(this.btnAddDailyCost, "btnAddDailyCost");
            this.btnAddDailyCost.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddDailyCost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddDailyCost.Name = "btnAddDailyCost";
            this.btnAddDailyCost.UseVisualStyleBackColor = false;
            this.btnAddDailyCost.Click += new System.EventHandler(this.btnAddVillage_Click);
            // 
            // DailyCostDataGrid
            // 
            resources.ApplyResources(this.DailyCostDataGrid, "DailyCostDataGrid");
            this.DailyCostDataGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.DailyCostDataGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.DailyCostDataGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.DailyCostDataGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.DailyCostDataGrid.DisplayLayout.MaxRowScrollRegions = 1;
            this.DailyCostDataGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            this.DailyCostDataGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.DailyCostDataGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.DailyCostDataGrid.DisplayLayout.Override.CellPadding = 3;
            this.DailyCostDataGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.DailyCostDataGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            this.DailyCostDataGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.DailyCostDataGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.DailyCostDataGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.DailyCostDataGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.DailyCostDataGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.DailyCostDataGrid.Name = "DailyCostDataGrid";
            this.DailyCostDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.DailyCostDataGrid_CellChange);
            // 
            // DailyCostGrid
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DailyCostDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Name = "DailyCostGrid";
            this.Resizable = false;
            this.ShowIcon = false;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VillagesGrid_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFrom)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailyCostDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddDailyCost;
        private System.Windows.Forms.Button btnDeleteDailyCost;
        private System.Windows.Forms.Button btnEditDailyCost;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinGrid.UltraGrid DailyCostDataGrid;
        private System.Windows.Forms.Button btnSearch;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dateTimeFrom;
        private System.Windows.Forms.Label TotalDailyCostLable;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dateTimeTo;
        private System.Windows.Forms.Label label3;
    }
}