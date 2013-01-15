namespace MvpSurvivalKit.Windows
{
    partial class Checkout
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
            this.label1 = new System.Windows.Forms.Label();
            this.uiProducts = new System.Windows.Forms.DataGridView();
            this.uxCheckout = new System.Windows.Forms.Button();
            this.uxCardNumber = new System.Windows.Forms.TextBox();
            this.uxCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiSubTotal = new System.Windows.Forms.Label();
            this.uiDiscount = new System.Windows.Forms.Label();
            this.uiTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout";
            // 
            // uiProducts
            // 
            this.uiProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiProducts.Location = new System.Drawing.Point(13, 30);
            this.uiProducts.Name = "uiProducts";
            this.uiProducts.Size = new System.Drawing.Size(259, 150);
            this.uiProducts.TabIndex = 1;
            // 
            // uxCheckout
            // 
            this.uxCheckout.Location = new System.Drawing.Point(13, 424);
            this.uxCheckout.Name = "uxCheckout";
            this.uxCheckout.Size = new System.Drawing.Size(75, 23);
            this.uxCheckout.TabIndex = 2;
            this.uxCheckout.Text = "Checkout";
            this.uxCheckout.UseVisualStyleBackColor = true;
            this.uxCheckout.Click += new System.EventHandler(this.uxCheckout_Click);
            // 
            // uxCardNumber
            // 
            this.uxCardNumber.Location = new System.Drawing.Point(13, 342);
            this.uxCardNumber.Name = "uxCardNumber";
            this.uxCardNumber.Size = new System.Drawing.Size(100, 20);
            this.uxCardNumber.TabIndex = 3;
            // 
            // uxCustomerName
            // 
            this.uxCustomerName.Location = new System.Drawing.Point(13, 392);
            this.uxCustomerName.Name = "uxCustomerName";
            this.uxCustomerName.Size = new System.Drawing.Size(100, 20);
            this.uxCustomerName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer Name:";
            // 
            // uiSubTotal
            // 
            this.uiSubTotal.AutoSize = true;
            this.uiSubTotal.Location = new System.Drawing.Point(21, 201);
            this.uiSubTotal.Name = "uiSubTotal";
            this.uiSubTotal.Size = new System.Drawing.Size(0, 13);
            this.uiSubTotal.TabIndex = 7;
            // 
            // uiDiscount
            // 
            this.uiDiscount.AutoSize = true;
            this.uiDiscount.Location = new System.Drawing.Point(34, 239);
            this.uiDiscount.Name = "uiDiscount";
            this.uiDiscount.Size = new System.Drawing.Size(0, 13);
            this.uiDiscount.TabIndex = 8;
            // 
            // uiTotal
            // 
            this.uiTotal.AutoSize = true;
            this.uiTotal.Location = new System.Drawing.Point(34, 265);
            this.uiTotal.Name = "uiTotal";
            this.uiTotal.Size = new System.Drawing.Size(0, 13);
            this.uiTotal.TabIndex = 9;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.uiTotal);
            this.Controls.Add(this.uiDiscount);
            this.Controls.Add(this.uiSubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxCustomerName);
            this.Controls.Add(this.uxCardNumber);
            this.Controls.Add(this.uxCheckout);
            this.Controls.Add(this.uiProducts);
            this.Controls.Add(this.label1);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiProducts;
        private System.Windows.Forms.Button uxCheckout;
        private System.Windows.Forms.TextBox uxCardNumber;
        private System.Windows.Forms.TextBox uxCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uiSubTotal;
        private System.Windows.Forms.Label uiDiscount;
        private System.Windows.Forms.Label uiTotal;
    }
}