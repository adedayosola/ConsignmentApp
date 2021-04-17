
namespace ConsignmentAppUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.cartListboxLabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(28, 19);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(266, 38);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(35, 135);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(297, 224);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(31, 92);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(90, 20);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(362, 218);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(140, 34);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "ADD TO CART";
            this.addToCart.UseVisualStyleBackColor = true;
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 20;
            this.cartListBox.Location = new System.Drawing.Point(531, 135);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(297, 224);
            this.cartListBox.TabIndex = 4;
            // 
            // cartListboxLabel
            // 
            this.cartListboxLabel.AutoSize = true;
            this.cartListboxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartListboxLabel.Location = new System.Drawing.Point(527, 92);
            this.cartListboxLabel.Name = "cartListboxLabel";
            this.cartListboxLabel.Size = new System.Drawing.Size(108, 20);
            this.cartListboxLabel.TabIndex = 5;
            this.cartListboxLabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(688, 378);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(140, 34);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "PURCHASE";
            this.makePurchase.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 563);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.cartListboxLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label cartListboxLabel;
        private System.Windows.Forms.Button makePurchase;
    }
}

