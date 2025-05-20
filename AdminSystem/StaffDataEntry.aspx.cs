using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page-level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the staff member's record to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if (StaffId != -1)
            {
                // display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        // create an instance of the Staff collection
        clsStaffCollection StaffList = new clsStaffCollection();
        // find the record to update
        StaffList.ThisStaff.Find(StaffId);
        // display the data for the record
        txtStaffID.Text = StaffList.ThisStaff.StaffID.ToString();
        txtName.Text = StaffList.ThisStaff.Name.ToString();
        txtDateJoined.Text = StaffList.ThisStaff.DateJoined.ToString();
        txtDateLeft.Text = StaffList.ThisStaff.DateLeft.ToString();
        txtRank.Text = StaffList.ThisStaff.Rank.ToString();
        txtNINumber.Text = StaffList.ThisStaff.NINumber.ToString();
        chkIsFemale.Checked = StaffList.ThisStaff.IsFemale;
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
            // capture the StaffId
            AStaff.StaffID = StaffId;
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
            // capture the IsFemale boolean
            AStaff.IsFemale = chkIsFemale.Checked;
            // create a new instance of the Staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            // if this is a new record (i.e. StaffId = -1) then add the data
            if (StaffId == -1)
            {
                // set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                // add the new record
                StaffList.Add();
            }
            // otherwise it must be an update
            else
            {
                // find the record to update
                StaffList.ThisStaff.Find(StaffId);
                // set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                // update the record
                StaffList.Update();
            }
            // redirect back to the list page
            Response.Redirect("StaffList.aspx");
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