using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientUtilsDll;

namespace Test111
{
   public class DAO
    {
        public string insertData(string shipment_id, string status, string errormsg)
        {
           
          
            object[][] strpram = new object[3][];
            strpram[0] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "p_shipment_id", shipment_id };
            strpram[1] = new object[] { ParameterDirection.Input, OracleDbType.Varchar2, "p_wc", status };
            strpram[2] = new object[] { ParameterDirection.Output, OracleDbType.Varchar2, "emsg", errormsg };
            //DataTable dt1 = new DataTable();
            try
            {
                DataTable dt1 = ClientUtils.ExecuteProc("ppsuser.PPS_DATA_INSERT", strpram).Tables[0];
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                return errormsg;
            }
            //if (dt1.Rows[0]["emsg"].ToString().Equals("OK"))
            //{
            //    MessageBox.Show("execution OK");
            //}
            return errormsg;
        }
    }
}
