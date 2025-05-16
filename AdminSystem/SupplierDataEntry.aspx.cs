using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of a clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the SupplierName
        AnSupplier.SupplierName = txtSupplierName.Text;
        AnSupplier.SupplierCost = Convert.ToDecimal(txtSupplierCost.Text);
        AnSupplier.SupplierQuality = txtSupplierQuality.Text;
        AnSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        AnSupplier.SupplierLocation = txtSupplierLocation.Text;
        AnSupplier.DateAdded = Convert.ToDateTime(DateTime.Now);
        AnSupplier.SupplierStockAvailable = chkStockAvailable.Checked;
        //store the supplier in the session object
        Session["AnSupplier"] = AnSupplier;

        //navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }
}