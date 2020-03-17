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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LANGCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CN_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EN_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VN_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENABLED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANGFUNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRONAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModify = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Pdf = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtgrw_ShipmentInfo = new System.Windows.Forms.DataGridView();
            this.SHIPMENT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARRIER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HAWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHIPMENT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_CheckSN = new System.Windows.Forms.Button();
            this.grdvw_SN_data = new System.Windows.Forms.DataGridView();
            this.txtShipment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrw_ShipmentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_SN_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(670, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(145, 56);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LANGCODE,
            this.CN_DESC,
            this.EN_DESC,
            this.VN_DESC,
            this.ENABLED,
            this.LANGFUNC,
            this.PRONAME});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(1, 695);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1442, 205);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LANGCODE
            // 
            this.LANGCODE.HeaderText = "LANGCODE";
            this.LANGCODE.MinimumWidth = 8;
            this.LANGCODE.Name = "LANGCODE";
            this.LANGCODE.Width = 150;
            // 
            // CN_DESC
            // 
            this.CN_DESC.HeaderText = "CN_DESC";
            this.CN_DESC.MinimumWidth = 8;
            this.CN_DESC.Name = "CN_DESC";
            this.CN_DESC.Width = 150;
            // 
            // EN_DESC
            // 
            this.EN_DESC.HeaderText = "EN_DESC";
            this.EN_DESC.MinimumWidth = 8;
            this.EN_DESC.Name = "EN_DESC";
            this.EN_DESC.Width = 150;
            // 
            // VN_DESC
            // 
            this.VN_DESC.HeaderText = "VN_DESC";
            this.VN_DESC.MinimumWidth = 8;
            this.VN_DESC.Name = "VN_DESC";
            this.VN_DESC.Width = 150;
            // 
            // ENABLED
            // 
            this.ENABLED.FillWeight = 50F;
            this.ENABLED.HeaderText = "ENABLED";
            this.ENABLED.MinimumWidth = 8;
            this.ENABLED.Name = "ENABLED";
            this.ENABLED.Width = 70;
            // 
            // LANGFUNC
            // 
            this.LANGFUNC.HeaderText = "LANGFUNC";
            this.LANGFUNC.MinimumWidth = 8;
            this.LANGFUNC.Name = "LANGFUNC";
            this.LANGFUNC.Width = 150;
            // 
            // PRONAME
            // 
            this.PRONAME.HeaderText = "PRONAME";
            this.PRONAME.MinimumWidth = 8;
            this.PRONAME.Name = "PRONAME";
            this.PRONAME.Width = 150;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(875, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(145, 53);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1123, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 28);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1016, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "LangCode";
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(1055, 12);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(109, 53);
            this.btn_Report.TabIndex = 5;
            this.btn_Report.Text = "Export Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Pdf
            // 
            this.btn_Pdf.Location = new System.Drawing.Point(1186, 14);
            this.btn_Pdf.Name = "btn_Pdf";
            this.btn_Pdf.Size = new System.Drawing.Size(109, 53);
            this.btn_Pdf.TabIndex = 5;
            this.btn_Pdf.Text = "Export PDF";
            this.btn_Pdf.UseVisualStyleBackColor = true;
            this.btn_Pdf.Click += new System.EventHandler(this.btn_Pdf_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(12, 12);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 28);
            this.dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(298, 12);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 28);
            this.dtpEnd.TabIndex = 6;
            // 
            // cmbShipment
            // 
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Location = new System.Drawing.Point(1, 97);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(200, 26);
            this.cmbShipment.TabIndex = 7;
            this.cmbShipment.SelectedValueChanged += new System.EventHandler(this.cmbShipment_SelectedValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(298, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
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
            this.dtgrw_ShipmentInfo.Location = new System.Drawing.Point(1, 167);
            this.dtgrw_ShipmentInfo.Name = "dtgrw_ShipmentInfo";
            this.dtgrw_ShipmentInfo.RowHeadersWidth = 62;
            this.dtgrw_ShipmentInfo.RowTemplate.Height = 30;
            this.dtgrw_ShipmentInfo.Size = new System.Drawing.Size(1442, 184);
            this.dtgrw_ShipmentInfo.TabIndex = 9;
            // 
            // SHIPMENT_ID
            // 
            this.SHIPMENT_ID.HeaderText = "SHIPMENT_ID";
            this.SHIPMENT_ID.MinimumWidth = 8;
            this.SHIPMENT_ID.Name = "SHIPMENT_ID";
            // 
            // CARRIER_NAME
            // 
            this.CARRIER_NAME.HeaderText = "CARRIER_NAME";
            this.CARRIER_NAME.MinimumWidth = 8;
            this.CARRIER_NAME.Name = "CARRIER_NAME";
            // 
            // POE
            // 
            this.POE.HeaderText = "POE";
            this.POE.MinimumWidth = 8;
            this.POE.Name = "POE";
            // 
            // HAWB
            // 
            this.HAWB.HeaderText = "HAWB";
            this.HAWB.MinimumWidth = 8;
            this.HAWB.Name = "HAWB";
            // 
            // SHIPMENT_TYPE
            // 
            this.SHIPMENT_TYPE.HeaderText = "SHIPMENT_TYPE";
            this.SHIPMENT_TYPE.MinimumWidth = 8;
            this.SHIPMENT_TYPE.Name = "SHIPMENT_TYPE";
            // 
            // REGION
            // 
            this.REGION.HeaderText = "REGION";
            this.REGION.MinimumWidth = 8;
            this.REGION.Name = "REGION";
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 8;
            this.QTY.Name = "QTY";
            // 
            // btn_CheckSN
            // 
            this.btn_CheckSN.Location = new System.Drawing.Point(1661, 546);
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
            this.grdvw_SN_data.Location = new System.Drawing.Point(1, 395);
            this.grdvw_SN_data.Name = "grdvw_SN_data";
            this.grdvw_SN_data.RowHeadersWidth = 62;
            this.grdvw_SN_data.RowTemplate.Height = 30;
            this.grdvw_SN_data.Size = new System.Drawing.Size(1442, 278);
            this.grdvw_SN_data.TabIndex = 11;
            // 
            // txtShipment
            // 
            this.txtShipment.Location = new System.Drawing.Point(1662, 460);
            this.txtShipment.Name = "txtShipment";
            this.txtShipment.Size = new System.Drawing.Size(144, 28);
            this.txtShipment.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1523, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shipment ID";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "W0",
            "W1",
            "W2",
            "W3",
            "W4"});
            this.cmbStatus.Location = new System.Drawing.Point(1662, 395);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(114, 26);
            this.cmbStatus.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1514, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Shipment Status";
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
            // 
            // PALLET_NO
            // 
            this.PALLET_NO.DataPropertyName = "PALLET_NO";
            this.PALLET_NO.HeaderText = "PALLET_NO";
            this.PALLET_NO.MinimumWidth = 8;
            this.PALLET_NO.Name = "PALLET_NO";
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
            // 
            // SSCC
            // 
            this.SSCC.DataPropertyName = "SSCC";
            this.SSCC.HeaderText = "SSCC";
            this.SSCC.MinimumWidth = 8;
            this.SSCC.Name = "SSCC";
            // 
            // PACK_PALLET_NO
            // 
            this.PACK_PALLET_NO.DataPropertyName = "PACK_PALLET_NO";
            this.PACK_PALLET_NO.HeaderText = "PACK_PALLET_NO";
            this.PACK_PALLET_NO.MinimumWidth = 8;
            this.PACK_PALLET_NO.Name = "PACK_PALLET_NO";
            // 
            // WC
            // 
            this.WC.DataPropertyName = "WC";
            this.WC.HeaderText = "WC";
            this.WC.MinimumWidth = 8;
            this.WC.Name = "WC";
            this.WC.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 912);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShipment);
            this.Controls.Add(this.grdvw_SN_data);
            this.Controls.Add(this.btn_CheckSN);
            this.Controls.Add(this.dtgrw_ShipmentInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbShipment);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btn_Pdf);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuery);
            this.Name = "Form1";
            this.Text = "My first App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrw_ShipmentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvw_SN_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANGCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CN_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EN_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VN_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENABLED;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANGFUNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRONAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Pdf;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtgrw_ShipmentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIPMENT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARRIER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HAWB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIPMENT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.Button btn_CheckSN;
        private System.Windows.Forms.DataGridView grdvw_SN_data;
        private System.Windows.Forms.TextBox txtShipment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
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
    }
}

