namespace CourseProjectWF
{
    partial class order_managerMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_managerMenuForm));
            this.TableChoiceBox = new System.Windows.Forms.GroupBox();
            this.ItemsBox = new System.Windows.Forms.RadioButton();
            this.OrdersBox = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPanel = new System.Windows.Forms.GroupBox();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.RejectOrderButton = new System.Windows.Forms.Button();
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.orderIDBoxComplete = new System.Windows.Forms.TextBox();
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.updateItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ItemIDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNamecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPricecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnStockcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchItemButton = new System.Windows.Forms.Button();
            this.TableChoiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.OrderPanel.SuspendLayout();
            this.ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TableChoiceBox
            // 
            this.TableChoiceBox.Controls.Add(this.ItemsBox);
            this.TableChoiceBox.Controls.Add(this.OrdersBox);
            resources.ApplyResources(this.TableChoiceBox, "TableChoiceBox");
            this.TableChoiceBox.Name = "TableChoiceBox";
            this.TableChoiceBox.TabStop = false;
            this.TableChoiceBox.Enter += new System.EventHandler(this.TableChoiceBox_Enter);
            // 
            // ItemsBox
            // 
            resources.ApplyResources(this.ItemsBox, "ItemsBox");
            this.ItemsBox.Name = "ItemsBox";
            this.ItemsBox.UseVisualStyleBackColor = true;
            this.ItemsBox.CheckedChanged += new System.EventHandler(this.ItemsBox_CheckedChanged);
            // 
            // OrdersBox
            // 
            resources.ApplyResources(this.OrdersBox, "OrdersBox");
            this.OrdersBox.Checked = true;
            this.OrdersBox.Name = "OrdersBox";
            this.OrdersBox.TabStop = true;
            this.OrdersBox.UseVisualStyleBackColor = true;
            this.OrdersBox.CheckedChanged += new System.EventHandler(this.OrdersBox_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.SearchOrderButton);
            this.OrderPanel.Controls.Add(this.orderIdLabel);
            this.OrderPanel.Controls.Add(this.RejectOrderButton);
            this.OrderPanel.Controls.Add(this.CompleteOrderButton);
            this.OrderPanel.Controls.Add(this.label14);
            this.OrderPanel.Controls.Add(this.orderIDBoxComplete);
            resources.ApplyResources(this.OrderPanel, "OrderPanel");
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.TabStop = false;
            this.OrderPanel.Enter += new System.EventHandler(this.OrderPanel_Enter);
            // 
            // orderIdLabel
            // 
            resources.ApplyResources(this.orderIdLabel, "orderIdLabel");
            this.orderIdLabel.Name = "orderIdLabel";
            // 
            // RejectOrderButton
            // 
            resources.ApplyResources(this.RejectOrderButton, "RejectOrderButton");
            this.RejectOrderButton.Name = "RejectOrderButton";
            this.RejectOrderButton.UseVisualStyleBackColor = true;
            this.RejectOrderButton.Click += new System.EventHandler(this.RejectOrderButton_Click);
            // 
            // CompleteOrderButton
            // 
            resources.ApplyResources(this.CompleteOrderButton, "CompleteOrderButton");
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.UseVisualStyleBackColor = true;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // orderIDBoxComplete
            // 
            resources.ApplyResources(this.orderIDBoxComplete, "orderIDBoxComplete");
            this.orderIDBoxComplete.Name = "orderIDBoxComplete";
            // 
            // ItemPanel
            // 
            this.ItemPanel.Controls.Add(this.SearchItemButton);
            this.ItemPanel.Controls.Add(this.label7);
            this.ItemPanel.Controls.Add(this.label6);
            this.ItemPanel.Controls.Add(this.label5);
            this.ItemPanel.Controls.Add(this.label4);
            this.ItemPanel.Controls.Add(this.label3);
            this.ItemPanel.Controls.Add(this.removeItemButton);
            this.ItemPanel.Controls.Add(this.updateItemButton);
            this.ItemPanel.Controls.Add(this.label1);
            this.ItemPanel.Controls.Add(this.textBox5);
            this.ItemPanel.Controls.Add(this.textBox4);
            this.ItemPanel.Controls.Add(this.textBox3);
            this.ItemPanel.Controls.Add(this.textBox2);
            this.ItemPanel.Controls.Add(this.textBox1);
            resources.ApplyResources(this.ItemPanel, "ItemPanel");
            this.ItemPanel.Name = "ItemPanel";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // removeItemButton
            // 
            resources.ApplyResources(this.removeItemButton, "removeItemButton");
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateItemButton
            // 
            resources.ApplyResources(this.updateItemButton, "updateItemButton");
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.UseVisualStyleBackColor = true;
            this.updateItemButton.Click += new System.EventHandler(this.updateItemButton_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // addItemButton
            // 
            resources.ApplyResources(this.addItemButton, "addItemButton");
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDcol,
            this.ItemNamecol,
            this.ItemPricecol,
            this.OnStockcol});
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ItemIDcol
            // 
            resources.ApplyResources(this.ItemIDcol, "ItemIDcol");
            this.ItemIDcol.Name = "ItemIDcol";
            // 
            // ItemNamecol
            // 
            resources.ApplyResources(this.ItemNamecol, "ItemNamecol");
            this.ItemNamecol.Name = "ItemNamecol";
            // 
            // ItemPricecol
            // 
            resources.ApplyResources(this.ItemPricecol, "ItemPricecol");
            this.ItemPricecol.Name = "ItemPricecol";
            // 
            // OnStockcol
            // 
            resources.ApplyResources(this.OnStockcol, "OnStockcol");
            this.OnStockcol.Name = "OnStockcol";
            // 
            // SearchOrderButton
            // 
            resources.ApplyResources(this.SearchOrderButton, "SearchOrderButton");
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.UseVisualStyleBackColor = true;
            this.SearchOrderButton.Click += new System.EventHandler(this.SearchOrderButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchItemButton
            // 
            resources.ApplyResources(this.SearchItemButton, "SearchItemButton");
            this.SearchItemButton.Name = "SearchItemButton";
            this.SearchItemButton.UseVisualStyleBackColor = true;
            this.SearchItemButton.Click += new System.EventHandler(this.SearchItemButton_Click);
            // 
            // order_managerMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.TableChoiceBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.OrderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "order_managerMenuForm";
            this.Load += new System.EventHandler(this.order_managerMenuForm_Load);
            this.TableChoiceBox.ResumeLayout(false);
            this.TableChoiceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ItemPanel.ResumeLayout(false);
            this.ItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       // private order_managerDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.GroupBox TableChoiceBox;
        private System.Windows.Forms.RadioButton ItemsBox;
        private System.Windows.Forms.RadioButton OrdersBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox OrderPanel;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Button RejectOrderButton;
        private System.Windows.Forms.Button CompleteOrderButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox orderIDBoxComplete;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button updateItemButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNamecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPricecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnStockcol;
        private System.Windows.Forms.Button SearchOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchItemButton;
    }
}