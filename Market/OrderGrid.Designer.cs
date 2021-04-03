
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
            this.deliveryPilotLable = new System.Windows.Forms.Label();
            this.deliveryPilot = new System.Windows.Forms.Label();
            this.btnExtractData = new System.Windows.Forms.Button();
            this.radioAllDeliveryNotDelivery = new System.Windows.Forms.RadioButton();
            this.radioWithoutDelivery = new System.Windows.Forms.RadioButton();
            this.radioDelivery = new System.Windows.Forms.RadioButton();
            this.TotalLable = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.DeliveryResturantLable = new System.Windows.Forms.Label();
            this.deliveryResturant = new System.Windows.Forms.Label();
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
            this.radioAllDelayedPaied = new System.Windows.Forms.RadioButton();
            this.radioPaied = new System.Windows.Forms.RadioButton();
            this.radioDelayed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVillage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGeneralProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.OrdersDataGrid.Size = new System.Drawing.Size(1344, 456);
            this.OrdersDataGrid.TabIndex = 2;
            this.OrdersDataGrid.Text = "ultraGrid1";
            this.OrdersDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.VillagesDataGrid_CellChange);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.deliveryPilotLable);
            this.panel1.Controls.Add(this.deliveryPilot);
            this.panel1.Controls.Add(this.btnExtractData);
            this.panel1.Controls.Add(this.TotalLable);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.DeliveryResturantLable);
            this.panel1.Controls.Add(this.deliveryResturant);
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
            this.panel1.Size = new System.Drawing.Size(1344, 291);
            this.panel1.TabIndex = 0;
            // 
            // deliveryPilotLable
            // 
            this.deliveryPilotLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryPilotLable.AutoSize = true;
            this.deliveryPilotLable.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryPilotLable.ForeColor = System.Drawing.Color.Gold;
            this.deliveryPilotLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deliveryPilotLable.Location = new System.Drawing.Point(508, 233);
            this.deliveryPilotLable.Name = "deliveryPilotLable";
            this.deliveryPilotLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deliveryPilotLable.Size = new System.Drawing.Size(59, 43);
            this.deliveryPilotLable.TabIndex = 59;
            this.deliveryPilotLable.Text = "----";
            // 
            // deliveryPilot
            // 
            this.deliveryPilot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryPilot.AutoSize = true;
            this.deliveryPilot.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryPilot.ForeColor = System.Drawing.Color.Gold;
            this.deliveryPilot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deliveryPilot.Location = new System.Drawing.Point(573, 233);
            this.deliveryPilot.Name = "deliveryPilot";
            this.deliveryPilot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deliveryPilot.Size = new System.Drawing.Size(165, 43);
            this.deliveryPilot.TabIndex = 58;
            this.deliveryPilot.Text = "ديليفري الطيار :";
            // 
            // btnExtractData
            // 
            this.btnExtractData.BackColor = System.Drawing.Color.Crimson;
            this.btnExtractData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractData.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnExtractData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExtractData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExtractData.Location = new System.Drawing.Point(12, 173);
            this.btnExtractData.Name = "btnExtractData";
            this.btnExtractData.Size = new System.Drawing.Size(229, 45);
            this.btnExtractData.TabIndex = 57;
            this.btnExtractData.Text = "ارسال البيانات";
            this.btnExtractData.UseVisualStyleBackColor = false;
            this.btnExtractData.Click += new System.EventHandler(this.btnExtractData_Click);
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
            // TotalLable
            // 
            this.TotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLable.AutoSize = true;
            this.TotalLable.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLable.ForeColor = System.Drawing.Color.Gold;
            this.TotalLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TotalLable.Location = new System.Drawing.Point(270, 233);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLable.Size = new System.Drawing.Size(59, 43);
            this.TotalLable.TabIndex = 53;
            this.TotalLable.Text = "----";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Gold;
            this.Total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Total.Location = new System.Drawing.Point(346, 233);
            this.Total.Name = "Total";
            this.Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total.Size = new System.Drawing.Size(111, 43);
            this.Total.TabIndex = 52;
            this.Total.Text = "الاجمالى :";
            // 
            // DeliveryResturantLable
            // 
            this.DeliveryResturantLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryResturantLable.AutoSize = true;
            this.DeliveryResturantLable.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryResturantLable.ForeColor = System.Drawing.Color.Gold;
            this.DeliveryResturantLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeliveryResturantLable.Location = new System.Drawing.Point(781, 233);
            this.DeliveryResturantLable.Name = "DeliveryResturantLable";
            this.DeliveryResturantLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DeliveryResturantLable.Size = new System.Drawing.Size(59, 43);
            this.DeliveryResturantLable.TabIndex = 51;
            this.DeliveryResturantLable.Text = "----";
            // 
            // deliveryResturant
            // 
            this.deliveryResturant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryResturant.AutoSize = true;
            this.deliveryResturant.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryResturant.ForeColor = System.Drawing.Color.Gold;
            this.deliveryResturant.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deliveryResturant.Location = new System.Drawing.Point(839, 233);
            this.deliveryResturant.Name = "deliveryResturant";
            this.deliveryResturant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deliveryResturant.Size = new System.Drawing.Size(187, 43);
            this.deliveryResturant.TabIndex = 50;
            this.deliveryResturant.Text = "ديليفري المطعم :";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDetails.Location = new System.Drawing.Point(124, 224);
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
            this.dateTimeTo.Location = new System.Drawing.Point(459, 173);
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
            this.dateTimeFrom.Location = new System.Drawing.Point(919, 171);
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
            this.OrderSellLable.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSellLable.ForeColor = System.Drawing.Color.Gold;
            this.OrderSellLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderSellLable.Location = new System.Drawing.Point(1079, 233);
            this.OrderSellLable.Name = "OrderSellLable";
            this.OrderSellLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderSellLable.Size = new System.Drawing.Size(59, 43);
            this.OrderSellLable.TabIndex = 45;
            this.OrderSellLable.Text = "----";
            // 
            // OrderSell
            // 
            this.OrderSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderSell.AutoSize = true;
            this.OrderSell.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSell.ForeColor = System.Drawing.Color.Gold;
            this.OrderSell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderSell.Location = new System.Drawing.Point(1154, 233);
            this.OrderSell.Name = "OrderSell";
            this.OrderSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderSell.Size = new System.Drawing.Size(185, 43);
            this.OrderSell.TabIndex = 44;
            this.OrderSell.Text = "اجمالى الاوردرات :";
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 18F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(717, 162);
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
            this.label2.Location = new System.Drawing.Point(1175, 162);
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
            this.comboGeneralProductType.Location = new System.Drawing.Point(459, 14);
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
            this.comboProductType.Location = new System.Drawing.Point(919, 89);
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
            this.label7.Location = new System.Drawing.Point(717, 4);
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
            this.label3.Location = new System.Drawing.Point(1175, 78);
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
            this.comboClient.Location = new System.Drawing.Point(459, 92);
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
            this.clientLable.Location = new System.Drawing.Point(717, 79);
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
            this.btnSearch.Location = new System.Drawing.Point(12, 224);
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
            // radioAllDelayedPaied
            // 
            this.radioAllDelayedPaied.AutoSize = true;
            this.radioAllDelayedPaied.Checked = true;
            this.radioAllDelayedPaied.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAllDelayedPaied.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioAllDelayedPaied.Location = new System.Drawing.Point(8, 14);
            this.radioAllDelayedPaied.Name = "radioAllDelayedPaied";
            this.radioAllDelayedPaied.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioAllDelayedPaied.Size = new System.Drawing.Size(67, 36);
            this.radioAllDelayedPaied.TabIndex = 62;
            this.radioAllDelayedPaied.TabStop = true;
            this.radioAllDelayedPaied.Text = "الكل";
            this.radioAllDelayedPaied.UseVisualStyleBackColor = true;
            // 
            // radioPaied
            // 
            this.radioPaied.AutoSize = true;
            this.radioPaied.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPaied.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioPaied.Location = new System.Drawing.Point(149, 14);
            this.radioPaied.Name = "radioPaied";
            this.radioPaied.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioPaied.Size = new System.Drawing.Size(85, 36);
            this.radioPaied.TabIndex = 61;
            this.radioPaied.TabStop = true;
            this.radioPaied.Text = "مدفوع";
            this.radioPaied.UseVisualStyleBackColor = true;
            // 
            // radioDelayed
            // 
            this.radioDelayed.AutoSize = true;
            this.radioDelayed.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDelayed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioDelayed.Location = new System.Drawing.Point(273, 14);
            this.radioDelayed.Name = "radioDelayed";
            this.radioDelayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioDelayed.Size = new System.Drawing.Size(77, 36);
            this.radioDelayed.TabIndex = 60;
            this.radioDelayed.TabStop = true;
            this.radioDelayed.Text = "مؤجل";
            this.radioDelayed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWithoutDelivery);
            this.groupBox1.Controls.Add(this.radioDelivery);
            this.groupBox1.Controls.Add(this.radioAllDeliveryNotDelivery);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 54);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioDelayed);
            this.groupBox2.Controls.Add(this.radioPaied);
            this.groupBox2.Controls.Add(this.radioAllDelayedPaied);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 54);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // OrderGrid
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label DeliveryResturantLable;
        private System.Windows.Forms.Label deliveryResturant;
        private System.Windows.Forms.RadioButton radioAllDeliveryNotDelivery;
        private System.Windows.Forms.RadioButton radioWithoutDelivery;
        private System.Windows.Forms.RadioButton radioDelivery;
        private System.Windows.Forms.Button btnExtractData;
        private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter ultraGridExcelExporter1;
        private System.Windows.Forms.Label deliveryPilotLable;
        private System.Windows.Forms.Label deliveryPilot;
        private System.Windows.Forms.RadioButton radioAllDelayedPaied;
        private System.Windows.Forms.RadioButton radioPaied;
        private System.Windows.Forms.RadioButton radioDelayed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}