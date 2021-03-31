﻿
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;

namespace Market
{
    partial class OrderGrid
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
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            this.OrdersDataGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExtractData = new System.Windows.Forms.Button();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioWithoutDelivery = new System.Windows.Forms.RadioButton();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.TotalLable = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.DeliveryLable = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dateTimeTo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.dateTimeFrom = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.OrderSellLable = new System.Windows.Forms.Label();
            this.OrderSell = new System.Windows.Forms.Label();
            this.comboVillage = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGeneralProductType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.comboProductType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboClient = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.clientLable = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGeneralProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductType)).BeginInit();
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
            this.OrdersDataGrid.Location = new System.Drawing.Point(21, 330);
            this.OrdersDataGrid.Name = "OrdersDataGrid";
            this.OrdersDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrdersDataGrid.Size = new System.Drawing.Size(1378, 456);
            this.OrdersDataGrid.TabIndex = 2;
            this.OrdersDataGrid.Text = "ultraGrid1";
            this.OrdersDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.VillagesDataGrid_CellChange);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExtractData);
            this.panel1.Controls.Add(this.radioAll);
            this.panel1.Controls.Add(this.radioWithoutDelivery);
            this.panel1.Controls.Add(this.radioDelivery);
            this.panel1.Controls.Add(this.TotalLable);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.DeliveryLable);
            this.panel1.Controls.Add(this.delivery);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.dateTimeTo);
            this.panel1.Controls.Add(this.dateTimeFrom);
            this.panel1.Controls.Add(this.OrderSellLable);
            this.panel1.Controls.Add(this.OrderSell);
            this.panel1.Controls.Add(this.comboVillage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboGeneralProductType);
            this.panel1.Controls.Add(this.comboProductType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboClient);
            this.panel1.Controls.Add(this.clientLable);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtboxOrderNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 291);
            this.panel1.TabIndex = 0;
            // 
            // btnExtractData
            // 
            this.btnExtractData.BackColor = System.Drawing.Color.Crimson;
            this.btnExtractData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractData.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnExtractData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExtractData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtractData.Location = new System.Drawing.Point(38, 173);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(229, 45);
            this.btnExtractData.TabIndex = 57;
            this.btnExtractData.Text = "ارسال البيانات";
            this.btnExtractData.UseVisualStyleBackColor = false;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioAll.Location = new System.Drawing.Point(38, 96);
            this.radioAll.Name = "radioAll";
            this.radioAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioAll.Size = new System.Drawing.Size(67, 36);
            this.radioAll.TabIndex = 56;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "الكل";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioWithoutDelivery
            // 
            this.radioWithoutDelivery.AutoSize = true;
            this.radioWithoutDelivery.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWithoutDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioWithoutDelivery.Location = new System.Drawing.Point(150, 96);
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
            this.radioDelivery.Location = new System.Drawing.Point(313, 96);
            this.radioDelivery.Name = "radioDelivery";
            this.radioDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioDelivery.Size = new System.Drawing.Size(86, 36);
            this.radioDelivery.TabIndex = 54;
            this.radioDelivery.TabStop = true;
            this.radioDelivery.Text = "دليفري";
            this.radioDelivery.UseVisualStyleBackColor = true;
            // 
            // TotalLable
            // 
            this.TotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLable.AutoSize = true;
            this.TotalLable.Font = new System.Drawing.Font("Cairo", 13.8F);
            this.TotalLable.ForeColor = System.Drawing.Color.Gold;
            this.TotalLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TotalLable.Location = new System.Drawing.Point(410, 242);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLable.Size = new System.Drawing.Size(64, 45);
            this.TotalLable.TabIndex = 53;
            this.TotalLable.Text = "----";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Cairo", 18F);
            this.Total.ForeColor = System.Drawing.Color.Gold;
            this.Total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Total.Location = new System.Drawing.Point(480, 233);
            this.Total.Name = "Total";
            this.Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total.Size = new System.Drawing.Size(145, 56);
            this.Total.TabIndex = 52;
            this.Total.Text = "الاجمالى :";
            // 
            // DeliveryLable
            // 
            this.DeliveryLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryLable.AutoSize = true;
            this.DeliveryLable.Font = new System.Drawing.Font("Cairo", 13.8F);
            this.DeliveryLable.ForeColor = System.Drawing.Color.Gold;
            this.DeliveryLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeliveryLable.Location = new System.Drawing.Point(760, 242);
            this.DeliveryLable.Name = "DeliveryLable";
            this.DeliveryLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeliveryLable.Size = new System.Drawing.Size(64, 45);
            this.DeliveryLable.TabIndex = 51;
            this.DeliveryLable.Text = "----";
            // 
            // delivery
            // 
            this.delivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Cairo", 18F);
            this.delivery.ForeColor = System.Drawing.Color.Gold;
            this.delivery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.delivery.Location = new System.Drawing.Point(830, 233);
            this.delivery.Name = "delivery";
            this.delivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.delivery.Size = new System.Drawing.Size(138, 56);
            this.delivery.TabIndex = 50;
            this.delivery.Text = "ديليفري :";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDetails.Location = new System.Drawing.Point(150, 224);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(117, 45);
            this.btnDetails.TabIndex = 49;
            this.btnDetails.Text = "تفاصيل";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeTo.Font = new System.Drawing.Font("Cairo", 10.2F);
            this.dateTimeTo.FormatProvider = new System.Globalization.CultureInfo("ar-EG");
            this.dateTimeTo.Location = new System.Drawing.Point(493, 173);
            this.dateTimeTo.MaskInput = "{date} {time}";
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeTo.Size = new System.Drawing.Size(252, 41);
            this.dateTimeTo.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.dateTimeTo.TabIndex = 48;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeFrom.Font = new System.Drawing.Font("Cairo", 10.2F);
            this.dateTimeFrom.FormatProvider = new System.Globalization.CultureInfo("ar-EG");
            this.dateTimeFrom.Location = new System.Drawing.Point(953, 171);
            this.dateTimeFrom.MaskInput = "{date} {time}";
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeFrom.Size = new System.Drawing.Size(248, 41);
            this.dateTimeFrom.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left;
            this.dateTimeFrom.TabIndex = 47;
            // 
            // OrderSellLable
            // 
            this.OrderSellLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderSellLable.AutoSize = true;
            this.OrderSellLable.Font = new System.Drawing.Font("Cairo", 13.8F);
            this.OrderSellLable.ForeColor = System.Drawing.Color.Gold;
            this.OrderSellLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderSellLable.Location = new System.Drawing.Point(1082, 242);
            this.OrderSellLable.Name = "OrderSellLable";
            this.OrderSellLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderSellLable.Size = new System.Drawing.Size(64, 45);
            this.OrderSellLable.TabIndex = 45;
            this.OrderSellLable.Text = "----";
            // 
            // OrderSell
            // 
            this.OrderSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderSell.AutoSize = true;
            this.OrderSell.Font = new System.Drawing.Font("Cairo", 18F);
            this.OrderSell.ForeColor = System.Drawing.Color.Gold;
            this.OrderSell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderSell.Location = new System.Drawing.Point(1152, 233);
            this.OrderSell.Name = "OrderSell";
            this.OrderSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderSell.Size = new System.Drawing.Size(178, 56);
            this.OrderSell.TabIndex = 44;
            this.OrderSell.Text = "سعر الاوردر :";
            // 
            // comboVillage
            // 
            this.comboVillage.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            this.comboVillage.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboVillage.Location = new System.Drawing.Point(38, 12);
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
            this.label5.Location = new System.Drawing.Point(296, 5);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(113, 56);
            this.label5.TabIndex = 42;
            this.label5.Text = "القريه :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 18F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(751, 162);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(82, 56);
            this.label4.TabIndex = 40;
            this.label4.Text = "الى :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1209, 162);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 56);
            this.label2.TabIndex = 38;
            this.label2.Text = "من :";
            // 
            // comboGeneralProductType
            // 
            this.comboGeneralProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGeneralProductType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.comboGeneralProductType.Font = new System.Drawing.Font("Cairo", 10.8F);
            valueListItem1.DataValue = 0;
            valueListItem1.DisplayText = "الكل";
            valueListItem2.DataValue = 1;
            valueListItem2.DisplayText = "مأكولات";
            valueListItem3.DataValue = 2;
            valueListItem3.DisplayText = "مشروبات";
            valueListItem4.DataValue = 3;
            valueListItem4.DisplayText = "شيشه";
            this.comboGeneralProductType.Items.AddRange(new Infragistics.Win.ValueListItem[] {
            valueListItem1,
            valueListItem2,
            valueListItem3,
            valueListItem4});
            this.comboGeneralProductType.Location = new System.Drawing.Point(493, 14);
            this.comboGeneralProductType.Name = "comboGeneralProductType";
            this.comboGeneralProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboGeneralProductType.Size = new System.Drawing.Size(252, 44);
            this.comboGeneralProductType.TabIndex = 37;
            this.comboGeneralProductType.ValueChanged += new System.EventHandler(this.comboGeneralProductType_ValueChanged);
            // 
            // comboProductType
            // 
            this.comboProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboProductType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.comboProductType.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboProductType.Location = new System.Drawing.Point(953, 89);
            this.comboProductType.Name = "comboProductType";
            this.comboProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboProductType.Size = new System.Drawing.Size(248, 44);
            this.comboProductType.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 18F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(751, 4);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(98, 56);
            this.label7.TabIndex = 36;
            this.label7.Text = "النوع :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1209, 78);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(121, 56);
            this.label3.TabIndex = 31;
            this.label3.Text = "الصنف :";
            // 
            // comboClient
            // 
            this.comboClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboClient.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            this.comboClient.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboClient.Location = new System.Drawing.Point(493, 92);
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
            this.clientLable.Location = new System.Drawing.Point(751, 79);
            this.clientLable.Name = "clientLable";
            this.clientLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientLable.Size = new System.Drawing.Size(125, 56);
            this.clientLable.TabIndex = 33;
            this.clientLable.Text = "العميل :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(38, 224);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtboxOrderNumber
            // 
            this.txtboxOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxOrderNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxOrderNumber.Location = new System.Drawing.Point(952, 11);
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
            this.label1.Location = new System.Drawing.Point(1209, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(171, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الاوردر :";
            // 
            // OrderGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1420, 797);
            this.Controls.Add(this.OrdersDataGrid);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Cairo", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderGrid";
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
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGeneralProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.UltraWinGrid.UltraGrid OrdersDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetails;
        private UltraDateTimeEditor dateTimeTo;
        private UltraDateTimeEditor dateTimeFrom;
        private System.Windows.Forms.Label OrderSellLable;
        private System.Windows.Forms.Label OrderSell;
        private UltraComboEditor comboVillage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private UltraComboEditor comboGeneralProductType;
        private UltraComboEditor comboProductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private UltraComboEditor comboClient;
        private System.Windows.Forms.Label clientLable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label DeliveryLable;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioWithoutDelivery;
        private System.Windows.Forms.RadioButton radioDelivery;
        private System.Windows.Forms.Button btnExtractData;
        private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter ultraGridExcelExporter1;
    }
}