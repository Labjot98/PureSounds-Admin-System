using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // Variable to store the primary key with page-level scope
    Int32 OrderId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the order's record to be processed from the session
        OrderId = Convert.ToInt32(Session["OrderId"]);

        if (IsPostBack == false)
        {
            // If this is not a new record
            if (OrderId != -1)
            {
                // Display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        // Create an instance of the Order collection
        clsOrderCollection OrderList = new clsOrderCollection();
        // Find the record to update using the OrderId
        OrderList.ThisOrder.Find(OrderId);

        // Display the data for the record
        txtOrderId.Text = OrderList.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrderList.ThisOrder.CustomerId.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString("yyyy-MM-dd"); // Formatting the date
        txtTotalAmount.Text = OrderList.ThisOrder.TotalAmount.ToString("0.00"); // Formatting to 2 decimal places
        txtStatus.Text = OrderList.ThisOrder.Status.ToString();
        chkDiscountApplied.Checked = OrderList.ThisOrder.DiscountApplied;
        txtPaymentMethod.Text = OrderList.ThisOrder.PaymentMethod.ToString();
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        // Capture the OrderId
        // AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text); // You may not need this if it's a new order (OrderId will be generated)

        // Capture the CustomerId
        string CustomerId = txtCustomerId.Text;

        // Capture the OrderDate
        string OrderDate = txtOrderDate.Text;

        // Capture the TotalAmount
        string TotalAmount = txtTotalAmount.Text;

        // Capture the Status
        string Status = txtStatus.Text;

        // Capture whether DiscountApplied
        string DiscountApplied = chkDiscountApplied.Checked.ToString();

        // Capture the PaymentMethod
        string PaymentMethod = txtPaymentMethod.Text;

        // Error variable to store validation messages
        string Error = "";

        // Validate the data
        Error += AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);

        // If there are no errors, proceed to add or update the order
        if (Error == "")
        {
            // Capture the OrderId if it exists
            AnOrder.OrderId = Convert.ToInt32(Session["OrderId"]); // Get the OrderId from session or set to -1 for new order

            // Capture the CustomerId
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);

            // Capture the OrderDate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);

            // Capture the TotalAmount
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);

            // Capture the Status
            AnOrder.Status = Status;

            // Capture the DiscountApplied boolean
            AnOrder.DiscountApplied = Convert.ToBoolean(DiscountApplied);

            // Capture the PaymentMethod
            AnOrder.PaymentMethod = PaymentMethod;

            // Create a new instance of the Order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            // If this is a new order (i.e., OrderId = -1), then add the data
            if (Convert.ToInt32(Session["OrderId"]) == -1)
            {
                // Set the ThisOrder property
                OrderList.ThisOrder = AnOrder;

                // Add the new record
                OrderList.Add();
            }
            // Otherwise, it must be an update
            else
            {
                // Find the record to update
                OrderList.ThisOrder.Find(AnOrder.OrderId);

                // Set the ThisOrder property
                OrderList.ThisOrder = AnOrder;

                // Update the record
                OrderList.Update();
            }

            // Redirect back to the list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }

    }

    protected void btnOK_Cancel(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            txtStatus.Text = AnOrder.Status;
            chkDiscountApplied.Checked = AnOrder.DiscountApplied;
            txtPaymentMethod.Text = AnOrder.PaymentMethod;
        }
        else
        {
            lblError.Text = "Order Id doesn't exist";
        }
    }
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

}