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
        Session["ItemID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store primary key value of the record to be edited
        int ItemID;
        if (lstStockList.SelectedIndex != -1)
        {
            ItemID = Convert.ToInt32(lstStockList.SelectedValue);

            Session["ItemID"] = ItemID;

            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 ItemID;
        //if a row has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ItemID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ItemID"] = ItemID;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else// if no record was selcted
        {
            //display an error message
            lblError.Text = "please select a record from the list to delete";
        }
    }
}