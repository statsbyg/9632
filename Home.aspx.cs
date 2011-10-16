using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Home : System.Web.UI.Page
{
    
    public dbCon DatabaseCon = new dbCon();
    protected void Page_Load(object sender, EventArgs e)
    {
        dgQuick.DataSource = DatabaseCon.dbRetrieve("SELECT SpeciesName FROM SpeciesTable");
        //dgQuick.DataBind();
        DatabaseCon.CloseDbCon_Reader();
        //this.btnDisplayPage.Click += new System.EventHandler(this.btnDisplayPage_Click);
        if (!Page.IsPostBack)
        {
            dgQuick.DataBind();
        }   
   }
    private void dgQuick__Page(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        dgQuick.CurrentPageIndex = e.NewPageIndex;
        DataBind();
    }
    private void btnDisplayPage_Click(Object sender, System.EventArgs e)
    {
        //set new page index and rebind the data. start from zero
       // dgQuick.CurrentPageIndex = Convert.ToInt32(txtNewPageNumber.Text) - 1;
        dgQuick.DataBind();
    }
    //private void BindData()
    //{
    //    dgQuick.DataSource = DatabaseCon.dbRetriev("SELECT SpeciesName FROM SpeciesTable");
    //    dgQuick.DataBind();
    //    DatabaseCon.CloseDbCon_Reader();
    //}
    public void dgQuick_PageIndexChanged(Object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
    {
        dgQuick.CurrentPageIndex = e.NewPageIndex;
        this.Page_Load(this.Page, e);
    }
}
