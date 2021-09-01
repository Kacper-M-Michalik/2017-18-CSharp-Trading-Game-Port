namespace TradingGameWPA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Shop1 = new System.Windows.Forms.Button();
            this.Shop2 = new System.Windows.Forms.Button();
            this.Shop3 = new System.Windows.Forms.Button();
            this.Shop4 = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.InvoilLabel = new System.Windows.Forms.Label();
            this.InvironLabel = new System.Windows.Forms.Label();
            this.InvwoodLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.Hereshop1 = new System.Windows.Forms.Button();
            this.Hereshop2 = new System.Windows.Forms.Button();
            this.Hereshop3 = new System.Windows.Forms.Button();
            this.Hereshop4 = new System.Windows.Forms.Button();
            this.BankruptAlertBox = new System.Windows.Forms.GroupBox();
            this.AlertPicBox = new System.Windows.Forms.PictureBox();
            this.AlertLabel2 = new System.Windows.Forms.Label();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.TradingMenuB = new System.Windows.Forms.PictureBox();
            this.ShopLabel = new System.Windows.Forms.Label();
            this.WoodPriceLabel = new System.Windows.Forms.Label();
            this.IronPriceLabel = new System.Windows.Forms.Label();
            this.OilPriceLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.Sellbutton = new System.Windows.Forms.Button();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.InfoMenuLabel = new System.Windows.Forms.Label();
            this.LostBox = new System.Windows.Forms.GroupBox();
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.LostLabel = new System.Windows.Forms.Label();
            this.WoodButton = new System.Windows.Forms.Button();
            this.IronButton = new System.Windows.Forms.Button();
            this.OilButton = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.ActivateSale = new System.Windows.Forms.Button();
            this.BackgroundPicture = new System.Windows.Forms.PictureBox();
            this.ThanksYouPanel = new System.Windows.Forms.Panel();
            this.CancelInfo = new System.Windows.Forms.Button();
            this.ThanksLabel3 = new System.Windows.Forms.Label();
            this.ThanksLabel2 = new System.Windows.Forms.Label();
            this.ThanksLabel1 = new System.Windows.Forms.Label();
            this.InfoBox.SuspendLayout();
            this.BankruptAlertBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradingMenuB)).BeginInit();
            this.LostBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).BeginInit();
            this.ThanksYouPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Shop1
            // 
            this.Shop1.Location = new System.Drawing.Point(165, 237);
            this.Shop1.Name = "Shop1";
            this.Shop1.Size = new System.Drawing.Size(110, 23);
            this.Shop1.TabIndex = 0;
            this.Shop1.Text = "Shop 1";
            this.Shop1.UseVisualStyleBackColor = true;
            this.Shop1.Visible = false;
            this.Shop1.Click += new System.EventHandler(this.Shop1_Click);
            // 
            // Shop2
            // 
            this.Shop2.Location = new System.Drawing.Point(349, 237);
            this.Shop2.Name = "Shop2";
            this.Shop2.Size = new System.Drawing.Size(110, 23);
            this.Shop2.TabIndex = 1;
            this.Shop2.Text = "Shop 2";
            this.Shop2.UseVisualStyleBackColor = true;
            this.Shop2.Visible = false;
            this.Shop2.Click += new System.EventHandler(this.Shop2_Click);
            // 
            // Shop3
            // 
            this.Shop3.Location = new System.Drawing.Point(400, 436);
            this.Shop3.Name = "Shop3";
            this.Shop3.Size = new System.Drawing.Size(110, 23);
            this.Shop3.TabIndex = 2;
            this.Shop3.Text = "Shop 3";
            this.Shop3.UseVisualStyleBackColor = true;
            this.Shop3.Visible = false;
            this.Shop3.Click += new System.EventHandler(this.Shop3_Click);
            // 
            // Shop4
            // 
            this.Shop4.Location = new System.Drawing.Point(484, 163);
            this.Shop4.Name = "Shop4";
            this.Shop4.Size = new System.Drawing.Size(110, 23);
            this.Shop4.TabIndex = 3;
            this.Shop4.Text = "Shop 4";
            this.Shop4.UseVisualStyleBackColor = true;
            this.Shop4.Visible = false;
            this.Shop4.Click += new System.EventHandler(this.Shop4_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.InfoBox.Controls.Add(this.InvoilLabel);
            this.InfoBox.Controls.Add(this.InvironLabel);
            this.InfoBox.Controls.Add(this.InvwoodLabel);
            this.InfoBox.Controls.Add(this.MoneyLabel);
            this.InfoBox.Location = new System.Drawing.Point(16, 23);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(149, 163);
            this.InfoBox.TabIndex = 5;
            this.InfoBox.TabStop = false;
            this.InfoBox.Visible = false;
            // 
            // InvoilLabel
            // 
            this.InvoilLabel.AutoSize = true;
            this.InvoilLabel.Location = new System.Drawing.Point(6, 116);
            this.InvoilLabel.Name = "InvoilLabel";
            this.InvoilLabel.Size = new System.Drawing.Size(57, 13);
            this.InvoilLabel.TabIndex = 9;
            this.InvoilLabel.Text = "Oil Barrels:";
            this.InvoilLabel.Visible = false;
            // 
            // InvironLabel
            // 
            this.InvironLabel.AutoSize = true;
            this.InvironLabel.Location = new System.Drawing.Point(6, 91);
            this.InvironLabel.Name = "InvironLabel";
            this.InvironLabel.Size = new System.Drawing.Size(28, 13);
            this.InvironLabel.TabIndex = 8;
            this.InvironLabel.Text = "Iron:";
            this.InvironLabel.Visible = false;
            // 
            // InvwoodLabel
            // 
            this.InvwoodLabel.AutoSize = true;
            this.InvwoodLabel.Location = new System.Drawing.Point(6, 66);
            this.InvwoodLabel.Name = "InvwoodLabel";
            this.InvwoodLabel.Size = new System.Drawing.Size(39, 13);
            this.InvwoodLabel.TabIndex = 7;
            this.InvwoodLabel.Text = "Wood:";
            this.InvwoodLabel.Visible = false;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(6, 16);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(51, 13);
            this.MoneyLabel.TabIndex = 6;
            this.MoneyLabel.Text = "Money: £";
            this.MoneyLabel.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(338, 266);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Hereshop1
            // 
            this.Hereshop1.Location = new System.Drawing.Point(165, 266);
            this.Hereshop1.Name = "Hereshop1";
            this.Hereshop1.Size = new System.Drawing.Size(85, 23);
            this.Hereshop1.TabIndex = 10;
            this.Hereshop1.Text = "You are here";
            this.Hereshop1.UseVisualStyleBackColor = true;
            this.Hereshop1.Visible = false;
            // 
            // Hereshop2
            // 
            this.Hereshop2.Location = new System.Drawing.Point(349, 266);
            this.Hereshop2.Name = "Hereshop2";
            this.Hereshop2.Size = new System.Drawing.Size(85, 23);
            this.Hereshop2.TabIndex = 11;
            this.Hereshop2.Text = "You are here";
            this.Hereshop2.UseVisualStyleBackColor = true;
            this.Hereshop2.Visible = false;
            // 
            // Hereshop3
            // 
            this.Hereshop3.Location = new System.Drawing.Point(400, 465);
            this.Hereshop3.Name = "Hereshop3";
            this.Hereshop3.Size = new System.Drawing.Size(85, 23);
            this.Hereshop3.TabIndex = 12;
            this.Hereshop3.Text = "You are here";
            this.Hereshop3.UseVisualStyleBackColor = true;
            this.Hereshop3.Visible = false;
            // 
            // Hereshop4
            // 
            this.Hereshop4.Location = new System.Drawing.Point(484, 193);
            this.Hereshop4.Name = "Hereshop4";
            this.Hereshop4.Size = new System.Drawing.Size(85, 23);
            this.Hereshop4.TabIndex = 13;
            this.Hereshop4.Text = "You are here";
            this.Hereshop4.UseVisualStyleBackColor = true;
            this.Hereshop4.Visible = false;
            // 
            // BankruptAlertBox
            // 
            this.BankruptAlertBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BankruptAlertBox.Controls.Add(this.AlertPicBox);
            this.BankruptAlertBox.Controls.Add(this.AlertLabel2);
            this.BankruptAlertBox.Controls.Add(this.AlertLabel);
            this.BankruptAlertBox.Location = new System.Drawing.Point(271, 68);
            this.BankruptAlertBox.Name = "BankruptAlertBox";
            this.BankruptAlertBox.Size = new System.Drawing.Size(272, 59);
            this.BankruptAlertBox.TabIndex = 9;
            this.BankruptAlertBox.TabStop = false;
            this.BankruptAlertBox.Visible = false;
            // 
            // AlertPicBox
            // 
            this.AlertPicBox.Image = global::TradingGameWPA.Properties.Resources.Alert;
            this.AlertPicBox.Location = new System.Drawing.Point(0, 0);
            this.AlertPicBox.Name = "AlertPicBox";
            this.AlertPicBox.Size = new System.Drawing.Size(74, 59);
            this.AlertPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlertPicBox.TabIndex = 0;
            this.AlertPicBox.TabStop = false;
            this.AlertPicBox.Visible = false;
            // 
            // AlertLabel2
            // 
            this.AlertLabel2.AutoSize = true;
            this.AlertLabel2.Location = new System.Drawing.Point(76, 34);
            this.AlertLabel2.Name = "AlertLabel2";
            this.AlertLabel2.Size = new System.Drawing.Size(182, 13);
            this.AlertLabel2.TabIndex = 15;
            this.AlertLabel2.Text = "SELL SOME STOCK IMMEDIATELY";
            this.AlertLabel2.Visible = false;
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Location = new System.Drawing.Point(70, 16);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(196, 13);
            this.AlertLabel.TabIndex = 14;
            this.AlertLabel.Text = "ALERT! YOU ARE GOING BANKRUPT";
            this.AlertLabel.Visible = false;
            // 
            // TradingMenuB
            // 
            this.TradingMenuB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TradingMenuB.Location = new System.Drawing.Point(271, 133);
            this.TradingMenuB.Name = "TradingMenuB";
            this.TradingMenuB.Size = new System.Drawing.Size(271, 264);
            this.TradingMenuB.TabIndex = 15;
            this.TradingMenuB.TabStop = false;
            this.TradingMenuB.Visible = false;
            // 
            // ShopLabel
            // 
            this.ShopLabel.AutoSize = true;
            this.ShopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopLabel.Location = new System.Drawing.Point(285, 142);
            this.ShopLabel.Name = "ShopLabel";
            this.ShopLabel.Size = new System.Drawing.Size(91, 17);
            this.ShopLabel.TabIndex = 0;
            this.ShopLabel.Text = "Welcome To:";
            this.ShopLabel.Visible = false;
            // 
            // WoodPriceLabel
            // 
            this.WoodPriceLabel.AutoSize = true;
            this.WoodPriceLabel.Location = new System.Drawing.Point(285, 179);
            this.WoodPriceLabel.Name = "WoodPriceLabel";
            this.WoodPriceLabel.Size = new System.Drawing.Size(45, 13);
            this.WoodPriceLabel.TabIndex = 1;
            this.WoodPriceLabel.Text = "Wood =";
            this.WoodPriceLabel.Visible = false;
            // 
            // IronPriceLabel
            // 
            this.IronPriceLabel.AutoSize = true;
            this.IronPriceLabel.Location = new System.Drawing.Point(285, 205);
            this.IronPriceLabel.Name = "IronPriceLabel";
            this.IronPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.IronPriceLabel.TabIndex = 2;
            this.IronPriceLabel.Text = "Iron =";
            this.IronPriceLabel.Visible = false;
            // 
            // OilPriceLabel
            // 
            this.OilPriceLabel.AutoSize = true;
            this.OilPriceLabel.Location = new System.Drawing.Point(285, 234);
            this.OilPriceLabel.Name = "OilPriceLabel";
            this.OilPriceLabel.Size = new System.Drawing.Size(28, 13);
            this.OilPriceLabel.TabIndex = 3;
            this.OilPriceLabel.Text = "Oil =";
            this.OilPriceLabel.Visible = false;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(288, 327);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(114, 23);
            this.BuyButton.TabIndex = 4;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Visible = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // Sellbutton
            // 
            this.Sellbutton.Location = new System.Drawing.Point(408, 327);
            this.Sellbutton.Name = "Sellbutton";
            this.Sellbutton.Size = new System.Drawing.Size(114, 23);
            this.Sellbutton.TabIndex = 5;
            this.Sellbutton.Text = "Sell";
            this.Sellbutton.UseVisualStyleBackColor = true;
            this.Sellbutton.Visible = false;
            this.Sellbutton.Click += new System.EventHandler(this.Sellbutton_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(462, 298);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(56, 23);
            this.LeaveButton.TabIndex = 6;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Visible = false;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(285, 270);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(28, 13);
            this.TaxLabel.TabIndex = 7;
            this.TaxLabel.Text = "Tax:";
            this.TaxLabel.Visible = false;
            // 
            // InfoMenuLabel
            // 
            this.InfoMenuLabel.AutoSize = true;
            this.InfoMenuLabel.Location = new System.Drawing.Point(285, 303);
            this.InfoMenuLabel.Name = "InfoMenuLabel";
            this.InfoMenuLabel.Size = new System.Drawing.Size(168, 13);
            this.InfoMenuLabel.TabIndex = 8;
            this.InfoMenuLabel.Text = "Please select \'Buy\' \'Sell\' or \'Leave\'";
            this.InfoMenuLabel.Visible = false;
            // 
            // LostBox
            // 
            this.LostBox.Controls.Add(this.ThanksLabel);
            this.LostBox.Controls.Add(this.RestartButton);
            this.LostBox.Controls.Add(this.LostLabel);
            this.LostBox.Location = new System.Drawing.Point(300, 227);
            this.LostBox.Name = "LostBox";
            this.LostBox.Size = new System.Drawing.Size(200, 123);
            this.LostBox.TabIndex = 14;
            this.LostBox.TabStop = false;
            this.LostBox.Visible = false;
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.Location = new System.Drawing.Point(0, 0);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(100, 23);
            this.ThanksLabel.TabIndex = 0;
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(62, 74);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // LostLabel
            // 
            this.LostLabel.AutoSize = true;
            this.LostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostLabel.Location = new System.Drawing.Point(37, 23);
            this.LostLabel.Name = "LostLabel";
            this.LostLabel.Size = new System.Drawing.Size(134, 20);
            this.LostLabel.TabIndex = 1;
            this.LostLabel.Text = "You are Bankrupt";
            this.LostLabel.Visible = false;
            // 
            // WoodButton
            // 
            this.WoodButton.Location = new System.Drawing.Point(288, 356);
            this.WoodButton.Name = "WoodButton";
            this.WoodButton.Size = new System.Drawing.Size(75, 23);
            this.WoodButton.TabIndex = 16;
            this.WoodButton.Text = "Wood";
            this.WoodButton.UseVisualStyleBackColor = true;
            this.WoodButton.Visible = false;
            this.WoodButton.Click += new System.EventHandler(this.WoodButton_Click);
            // 
            // IronButton
            // 
            this.IronButton.Location = new System.Drawing.Point(369, 356);
            this.IronButton.Name = "IronButton";
            this.IronButton.Size = new System.Drawing.Size(75, 23);
            this.IronButton.TabIndex = 17;
            this.IronButton.Text = "Iron";
            this.IronButton.UseVisualStyleBackColor = true;
            this.IronButton.Visible = false;
            this.IronButton.Click += new System.EventHandler(this.IronButton_Click);
            // 
            // OilButton
            // 
            this.OilButton.Location = new System.Drawing.Point(447, 356);
            this.OilButton.Name = "OilButton";
            this.OilButton.Size = new System.Drawing.Size(75, 23);
            this.OilButton.TabIndex = 18;
            this.OilButton.Text = "Oil";
            this.OilButton.UseVisualStyleBackColor = true;
            this.OilButton.Visible = false;
            this.OilButton.Click += new System.EventHandler(this.OilButton_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AmountBox.Location = new System.Drawing.Point(288, 356);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(156, 20);
            this.AmountBox.TabIndex = 19;
            this.AmountBox.Text = "0";
            this.AmountBox.Visible = false;
            // 
            // ActivateSale
            // 
            this.ActivateSale.Location = new System.Drawing.Point(447, 356);
            this.ActivateSale.Name = "ActivateSale";
            this.ActivateSale.Size = new System.Drawing.Size(75, 23);
            this.ActivateSale.TabIndex = 20;
            this.ActivateSale.Text = "SellBuy";
            this.ActivateSale.UseVisualStyleBackColor = true;
            this.ActivateSale.Visible = false;
            this.ActivateSale.Click += new System.EventHandler(this.ActivateSale_Click);
            // 
            // BackgroundPicture
            // 
            this.BackgroundPicture.BackgroundImage = global::TradingGameWPA.Properties.Resources.world;
            this.BackgroundPicture.Image = global::TradingGameWPA.Properties.Resources.world;
            this.BackgroundPicture.Location = new System.Drawing.Point(1, 0);
            this.BackgroundPicture.Name = "BackgroundPicture";
            this.BackgroundPicture.Size = new System.Drawing.Size(766, 560);
            this.BackgroundPicture.TabIndex = 4;
            this.BackgroundPicture.TabStop = false;
            // 
            // ThanksYouPanel
            // 
            this.ThanksYouPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ThanksYouPanel.Controls.Add(this.CancelInfo);
            this.ThanksYouPanel.Controls.Add(this.ThanksLabel3);
            this.ThanksYouPanel.Controls.Add(this.ThanksLabel2);
            this.ThanksYouPanel.Controls.Add(this.ThanksLabel1);
            this.ThanksYouPanel.Location = new System.Drawing.Point(303, 189);
            this.ThanksYouPanel.Name = "ThanksYouPanel";
            this.ThanksYouPanel.Size = new System.Drawing.Size(200, 100);
            this.ThanksYouPanel.TabIndex = 21;
            this.ThanksYouPanel.Visible = false;
            // 
            // CancelInfo
            // 
            this.CancelInfo.BackColor = System.Drawing.Color.Red;
            this.CancelInfo.Location = new System.Drawing.Point(172, 0);
            this.CancelInfo.Name = "CancelInfo";
            this.CancelInfo.Size = new System.Drawing.Size(28, 19);
            this.CancelInfo.TabIndex = 3;
            this.CancelInfo.Text = "X";
            this.CancelInfo.UseVisualStyleBackColor = false;
            this.CancelInfo.Click += new System.EventHandler(this.CancelInfo_Click);
            // 
            // ThanksLabel3
            // 
            this.ThanksLabel3.AutoSize = true;
            this.ThanksLabel3.Location = new System.Drawing.Point(7, 74);
            this.ThanksLabel3.Name = "ThanksLabel3";
            this.ThanksLabel3.Size = new System.Drawing.Size(46, 13);
            this.ThanksLabel3.TabIndex = 2;
            this.ThanksLabel3.Text = "Tax: NA";
            // 
            // ThanksLabel2
            // 
            this.ThanksLabel2.AutoSize = true;
            this.ThanksLabel2.Location = new System.Drawing.Point(7, 45);
            this.ThanksLabel2.Name = "ThanksLabel2";
            this.ThanksLabel2.Size = new System.Drawing.Size(66, 13);
            this.ThanksLabel2.TabIndex = 1;
            this.ThanksLabel2.Text = "You Traded:";
            // 
            // ThanksLabel1
            // 
            this.ThanksLabel1.AutoSize = true;
            this.ThanksLabel1.Location = new System.Drawing.Point(7, 16);
            this.ThanksLabel1.Name = "ThanksLabel1";
            this.ThanksLabel1.Size = new System.Drawing.Size(151, 13);
            this.ThanksLabel1.TabIndex = 0;
            this.ThanksLabel1.Text = "Thank You For Your Purchase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 559);
            this.Controls.Add(this.ThanksYouPanel);
            this.Controls.Add(this.WoodButton);
            this.Controls.Add(this.IronButton);
            this.Controls.Add(this.OilButton);
            this.Controls.Add(this.Sellbutton);
            this.Controls.Add(this.ActivateSale);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.InfoMenuLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.OilPriceLabel);
            this.Controls.Add(this.IronPriceLabel);
            this.Controls.Add(this.WoodPriceLabel);
            this.Controls.Add(this.ShopLabel);
            this.Controls.Add(this.TradingMenuB);
            this.Controls.Add(this.BankruptAlertBox);
            this.Controls.Add(this.Hereshop3);
            this.Controls.Add(this.Hereshop1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.Shop3);
            this.Controls.Add(this.Shop4);
            this.Controls.Add(this.Hereshop4);
            this.Controls.Add(this.Shop1);
            this.Controls.Add(this.Hereshop2);
            this.Controls.Add(this.Shop2);
            this.Controls.Add(this.LostBox);
            this.Controls.Add(this.BackgroundPicture);
            this.Name = "Form1";
            this.Text = "Game";
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.BankruptAlertBox.ResumeLayout(false);
            this.BankruptAlertBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradingMenuB)).EndInit();
            this.LostBox.ResumeLayout(false);
            this.LostBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPicture)).EndInit();
            this.ThanksYouPanel.ResumeLayout(false);
            this.ThanksYouPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Shop1;
        private System.Windows.Forms.Button Shop2;
        private System.Windows.Forms.Button Shop3;
        private System.Windows.Forms.Button Shop4;
        private System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label InvoilLabel;
        private System.Windows.Forms.Label InvironLabel;
        private System.Windows.Forms.Label InvwoodLabel;
        private System.Windows.Forms.Button Hereshop1;
        private System.Windows.Forms.Button Hereshop2;
        private System.Windows.Forms.Button Hereshop3;
        private System.Windows.Forms.Button Hereshop4;
        private System.Windows.Forms.GroupBox BankruptAlertBox;
        private System.Windows.Forms.PictureBox AlertPicBox;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.Label AlertLabel2;
        private System.Windows.Forms.PictureBox TradingMenuB;
        private System.Windows.Forms.Label ShopLabel;
        private System.Windows.Forms.Label WoodPriceLabel;
        private System.Windows.Forms.Label IronPriceLabel;
        private System.Windows.Forms.Label OilPriceLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button Sellbutton;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label InfoMenuLabel;
        private System.Windows.Forms.GroupBox LostBox;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label LostLabel;
        private System.Windows.Forms.Button WoodButton;
        private System.Windows.Forms.Button IronButton;
        private System.Windows.Forms.Button OilButton;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Button ActivateSale;
        private System.Windows.Forms.Label ThanksLabel;
        private System.Windows.Forms.PictureBox BackgroundPicture;
        private System.Windows.Forms.Panel ThanksYouPanel;
        private System.Windows.Forms.Label ThanksLabel3;
        private System.Windows.Forms.Label ThanksLabel2;
        private System.Windows.Forms.Label ThanksLabel1;
        private System.Windows.Forms.Button CancelInfo;
    }
}

