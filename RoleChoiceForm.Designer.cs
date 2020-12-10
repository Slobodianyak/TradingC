namespace CourseProjectWF
{
    partial class RoleChoiceForm
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
            this.ShipperWelcomeLink = new System.Windows.Forms.LinkLabel();
            this.CustomerWelcomeLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Continue as";
            // 
            // ShipperWelcomeLink
            // 
            this.ShipperWelcomeLink.AutoSize = true;
            this.ShipperWelcomeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipperWelcomeLink.Location = new System.Drawing.Point(113, 103);
            this.ShipperWelcomeLink.Name = "ShipperWelcomeLink";
            this.ShipperWelcomeLink.Size = new System.Drawing.Size(105, 29);
            this.ShipperWelcomeLink.TabIndex = 1;
            this.ShipperWelcomeLink.TabStop = true;
            this.ShipperWelcomeLink.Text = "Shipper";
            this.ShipperWelcomeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShipperWelcomeLink_LinkClicked);
            // 
            // CustomerWelcomeLink
            // 
            this.CustomerWelcomeLink.AutoSize = true;
            this.CustomerWelcomeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerWelcomeLink.Location = new System.Drawing.Point(102, 165);
            this.CustomerWelcomeLink.Name = "CustomerWelcomeLink";
            this.CustomerWelcomeLink.Size = new System.Drawing.Size(125, 29);
            this.CustomerWelcomeLink.TabIndex = 2;
            this.CustomerWelcomeLink.TabStop = true;
            this.CustomerWelcomeLink.Text = "Customer";
            this.CustomerWelcomeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustomerWelcomeLink_LinkClicked);
            // 
            // RoleChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 257);
            this.Controls.Add(this.CustomerWelcomeLink);
            this.Controls.Add(this.ShipperWelcomeLink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RoleChoiceForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.RoleChoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ShipperWelcomeLink;
        private System.Windows.Forms.LinkLabel CustomerWelcomeLink;
    }
}