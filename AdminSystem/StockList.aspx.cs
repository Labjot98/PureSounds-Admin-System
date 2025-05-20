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
        if(IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();

        lstStockList.DataSource = Stock.StockList;

        lstStockList.DataValueField = "ItemID";

        lstStockList.DataTextField = "ItemName";

        lstStockList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //STORE -1 in the session object to indicate this is a new record
        Session["ItemId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }
}