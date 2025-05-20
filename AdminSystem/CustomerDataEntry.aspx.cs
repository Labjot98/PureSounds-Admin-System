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

        //capture the data from the form
        string CustomerId = txtCreatedOn.Text;
        string CustomerFullname = txtCustomerFullname.Text;
        string Email = txtEmail.Text;
        string Address = txtAddress.Text; 
        string Password = txtPassword.Text;
        string BonusEligibility = chkBonusEligibility.Text;
        string CreatedOn = txtCreatedOn.Text;

        //variable to store any error message
        string Error = "";

        //validate the data
        Error += ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

        if(Error == "")
        {
            //capture the customer full name
            ACustomer.CustomerFullname = CustomerFullname;

            //capture the customer email
            ACustomer.Email = Email;

            //capture the customer address
            ACustomer.Address = Address;

            //capture the customer password
            ACustomer.Password = Password;

            //capture the customer created on date
            ACustomer.CreatedOn = Convert.ToDateTime(CreatedOn);

            //capture active
            ACustomer.BonusEligibility = chkBonusEligibility.Checked;

            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //set the ThisCustomer property
            CustomerList.ThisCustomer = ACustomer;

            //add the new record
            CustomerList.Add();

            //redirect back to list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the Error message
            lblError.Text = Error; 
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();

        //create a variable to store the primary key
        Int32 CustomerId;

        //create a variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        //find the record
        Found = ACustomer.Find(CustomerId);

        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerFullname.Text = ACustomer.CustomerFullname;
            txtEmail.Text = ACustomer.Email;
            txtAddress.Text = ACustomer.Address;
            txtPassword.Text = ACustomer.Password;
            txtCreatedOn.Text = ACustomer.CreatedOn.ToString();
            chkBonusEligibility.Checked = ACustomer.BonusEligibility;
        }
        else
        {
            lblError.Text = "Error";
        }
    }
}