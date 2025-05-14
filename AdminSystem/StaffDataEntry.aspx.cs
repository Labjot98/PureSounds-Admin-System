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

    protected void txtRank_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        // capture the StaffID
        // AStaff.StaffID = Convert.ToInt32(txtStaffID.Text); WE NO LONGER SEEM TO DO THIS FOR THE 'OKAY' BUTTON
        // capture the Name
        string Name = txtName.Text;
        // capture the DateJoined
        string DateJoined = txtDateJoined.Text;
        // capture the DateLeft
        string DateLeft = txtDateLeft.Text;
        // capture the Rank
        string Rank = txtRank.Text;
        // capture the NINumber
        string NINumber = txtNINumber.Text;
        // capture the IsFemale?
        string IsFemale = chkIsFemale.Text;
        string Error = "";
        // validate the data
        Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
        if (Error == "")
        {
            // capture the name
            AStaff.Name = Name;
            // capture the date joined
            AStaff.DateJoined = Convert.ToDateTime(DateJoined);
            // capture the date left
            AStaff.DateLeft = Convert.ToDateTime(DateLeft);
            // capture the rank
            AStaff.Rank = Rank;
            // capture the NI number
            AStaff.NINumber = NINumber;
            // store the staff member details in the session object
            Session["AStaff"] = AStaff;
            // navigate to the view page
            Response.Redirect("StaffViewer.aspx");
        }

        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        // create a variable to store the primary key
        Int32 StaffID;
        // create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        // find the record
        Found = AStaff.Find(StaffID);
        // if found
        if (Found == true)
        {
            // display the values of the property in the form
            txtName.Text = AStaff.Name;
            txtDateJoined.Text = AStaff.DateJoined.ToString();
            txtDateLeft.Text = AStaff.DateLeft.ToString();
            txtRank.Text = AStaff.Rank;
            txtNINumber.Text = AStaff.NINumber.ToString();
            chkIsFemale.Checked = AStaff.IsFemale;
        }
    }
}