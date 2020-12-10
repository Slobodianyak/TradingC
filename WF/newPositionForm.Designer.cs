namespace CourseProjectWF
{
    partial class newPositionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.AmountOrder = new System.Windows.Forms.TextBox();
            this.ItemIDOrder = new System.Windows.Forms.TextBox();
            this.newPositionButton = new System.Windows.Forms.Button();
            this.FinishOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(86, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Position";
            // 
            // AmountOrder
            // 
            this.AmountOrder.Location = new System.Drawing.Point(129, 61);
            this.AmountOrder.Name = "AmountOrder";
            this.AmountOrder.Size = new System.Drawing.Size(110, 22);
            this.AmountOrder.TabIndex = 10;
            // 
            // ItemIDOrder
            // 
            this.ItemIDOrder.Location = new System.Drawing.Point(14, 61);
            this.ItemIDOrder.Name = "ItemIDOrder";
            this.ItemIDOrder.Size = new System.Drawing.Size(103, 22);
            this.ItemIDOrder.TabIndex = 9;
            // 
            // newPositionButton
            // 
            this.newPositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPositionButton.Location = new System.Drawing.Point(12, 99);
            this.newPositionButton.Name = "newPositionButton";
            this.newPositionButton.Size = new System.Drawing.Size(227, 27);
            this.newPositionButton.TabIndex = 8;
            this.newPositionButton.Text = "Add Position";
            this.newPositionButton.UseVisualStyleBackColor = true;
            this.newPositionButton.Click += new System.EventHandler(this.newPositionButton_Click);
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishOrderButton.Location = new System.Drawing.Point(14, 132);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Size = new System.Drawing.Size(225, 26);
            this.FinishOrderButton.TabIndex = 12;
            this.FinishOrderButton.Text = "Finish";
            this.FinishOrderButton.UseVisualStyleBackColor = true;
            this.FinishOrderButton.Click += new System.EventHandler(this.FinishOrderButton_Click);
            // 
            // newPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 186);
            this.Controls.Add(this.FinishOrderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountOrder);
            this.Controls.Add(this.ItemIDOrder);
            this.Controls.Add(this.newPositionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "newPositionForm";
            this.Text = "newPositionForm";
            this.Load += new System.EventHandler(this.newPositionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountOrder;
        private System.Windows.Forms.TextBox ItemIDOrder;
        private System.Windows.Forms.Button newPositionButton;
        private System.Windows.Forms.Button FinishOrderButton;
    }
}