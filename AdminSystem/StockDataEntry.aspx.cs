using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ItemID;


    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numver of the item to be processed
        ItemID = Convert.ToInt32(Session["ItemID"]);

        //if this is not a new record
        if(IsPostBack == false)
        {
            //if this is not a new record
            if (ItemID != -1)
            {
                //displays the current data for the record
                DisplayStock();
            }
            
        }
    }

    void DisplayStock()
    {
        //create a new instance of the stock list
        clsStockCollection ALLStock = new clsStockCollection();

        ALLStock.ThisStock.Find(ItemID);
        //display the data for the record

        txtItemID.Text = ALLStock.ThisStock.ItemID.ToString();
        txtItemName.Text = ALLStock.ThisStock.ItemName;
        txtDatePosted.Text = ALLStock.ThisStock.DatePosted.ToString();
        txtQuantity.Text = ALLStock.ThisStock.Quantity.ToString();
        txtPrice.Text = ALLStock.ThisStock.Price.ToString();
        txtBrand.Text = ALLStock.ThisStock.Brand;
        chkBluetooth.Checked = ALLStock.ThisStock.Bluetooth;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        //create new instance of cls stock
        clsStock1 aStock = new clsStock1();

        string ItemName = txtItemName.Text;
        //string ItemID = txtItemID.Text;
        string DatePosted = txtDatePosted.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string Brand = txtBrand.Text;
        string Bluetooth = chkBluetooth.Text;



        string Error = "";

        Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

        if (Error == "")
        {
            aStock.ItemID = ItemID;
            aStock.ItemName = ItemName;
            aStock.DatePosted = Convert.ToDateTime(DatePosted);
            aStock.Quantity = Convert.ToInt32(Quantity);
            aStock.Price = Convert.ToDecimal(Price);
            aStock.Brand = Brand;
            aStock.Bluetooth = chkBluetooth.Checked;

            //create new instance of Stock Collection
            clsStockCollection StockList = new clsStockCollection();
            
            //if this is a new record
            if(ItemID == -1)
            {
                //set thisStock property
                StockList.ThisStock = aStock;
                //add the new record
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(ItemID);
                StockList.ThisStock = aStock;
                StockList.Update();
            }
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