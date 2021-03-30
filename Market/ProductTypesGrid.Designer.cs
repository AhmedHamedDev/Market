
using Infragistics.Win.Misc;

namespace Market
{
    partial class ProductTypesGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTypesGrid));
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductNameSearch = new System.Windows.Forms.Button();
            this.txtboxProductTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteProductType = new System.Windows.Forms.Button();
            this.btnEditProductType = new System.Windows.Forms.Button();
            this.btnAddProductType = new System.Windows.Forms.Button();
            this.ProductsTypesDataGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.comboGeneralProductType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTypesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGeneralProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboGeneralProductType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnProductNameSearch);
            this.panel1.Controls.Add(this.txtboxProductTypeName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // btnProductNameSearch
            // 
            this.btnProductNameSearch.BackColor = System.Drawing.Color.DarkOrange;
            resources.ApplyResources(this.btnProductNameSearch, "btnProductNameSearch");
            this.btnProductNameSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductNameSearch.Name = "btnProductNameSearch";
            this.btnProductNameSearch.UseVisualStyleBackColor = false;
            this.btnProductNameSearch.Click += new System.EventHandler(this.btnProductNameSearch_Click);
            // 
            // txtboxProductTypeName
            // 
            resources.ApplyResources(this.txtboxProductTypeName, "txtboxProductTypeName");
            this.txtboxProductTypeName.Name = "txtboxProductTypeName";
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
            this.panel2.Controls.Add(this.btnDeleteProductType);
            this.panel2.Controls.Add(this.btnEditProductType);
            this.panel2.Controls.Add(this.btnAddProductType);
            this.panel2.Name = "panel2";
            // 
            // btnDeleteProductType
            // 
            resources.ApplyResources(this.btnDeleteProductType, "btnDeleteProductType");
            this.btnDeleteProductType.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteProductType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteProductType.Name = "btnDeleteProductType";
            this.btnDeleteProductType.UseVisualStyleBackColor = false;
            this.btnDeleteProductType.Click += new System.EventHandler(this.btnDeleteProductType_Click);
            // 
            // btnEditProductType
            // 
            resources.ApplyResources(this.btnEditProductType, "btnEditProductType");
            this.btnEditProductType.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditProductType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditProductType.Name = "btnEditProductType";
            this.btnEditProductType.UseVisualStyleBackColor = false;
            this.btnEditProductType.Click += new System.EventHandler(this.btnEditProductType_Click);
            // 
            // btnAddProductType
            // 
            resources.ApplyResources(this.btnAddProductType, "btnAddProductType");
            this.btnAddProductType.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddProductType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.UseVisualStyleBackColor = false;
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);
            // 
            // ProductsTypesDataGrid
            // 
            resources.ApplyResources(this.ProductsTypesDataGrid, "ProductsTypesDataGrid");
            this.ProductsTypesDataGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ProductsTypesDataGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.ProductsTypesDataGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ProductsTypesDataGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.ProductsTypesDataGrid.DisplayLayout.MaxRowScrollRegions = 1;
            this.ProductsTypesDataGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            this.ProductsTypesDataGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ProductsTypesDataGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ProductsTypesDataGrid.DisplayLayout.Override.CellPadding = 3;
            this.ProductsTypesDataGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ProductsTypesDataGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            this.ProductsTypesDataGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ProductsTypesDataGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ProductsTypesDataGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ProductsTypesDataGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ProductsTypesDataGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ProductsTypesDataGrid.Name = "ProductsTypesDataGrid";
            this.ProductsTypesDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.ProductsTypesDataGrid_CellChange);
            // 
            // comboGeneralProductType
            // 
            resources.ApplyResources(this.comboGeneralProductType, "comboGeneralProductType");
            this.comboGeneralProductType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            valueListItem1.DataValue = 0;
            resources.ApplyResources(valueListItem1, "valueListItem1");
            valueListItem1.ForceApplyResources = "";
            valueListItem2.DataValue = 1;
            resources.ApplyResources(valueListItem2, "valueListItem2");
            valueListItem2.ForceApplyResources = "";
            valueListItem3.DataValue = 2;
            resources.ApplyResources(valueListItem3, "valueListItem3");
            valueListItem3.ForceApplyResources = "";
            valueListItem4.DataValue = 3;
            resources.ApplyResources(valueListItem4, "valueListItem4");
            valueListItem4.ForceApplyResources = "";
            this.comboGeneralProductType.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2,
            valueListItem3,
            valueListItem4});
            this.comboGeneralProductType.Name = "comboGeneralProductType";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Name = "label7";
            // 
            // ProductTypesGrid
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductsTypesDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Name = "ProductTypesGrid";
            this.Resizable = false;
            this.ShowIcon = false;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductTypesGrid_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTypesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGeneralProductType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddProductType;
        private System.Windows.Forms.Button btnDeleteProductType;
        private System.Windows.Forms.Button btnEditProductType;
        private System.Windows.Forms.TextBox txtboxProductTypeName;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ProductsTypesDataGrid;
        private System.Windows.Forms.Button btnProductNameSearch;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor comboGeneralProductType;
        private System.Windows.Forms.Label label7;
    }
}