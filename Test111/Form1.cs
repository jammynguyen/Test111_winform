using iTextSharp.text;
using iTextSharp.text.pdf;
using Oracle.ManagedDataAccess.Client;
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



namespace Test111
{
    public partial class Form1 : Form
    {
        public Form1()
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
            string sql = @"select * from PPSUSER.T_BASICLANGUAGE_INFO a where a.PRONAME = 'Weight' order by langcode asc";
            //DataTable dt = new DataTable();
            object[][] sqlparams = new object[0][];
            DataSet dbs = ClientUtils.ExecuteSQL(sql, sqlparams);
            DataTable db = dbs.Tables[0];
            //dataGridView1.DataSource = db;
            if (db.Rows.Count > 0)
            {
                for (int i = 0; i < db.Rows.Count; i++)
                {
                    //创建行
                    DataGridViewRow dr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //累加序号
                    dr.HeaderCell.Value = (i + 1).ToString();
                    dr.Cells[0].Value = db.Rows[i]["LANGCODE"].ToString();
                    dr.Cells[1].Value = db.Rows[i]["CN_DESC"].ToString();
                    dr.Cells[2].Value = db.Rows[i]["EN_DESC"].ToString();
                    dr.Cells[3].Value = db.Rows[i]["VN_DESC"].ToString();
                    dr.Cells[4].Value = db.Rows[i]["ENABLED"].ToString();
                    //dr.Cells[5].Value = Convert.ToDateTime(db.Rows[i]["CDT"]).ToString("yyyy/MM/dd");
                    dr.Cells[5].Value = db.Rows[i]["LANGFUNC"].ToString();
                    dr.Cells[6].Value = db.Rows[i]["PRONAME"].ToString();
                    //dr.Cells[8].Value = db.Rows[i]["REMARK"].ToString();
                    try
                    {
                        dataGridView1.Invoke((MethodInvoker)delegate ()
                        {
                            dataGridView1.Rows.Add(dr);
                        });
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        return;
                    }

                }

            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql = @"select * from PPSUSER.T_BASICLANGUAGE_INFO a where a.PRONAME = 'Weight' order by langcode asc";
            //DataTable dt = new DataTable();
            object[][] sqlparams = new object[0][];
            DataSet dbs = ClientUtils.ExecuteSQL(sql, sqlparams);
            DataTable dt2 = dbs.Tables[0];

            string strEnabled = null;
            string strLangcode = null;
            object[][] param1 = new object[2][];
            string sqlUpdate = @"update PPSUSER.T_BASICLANGUAGE_INFO a set a.ENABLED=:ENABLED where a.LANGCODE =:LANGCODE";


            if (dataGridView1.Rows.Count > 0)
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //DataGridViewRow dr = new DataGridViewRow();
                    //foreach (DataGridViewColumn c in dataGridView1.Columns)
                    //{
                    //    dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    //}
                    strEnabled = dataGridView1.CurrentCell.Value.ToString();
                    tt = dataGridView1.CurrentCell.RowIndex.ToString();
                    rowtt = int.Parse(tt);


                }

                textBox1.Text = dt2.Rows[rowtt]["LANGCODE"].ToString();
                //param1[1] = dataGridView1.Rows[rowtt].Cells.Count.ToString();
                strLangcode = textBox1.Text;
                param1[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "ENABLED", strEnabled };
                param1[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "LANGCODE", textBox1.Text.Trim() };
                DataSet dts1 = ClientUtils.ExecuteSQL(sqlUpdate, param1);
            }

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
                tt = dataGridView1.CurrentCell.RowIndex.ToString();
                rowtt = int.Parse(tt);
                textBox1.Text = dt2.Rows[rowtt]["LANGCODE"].ToString();

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
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
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
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //foreach (DataGridViewRow row in dataGridView1.Rows)
                            //{
                            //    foreach (DataGridViewCell cell in row.Cells)
                            //    {
                            //        pdfTable.AddCell(cell.Value.ToString());
                            //    }
                            //}
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                string id = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(id);
                                string name = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(name);
                                string city = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(city);
                                string department = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(department);
                                string gender = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(gender);
                                string email = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(email);
                                // Now your image cell 
                                //byte[] imageByte = (byte[])row.Cells[6].Value;
                                //iTextSharp.text.Image myImage = iTextSharp.text.Image.GetInstance(imageByte);
                                //pdfTable.AddCell(myImage);
                            }


                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = @"select * from PPSUSER.T_BASICLANGUAGE_INFO a where a.langcode = 'E0179' order by langcode asc";
                //DataTable dt = new DataTable();
                object[][] sqlparams = new object[0][];
                DataSet dbs = ClientUtils.ExecuteSQL(sql, sqlparams);
                DataTable dt2 = dbs.Tables[0];
                if (dt2.Rows.Count > 0)
                {
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt2.Columns.Count; j++)
                        {
                            string data = dt2.Rows[i][j].ToString();
                            var filepath = @"D:\temp\test.csv";
                            using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                                FileMode.Create, FileAccess.Write)))
                            {
                                writer.WriteLine("sep=,");
                                writer.WriteLine("Hello, Goodbye");
                            }
                            File.WriteAllText(filepath, data);
                        }
                    }
                }
                // Prepare the values
                //using (var w = new StreamWriter("D:\temp.test.cvs")) {
                //    csvFileWriter = StreamWriter;
                //    scannerDataGridView = DataGridView;
                //}

                //}
                

            }

            //}

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void GenerarDocumento(Document document)
        {

            //se crea un objeto PdfTable con el # de columnas del dataGridView


            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);


            //asignamos algunas propiedades para el diseño del pdf

            datatable.DefaultCell.Padding = 3;

            float[] headerwidths = GetSizeOfColumn(dataGridView1);

            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF

            for (int i = 0; i < dataGridView1.ColumnCount; i++)

            {

                datatable.AddCell(dataGridView1.Columns[i].HeaderText);

            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            //SE GENERA EL CUERPO DEL PDF

            for (int i = 0; i < dataGridView1.RowCount; i++)

            {

                for (int j = 0; j < dataGridView1.ColumnCount; j++)

                {

                    datatable.AddCell(dataGridView1[j, i].Value.ToString());

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
            datefrom= dtpStart.Value.ToString("yyyy/MM/dd")+" 00:00:00";
            dateto = dtpEnd.Value.ToString("yyyy/MM/dd") + " 23:59:59";
            object[][] param = new object[2][];
            //DataTable dt = new DataTable();
            string sql = @"select * from t_shipment_info where cdt between to_date(:datefrom,'YYYY/MM/DD HH24:MI:SS') and to_date(:dateto,'YYYY/MM/DD HH24:MI:SS')";
            param[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "datefrom", datefrom };
            param[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "dateto", dateto };
            DataTable dt = ClientUtils.ExecuteSQL(sql, param).Tables[0];
            //DataTable dt = dts.Tables[0];
          
            if (dt.Rows.Count > 0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                { 
                cmbShipment.Text = dt.Rows[0]["shipment_id"].ToString();
                DataGridViewRow dr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }
                //累加序号
                //dr.HeaderCell.Value = (i + 1).ToString();
                dr.Cells[0].Value = dt.Rows[i]["SHIPMENT_ID"].ToString();
                dr.Cells[1].Value = dt.Rows[i]["CARRIER_NAME"].ToString();
                dr.Cells[2].Value = dt.Rows[i]["POE"].ToString();
                dr.Cells[3].Value = dt.Rows[i]["HAWB"].ToString();
                dr.Cells[4].Value = dt.Rows[i]["SHIPMENT_TYPE"].ToString();
                //dr.Cells[5].Value = Convert.ToDateTime(db.Rows[i]["CDT"]).ToString("yyyy/MM/dd");
                dr.Cells[5].Value = dt.Rows[i]["REGION"].ToString();
                dr.Cells[6].Value = dt.Rows[i]["QTY"].ToString();
                //dr.Cells[7].Value = dt.Rows[0]["CARTON_QTY"].ToString();
                cmbShipment.Items.Add(dt.Rows[i]["shipment_id"].ToString());
                try
                {
                    dtgrw_ShipmentInfo.Invoke((MethodInvoker)delegate ()
                    {
                        dtgrw_ShipmentInfo.Rows.Add(dr);
                    });
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    return;
                }
                   
                }
            }
                
        }

        private void cmbShipment_SelectedValueChanged(object sender, EventArgs e)
        {
            
            string strShipment = null;
            string strSql = @"select*from t_shipment_info where shipment_id=:shipment_id";

            object[][] strpara = new object[1][];
            if (!string.IsNullOrEmpty(cmbShipment.Text.Trim()))
            {
                strShipment = cmbShipment.Text.Trim();
                strpara[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "shipment_id", strShipment };

                DataTable dt = ClientUtils.ExecuteSQL(strSql, strpara).Tables[0];
                //dtgrw_ShipmentInfo.DataSource = null;
                dtgrw_ShipmentInfo.Rows.Clear();
                DataGridViewRow dr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }
                //累加序号
                //dr.HeaderCell.Value = (i + 1).ToString();
                dr.Cells[0].Value = dt.Rows[0]["SHIPMENT_ID"].ToString();
                dr.Cells[1].Value = dt.Rows[0]["CARRIER_NAME"].ToString();
                dr.Cells[2].Value = dt.Rows[0]["POE"].ToString();
                dr.Cells[3].Value = dt.Rows[0]["HAWB"].ToString();
                dr.Cells[4].Value = dt.Rows[0]["SHIPMENT_TYPE"].ToString();
                //dr.Cells[5].Value = Convert.ToDateTime(db.Rows[i]["CDT"]).ToString("yyyy/MM/dd");
                dr.Cells[5].Value = dt.Rows[0]["REGION"].ToString();
                dr.Cells[6].Value = dt.Rows[0]["QTY"].ToString();
                //dr.Cells[7].Value = dt.Rows[0]["CARTON_QTY"].ToString();
                try
                {
                    dtgrw_ShipmentInfo.Invoke((MethodInvoker)delegate ()
                    {
                        dtgrw_ShipmentInfo.Rows.Add(dr);
                    });
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    return;
                }

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
            DAO inx = new DAO();
            string strinsert = inx.insertData(txtShipment.Text.Trim(), cmbStatus.Text.Trim());
            MessageBox.Show("execution OK...");

            string sql = @"select * from PPS_OPERATE_DATA_TOTAL where shipment=:shipment_id and wc=:wc order by carton_no";
            object[][] param1 = new object[2][];
            param1[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "shipment_id", txtShipment.Text.Trim() };
            param1[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "wc", cmbStatus.Text.Trim() };
            DataTable dt2 = ClientUtils.ExecuteSQL(sql, param1).Tables[0];
                grdvw_SN_data.DataSource = dt2;
            //if (dt2.Rows.Count>0)
            //{
            //    grdvw_SN_data.Rows.Clear();
            //    DataGridViewRow dr = new DataGridViewRow();
            //    foreach(DataGridViewColumn c in grdvw_SN_data.Columns)
            //    {
            //        dr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
            //    }
            //        for (int i = 0; i < 5; i++)
            //        {
            //            dr.Cells[0].Value = dt2.Rows[i]["CARTON_NO"].ToString();
            //            dr.Cells[1].Value = dt2.Rows[i]["PART_NO"].ToString();
            //            dr.Cells[2].Value = dt2.Rows[i]["DELIVERY_NO"].ToString();
            //            dr.Cells[3].Value = dt2.Rows[i]["SHIPMENT"].ToString();
            //            dr.Cells[4].Value = dt2.Rows[i]["PALLET_NO"].ToString();
            //            dr.Cells[5].Value = dt2.Rows[i]["LINE_ITEM"].ToString();
            //            dr.Cells[6].Value = dt2.Rows[i]["ASSIGN_QTY"].ToString();
            //            dr.Cells[7].Value = dt2.Rows[i]["ASSIGN_CARTON"].ToString();
            //            dr.Cells[8].Value = dt2.Rows[i]["COO"].ToString();
            //            dr.Cells[9].Value = dt2.Rows[i]["PICK_PALLET_NO"].ToString();
            //            dr.Cells[10].Value = dt2.Rows[i]["SSCC"].ToString();
            //            dr.Cells[11].Value = dt2.Rows[i]["PACK_PALLET_NO"].ToString();
            //            dr.Cells[12].Value = dt2.Rows[i]["WC"].ToString();
            //            try
            //            {
            //                grdvw_SN_data.Invoke((MethodInvoker)delegate ()
            //                {
            //                    grdvw_SN_data.Rows.Add(dr);
            //                });
            //            }
            //            catch (Exception e1)
            //            {
            //                MessageBox.Show(e1.ToString());
            //                return;
            //            }
            //        }
            //    }
            }

        }
    }
}
