using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrder();
        }


    }

    void DisplayOrder()
    {
        //create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();

        //set the data source to list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;

        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";

        //set the data field to display
        lstOrderList.DataTextField = "OrderDate";

        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;

        // Redirect to the order data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited
        Int32 OrderId;
        // If a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to be edited
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);

            // Store the data in the session object
            Session["OrderId"] = OrderId;

            // Redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else  // If no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}