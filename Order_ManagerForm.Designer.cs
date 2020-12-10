namespace CourseProjectWF
{
    partial class Order_ManagerForm
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
            this.Order_ManagerLoginText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Order_ManagerSignUPFormLink = new System.Windows.Forms.LinkLabel();
            this.Order_ManagerLoginButton = new System.Windows.Forms.Button();
            this.Order_ManagerPasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Order_ManagerLoginText
            // 
            this.Order_ManagerLoginText.Location = new System.Drawing.Point(186, 73);
            this.Order_ManagerLoginText.Name = "Order_ManagerLoginText";
            this.Order_ManagerLoginText.Size = new System.Drawing.Size(154, 22);
            this.Order_ManagerLoginText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Order_ManagerSignUPFormLink
            // 
            this.Order_ManagerSignUPFormLink.AutoSize = true;
            this.Order_ManagerSignUPFormLink.Location = new System.Drawing.Point(103, 275);
            this.Order_ManagerSignUPFormLink.Name = "Order_ManagerSignUPFormLink";
            this.Order_ManagerSignUPFormLink.Size = new System.Drawing.Size(158, 17);
            this.Order_ManagerSignUPFormLink.TabIndex = 4;
            this.Order_ManagerSignUPFormLink.TabStop = true;
            this.Order_ManagerSignUPFormLink.Text = "Don\'t have an account?";
            this.Order_ManagerSignUPFormLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Order_ManagerLoginFormLink_LinkClicked);
            // 
            // Order_ManagerLoginButton
            // 
            this.Order_ManagerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_ManagerLoginButton.Location = new System.Drawing.Point(123, 182);
            this.Order_ManagerLoginButton.Name = "Order_ManagerLoginButton";
            this.Order_ManagerLoginButton.Size = new System.Drawing.Size(122, 49);
            this.Order_ManagerLoginButton.TabIndex = 5;
            this.Order_ManagerLoginButton.Text = "Login";
            this.Order_ManagerLoginButton.UseVisualStyleBackColor = true;
            this.Order_ManagerLoginButton.Click += new System.EventHandler(this.Order_ManagerLoginButton_Click);
            // 
            // Order_ManagerPasswordText
            // 
            this.Order_ManagerPasswordText.Location = new System.Drawing.Point(186, 135);
            this.Order_ManagerPasswordText.Name = "Order_ManagerPasswordText";
            this.Order_ManagerPasswordText.Size = new System.Drawing.Size(154, 22);
            this.Order_ManagerPasswordText.TabIndex = 6;
            this.Order_ManagerPasswordText.TextChanged += new System.EventHandler(this.Order_ManagerPasswordText_TextChanged);
            // 
            // LoginOrder_ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 314);
            this.Controls.Add(this.Order_ManagerPasswordText);
            this.Controls.Add(this.Order_ManagerLoginButton);
            this.Controls.Add(this.Order_ManagerSignUPFormLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Order_ManagerLoginText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginOrder_ManagerForm";
            this.Text = "Login as Order_Manager ";
            this.Load += new System.EventHandler(this.LoginOrder_ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Order_ManagerLoginText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Order_ManagerSignUPFormLink;
        private System.Windows.Forms.Button Order_ManagerLoginButton;
        private System.Windows.Forms.TextBox Order_ManagerPasswordText;
    }
}