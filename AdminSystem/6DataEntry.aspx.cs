using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        ////create a new instance of a clsSupplier
        //clsSupplier AnSupplier = new clsSupplier();
        ////capture the SupplierId
        //AnSupplier.SupplierName = txtSupplierName.Text;
        ////store the supplier in the session object
        //Session["AnSupplier"] = AnSupplier;

        ////navigate to the viewer page
        //Response.Redirect("SupplierViewer.aspx");
    }

    protected void txtSupplierName_TextChanged(object sender, EventArgs e)
    {

    }
}