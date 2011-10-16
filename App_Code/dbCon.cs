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
public class dbCon
{
    OleDbConnection dbConn = null;
    OleDbCommand dCmd = null;
    OleDbDataAdapter dA = null;
    DataSet dSet = null;
    OleDbDataReader dReader = null;
    String strConnection = null;
    String strSQL = null;
    public dbCon()
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
            dbConn = new OleDbConnection(strConnection);
            dbConn.Open();
            dCmd = new OleDbCommand(stmt, dbConn);
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

        if (dbConn != null)
            dbConn.Close();

    }
    public DataSet dbRetriev(string stmt)
    {
        try
        {
            dbConn = new OleDbConnection(strConnection);
            dbConn.Open();
            dA = new OleDbDataAdapter(stmt, dbConn);
            dSet = new DataSet();
            dA.Fill(dSet, "Table");
            return dSet;

        }
        finally
        {

        }
    }
}
