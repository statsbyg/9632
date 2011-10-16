using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


/// <summary>
/// Summary description for dbCon
/// </summary>
public class conn
{
    OleDbConnection con = null;
    OleDbCommand dCmd = null;
    OleDbDataReader dReader = null;
    String strConnection = null;
    String strSQL = null;
    public conn()
    {
        //
        // TODO: Add constructor logic here
        //
        strConnection = "Provider=SQLNCLI;Server=" + System.Environment.MachineName + "\\SQLExpress;Database=P_SEC;Trusted_Connection=yes";
    }
    public OleDbDataReader dbRetrieve(string stmt)
    {
        try
        {
            con = new OleDbConnection(strConnection);
            con.Open();
            dCmd = new OleDbCommand(stmt, con);
            dReader = dCmd.ExecuteReader();
            return dReader;
        }//try
        finally
        {
        }//finally
    }
    public void CloseDbCon_Reader()
    {
        if (dReader != null)
            dReader.Close();

        if (con != null)
            con.Close();

    }
}
