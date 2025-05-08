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
        //create an instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        //capture the customer id
        ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);

        //capture the customer full name
        ACustomer.CustomerFullname = txtCustomerFullname.Text;

        //capture the customer email
        ACustomer.Email = txtEmail.Text;

        //capture the customer address
        ACustomer.Address = txtAddress.Text;

        //capture the customer password
        ACustomer.Password = txtPassword.Text;

        //capture the customer created on date
        ACustomer.CreatedOn = Convert.ToDateTime(DateTime.Now);

        //capture the bonus eligibility
        ACustomer.BonusEligibility = chkBonusEligibility.Checked;

        //store the form data in the session object
        Session["ACustomer"] = ACustomer;

        //navigate to view page
        Response.Redirect("CustomerViewer.aspx");
    }
}