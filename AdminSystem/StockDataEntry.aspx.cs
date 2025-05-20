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

        string ItemName = txtItemName.Text;
        string ItemID = txtItemID.Text;
        string DatePosted = txtDatePosted.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string Brand = txtBrand.Text;
        string Bluetooth = chkBluetooth.Text;



        string Error = "";

        Error = aStock.Valid(ItemName, ItemID, DatePosted, Price, Quantity);

        if (Error == "")
        {
            aStock.ItemName = ItemName;
            aStock.DatePosted = Convert.ToDateTime(DatePosted);
            aStock.Quantity = Convert.ToInt32(Quantity);
            aStock.Price = Convert.ToDecimal(Price);
            aStock.Brand = Brand;
            aStock.Bluetooth = chkBluetooth.Checked;

            //create new instance of Stock Collection
            clsStockCollection StockList = new clsStockCollection();
            
            //set thisStock property and call add function
            StockList.ThisStock = aStock;
            StockList.Add();

            //redirect to list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }




    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create new instance of cls stock
        clsStock1 aStock = new clsStock1();

        Int32 ItemID;

        Boolean Found = false;

        ItemID = Convert.ToInt32(txtItemID.Text);

        Found = aStock.Find(ItemID);

        if (Found == true)
        {
            txtItemID.Text = aStock.ItemID.ToString();
            txtItemName.Text = aStock.ItemName.ToString();
            txtDatePosted.Text = aStock.DatePosted.ToString();
            txtQuantity.Text = aStock.Quantity.ToString();
            txtPrice.Text = aStock.Price.ToString();
            txtBrand.Text = aStock.Brand.ToString();
            chkBluetooth.Checked = aStock.Bluetooth;
        }
    }
}