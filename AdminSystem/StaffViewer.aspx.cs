using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        // get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        // display the name for this entry
        Response.Write(AStaff.StaffID);
        Response.Write(AStaff.Name);
        Response.Write(AStaff.DateJoined);
        Response.Write(AStaff.DateLeft);
        Response.Write(AStaff.Rank);
        Response.Write(AStaff.NINumber);
        Response.Write(AStaff.IsFemale);



    }
}