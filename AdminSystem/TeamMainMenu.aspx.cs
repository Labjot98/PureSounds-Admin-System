using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        // redirect the user to the Customer login page
        Response.Redirect("CustomerLogin.aspx");
    }
    protected void btnOrders_Click(object sender, EventArgs e)
    {
        // redirect the user to the Orders login page
        Response.Redirect("OrderLogin.aspx");
    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        // redirect the user to the Staff login page
        Response.Redirect("StaffLogin.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        // redirect the user to the Stock login page
        Response.Redirect("StockLogin.aspx");
    }

    protected void btnSupplier_Click(object sender, EventArgs e)
    {
        // redirect the user to the Supplier login page
        Response.Redirect("SupplierLogin.aspx");
    }
}