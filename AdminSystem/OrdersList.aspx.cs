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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 OrderId;

        // if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // get the primary key value of the record to be deleted
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);

            // store the data in the session object for confirmation
            Session["OrderId"] = OrderId;

            // redirect to the delete confirmation page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else  // if no record has been selected
        {
            lblError.Text = "Please select an order from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the Order Collection object
        clsOrderCollection AOrder = new clsOrderCollection();
        // retrieve the value of OrderDate from the presentation layer (assume txtOrderDate is a text input)
        AOrder.ReportByOrderDate(txtFilter.Text);
        // set the data source to the list of Orders in the collection
        lstOrderList.DataSource = AOrder.OrderList;
        // set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        // set the name of the field to display
        lstOrderList.DataTextField = "OrderDate";
        // bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the Order Collection object
        clsOrderCollection AOrder = new clsOrderCollection();
        // set an empty string to clear the filter (show all orders)
        AOrder.ReportByOrderDate("");
        // clear any existing filter to tidy up the interface
        txtFilter.Text = "";  // Assuming there's a textbox for order date filter
                                 // set the data source to the list of Orders in the collection
        lstOrderList.DataSource = AOrder.OrderList;
        // set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        // set the name of the field to display
        lstOrderList.DataTextField = "OrderDate";  // You can also display other fields like total amount or status
                                                   // bind the data to the list
        lstOrderList.DataBind();
    }
}