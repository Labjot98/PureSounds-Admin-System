using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of Supplier
        clsSupplier AnSupplier = new clsSupplier();
        //get data from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //Display the SupplierName for this entry
        Response.Write(AnSupplier.SupplierId);
        Response.Write(AnSupplier.SupplierName);
        Response.Write(AnSupplier.SupplierLocation);
        Response.Write(AnSupplier.DateAdded);
        Response.Write(AnSupplier.SupplierQuality);
        Response.Write(AnSupplier.SupplierCost);
        Response.Write(AnSupplier.SupplierStockAvailable);


    }
}