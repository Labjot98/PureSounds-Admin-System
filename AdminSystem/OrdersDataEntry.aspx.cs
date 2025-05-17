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


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //capture the data from the form
        string OrderId = txtOrderId.Text;
        string CustomerId = txtCustomerId.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string Status = txtStatus.Text;
        string PaymentMethod = txtPaymentMethod.Text;
        string DiscountApplied = chkDiscountApplied.Text;

        //variable to store any error message
        string Error = "";

        //validate the data
        Error += AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);

        if (Error == "")
        {
            //capture the order ID
            AnOrder.OrderId = Convert.ToInt32(OrderId);

            //capture the customer ID
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);

            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);

            //capture the total amount
            AnOrder.TotalAmount = Convert.ToDecimal(TotalAmount);

            //capture the order status
            AnOrder.Status = Status;

            //capture the payment method
            AnOrder.PaymentMethod = PaymentMethod;

            //store the form data in the session object
            Session["AnOrder"] = AnOrder;

            //navigate to the view page
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {
            //display the Error message
            lblError.Text = Error;
        }

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
}