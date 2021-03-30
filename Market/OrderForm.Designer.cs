
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;

namespace Market
{
    partial class OrderForm
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
            Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
            Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalLable = new System.Windows.Forms.Label();
            this.comboClient = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.clientLable = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.checkBoxIsDelivery = new System.Windows.Forms.CheckBox();
            this.Total = new System.Windows.Forms.Label();
            this.txtboxOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrderDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderDetailsDataGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LableAvailableQuantity = new System.Windows.Forms.Label();
            this.AvailableQuantity = new System.Windows.Forms.Label();
            this.comboGeneralProductType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.comboProductType = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.lableSellPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboGeneralProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TotalLable);
            this.panel1.Controls.Add(this.comboClient);
            this.panel1.Controls.Add(this.btnAddClient);
            this.panel1.Controls.Add(this.clientLable);
            this.panel1.Controls.Add(this.btnSaveOrder);
            this.panel1.Controls.Add(this.checkBoxIsDelivery);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.txtboxOrderNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 234);
            this.panel1.TabIndex = 0;
            // 
            // TotalLable
            // 
            this.TotalLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLable.AutoSize = true;
            this.TotalLable.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLable.ForeColor = System.Drawing.Color.Gold;
            this.TotalLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TotalLable.Location = new System.Drawing.Point(987, 174);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalLable.Size = new System.Drawing.Size(64, 45);
            this.TotalLable.TabIndex = 33;
            this.TotalLable.Text = "----";
            // 
            // comboClient
            // 
            this.comboClient.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.None;
            this.comboClient.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboClient.Location = new System.Drawing.Point(302, 90);
            this.comboClient.Name = "comboClient";
            this.comboClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboClient.Size = new System.Drawing.Size(281, 44);
            this.comboClient.TabIndex = 27;
            this.comboClient.TextChanged += new System.EventHandler(this.comboClient_TextChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddClient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddClient.Location = new System.Drawing.Point(39, 90);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(156, 44);
            this.btnAddClient.TabIndex = 26;
            this.btnAddClient.Text = "اضافه عميل";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // clientLable
            // 
            this.clientLable.AutoSize = true;
            this.clientLable.Font = new System.Drawing.Font("Cairo", 18F);
            this.clientLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientLable.Location = new System.Drawing.Point(589, 78);
            this.clientLable.Name = "clientLable";
            this.clientLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientLable.Size = new System.Drawing.Size(125, 56);
            this.clientLable.TabIndex = 24;
            this.clientLable.Text = "العميل :";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSaveOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveOrder.Location = new System.Drawing.Point(39, 171);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(156, 44);
            this.btnSaveOrder.TabIndex = 23;
            this.btnSaveOrder.Text = "حفظ";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // checkBoxIsDelivery
            // 
            this.checkBoxIsDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsDelivery.AutoSize = true;
            this.checkBoxIsDelivery.Font = new System.Drawing.Font("Cairo", 12F);
            this.checkBoxIsDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxIsDelivery.Location = new System.Drawing.Point(943, 90);
            this.checkBoxIsDelivery.Name = "checkBoxIsDelivery";
            this.checkBoxIsDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsDelivery.Size = new System.Drawing.Size(107, 41);
            this.checkBoxIsDelivery.TabIndex = 22;
            this.checkBoxIsDelivery.Text = "ديليفري";
            this.checkBoxIsDelivery.UseVisualStyleBackColor = true;
            this.checkBoxIsDelivery.CheckedChanged += new System.EventHandler(this.checkBoxIsDelivery_CheckedChanged);
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Cairo", 18F);
            this.Total.ForeColor = System.Drawing.Color.Gold;
            this.Total.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Total.Location = new System.Drawing.Point(1056, 165);
            this.Total.Name = "Total";
            this.Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total.Size = new System.Drawing.Size(145, 56);
            this.Total.TabIndex = 5;
            this.Total.Text = "الاجمالى :";
            // 
            // txtboxOrderNumber
            // 
            this.txtboxOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxOrderNumber.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxOrderNumber.Location = new System.Drawing.Point(759, 24);
            this.txtboxOrderNumber.Name = "txtboxOrderNumber";
            this.txtboxOrderNumber.Size = new System.Drawing.Size(291, 45);
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
            this.label1.Location = new System.Drawing.Point(1056, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(171, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الاوردر :";
            // 
            // btnAddOrderDetails
            // 
            this.btnAddOrderDetails.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrderDetails.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAddOrderDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddOrderDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddOrderDetails.Location = new System.Drawing.Point(39, 111);
            this.btnAddOrderDetails.Name = "btnAddOrderDetails";
            this.btnAddOrderDetails.Size = new System.Drawing.Size(156, 44);
            this.btnAddOrderDetails.TabIndex = 21;
            this.btnAddOrderDetails.Text = "اضافه";
            this.btnAddOrderDetails.UseVisualStyleBackColor = false;
            this.btnAddOrderDetails.Click += new System.EventHandler(this.btnAddOrderDetails_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1058, 99);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(121, 56);
            this.label3.TabIndex = 19;
            this.label3.Text = "الصنف :";
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.Font = new System.Drawing.Font("Cairo", 12F);
            this.txtboxQuantity.Location = new System.Drawing.Point(302, 111);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.Size = new System.Drawing.Size(281, 45);
            this.txtboxQuantity.TabIndex = 16;
            this.txtboxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 18F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(589, 100);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(125, 56);
            this.label4.TabIndex = 15;
            this.label4.Text = "الكميه :";
            // 
            // OrderDetailsDataGrid
            // 
            this.OrderDetailsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDetailsDataGrid.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.OrderDetailsDataGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.OrderDetailsDataGrid.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.OrderDetailsDataGrid.DisplayLayout.MaxColScrollRegions = 1;
            this.OrderDetailsDataGrid.DisplayLayout.MaxRowScrollRegions = 1;
            this.OrderDetailsDataGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            this.OrderDetailsDataGrid.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.OrderDetailsDataGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.OrderDetailsDataGrid.DisplayLayout.Override.CellPadding = 3;
            this.OrderDetailsDataGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.OrderDetailsDataGrid.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            this.OrderDetailsDataGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.OrderDetailsDataGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.OrderDetailsDataGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.OrderDetailsDataGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.OrderDetailsDataGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.OrderDetailsDataGrid.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.OrderDetailsDataGrid.Location = new System.Drawing.Point(21, 466);
            this.OrderDetailsDataGrid.Name = "OrderDetailsDataGrid";
            this.OrderDetailsDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderDetailsDataGrid.Size = new System.Drawing.Size(1004, 327);
            this.OrderDetailsDataGrid.TabIndex = 2;
            this.OrderDetailsDataGrid.Text = "ultraGrid1";
            this.OrderDetailsDataGrid.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.OrderDetailsDataGrid_CellChange);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleteOrderDetail);
            this.panel2.Location = new System.Drawing.Point(1031, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 327);
            this.panel2.TabIndex = 3;
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrderDetail.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrderDetail.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrderDetail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteOrderDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(18, 16);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(198, 52);
            this.btnDeleteOrderDetail.TabIndex = 2;
            this.btnDeleteOrderDetail.Text = "حذف";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = false;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lableSellPrice);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.LableAvailableQuantity);
            this.panel3.Controls.Add(this.AvailableQuantity);
            this.panel3.Controls.Add(this.comboGeneralProductType);
            this.panel3.Controls.Add(this.comboProductType);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtboxQuantity);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnAddOrderDetails);
            this.panel3.Location = new System.Drawing.Point(21, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 187);
            this.panel3.TabIndex = 4;
            // 
            // LableAvailableQuantity
            // 
            this.LableAvailableQuantity.AutoSize = true;
            this.LableAvailableQuantity.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableAvailableQuantity.ForeColor = System.Drawing.Color.Gold;
            this.LableAvailableQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LableAvailableQuantity.Location = new System.Drawing.Point(358, 65);
            this.LableAvailableQuantity.Name = "LableAvailableQuantity";
            this.LableAvailableQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LableAvailableQuantity.Size = new System.Drawing.Size(64, 45);
            this.LableAvailableQuantity.TabIndex = 32;
            this.LableAvailableQuantity.Text = "----";
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.AutoSize = true;
            this.AvailableQuantity.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantity.ForeColor = System.Drawing.Color.Gold;
            this.AvailableQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AvailableQuantity.Location = new System.Drawing.Point(420, 65);
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AvailableQuantity.Size = new System.Drawing.Size(178, 45);
            this.AvailableQuantity.TabIndex = 31;
            this.AvailableQuantity.Text = "الكميه المتاحه :";
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
            this.comboGeneralProductType.Location = new System.Drawing.Point(759, 32);
            this.comboGeneralProductType.Name = "comboGeneralProductType";
            this.comboGeneralProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboGeneralProductType.Size = new System.Drawing.Size(291, 44);
            this.comboGeneralProductType.TabIndex = 30;
            this.comboGeneralProductType.ValueChanged += new System.EventHandler(this.comboGeneralProductType_ValueChanged);
            // 
            // comboProductType
            // 
            this.comboProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboProductType.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            this.comboProductType.Font = new System.Drawing.Font("Cairo", 10.8F);
            this.comboProductType.Location = new System.Drawing.Point(759, 110);
            this.comboProductType.Name = "comboProductType";
            this.comboProductType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboProductType.Size = new System.Drawing.Size(291, 44);
            this.comboProductType.TabIndex = 29;
            this.comboProductType.ValueChanged += new System.EventHandler(this.comboProductType_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 18F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(1056, 21);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(98, 56);
            this.label7.TabIndex = 29;
            this.label7.Text = "النوع :";
            // 
            // lableSellPrice
            // 
            this.lableSellPrice.AutoSize = true;
            this.lableSellPrice.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableSellPrice.ForeColor = System.Drawing.Color.Gold;
            this.lableSellPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lableSellPrice.Location = new System.Drawing.Point(358, 30);
            this.lableSellPrice.Name = "lableSellPrice";
            this.lableSellPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lableSellPrice.Size = new System.Drawing.Size(64, 45);
            this.lableSellPrice.TabIndex = 34;
            this.lableSellPrice.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(420, 30);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(125, 45);
            this.label5.TabIndex = 33;
            this.label5.Text = "سعر البيع :";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1288, 804);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OrderDetailsDataGrid);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Cairo", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(18, 30, 18, 30);
            this.Resizable = false;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "الرئيسيه";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboGeneralProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProductType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxOrderNumber;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinGrid.UltraGrid OrderDetailsDataGrid;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddOrderDetails;
        private System.Windows.Forms.CheckBox checkBoxIsDelivery;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteOrderDetail;
        private System.Windows.Forms.Label clientLable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddClient;
        private UltraComboEditor comboClient;
        private UltraComboEditor comboProductType;
        private UltraComboEditor comboGeneralProductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AvailableQuantity;
        private System.Windows.Forms.Label LableAvailableQuantity;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.Label lableSellPrice;
        private System.Windows.Forms.Label label5;
    }
}