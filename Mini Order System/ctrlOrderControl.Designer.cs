namespace Mini_Order_System
{
    partial class ctrlOrderControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductName1 = new System.Windows.Forms.Label();
            this.lblQuantity1 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblTotal3 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.orderSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.orderSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(501, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Order Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName1
            // 
            this.lblProductName1.AutoSize = true;
            this.lblProductName1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName1.Location = new System.Drawing.Point(20, 40);
            this.lblProductName1.Name = "lblProductName1";
            this.lblProductName1.Size = new System.Drawing.Size(113, 21);
            this.lblProductName1.TabIndex = 1;
            this.lblProductName1.Text = "Product Name:";
            // 
            // lblQuantity1
            // 
            this.lblQuantity1.AutoSize = true;
            this.lblQuantity1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity1.Location = new System.Drawing.Point(20, 75);
            this.lblQuantity1.Name = "lblQuantity1";
            this.lblQuantity1.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity1.TabIndex = 2;
            this.lblQuantity1.Text = "Quantity:";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.Location = new System.Drawing.Point(20, 110);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(47, 21);
            this.lblPrice2.TabIndex = 3;
            this.lblPrice2.Text = "Price:";
            // 
            // lblTotal3
            // 
            this.lblTotal3.AutoSize = true;
            this.lblTotal3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal3.Location = new System.Drawing.Point(20, 150);
            this.lblTotal3.Name = "lblTotal3";
            this.lblTotal3.Size = new System.Drawing.Size(60, 25);
            this.lblTotal3.TabIndex = 4;
            this.lblTotal3.Text = "Total:";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(160, 40);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(270, 21);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "[Product Name]";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(160, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(270, 21);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "0";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(160, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(270, 21);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "$0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(160, 150);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(270, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(150, 350);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(200, 60);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Process Order";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // orderSummaryGroupBox
            // 
            this.orderSummaryGroupBox.Controls.Add(this.lblTotal);
            this.orderSummaryGroupBox.Controls.Add(this.lblPrice);
            this.orderSummaryGroupBox.Controls.Add(this.lblQuantity);
            this.orderSummaryGroupBox.Controls.Add(this.lblProductName);
            this.orderSummaryGroupBox.Controls.Add(this.lblTotal3);
            this.orderSummaryGroupBox.Controls.Add(this.lblPrice2);
            this.orderSummaryGroupBox.Controls.Add(this.lblQuantity1);
            this.orderSummaryGroupBox.Controls.Add(this.lblProductName1);
            this.orderSummaryGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSummaryGroupBox.Location = new System.Drawing.Point(25, 75);
            this.orderSummaryGroupBox.Name = "orderSummaryGroupBox";
            this.orderSummaryGroupBox.Size = new System.Drawing.Size(450, 200);
            this.orderSummaryGroupBox.TabIndex = 10;
            this.orderSummaryGroupBox.TabStop = false;
            this.orderSummaryGroupBox.Text = "Summary";
            // 
            // ctrlOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderSummaryGroupBox);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblTitle);
            this.Name = "ctrlOrderControl";
            this.Size = new System.Drawing.Size(501, 480);
            this.orderSummaryGroupBox.ResumeLayout(false);
            this.orderSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductName1;
        private System.Windows.Forms.Label lblQuantity1;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblTotal3;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox orderSummaryGroupBox;
    }
}