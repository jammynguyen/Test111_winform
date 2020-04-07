using iTextSharp.text;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test111.Core;
using Test111.Entitys;
using Test111.Utils;

namespace Test111
{
    public partial class fMain : Form
    {
        private Controller controller;
        private bool isMix = false;
        private bool isCartonType = false;
        private CreateBarcodeForShippingLabel createBarcodes;
        private ShipmentInfo shipmentInfo;
        private double saveDays = 90;
        public static string Printer = "";
        public fMain()
        {
            InitializeComponent();
        }
        string tt = null;
        int rowtt = 0;
        string datefrom;
        string dateto;
        private void Form1_Load(object sender, EventArgs e)
        {
            ClientUtils.ServerUrl = "http://10.171.16.201:8090/WCF_RemoteObject";
            //ClientUtils.ServerUrl = string.Format("http://{0}:8090/WCF_RemoteObject", ConfigurationManager.AppSettings["AP"]);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = @"select * from PPSUSER.T_BASICLANGUAGE_INFO a where a.PRONAME = 'Weight' order by langcode asc";
            //DataTable dt = new DataTable();
            object[][] sqlparams = new object[0][];
            DataSet dbs = ClientUtils.ExecuteSQL(sql, sqlparams);
            DataTable dt2 = dbs.Tables[0];
            if (dt2.Rows.Count > 0)
            {
                tt = dtgrd_CartonInfo.CurrentCell.RowIndex.ToString();
                rowtt = int.Parse(tt);
                //textBox1.Text = dt2.Rows[rowtt]["LANGCODE"].ToString();

            }
            //else
            //{
            //    ShowDialog("no information on datagridview");
            //}

            //dt2.Rows[rowtt]["LANGCODE"].ToString();
        }

        //private void btn_Report_Click(object sender, EventArgs e)
        //{
        //    string sql = @"select * from PPSUSER.T_BASICLANGUAGE_INFO a where a.langcode = 'E0179' order by langcode asc";
        //    //DataTable dt = new DataTable();
        //    object[][] sqlparams = new object[0][];
        //    DataSet dbs = ClientUtils.ExecuteSQL(sql, sqlparams);
        //    DataTable dt2 = dbs.Tables[0];
        //    if (dt2.Rows.Count > 0)
        //    {
        //        for (int i= 0; i < dt2.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < dt2.Columns.Count; j++)
        //            {
        //                string data = dt2.Rows[i][j].ToString();
        //                var filepath = @"D:\temp\test.csv";
        //                using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
        //                    FileMode.Create, FileAccess.Write)))
        //                {
        //                    writer.WriteLine("sep=,");
        //                    writer.WriteLine("Hello, Goodbye");
        //                }
        //                File.WriteAllText(filepath, data);
        //            }
        //        }
        //    }
        //    // Prepare the values
        //    //using (var w = new StreamWriter("D:\temp.test.cvs"))

        //}
        //csvFileWriter = StreamWriter
        //scannerDataGridView = DataGridView   

        private void btn_Report_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {

        }


        public void GenerarDocumento(Document document)
        {

            //se crea un objeto PdfTable con el # de columnas del dataGridView


            PdfPTable datatable = new PdfPTable(dtgrd_CartonInfo.ColumnCount);


            //asignamos algunas propiedades para el diseño del pdf

            datatable.DefaultCell.Padding = 3;

            float[] headerwidths = GetSizeOfColumn(dtgrd_CartonInfo);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF

            for (int i = 0; i < dtgrd_CartonInfo.ColumnCount; i++)

            {

                datatable.AddCell(dtgrd_CartonInfo.Columns[i].HeaderText);

            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF

            for (int i = 0; i < dtgrd_CartonInfo.RowCount; i++)

            {

                for (int j = 0; j < dtgrd_CartonInfo.ColumnCount; j++)

                {

                    datatable.AddCell(dtgrd_CartonInfo[j, i].Value.ToString());

                }

                datatable.CompleteRow();

            }

            //Add PdfTable to the doc


            document.Add(datatable);


        }
        public float[] GetSizeOfColumn(DataGridView dg)

        {

            float[] values = new float[dg.ColumnCount];

            for (int i = 0; i < dg.ColumnCount; i++)

            {

                values[i] = (float)dg.Columns[i].Width;

            }

            return values;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgrw_ShipmentInfo.DataSource = null;
            datefrom= dtpStart.Value.ToString("yyyy/MM/dd")+" 00:00:00";
            dateto = dtpEnd.Value.ToString("yyyy/MM/dd") + " 23:59:59";
            object[][] param = new object[2][];
            //DataTable dt = new DataTable();
            string sql = @"select SHIPMENT_ID,CARRIER_NAME,POE,HAWB,SHIPMENT_TYPE,REGION,QTY from t_shipment_info where cdt between to_date(:datefrom,'YYYY/MM/DD HH24:MI:SS') and to_date(:dateto,'YYYY/MM/DD HH24:MI:SS')";
            if (dtpEnd.Value.Date < dtpStart.Value.Date)
            {
                MessageBox.Show("The start time cannot greater than the end time, pls fix again");
            }
            else
            {
                param[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "datefrom", datefrom };
                param[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "dateto", dateto };
                DataTable dt = ClientUtils.ExecuteSQL(sql, param).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dtgrw_ShipmentInfo.DataSource = dt;
                    cmbShipment.Text = dt.Rows[0]["SHIPMENT_ID"].ToString();
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        //DataGridViewRow dr = new DataGridViewRow();
                        cmbShipment.Items.Add(dt.Rows[i]["SHIPMENT_ID"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No shipment Found");
                }
                
            }
          
            //DataTable dt = dts.Tables[0];

            //if (dt.Rows.Count > 0)
            //{
            //    for(int i=0;i<dt.Rows.Count;i++)
            //    { 
            //    cmbShipment.Text = dt.Rows[0]["shipment_id"].ToString();
            //    DataGridViewRow dr = new DataGridViewRow();
            //    foreach (DataGridViewColumn c in dtgrd_CartonInfo.Columns)
            //    {
            //        dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
            //    }
            //    //累加序号
            //    //dr.HeaderCell.Value = (i + 1).ToString();
            //    dr.Cells[0].Value = dt.Rows[i]["SHIPMENT_ID"].ToString();
            //    dr.Cells[1].Value = dt.Rows[i]["CARRIER_NAME"].ToString();
            //    dr.Cells[2].Value = dt.Rows[i]["POE"].ToString();
            //    dr.Cells[3].Value = dt.Rows[i]["HAWB"].ToString();
            //    dr.Cells[4].Value = dt.Rows[i]["SHIPMENT_TYPE"].ToString();
            //    //dr.Cells[5].Value = Convert.ToDateTime(db.Rows[i]["CDT"]).ToString("yyyy/MM/dd");
            //    dr.Cells[5].Value = dt.Rows[i]["REGION"].ToString();
            //    dr.Cells[6].Value = dt.Rows[i]["QTY"].ToString();
            //    //dr.Cells[7].Value = dt.Rows[0]["CARTON_QTY"].ToString();
            //    //cmbShipment.Items.Add(dt.Rows[i]["shipment_id"].ToString());
            //    try
            //    {
            //            dtgrw_ShipmentInfo.Invoke((MethodInvoker)delegate ()
            //            {
            //                dtgrw_ShipmentInfo.Rows.Add(dr);
            //            });
            //        }
            //    catch (Exception e1)
            //    {
            //        MessageBox.Show(e1.Message);
            //        return;
            //    }

            //    }
            //}

        }

        private void cmbShipment_SelectedValueChanged(object sender, EventArgs e)
        {

            dtgrw_ShipmentInfo.DataSource = null;
            dtgrw_ShipmentInfo.Rows.Clear();
            string strShipment = null;
            string strSql = @"select SHIPMENT_ID,CARRIER_NAME,POE,HAWB,SHIPMENT_TYPE,REGION,QTY from t_shipment_info where shipment_id=:shipment_id";

            object[][] strpara = new object[1][];
            if (!string.IsNullOrEmpty(cmbShipment.Text.Trim()))
            {
                strShipment = cmbShipment.Text.Trim();
                strpara[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "shipment_id", strShipment };

                DataTable dt = ClientUtils.ExecuteSQL(strSql, strpara).Tables[0];

                dtgrw_ShipmentInfo.DataSource = dt;
                //DataGridViewRow dr = new DataGridViewRow();
                //foreach (DataGridViewColumn c in dtgrd_CartonInfo.Columns)
                //{
                //    dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                //}
                ////累加序号
                ////dr.HeaderCell.Value = (i + 1).ToString();
                //dr.Cells[0].Value = dt.Rows[0]["SHIPMENT_ID"].ToString();
                //dr.Cells[1].Value = dt.Rows[0]["CARRIER_NAME"].ToString();
                //dr.Cells[2].Value = dt.Rows[0]["POE"].ToString();
                //dr.Cells[3].Value = dt.Rows[0]["HAWB"].ToString();
                //dr.Cells[4].Value = dt.Rows[0]["SHIPMENT_TYPE"].ToString();
                ////dr.Cells[5].Value = Convert.ToDateTime(db.Rows[i]["CDT"]).ToString("yyyy/MM/dd");
                //dr.Cells[5].Value = dt.Rows[0]["REGION"].ToString();
                //dr.Cells[6].Value = dt.Rows[0]["QTY"].ToString();
                ////dr.Cells[7].Value = dt.Rows[0]["CARTON_QTY"].ToString();
                //try
                //{
                //    dtgrw_ShipmentInfo.Invoke((MethodInvoker)delegate ()
                //    {
                //        dtgrw_ShipmentInfo.Rows.Add(dr);
                //    });
                //}
                //catch (Exception e1)
                //{
                //    MessageBox.Show(e1.Message);
                //    return;
                //}

            }
        }

        private void btn_CheckSN_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbStatus.Text.Trim()))
            {
                MessageBox.Show("Pls select Shipment Status first");
            }
            else if(string.IsNullOrEmpty(txtShipment.Text.Trim()))
            {
                MessageBox.Show("Pls Input Shipment ID");
            }
            else 
            {
                if(cmbStatus.Text.Trim()=="ALL")
                {
                    check_all(txtShipment.Text.Trim());
                }
                else
                {
                    grdvw_SN_data.DataSource = null;
                    DAO inx = new DAO();
                    string strinsert = inx.insertData(txtShipment.Text.Trim(), cmbStatus.Text.Trim(), "");
                    //MessageBox.Show("execution OK...");
                    //grdvw_SN_data.Rows.Clear();

                    string sql = @"select carton_no,
                           shipment,
                           part_no,
                           pick_pallet_no,
                           sscc,
                           pack_pallet_no,
                           TRACKING_NO,
                           BABYTRACKING_NO,
                           location_no,
                           delivery_no,
                           pallet_no,
                           COO,
                           wc from PPS_OPERATE_DATA_TOTAL where shipment=:shipment and wc=:wc order by pallet_no";
                    object[][] param1 = new object[2][];
                    param1[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "shipment", txtShipment.Text.Trim() };
                    param1[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "wc", cmbStatus.Text.Trim() };
                    DataTable dt2 = ClientUtils.ExecuteSQL(sql, param1).Tables[0]; 
                    if (dt2.Rows.Count > 0)
                    {
                        grdvw_SN_data.DataSource = dt2;
                    }
                    else
                    {
                        MessageBox.Show("No data found");
                    }
                }

            }

        }

        private void btn_CheckCarton_Click(object sender, EventArgs e)
        {
            //grdvw_SN_data.Rows.Clear();
            string strsql = @" SELECT DISTINCT a.carton_no,
                        a.part_no,
                        b.delivery_no,
                        b.shipment_id,
                        d.pallet_no,
                        D.LINE_ITEM,
                        D.ASSIGN_QTY,
                        D.ASSIGN_CARTON,
                        D.COO,
                        a.pick_pallet_no,
                        a.sscc,
                                        a.pack_pallet_no,
                                         a.wc
                          FROM t_sn_status a
                               INNER JOIN t_order_info b ON a.part_no = b.ictpn and a.delivery_no=b.delivery_no
                               --inner join t_trolley_sn_status c
                               --on b.delivery_no=c.delivery_no
                               INNER JOIN t_pallet_order d ON b.shipment_id = d.shipment_id and b.ictpn=d.ictpn
                               INNER JOIN t_shipment_pallet e
                                  ON d.pallet_no = e.pallet_no AND A.coo = d.coo
                         WHERE a.carton_no=:carton_no
                         ORDER BY a.carton_no";
            object[][] prama = new object[1][];
            
            if (rtxbx_CartonNo.Lines.Count()>0)
            {
                var lines= rtxbx_CartonNo.Text.Split(new[] { '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);
                foreach(var line in lines)
                {
                    prama[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "carton_no", line };
                    DataTable dt = ClientUtils.ExecuteSQL(strsql, prama).Tables[0];
                    //grdvw_SN_data.DataSource = dt;
                    if(dt.Rows.Count>0)
                    {
                        DataGridViewRow dr = new DataGridViewRow();
                        foreach (DataGridViewColumn c in dtgrd_CartonInfo.Columns)
                        {
                            dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                        }
                        dr.Cells[0].Value = dt.Rows[0]["CARTON_NO"].ToString();
                        dr.Cells[1].Value = dt.Rows[0]["part_no"].ToString();
                        dr.Cells[2].Value = dt.Rows[0]["delivery_no"].ToString();
                        dr.Cells[3].Value = dt.Rows[0]["shipment_id"].ToString();
                        dr.Cells[4].Value = dt.Rows[0]["pallet_no"].ToString();
                        dr.Cells[5].Value = dt.Rows[0]["LINE_ITEM"].ToString();
                        dr.Cells[6].Value = dt.Rows[0]["ASSIGN_QTY"].ToString();
                        dr.Cells[7].Value = dt.Rows[0]["ASSIGN_CARTON"].ToString();
                        dr.Cells[8].Value = dt.Rows[0]["COO"].ToString();
                        dr.Cells[9].Value = dt.Rows[0]["pick_pallet_no"].ToString();
                        dr.Cells[10].Value = dt.Rows[0]["sscc"].ToString();
                        dr.Cells[11].Value = dt.Rows[0]["pack_pallet_no"].ToString();
                        dr.Cells[12].Value = dt.Rows[0]["wc"].ToString();
                        //dr.Cells[13].Value = dt.Rows[0]["OEM"].ToString();
                        try
                        {
                            dtgrd_CartonInfo.Invoke((MethodInvoker)delegate ()
                            {
                                dtgrd_CartonInfo.Rows.Add(dr);
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Pls input the carton no in the blank first");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        public void check_all(string p_shipment_id)
        {

           grdvw_SN_data.DataSource = null;
                string sqlCheckall = @"SELECT DISTINCT a.carton_no,
                           b.shipment_id,
                           a.part_no,
                           a.pick_pallet_no,
                           a.sscc,
                           a.pack_pallet_no,
                           A.TRACKING_NO,
                           A.BABYTRACKING_NO,
                           a.location_no,
                           b.delivery_no,
                           d.pallet_no,
                           D.COO,
                           a.wc
                     
                                 --a.customer_no
                                 FROM t_sn_status a
                           INNER JOIN t_order_info b ON a.part_no = b.ictpn 
                           --inner join t_trolley_sn_status c
                           --on b.delivery_no=c.delivery_no
                           INNER JOIN t_pallet_order d
                              ON     b.shipment_id = d.shipment_id
                                 AND b.ictpn = d.ictpn
                                 AND a.coo = d.coo and b.mpn=d.mpn
                                 AND b.delivery_no = d.delivery_no and b.line_item=d.line_item --and A.PALLET_NO = D.PALLET_NO
                               INNER JOIN t_shipment_pallet e
                                      ON d.pallet_no = e.pallet_no AND 
                                      d.shipment_id = e.shipment_id
                                WHERE b.shipment_id = :shipment_id  ORDER BY a.wc";
                object[][] param1 = new object[1][];
                param1[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "shipment_id", p_shipment_id };
                //param[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "dateto", dateto };
                DataSet ds1 = ClientUtils.ExecuteSQL(sqlCheckall, param1);
                if (ds1.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("No data found!");
                }
                else
                {
                    grdvw_SN_data.DataSource = ds1.Tables[0];
                }
            
        }
        private void btn_CheckAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reprint_Click(object sender, EventArgs e)
        {
            fPrintAll rp = new fPrintAll();
            rp.ShowDialog();
        }

        private void btn_exportExcel_Click(object sender, EventArgs e)
        {

            btn_exportExcel.Enabled = false;
            if (grdvw_SN_data.Rows.Count > 1)
            {

                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                Microsoft.Office.Interop.Excel.Range aRange;
                //app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                // changing the name of active sheet  
                //worksheet.Name = "Exported from gridview";
                //worksheet.AllocatedRange.AutoFitColumns();
                //worksheet.AllocatedRange.AutoFitRows();
                // storing header part in Excel  

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XLS (*.xlsx)|*.xlsx";
                sfd.FileName = "Output.xlsx";
                //string filename1 = @"D:\temp\test.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        string CsvFpath = sfd.FileName;
                        for (int l = 1; l < grdvw_SN_data.Columns.Count + 1; l++)
                        {
                            worksheet.Cells[1, l] = grdvw_SN_data.Columns[l - 1].HeaderText;
                        }
                        int i = 0, j = 0;
                        // storing Each row and column value to excel sheet  
                        for (i = 0; i < grdvw_SN_data.Rows.Count - 1; i++)
                        {
                            for (j = 0; j < grdvw_SN_data.Columns.Count; j++)
                            {
                                //app.Range["G"].NumberFormat =
                                app.Range["A" + (i + 2)].NumberFormat = "@";
                                app.Range["E" + (i + 2)].NumberFormat = "@";
                                app.Range["F" + (i + 2)].NumberFormat = "0";
                                app.Range["G" + (i + 2)].NumberFormat = "@";
                                app.Range["J" + (i + 2)].NumberFormat = "0";
                                app.Range["K" + (i + 2)].NumberFormat = "@";

                                worksheet.Cells[i + 2, j + 1] = grdvw_SN_data.Rows[i].Cells[j].Value.ToString();

                            }
                        }
                        aRange = worksheet.get_Range("A2", "N" + (i + 1));

                        aRange.Columns.AutoFit();
                        // CellRange cRange = worksheet.Range[]
                        aRange.Borders.LineStyle = LineStyleType.Dashed;
                        //aRange.Borders[BordersLineType.DiagonalDown].LineStyle = LineStyleType.None;
                        //aRange.Borders[BordersLineType.DiagonalUp].LineStyle = LineStyleType.None;


                        // save the application  
                        workbook.SaveAs(CsvFpath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        // Exit from the application  
                        MessageBox.Show("Data Exported Successfully !!!", "Info");


                        app.Quit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

            btn_exportExcel.Enabled = true;
        }

        private void btn_shipmentsearch_Click(object sender, EventArgs e)
        {
            dtgrw_ShipmentInfo.DataSource = null;

            object[][] param = new object[1][];
            //DataTable dt = new DataTable();
            string sql = @"select SHIPMENT_ID,CARRIER_NAME,POE,HAWB,SHIPMENT_TYPE,REGION,QTY from t_shipment_info where shipment_id=:shipment_id";
            if (string.IsNullOrEmpty(cmbShipment.Text.Trim()))
            {
                MessageBox.Show("Nhập vào shipment ID để tìm kiếm");
            }
            else
            {
                param[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "shipment_id", cmbShipment.Text.Trim() };
                //param[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "dateto", dateto };
                DataTable dt = ClientUtils.ExecuteSQL(sql, param).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dtgrw_ShipmentInfo.DataSource = dt;
                    //cmbShipment.Text = dt.Rows[0]["SHIPMENT_ID"].ToString();
                    //for (int i = 1; i < dt.Rows.Count; i++)
                    //{
                    //    //DataGridViewRow dr = new DataGridViewRow();
                    //    cmbShipment.Items.Add(dt.Rows[i]["SHIPMENT_ID"].ToString());
                    //}
                }
                else
                {
                    MessageBox.Show("No shipment Found");
                }

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
