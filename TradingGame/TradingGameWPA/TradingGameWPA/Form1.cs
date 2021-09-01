using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingGameWPA
{
    public partial class Form1 : Form
    {
        public decimal lostamount = 0;
        public decimal money = 10000;
        public decimal basictax = 0;
        public int woodinv = 0;
        public decimal taxmult = 0;
        public decimal profit = 0;
        public int ironinv = 0;
        public int oilinv = 0;
        public int taxshop1 = 1;
        public int taxshop2 = 1;
        public int taxshop3 = 1;
        public int taxshop4 = 1;
        public int minwoodprice = 2;
        public int minironprice = 7;
        public int minoilprice = 14;
        public int woodprice = 0;
        public int ironprice = 0;
        public int oilprice = 0;
        public int numbertrade = 0;
        public int itemprice = 0;
        public string sellorbuy = "NA";
        public string purchaseitem = "nothing";
        public string shopclicked = "none";
        public string currentshop = "none";
        public string notshopping = "true";
        public decimal taxwhich = 0;
        public int maxwoodprice = 20;
        public int maxironprice = 40;
        public int maxoilprice = 80;
        public string pricevaluewood = "none";
        public string pricevalueiron = "none";
        public string pricevalueoil = "none";
        public int pricewoodsell = 11;
        public int pricewoodbuy = 9;
        public int pricewoodneut = 10;
        public int priceironsell = 21;
        public int priceironbuy = 19;
        public int priceironneut = 20;
        public int priceoilsell = 41;
        public int priceoilbuy = 39;
        public int priceoilneut = 40;
        public int displayinv = 0;
       // System.Media.SoundPlayer ClickSo = new System.Media.SoundPlayer(@"D:\C#\BUTTONSE.wav");
       // System.Media.SoundPlayer AirplaneSFX = new System.Media.SoundPlayer(@"D:\C#\AIRPLANE.wav");
        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        // Creates The New Shop And Sets where you are //

        private void CreateNewShopFull1()
        {

            // Charges your travel fee & sets the "You are here button"//

            //AirplaneSFX.Play();
            notshopping = "false";
            currentshop = "Shop 1";
            taxwhich = taxshop1;
            money = money - 1000;
            MoneyLabel.Text = "Money: £" + Convert.ToString(money);

            Hereshop1.Visible = true;
            Hereshop2.Visible = false;
            Hereshop3.Visible = false;
            Hereshop4.Visible = false;

            // Randomizes the tax for the other shops //

            taxshop2 = random.Next(1, 15);
            taxshop3 = random.Next(1, 15);
            taxshop4 = random.Next(1, 15);

            Shop1.Text = "Shop 1 - Tax: " + Convert.ToString(taxshop1) + "%";
            Shop2.Text = "Shop 2 - Tax: " + Convert.ToString(taxshop2) + "%";
            Shop3.Text = "Shop 3 - Tax: " + Convert.ToString(taxshop3) + "%";
            Shop4.Text = "Shop 4 - Tax: " + Convert.ToString(taxshop4) + "%";

            // Randomizes cost of items //

            RandPrice();

            // Prepares your shopping menu //

            MenuPrep();

        }

        private void CreateNewShopFull2()
        {

            //AirplaneSFX.Play();
            notshopping = "false";
            currentshop = "Shop 2";
            taxwhich = taxshop2;
            money = money - 1000;
            MoneyLabel.Text = "Money: £" + Convert.ToString(money);

            Hereshop1.Visible = false;
            Hereshop3.Visible = false;
            Hereshop4.Visible = false;

            taxshop1 = random.Next(1, 15);
            taxshop3 = random.Next(1, 15);
            taxshop4 = random.Next(1, 15);

            Shop1.Text = "Shop 1 - Tax: " + Convert.ToString(taxshop1) + "%";
            Shop2.Text = "Shop 2 - Tax: " + Convert.ToString(taxshop2) + "%";
            Shop3.Text = "Shop 3 - Tax: " + Convert.ToString(taxshop3) + "%";
            Shop4.Text = "Shop 4 - Tax: " + Convert.ToString(taxshop4) + "%";

            RandPrice();

            MenuPrep();

            Hereshop2.Visible = true;


        }

        private void CreateNewShopFull3()
        {

            //AirplaneSFX.Play();
            notshopping = "false";
            currentshop = "Shop 3";
            taxwhich = taxshop3;
            money = money - 1000;
            MoneyLabel.Text = "Money: £" + Convert.ToString(money);

            Hereshop1.Visible = false;
            Hereshop2.Visible = false;
            Hereshop3.Visible = true;
            Hereshop4.Visible = false;

            taxshop2 = random.Next(1, 15);
            taxshop1 = random.Next(1, 15);
            taxshop4 = random.Next(1, 15);

            Shop1.Text = "Shop 1 - Tax: " + Convert.ToString(taxshop1) + "%";
            Shop2.Text = "Shop 2 - Tax: " + Convert.ToString(taxshop2) + "%";
            Shop3.Text = "Shop 3 - Tax: " + Convert.ToString(taxshop3) + "%";
            Shop4.Text = "Shop 4 - Tax: " + Convert.ToString(taxshop4) + "%";

            RandPrice();

            MenuPrep();



        }

        private void CreateNewShopFull4()
        {

            //AirplaneSFX.Play();
            notshopping = "false";
            currentshop = "Shop 4";
            taxwhich = taxshop4;
            money = money - 1000;
            MoneyLabel.Text = "Money: £" + Convert.ToString(money);

            Hereshop1.Visible = false;
            Hereshop2.Visible = false;
            Hereshop3.Visible = false;

            taxshop1 = random.Next(1, 15);
            taxshop2 = random.Next(1, 15);
            taxshop3 = random.Next(1, 15);

            Shop1.Text = "Shop 1 - Tax: " + Convert.ToString(taxshop1) + "%";
            Shop2.Text = "Shop 2 - Tax: " + Convert.ToString(taxshop2) + "%";
            Shop3.Text = "Shop 3 - Tax: " + Convert.ToString(taxshop3) + "%";
            Shop4.Text = "Shop 4 - Tax: " + Convert.ToString(taxshop4) + "%";

            RandPrice();

            MenuPrep();

            Hereshop4.Visible = true;


        }

        private void Bankrupcy()
        {
            Hereshop2.Visible = false;
            Shop2.Visible = false;
            money = money - 1000;
            MoneyLabel.Text = "Money: £" + Convert.ToString(money);
            LostBox.Visible = true;
            LostLabel.Visible = true;
            RestartButton.Visible = true;
            
            notshopping = "false";
        }

        private void LowMoneyAlert()
        {

            BankruptAlertBox.Visible = true;
            BankruptAlertBox.BringToFront();
            AlertPicBox.Visible = true;
            AlertPicBox.BringToFront();
            AlertLabel.Visible = true;
            AlertLabel.BringToFront();
            AlertLabel2.Visible = true;
            AlertLabel2.BringToFront();

        }

        // Shop Buttons //

        private void Shop1_Click(object sender, EventArgs e)
        {

            // Checks if you are already at a different shop, so you don't have more than 1 shopping menus on at one time, etc. //

            if (notshopping == "true")
            {

                // Checks if your selected shop is different than the one you are already at //

                if (currentshop != "Shop 1")
                {

                   // Checks if you are going bankrupt //

                    if (money - 1000 >= 0)
                    {

                        // Make sure the bankrupt alert is off //

                        AlertLabel.Visible = false;
                        AlertLabel2.Visible = false;
                        CreateNewShopFull1();



                    }
                    else if (money - 1000 < 0 && money - 1000 >= -1000)
                    {

                        LowMoneyAlert();
                        CreateNewShopFull1();


                    }
                    else if (money - 1000 <= -1001)
                    {

                        Bankrupcy();

                    }

                }
                else
                {

                    //ClickSo.Play();
                    MenuPrep();

                }


            }


        }

        private void Shop2_Click(object sender, EventArgs e)
        {

            if (notshopping == "true")
            {

                if (currentshop != "Shop 2")
                {

                    if (money - 1000 >= 0)
                    {

                        // Make sure the bankrupt alert is off //

                        AlertLabel.Visible = false;
                        AlertLabel2.Visible = false;
                        CreateNewShopFull2();



                    }
                    else if (money - 1000 < 0 && money - 1000 >= -1000)
                    {
                        LowMoneyAlert();
                        CreateNewShopFull2();


                    }
                    else if (money-1000<-1000)
                    {
                       
                        Bankrupcy();

                    }

                }
                else
                {
                    //ClickSo.Play();
                    MenuPrep();

                }
            }


        }

        private void Shop3_Click(object sender, EventArgs e)
        {


            if (notshopping == "true")
            {

                if (currentshop != "Shop 3")
                {

                    if (money - 1000 >= 0)
                    {

                        // Make sure the bankrupt alert is off //

                        AlertLabel.Visible = false;
                        AlertLabel2.Visible = false;
                        CreateNewShopFull3();



                    }
                    else if (money - 1000 < 0 && money - 1000 >= -1000)
                    {
                        LowMoneyAlert();
                        CreateNewShopFull3();


                    }
                    else if (money - 1000 <= -1001)
                    {

                        Bankrupcy();

                    }


                }
                else
                {
                    //////ClickSo.Play();
                    MenuPrep();

                }
            }


        }

        private void Shop4_Click(object sender, EventArgs e)
        {


            if (notshopping == "true")
            {

                if (currentshop != "Shop 4")
                {

                    if (money - 1000 >= 0)
                    {

                        // Make sure the bankrupt alert is off //

                        AlertLabel.Visible = false;
                        AlertLabel2.Visible = false;
                        CreateNewShopFull4();



                    }
                    else if (money - 1000 < 0 && money - 1000 >= -1000)
                    {

                        LowMoneyAlert();
                        CreateNewShopFull4();
                       

                    }
                    else if (money - 1000 <= -1001)
                    {

                        Bankrupcy();

                    }



                }
                else
                {
                    //ClickSo.Play();
                    MenuPrep();

                }
            }


        }




        // Start button //

        private void StartButton_Click(object sender, EventArgs e)
        {

            Shop1.Visible = true;
            Shop1.Text = "Shop 1 - Tax: " + Convert.ToString(taxshop1) + "%";
            Shop2.Visible = true;
            Shop2.Text = "Shop 2 - Tax: " + Convert.ToString(taxshop2) + "%";
            Shop3.Visible = true;
            Shop3.Text = "Shop 3 - Tax: " + Convert.ToString(taxshop3) + "%";
            Shop4.Visible = true;
            Shop4.Text = "Shop 4 - Tax: " + Convert.ToString(taxshop4) + "%";

            StartButton.Visible = false;
            MoneyLabel.Visible = true;
            InfoBox.Visible = true;
            InvwoodLabel.Visible = true;
            InvironLabel.Visible = true;
            InvoilLabel.Visible = true;

            MoneyLabel.Text = "Money: £" + Convert.ToString(money);
            InvwoodLabel.Text = "Wood: " + Convert.ToString(woodinv);
            InvironLabel.Text = "Iron: " + Convert.ToString(ironinv);
            InvoilLabel.Text = "Oil Barrels: " + Convert.ToString(oilinv);
        }



        // Cost generator //

        public void RandPrice()
        {

            // Randomizes cost of items //

            woodprice = random.Next(minwoodprice, maxwoodprice);
            ironprice = random.Next(minironprice, maxironprice);
            oilprice = random.Next(minoilprice, maxoilprice);

            // Tells you wether the price is good or bad for buying or selling //

            if (woodprice >= pricewoodsell)
            {
                pricevaluewood = "Good price for selling";
            }
            else if (woodprice == pricewoodneut)
            {
                pricevaluewood = "Neutral price";
            }
            else if (woodprice <= pricewoodbuy)
            {
                pricevaluewood = "Good price for buying";
            }



            if (ironprice >= priceironsell)
            {
                pricevalueiron = "Good price for selling";
            }
            else if (ironprice == priceironneut)
            {
                pricevalueiron = "Neutral price";
            }
            else if (ironprice <= priceironbuy)
            {
                pricevalueiron = "Good price for buying";
            }



            if (oilprice >= priceoilsell)
            {
                pricevalueoil = "Good price for selling";
            }
            else if (oilprice == priceoilneut)
            {
                pricevalueoil = "Neutral price";
            }
            else if (oilprice <= priceoilbuy)
            {
                pricevalueoil = "Good price for buying";
            }


        }



        // Prepares The Shop menu //

        public void MenuPrep()
        {
            
            ShopLabel.Visible = true;
            ShopLabel.Text = "Welcome To: " + currentshop;
            WoodPriceLabel.Visible = true;
            WoodPriceLabel.Text = "Wood = £" + Convert.ToString(woodprice) + " per unit    " + pricevaluewood;
            IronPriceLabel.Visible = true;
            IronPriceLabel.Text = "Iron = £" + Convert.ToString(ironprice) + " per unit    " + pricevalueiron;
            OilPriceLabel.Visible = true;
            OilPriceLabel.Text = "Oil = £" + Convert.ToString(oilprice) + " per unit    " + pricevalueoil;
            TaxLabel.Visible = true;
            TaxLabel.Text = "Tax: " + Convert.ToString(taxwhich) + "%";
            InfoMenuLabel.Visible = true;
            BuyButton.Visible = true;
            Sellbutton.Visible = true;
            LeaveButton.Visible = true;
            TradingMenuB.Visible = true;
        }



        // Buying, selling and leaving buttons //

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //ClickSo.Play();
            InfoMenuLabel.Text = "Please pick what item to buy";
            BuyButton.Visible = false;
            Sellbutton.Visible = false;
            WoodButton.Visible = true;
            WoodButton.BringToFront();
            IronButton.Visible = true;
            IronButton.BringToFront();
            OilButton.Visible = true;
            OilButton.BringToFront();
            sellorbuy = "Buy";


        }

        private void Sellbutton_Click(object sender, EventArgs e)
        {
            //ClickSo.Play();
            InfoMenuLabel.Text = "Please pick what item to sell";
            BuyButton.Visible = false;
            Sellbutton.Visible = false;
            WoodButton.Visible = true;
            WoodButton.BringToFront();
            IronButton.Visible = true;
            IronButton.BringToFront();
            OilButton.Visible = true;
            OilButton.BringToFront();
            sellorbuy = "Sell";
            

        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {

            notshopping = "true";
            //ClickSo.Play();
            TradingMenuB.Visible = false;
            ShopLabel.Visible = false;
            WoodPriceLabel.Visible = false;
            IronPriceLabel.Visible = false;
            OilPriceLabel.Visible = false;
            TaxLabel.Visible = false;
            InfoMenuLabel.Visible = false;
            BuyButton.Visible = false;
            Sellbutton.Visible = false;
            BankruptAlertBox.Visible = false;
            AlertPicBox.Visible = false;
            AlertLabel.Visible = false;
            AlertLabel2.Visible = false;
            LeaveButton.Visible = false;
            AmountBox.Visible = false;
            ActivateSale.Visible = false;
            WoodButton.Visible = false;
            IronButton.Visible = false;
            OilButton.Visible = false;

        }


        // Restart Button //

        private void RestartButton_Click(object sender, EventArgs e)
        {

            Application.Restart();

        }

       


        // Object Buttons, tell the game what item you want to sell or buy //

        private void WoodButton_Click(object sender, EventArgs e)
        {
            //ClickSo.Play();
            itemprice = woodprice;
            purchaseitem = "Wood";
            WoodButton.Visible = false;
            IronButton.Visible = false;
            OilButton.Visible = false;
            AmountBox.Visible = true;
            AmountBox.BringToFront();
            ActivateSale.Visible = true;
            ActivateSale.BringToFront();
            if (sellorbuy == "Sell")
            {
                displayinv = woodinv;
                ActivateSale.Text = "Sell";
                InfoMenuLabel.Text = "How much do you want to sell?";
            }
            else
            {

                ActivateSale.Text = "Buy";
                InfoMenuLabel.Text = "How much do you want to buy?";


            }

        }


        private void IronButton_Click(object sender, EventArgs e)
        {
            //ClickSo.Play();
            itemprice = ironprice;
            purchaseitem = "Iron";
            WoodButton.Visible = false;
            IronButton.Visible = false;
            OilButton.Visible = false;
            AmountBox.Visible = true;
            AmountBox.BringToFront();
            ActivateSale.Visible = true;
            ActivateSale.BringToFront();
            if (sellorbuy == "Sell")
            {
                displayinv = ironinv;
                ActivateSale.Text = "Sell";
                InfoMenuLabel.Text = "How much do you want to sell?";
            }
            else
            {

                ActivateSale.Text = "Buy";
                InfoMenuLabel.Text = "How much do you want to buy?";


            }

        }


        private void OilButton_Click(object sender, EventArgs e)
        {
            //ClickSo.Play();
            itemprice = oilprice;
            purchaseitem = "Oil";
            WoodButton.Visible = false;
            IronButton.Visible = false;
            OilButton.Visible = false;
            AmountBox.Visible = true;
            AmountBox.BringToFront();
            ActivateSale.Visible = true;
            ActivateSale.BringToFront();
            if (sellorbuy == "Sell")
            {
                displayinv = oilinv;
                ActivateSale.Text = "Sell";
                InfoMenuLabel.Text = "How much do you want to sell?";
            }
            else
            {

                ActivateSale.Text = "Buy";
                InfoMenuLabel.Text = "How much do you want to buy?";


            }

        }


        // Trading, so you sell and buy //

        private void Trade()
        {
           

            if (sellorbuy == "Sell")
            {


                if (displayinv >= numbertrade)
                {


                    if (purchaseitem == "Wood")
                    {

                        taxmult = 1- (taxwhich / 100);
                        lostamount = numbertrade*woodprice*(taxwhich / 100);
                        money = money + (numbertrade * woodprice * taxmult);
                        woodinv = woodinv - numbertrade;
                        MoneyLabel.Text = "Money: £" + Convert.ToString(money);
                        InvwoodLabel.Text = "Wood: " + Convert.ToString(woodinv);
                        
                        ThanksYouPanel.Visible = true;
                        ThanksYouPanel.BringToFront();
                        ThanksLabel1.BringToFront();
                        ThanksLabel2.BringToFront();
                        ThanksLabel3.BringToFront();
                        ThanksLabel1.Text = "Thank You For Your Transaction";
                        ThanksLabel2.Text = "You Sold: " + Convert.ToString(numbertrade) + " Wood    For: £" + Convert.ToString(numbertrade * woodprice * taxmult);
                        ThanksLabel3.Text = "Tax: "+Convert.ToString(taxwhich)+"%  (£"+Convert.ToString(lostamount)+")";


                    }
                    else if (purchaseitem == "Iron")
                    {
                        taxmult = 1 - (taxwhich / 100);
                        lostamount = numbertrade * ironprice * (taxwhich / 100);
                        money = money + (numbertrade * ironprice * taxmult);
                        ironinv = ironinv - numbertrade;
                        MoneyLabel.Text = "Money: £" + Convert.ToString(money);
                        InvironLabel.Text = "Iron: " + Convert.ToString(ironinv);

                        ThanksYouPanel.Visible = true;
                        ThanksYouPanel.BringToFront();
                        ThanksLabel1.BringToFront();
                        ThanksLabel2.BringToFront();
                        ThanksLabel3.BringToFront();
                        ThanksLabel1.Text = "Thank You For Your Transaction";
                        ThanksLabel2.Text = "You Sold: " + Convert.ToString(numbertrade) + " Iron    For: £" + Convert.ToString(numbertrade * ironprice * taxmult);
                        ThanksLabel3.Text = "Tax: " + Convert.ToString(taxwhich) + "%  (£" + Convert.ToString(lostamount) + ")";

                    }
                    else if (purchaseitem == "Oil")
                    {
                        taxmult = 1 - (taxwhich / 100);
                        lostamount = numbertrade * oilprice * (taxwhich / 100);
                        money = money + (numbertrade * oilprice * taxmult);
                        oilinv = oilinv - numbertrade;
                        MoneyLabel.Text = "Money: £" + Convert.ToString(money);
                        InvoilLabel.Text = "Wood: " + Convert.ToString(oilinv);

                        ThanksYouPanel.Visible = true;
                        ThanksYouPanel.BringToFront();
                        ThanksLabel1.BringToFront();
                        ThanksLabel2.BringToFront();
                        ThanksLabel3.BringToFront();
                        ThanksLabel1.Text = "Thank You For Your Transaction";
                        ThanksLabel2.Text = "You Sold: " + Convert.ToString(numbertrade) + " Oil    For: £" + Convert.ToString(numbertrade * oilprice * taxmult);
                        ThanksLabel3.Text = "Tax: " + Convert.ToString(taxwhich) + "%  (£" + Convert.ToString(lostamount) + ")";

                    }


                }
                else
                {

                    ThanksYouPanel.Visible = true;
                    ThanksYouPanel.BringToFront();
                    ThanksLabel1.Text = "You Don't Have Enough Of This Item";
                    ThanksLabel1.BringToFront();
                    ThanksLabel2.Text = "You need " + Convert.ToString(displayinv-numbertrade) + " more "+purchaseitem;
                    ThanksLabel2.BringToFront();
                    ThanksLabel3.Text = " ";
                    ThanksLabel3.BringToFront();



                }



            }
            else if (sellorbuy == "Buy")
            {
               
                if (money >= itemprice * numbertrade)
                {

                    money = money - itemprice * numbertrade;

                    if (purchaseitem == "Wood")
                    {

                        woodinv = woodinv + numbertrade;
                        MoneyLabel.Text = "Money: £" + Convert.ToString(money);
                        InvwoodLabel.Text = "Wood: " + Convert.ToString(woodinv);

                        ThanksYouPanel.Visible = true;
                        ThanksYouPanel.BringToFront();
                        ThanksLabel1.BringToFront();
                        ThanksLabel2.BringToFront();
                        ThanksLabel3.BringToFront();
                        ThanksLabel1.Text = "Thank You For Your Purchase";
                        ThanksLabel2.Text = "You Bought: " + Convert.ToString(numbertrade) + " Wood";
                        ThanksLabel3.Text = "Tax: NA";


                    }
                    else if (purchaseitem == "Iron")
                    {

                        ironinv = ironinv + numbertrade;
                        MoneyLabel.Text = "Money: £" + Convert.ToString(money);
                        InvironLabel.Text = "Iron: " + Convert.ToString(ironinv);

                        ThanksYouPanel.Visible = true;
                        ThanksYouPanel.BringToFront();
                        ThanksLabel1.BringToFront();
                        ThanksLabel2.BringToFront();
                        ThanksLabel3.BringToFront();
                        ThanksLabel1.Text = "Thank You For Your Purchase";
                        ThanksLabel2.Text = "You Bought: " + Convert.ToString(numbertrade) + " Iron";
                        ThanksLabel3.Text = "Tax: NA";

                    }
                    else if (purchaseitem == "Oil")
                    {

                        oilinv = oilinv + numbertrade;
                        MoneyLabel.Text = "Money: £" + Convert.ToString(money);
                        InvoilLabel.Text = "Oil: " + Convert.ToString(oilinv);

                        ThanksYouPanel.Visible = true;
                        ThanksYouPanel.BringToFront();
                        ThanksLabel1.BringToFront();
                        ThanksLabel2.BringToFront();
                        ThanksLabel3.BringToFront();
                        ThanksLabel1.Text = "Thank You For Your Purchase";
                        ThanksLabel2.Text = "You Bought: "+Convert.ToString(numbertrade)+" Oil";
                        ThanksLabel3.Text = "Tax: NA";
                        
                    }


                }
                else
                {

                    ThanksYouPanel.Visible = true;
                    ThanksYouPanel.BringToFront();
                    ThanksLabel1.Text = "You cannot Afford That";
                    ThanksLabel1.BringToFront();
                    ThanksLabel2.Text = "You need " + Convert.ToString( (numbertrade*itemprice)-money ) + " more money";
                    ThanksLabel2.BringToFront();
                    ThanksLabel3.Text = " ";
                    ThanksLabel3.BringToFront();



                }



            }

        }


        // Tels the game how much of an item you what to buy //

        private void ActivateSale_Click(object sender, EventArgs e)
        {
            //ClickSo.Play();
            numbertrade = Convert.ToInt32(AmountBox.Text);
            Trade();

        }


        // Deletes info Menu //

        private void CancelInfo_Click(object sender, EventArgs e)
        {
            //ClickSo.Play();
            ThanksYouPanel.Visible = false;


        }

    }
}
