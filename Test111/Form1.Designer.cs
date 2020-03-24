namespace Test111
{
    partial class Form1
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtgrw_ShipmentInfo = new System.Windows.Forms.DataGridView();
            this.btn_CheckSN = new System.Windows.Forms.Button();
            this.grdvw_SN_data = new System.Windows.Forms.DataGridView();
            this.txtShipment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxbx_CartonNo = new System.Windows.Forms.RichTextBox();
            this.btn_CheckCarton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgrd_CartonInfo = new System.Windows.Forms.DataGridView();
            this.SHIPMENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARRIER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HAWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHIPMENT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARTON_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELIVERY_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHIPMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PALLET_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINE_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSIGN_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSIGN_CARTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICK_PALLET_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACK_PALLET_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrw_ShipmentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_SN_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_CartonInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(1372, 22);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 28);
            this.dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(1619, 22);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 28);
            this.dtpEnd.TabIndex = 6;
            // 
            // cmbShipment
            // 
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Location = new System.Drawing.Point(1413, 96);
            this.cmbShipment.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(174, 26);
            this.cmbShipment.TabIndex = 7;
            this.cmbShipment.SelectedValueChanged += new System.EventHandler(this.cmbShipment_SelectedValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1619, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(185, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Shiment Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtgrw_ShipmentInfo
            // 
            this.dtgrw_ShipmentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrw_ShipmentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHIPMENT_ID,
            this.CARRIER_NAME,
            this.POE,
            this.HAWB,
            this.SHIPMENT_TYPE,
            this.REGION,
            this.QTY});
            this.dtgrw_ShipmentInfo.Location = new System.Drawing.Point(10, 22);
            this.dtgrw_ShipmentInfo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgrw_ShipmentInfo.Name = "dtgrw_ShipmentInfo";
            this.dtgrw_ShipmentInfo.RowHeadersWidth = 62;
            this.dtgrw_ShipmentInfo.RowTemplate.Height = 30;
            this.dtgrw_ShipmentInfo.Size = new System.Drawing.Size(1232, 204);
            this.dtgrw_ShipmentInfo.TabIndex = 9;
            // 
            // btn_CheckSN
            // 
            this.btn_CheckSN.Location = new System.Drawing.Point(1660, 404);
            this.btn_CheckSN.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_CheckSN.Name = "btn_CheckSN";
            this.btn_CheckSN.Size = new System.Drawing.Size(145, 40);
            this.btn_CheckSN.TabIndex = 10;
            this.btn_CheckSN.Text = "Check SN";
            this.btn_CheckSN.UseVisualStyleBackColor = true;
            this.btn_CheckSN.Click += new System.EventHandler(this.btn_CheckSN_Click);
            // 
            // grdvw_SN_data
            // 
            this.grdvw_SN_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvw_SN_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CARTON_NO,
            this.PART_NO,
            this.DELIVERY_NO,
            this.SHIPMENT,
            this.PALLET_NO,
            this.LINE_ITEM,
            this.ASSIGN_QTY,
            this.ASSIGN_CARTON,
            this.COO,
            this.PICK_PALLET_NO,
            this.SSCC,
            this.PACK_PALLET_NO,
            this.WC});
            this.grdvw_SN_data.Location = new System.Drawing.Point(10, 248);
            this.grdvw_SN_data.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grdvw_SN_data.Name = "grdvw_SN_data";
            this.grdvw_SN_data.RowHeadersWidth = 62;
            this.grdvw_SN_data.RowTemplate.Height = 30;
            this.grdvw_SN_data.Size = new System.Drawing.Size(1478, 343);
            this.grdvw_SN_data.TabIndex = 11;
            // 
            // txtShipment
            // 
            this.txtShipment.Location = new System.Drawing.Point(1660, 329);
            this.txtShipment.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtShipment.Name = "txtShipment";
            this.txtShipment.Size = new System.Drawing.Size(144, 28);
            this.txtShipment.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1531, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shipment ID";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "W0";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "W1",
            "W2",
            "W3",
            "W4",
            "W5"});
            this.cmbStatus.Location = new System.Drawing.Point(1676, 262);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(114, 26);
            this.cmbStatus.TabIndex = 14;
            this.cmbStatus.Text = "W0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1528, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Shipment Status";
            // 
            // rtxbx_CartonNo
            // 
            this.rtxbx_CartonNo.Location = new System.Drawing.Point(1531, 692);
            this.rtxbx_CartonNo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rtxbx_CartonNo.Name = "rtxbx_CartonNo";
            this.rtxbx_CartonNo.Size = new System.Drawing.Size(218, 176);
            this.rtxbx_CartonNo.TabIndex = 15;
            this.rtxbx_CartonNo.Text = "";
            // 
            // btn_CheckCarton
            // 
            this.btn_CheckCarton.Location = new System.Drawing.Point(1531, 892);
            this.btn_CheckCarton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_CheckCarton.Name = "btn_CheckCarton";
            this.btn_CheckCarton.Size = new System.Drawing.Size(180, 46);
            this.btn_CheckCarton.TabIndex = 16;
            this.btn_CheckCarton.Text = "Check carton Info";
            this.btn_CheckCarton.UseVisualStyleBackColor = true;
            this.btn_CheckCarton.Click += new System.EventHandler(this.btn_CheckCarton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1525, 653);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Input carton No in below";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1313, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1584, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1322, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Shipment";
            // 
            // dtgrd_CartonInfo
            // 
            this.dtgrd_CartonInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_CartonInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dtgrd_CartonInfo.Location = new System.Drawing.Point(10, 644);
            this.dtgrd_CartonInfo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtgrd_CartonInfo.Name = "dtgrd_CartonInfo";
            this.dtgrd_CartonInfo.RowHeadersWidth = 62;
            this.dtgrd_CartonInfo.RowTemplate.Height = 30;
            this.dtgrd_CartonInfo.Size = new System.Drawing.Size(1478, 349);
            this.dtgrd_CartonInfo.TabIndex = 11;
            // 
            // SHIPMENT_ID
            // 
            this.SHIPMENT_ID.DataPropertyName = "SHIPMENT_ID";
            this.SHIPMENT_ID.HeaderText = "SHIPMENT_ID";
            this.SHIPMENT_ID.MinimumWidth = 8;
            this.SHIPMENT_ID.Name = "SHIPMENT_ID";
            this.SHIPMENT_ID.Width = 120;
            // 
            // CARRIER_NAME
            // 
            this.CARRIER_NAME.DataPropertyName = "CARRIER_NAME";
            this.CARRIER_NAME.HeaderText = "CARRIER_NAME";
            this.CARRIER_NAME.MinimumWidth = 8;
            this.CARRIER_NAME.Name = "CARRIER_NAME";
            this.CARRIER_NAME.Width = 120;
            // 
            // POE
            // 
            this.POE.DataPropertyName = "POE";
            this.POE.HeaderText = "POE";
            this.POE.MinimumWidth = 8;
            this.POE.Name = "POE";
            // 
            // HAWB
            // 
            this.HAWB.DataPropertyName = "HAWB";
            this.HAWB.HeaderText = "HAWB";
            this.HAWB.MinimumWidth = 8;
            this.HAWB.Name = "HAWB";
            // 
            // SHIPMENT_TYPE
            // 
            this.SHIPMENT_TYPE.DataPropertyName = "SHIPMENT_TYPE";
            this.SHIPMENT_TYPE.HeaderText = "SHIPMENT_TYPE";
            this.SHIPMENT_TYPE.MinimumWidth = 8;
            this.SHIPMENT_TYPE.Name = "SHIPMENT_TYPE";
            this.SHIPMENT_TYPE.Width = 120;
            // 
            // REGION
            // 
            this.REGION.DataPropertyName = "REGION";
            this.REGION.HeaderText = "REGION";
            this.REGION.MinimumWidth = 8;
            this.REGION.Name = "REGION";
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "Quantity";
            this.QTY.MinimumWidth = 8;
            this.QTY.Name = "QTY";
            this.QTY.Width = 120;
            // 
            // CARTON_NO
            // 
            this.CARTON_NO.DataPropertyName = "CARTON_NO";
            this.CARTON_NO.HeaderText = "CARTON_NO";
            this.CARTON_NO.MinimumWidth = 8;
            this.CARTON_NO.Name = "CARTON_NO";
            this.CARTON_NO.Width = 120;
            // 
            // PART_NO
            // 
            this.PART_NO.DataPropertyName = "PART_NO";
            this.PART_NO.HeaderText = "PART_NO";
            this.PART_NO.MinimumWidth = 8;
            this.PART_NO.Name = "PART_NO";
            this.PART_NO.Width = 120;
            // 
            // DELIVERY_NO
            // 
            this.DELIVERY_NO.DataPropertyName = "DELIVERY_NO";
            this.DELIVERY_NO.HeaderText = "DELIVERY_NO";
            this.DELIVERY_NO.MinimumWidth = 8;
            this.DELIVERY_NO.Name = "DELIVERY_NO";
            // 
            // SHIPMENT
            // 
            this.SHIPMENT.DataPropertyName = "SHIPMENT";
            this.SHIPMENT.HeaderText = "SHIPMENT";
            this.SHIPMENT.MinimumWidth = 8;
            this.SHIPMENT.Name = "SHIPMENT";
            this.SHIPMENT.Width = 120;
            // 
            // PALLET_NO
            // 
            this.PALLET_NO.DataPropertyName = "PALLET_NO";
            this.PALLET_NO.HeaderText = "PALLET_NO";
            this.PALLET_NO.MinimumWidth = 8;
            this.PALLET_NO.Name = "PALLET_NO";
            this.PALLET_NO.Width = 120;
            // 
            // LINE_ITEM
            // 
            this.LINE_ITEM.DataPropertyName = "LINE_ITEM";
            this.LINE_ITEM.HeaderText = "LINE_ITEM";
            this.LINE_ITEM.MinimumWidth = 8;
            this.LINE_ITEM.Name = "LINE_ITEM";
            this.LINE_ITEM.Width = 80;
            // 
            // ASSIGN_QTY
            // 
            this.ASSIGN_QTY.DataPropertyName = "ASSIGN_QTY";
            this.ASSIGN_QTY.HeaderText = "ASSIGN_QTY";
            this.ASSIGN_QTY.MinimumWidth = 8;
            this.ASSIGN_QTY.Name = "ASSIGN_QTY";
            this.ASSIGN_QTY.Width = 50;
            // 
            // ASSIGN_CARTON
            // 
            this.ASSIGN_CARTON.DataPropertyName = "ASSIGN_CARTON";
            this.ASSIGN_CARTON.HeaderText = "ASSIGN_CARTON";
            this.ASSIGN_CARTON.MinimumWidth = 8;
            this.ASSIGN_CARTON.Name = "ASSIGN_CARTON";
            this.ASSIGN_CARTON.Width = 50;
            // 
            // COO
            // 
            this.COO.DataPropertyName = "COO";
            this.COO.HeaderText = "COO";
            this.COO.MinimumWidth = 8;
            this.COO.Name = "COO";
            this.COO.Width = 50;
            // 
            // PICK_PALLET_NO
            // 
            this.PICK_PALLET_NO.DataPropertyName = "PICK_PALLET_NO";
            this.PICK_PALLET_NO.HeaderText = "PICK_PALLET_NO";
            this.PICK_PALLET_NO.MinimumWidth = 8;
            this.PICK_PALLET_NO.Name = "PICK_PALLET_NO";
            this.PICK_PALLET_NO.Width = 120;
            // 
            // SSCC
            // 
            this.SSCC.DataPropertyName = "SSCC";
            this.SSCC.HeaderText = "SSCC";
            this.SSCC.MinimumWidth = 8;
            this.SSCC.Name = "SSCC";
            this.SSCC.Width = 120;
            // 
            // PACK_PALLET_NO
            // 
            this.PACK_PALLET_NO.DataPropertyName = "PACK_PALLET_NO";
            this.PACK_PALLET_NO.HeaderText = "PACK_PALLET_NO";
            this.PACK_PALLET_NO.MinimumWidth = 8;
            this.PACK_PALLET_NO.Name = "PACK_PALLET_NO";
            this.PACK_PALLET_NO.Width = 120;
            // 
            // WC
            // 
            this.WC.DataPropertyName = "WC";
            this.WC.HeaderText = "WC";
            this.WC.MinimumWidth = 8;
            this.WC.Name = "WC";
            this.WC.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CARTON_NO";
            this.dataGridViewTextBoxColumn1.HeaderText = "CARTON_NO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PART_NO";
            this.dataGridViewTextBoxColumn2.HeaderText = "PART_NO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DELIVERY_NO";
            this.dataGridViewTextBoxColumn3.HeaderText = "DELIVERY_NO";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SHIPMENT";
            this.dataGridViewTextBoxColumn4.HeaderText = "SHIPMENT";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PALLET_NO";
            this.dataGridViewTextBoxColumn5.HeaderText = "PALLET_NO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LINE_ITEM";
            this.dataGridViewTextBoxColumn6.HeaderText = "LINE_ITEM";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ASSIGN_QTY";
            this.dataGridViewTextBoxColumn7.HeaderText = "ASSIGN_QTY";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ASSIGN_CARTON";
            this.dataGridViewTextBoxColumn8.HeaderText = "ASSIGN_CARTON";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "COO";
            this.dataGridViewTextBoxColumn9.HeaderText = "COO";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PICK_PALLET_NO";
            this.dataGridViewTextBoxColumn10.HeaderText = "PICK_PALLET_NO";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SSCC";
            this.dataGridViewTextBoxColumn11.HeaderText = "SSCC";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PACK_PALLET_NO";
            this.dataGridViewTextBoxColumn12.HeaderText = "PACK_PALLET_NO";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "WC";
            this.dataGridViewTextBoxColumn13.HeaderText = "WC";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1758, 822);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CheckCarton);
            this.Controls.Add(this.rtxbx_CartonNo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShipment);
            this.Controls.Add(this.dtgrd_CartonInfo);
            this.Controls.Add(this.grdvw_SN_data);
            this.Controls.Add(this.btn_CheckSN);
            this.Controls.Add(this.dtgrw_ShipmentInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbShipment);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "My first App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrw_ShipmentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_SN_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_CartonInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtgrw_ShipmentInfo;
        private System.Windows.Forms.Button btn_CheckSN;
        private System.Windows.Forms.DataGridView grdvw_SN_data;
        private System.Windows.Forms.TextBox txtShipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxbx_CartonNo;
        private System.Windows.Forms.Button btn_CheckCarton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgrd_CartonInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIPMENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARRIER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HAWB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIPMENT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARTON_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PART_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELIVERY_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIPMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PALLET_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINE_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSIGN_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSIGN_CARTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn COO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICK_PALLET_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACK_PALLET_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}

