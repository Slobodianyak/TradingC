namespace CourseProjectWF
{
    partial class LoginCustomerForm
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
            this.customerPasswordText = new System.Windows.Forms.TextBox();
            this.customerLoginText = new System.Windows.Forms.TextBox();
            this.customerLoginButton = new System.Windows.Forms.Button();
            this.customerSignUpFormLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // customerPasswordText
            // 
            this.customerPasswordText.Location = new System.Drawing.Point(239, 117);
            this.customerPasswordText.Name = "customerPasswordText";
            this.customerPasswordText.Size = new System.Drawing.Size(133, 22);
            this.customerPasswordText.TabIndex = 2;
            // 
            // customerLoginText
            // 
            this.customerLoginText.Location = new System.Drawing.Point(239, 55);
            this.customerLoginText.Name = "customerLoginText";
            this.customerLoginText.Size = new System.Drawing.Size(133, 22);
            this.customerLoginText.TabIndex = 3;
            // 
            // customerLoginButton
            // 
            this.customerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLoginButton.Location = new System.Drawing.Point(132, 164);
            this.customerLoginButton.Name = "customerLoginButton";
            this.customerLoginButton.Size = new System.Drawing.Size(122, 52);
            this.customerLoginButton.TabIndex = 4;
            this.customerLoginButton.Text = "Login";
            this.customerLoginButton.UseVisualStyleBackColor = true;
            this.customerLoginButton.Click += new System.EventHandler(this.customerLoginButton_Click);
            // 
            // customerSignUpFormLink
            // 
            this.customerSignUpFormLink.AutoSize = true;
            this.customerSignUpFormLink.Location = new System.Drawing.Point(111, 235);
            this.customerSignUpFormLink.Name = "customerSignUpFormLink";
            this.customerSignUpFormLink.Size = new System.Drawing.Size(158, 17);
            this.customerSignUpFormLink.TabIndex = 5;
            this.customerSignUpFormLink.TabStop = true;
            this.customerSignUpFormLink.Text = "Don\'t have an account?";
            this.customerSignUpFormLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerSignUpFormLink_LinkClicked);
            // 
            // LoginCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 272);
            this.Controls.Add(this.customerSignUpFormLink);
            this.Controls.Add(this.customerLoginButton);
            this.Controls.Add(this.customerLoginText);
            this.Controls.Add(this.customerPasswordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginCustomerForm";
            this.Text = "Login as Customer";
            this.Load += new System.EventHandler(this.LoginCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerPasswordText;
        private System.Windows.Forms.TextBox customerLoginText;
        private System.Windows.Forms.Button customerLoginButton;
        private System.Windows.Forms.LinkLabel customerSignUpFormLink;
    }
}