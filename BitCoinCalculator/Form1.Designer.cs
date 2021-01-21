namespace BitCoinCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyMenu = new System.Windows.Forms.ComboBox();
            this.getRatesBTC = new System.Windows.Forms.Button();
            this.amountOfBTC = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.resultl_bl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyMenu
            // 
            this.currencyMenu.FormattingEnabled = true;
            this.currencyMenu.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyMenu.Location = new System.Drawing.Point(43, 54);
            this.currencyMenu.Name = "currencyMenu";
            this.currencyMenu.Size = new System.Drawing.Size(151, 28);
            this.currencyMenu.TabIndex = 0;
            this.currencyMenu.Text = "Select Currency";
            // 
            // getRatesBTC
            // 
            this.getRatesBTC.Location = new System.Drawing.Point(240, 141);
            this.getRatesBTC.Name = "getRatesBTC";
            this.getRatesBTC.Size = new System.Drawing.Size(130, 41);
            this.getRatesBTC.TabIndex = 1;
            this.getRatesBTC.Text = "Get Rates";
            this.getRatesBTC.UseVisualStyleBackColor = true;
            this.getRatesBTC.Click += new System.EventHandler(this.getRatesBTC_Click);
            // 
            // amountOfBTC
            // 
            this.amountOfBTC.Location = new System.Drawing.Point(43, 143);
            this.amountOfBTC.Name = "amountOfBTC";
            this.amountOfBTC.PlaceholderText = "Amount Of BitCoins";
            this.amountOfBTC.Size = new System.Drawing.Size(151, 27);
            this.amountOfBTC.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(48, 248);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(151, 27);
            this.result.TabIndex = 3;
            this.result.Visible = false;
            // 
            // resultl_bl
            // 
            this.resultl_bl.AutoSize = true;
            this.resultl_bl.Location = new System.Drawing.Point(48, 208);
            this.resultl_bl.Name = "resultl_bl";
            this.resultl_bl.Size = new System.Drawing.Size(49, 20);
            this.resultl_bl.TabIndex = 4;
            this.resultl_bl.Text = "Result";
            this.resultl_bl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(959, 579);
            this.Controls.Add(this.resultl_bl);
            this.Controls.Add(this.result);
            this.Controls.Add(this.amountOfBTC);
            this.Controls.Add(this.getRatesBTC);
            this.Controls.Add(this.currencyMenu);
            this.Name = "Form1";
            this.Text = "BitCoinCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyMenu;
        private System.Windows.Forms.Button getRatesBTC;
        private System.Windows.Forms.TextBox amountOfBTC;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultl_bl;
    }
}

