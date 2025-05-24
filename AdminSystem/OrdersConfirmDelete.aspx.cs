using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // variable to store the primary key value of the record to be deleted
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get from the session object the OrderId of the order to be deleted
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create a new instance of the Order Collection class
        clsOrderCollection AllOrders = new clsOrderCollection();

        // retrieve the OrderId from the session object
        Int32 OrderId = Convert.ToInt32(Session["OrderId"]);

        // find the record to delete
        AllOrders.ThisOrder.Find(OrderId);

        // delete the record
        AllOrders.Delete();

        // redirect back to the main order list page
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("OrdersList.aspx");
    }
}