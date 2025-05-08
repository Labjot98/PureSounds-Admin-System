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

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create new instance of cls stock
        clsStock1 aStock = new clsStock1();

        //capture the text inside of itemname label
        aStock.ItemName = txtItemName.Text;
        //capture the text inside of itemID label
        aStock.ItemID = Convert.ToInt32(txtItemID.Text);
        aStock.DatePosted = Convert.ToDateTime(txtDatePosted.Text);
        aStock.Quantity = Convert.ToInt32(txtQuantity.Text);
        aStock.Price = Convert.ToDecimal(txtPrice.Text);
        aStock.Brand = txtBrand.Text;
        aStock.Bluetooth = chkBluetooth.Checked;
        



        //store the stock in the session object
        Session["aStock"] = aStock;

        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }
}