using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {
        // create an instance of the Staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        // set the data source to list of staff in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        // set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        // set the data field to display
        lstStaffList.DataTextField = "Name";
        // bind the data to the list
        lstStaffList.DataBind();
     }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        // redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }
}