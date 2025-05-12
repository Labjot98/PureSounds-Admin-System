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
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        // capture the Name
        AStaff.Name = txtName.Text;
        // capture the DateJoined
        AStaff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
        // capture the DateLeft
        AStaff.DateLeft = Convert.ToDateTime(txtDateLeft.Text);
        // capture the Rank
        AStaff.Rank = txtRank.Text;
        // capture the NINumber
        AStaff.NINumber = txtNINumber.Text;
        // capture the IsFemale?
        AStaff.IsFemale = chkIsFemale.Checked;

        // store the data in the session object
        Session["AStaff"] = AStaff;
        // navigate to the view page
        Response.Redirect("StaffViewer.aspx");



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