namespace CourseProjectWF
{
    partial class newItemForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newItemName = new System.Windows.Forms.TextBox();
            this.newItemPrice = new System.Windows.Forms.TextBox();
            this.newItemOnStock = new System.Windows.Forms.TextBox();
            this.newItemConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "On Stock";
            // 
            // newItemName
            // 
            this.newItemName.Location = new System.Drawing.Point(227, 80);
            this.newItemName.Name = "newItemName";
            this.newItemName.Size = new System.Drawing.Size(100, 22);
            this.newItemName.TabIndex = 4;
            // 
            // newItemPrice
            // 
            this.newItemPrice.Location = new System.Drawing.Point(227, 142);
            this.newItemPrice.Name = "newItemPrice";
            this.newItemPrice.Size = new System.Drawing.Size(100, 22);
            this.newItemPrice.TabIndex = 5;
            // 
            // newItemOnStock
            // 
            this.newItemOnStock.Location = new System.Drawing.Point(227, 203);
            this.newItemOnStock.Name = "newItemOnStock";
            this.newItemOnStock.Size = new System.Drawing.Size(100, 22);
            this.newItemOnStock.TabIndex = 6;
            // 
            // newItemConfirmButton
            // 
            this.newItemConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newItemConfirmButton.Location = new System.Drawing.Point(128, 277);
            this.newItemConfirmButton.Name = "newItemConfirmButton";
            this.newItemConfirmButton.Size = new System.Drawing.Size(96, 41);
            this.newItemConfirmButton.TabIndex = 7;
            this.newItemConfirmButton.Text = "Confirm";
            this.newItemConfirmButton.UseVisualStyleBackColor = true;
            this.newItemConfirmButton.Click += new System.EventHandler(this.newItemConfirmButton_Click);
            // 
            // newItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(381, 354);
            this.Controls.Add(this.newItemConfirmButton);
            this.Controls.Add(this.newItemOnStock);
            this.Controls.Add(this.newItemPrice);
            this.Controls.Add(this.newItemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newItemForm";
            this.Text = "New Item";
            this.Load += new System.EventHandler(this.newItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newItemName;
        private System.Windows.Forms.TextBox newItemPrice;
        private System.Windows.Forms.TextBox newItemOnStock;
        private System.Windows.Forms.Button newItemConfirmButton;
    }
}