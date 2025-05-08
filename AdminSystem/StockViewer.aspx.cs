using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create instance of aStock1
        clsStock1 aStock = new clsStock1();
        //get the data from the session object
        aStock = (clsStock1)Session["aStock"];

        //display the itemID for this entry
        Response.Write(aStock.ItemID);
        //display the itemName for this entry
        Response.Write(aStock.ItemName);
        //etc..
        Response.Write(aStock.DatePosted);
        Response.Write(aStock.Quantity);
        Response.Write(aStock.Price);
        Response.Write(aStock.Brand);
        Response.Write(aStock.Bluetooth);
        
    }
}