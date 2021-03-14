using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesTaxesSol
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hids controls on initial load
            if (!IsPostBack)
            {
                this.hideControls();
            }

        }

        public void hideControls()
        {
            //txt item controls
            txtItem2.Visible = false;
            txtItem3.Visible = false;
            txtItem4.Visible = false;
            //txt quanity controls
            txtQty2.Visible = false;
            txtQty3.Visible = false;
            txtQty4.Visible = false;
            //txt price controls
            txtPrice2.Visible = false;
            txtPrice3.Visible = false;
            txtPrice4.Visible = false;
            //add btn controls  
            btnAdd2.Visible = false;
            btnAdd3.Visible = false;
            //clear btn controls
            btnClear2.Visible = false;
            btnClear3.Visible = false;
            btnClear4.Visible = false;
            //remove btn controls 
            btnRemove2.Visible = false;
            btnRemove3.Visible = false;
            btnRemove4.Visible = false;

        }
        



        //Submit Click event that checks if there is input in the textbox. 
        //If there is input, add it to the dictionary.
        //Then, it runs the Calculate_TaxPrice method.
        protected void Submit_Click(object sender, EventArgs e)
        {
            CartModel cart1 = new CartModel();
            //Create dictionary to store input values
            Dictionary<int, CartModel> Mylist = new Dictionary<int, CartModel>();

            if (txtItem1.Text.Length > 0 && txtQty1.Text.Length > 0 
               && txtPrice1.Text.Length > 0) 
            {
                cart1.Item = txtItem1.Text;
                cart1.Qty = txtQty1.Text;
                cart1.Price = txtPrice1.Text;
                Mylist.Add(1, cart1);

            } 

            CartModel cart2 = new CartModel();

            if (txtItem2.Text.Length > 0 && txtQty2.Text.Length > 0
                && txtPrice2.Text.Length > 0)
            {
                cart2.Item = txtItem2.Text;
                cart2.Qty = txtQty2.Text;
                cart2.Price = txtPrice2.Text;
                Mylist.Add(2, cart2);
            }

            CartModel cart3 = new CartModel();

            if (txtItem3.Text.Length > 0 && txtQty3.Text.Length > 0
                && txtPrice3.Text.Length > 0)
            {
                cart3.Item = txtItem3.Text;
                cart3.Qty = txtQty3.Text;
                cart3.Price = txtPrice3.Text;
                Mylist.Add(3, cart3);
            }

            CartModel cart4 = new CartModel();

            if (txtItem4.Text.Length > 0 && txtQty4.Text.Length > 0
                && txtPrice4.Text.Length > 0)
            {
                cart4.Item = txtItem4.Text;
                cart4.Qty = txtQty4.Text;
                cart4.Price = txtPrice4.Text;
                Mylist.Add(4, cart4);
            }

            this.Calculate_TaxPrice(Mylist);
        }


        //Method that calculates total, total sales tax, total for each item including sales tax 
        //and formats each item, price, qty to display in a label.
        protected void Calculate_TaxPrice(Dictionary<int, CartModel> MyList)
        {
            double totalSalesTax = 0;
            double FinalPrice = 0;

            //check if it is imported
            foreach (KeyValuePair<int, CartModel> entry in MyList)
            {
                CartModel mycart = (CartModel)entry.Value;
                double Salestaxvalue;
                if (mycart.Item.Contains("Imported")) {
                    Salestaxvalue = .05;
                } else
                {
                    Salestaxvalue = .10;
                }
                //calculate each item's price
                double cartPrice = Convert.ToDouble(mycart.Price);
                double cartQty = Convert.ToDouble(mycart.Qty);
                double finalPrice = cartPrice * cartQty;

                //calculate sales tax and the total sales tax
                double SalesTax = finalPrice * Salestaxvalue;
                totalSalesTax = totalSalesTax + SalesTax;

                //calculate total price of items including sales tax
                double actualfinalprice = finalPrice + SalesTax;
                FinalPrice = FinalPrice + actualfinalprice;


                //Apply formatting to each item's string to display in a label
                string displayTotal = string.Format("{0:0.00}", actualfinalprice);

                if (entry.Key == 1)
                {
                    string display = string.Format("{0}: {1} ({2} @ {3})",
                        entry.Value.Item,
                        displayTotal,
                        entry.Value.Qty,
                        entry.Value.Price.ToString()
                        );
                    lblItem1.Text = display;
                }

                if (entry.Key == 2)
                {
                    string display = string.Format("{0}: {1} ({2} @ {3})",
                        entry.Value.Item,
                        displayTotal,
                        entry.Value.Qty,
                        entry.Value.Price.ToString()
                        );
                    lblItem2.Text = display;
                }

                if (entry.Key == 3)
                {
                    string display = string.Format("{0}: {1} ({2} @ {3})",
                        entry.Value.Item,
                        displayTotal,
                        entry.Value.Qty,
                        entry.Value.Price.ToString()
                        );
                    lblItem3.Text = display;
                }
                if (entry.Key == 4)
                {
                    string display = string.Format("{0}: {1} ({2} @ {3})",
                        entry.Value.Item,
                        displayTotal,
                        entry.Value.Qty,
                        entry.Value.Price.ToString()
                        );
                    lblItem4.Text = display;
                }
                string displaySalesTax = string.Format("Sales Taxes: {0:0.00}", totalSalesTax);
                lblSalesTax.Text = displaySalesTax;

                string displayTotalPrice = string.Format("Total: {0:0.00}", FinalPrice);
                lblTotalPrice.Text = displayTotalPrice;

            }
        }

        //Clear All Textboxes and Labels Event Method
        protected void Clear_Click(object sender, EventArgs e)
        {
            txtItem1.Text = "";
            txtItem2.Text = "";
            txtItem3.Text = "";
            txtItem4.Text = "";

            txtQty1.Text = "";
            txtQty2.Text = "";
            txtQty3.Text = "";
            txtQty4.Text = "";

            txtPrice1.Text = "";
            txtPrice2.Text = "";
            txtPrice3.Text = "";
            txtPrice4.Text = "";

            lblItem1.Text = "";
            lblItem2.Text = "";
            lblItem3.Text = "";
            lblItem4.Text = "";
            lblSalesTax.Text = "";
            lblTotalPrice.Text = "";
            
        }

        //Clear button events
        protected void btnClear1_Click(object sender, EventArgs e)
        {
            txtItem1.Text = "";
            txtQty1.Text = "";
            txtPrice1.Text = "";
        }

        protected void btnClear2_Click(object sender, EventArgs e)
        {
            txtItem2.Text = "";
            txtQty2.Text = "";
            txtPrice2.Text = "";
        }

        protected void btnClear3_Click(object sender, EventArgs e)
        {
            txtItem3.Text = "";
            txtQty3.Text = "";
            txtPrice3.Text = "";
        }

        protected void btnClear4_Click(object sender, EventArgs e)
        {
            txtItem4.Text = "";
            txtQty4.Text = "";
            txtPrice4.Text = "";
        }

        //Add button events
        protected void btnAdd1_Click(object sender, EventArgs e)
        {
            txtItem2.Visible = true;
            txtQty2.Visible = true;
            txtPrice2.Visible = true;
            btnAdd2.Visible = true;
            btnClear2.Visible = true;
            btnRemove2.Visible = true;
        }

        protected void btnAdd2_Click(object sender, EventArgs e)
        {
            txtItem3.Visible = true;
            txtQty3.Visible = true;
            txtPrice3.Visible = true;
            btnAdd3.Visible = true;
            btnClear3.Visible = true;
            btnRemove3.Visible = true;
        }

        protected void btnAdd3_Click(object sender, EventArgs e)
        {
            txtItem4.Visible = true;
            txtQty4.Visible = true;
            txtPrice4.Visible = true;
            btnClear4.Visible = true;
            btnRemove4.Visible = true;
        }

        //Remove button events
        protected void btnRemove2_Click(object sender, EventArgs e)
        {
            txtItem2.Visible = false;
            txtQty2.Visible = false;
            txtPrice2.Visible = false;
            btnAdd2.Visible = false;
            btnClear2.Visible = false;
            btnRemove2.Visible = false;
        }

        protected void btnRemove3_Click(object sender, EventArgs e)
        {
            txtItem3.Visible = false;
            txtQty3.Visible = false;
            txtPrice3.Visible = false;
            btnAdd3.Visible = false;
            btnClear3.Visible = false;
            btnRemove3.Visible = false;
        }

        protected void btnRemove4_Click(object sender, EventArgs e)
        {
            txtItem4.Visible = false;
            txtQty4.Visible = false;
            txtPrice4.Visible = false;
            btnClear4.Visible = false;
            btnRemove4.Visible = false;
        }
    } 
}