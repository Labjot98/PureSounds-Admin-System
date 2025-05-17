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
        //capture the order id
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture the customer id
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //capture the order date
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //capture the total amount
        AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        //capture the order status
        AnOrder.Status = txtStatus.Text;
        //capture if discount was applied
        AnOrder.DiscountApplied = chkDiscountApplied.Checked;
        //capture the payment method
        AnOrder.PaymentMethod = txtPaymentMethod.Text;
        //store the form data in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to view page
        Response.Redirect("OrdersViewer.aspx");

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