using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ItemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemID = Convert.ToInt32(Session["ItemID"]);
    }

    protected void btnYesClick_Click(object sender, EventArgs e)
    {
        //create a new instance of the stockCollection class
        clsStockCollection StockList = new clsStockCollection();
        //find record to delete
        StockList.ThisStock.Find(ItemID);
        //delete the record
        StockList.Delete();
        //redirect back to main page
        Response.Redirect("StockList.aspx");

    }

    protected void btnNo_Click_Click(object sender, EventArgs e)
    {
        //redirect back to main page
        Response.Redirect("StockList.aspx");
    }
}