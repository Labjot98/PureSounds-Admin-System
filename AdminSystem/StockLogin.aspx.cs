using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the stock user class
        clsStockUser AnUser = new clsStockUser();
        //variables to store username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //variable to store result of find method
        Boolean Found = false;
        //get username and password entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        Session["AnUser"] = AnUser;
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a UserName ";
        }
        else if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a Password ";
        }
        else if (Found == true)
        {
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect, please try again ";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}