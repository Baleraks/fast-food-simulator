namespace DesktopApp
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbCustomerTimeInterval = new System.Windows.Forms.TextBox();
            this.tbCookTimeInterval = new System.Windows.Forms.TextBox();
            this.lbCustomerTimeInterval = new System.Windows.Forms.Label();
            this.lbCookTimeInterval = new System.Windows.Forms.Label();
            this.gbOrderLine = new System.Windows.Forms.GroupBox();
            this.lbCustomersOutput = new System.Windows.Forms.Label();
            this.lbNumberOfCustomers = new System.Windows.Forms.Label();
            this.gbKitchen = new System.Windows.Forms.GroupBox();
            this.lbPrepOrderOutput = new System.Windows.Forms.Label();
            this.lbReadyToCookOutput = new System.Windows.Forms.Label();
            this.lbReadyToCook = new System.Windows.Forms.Label();
            this.lbPrepOrders = new System.Windows.Forms.Label();
            this.gbOrderArea = new System.Windows.Forms.GroupBox();
            this.lbOrderOutput = new System.Windows.Forms.Label();
            this.lbOrdersToCook = new System.Windows.Forms.Label();
            this.gbPickUp = new System.Windows.Forms.GroupBox();
            this.lbWaitingCustomersOutput = new System.Windows.Forms.Label();
            this.lbAvailableOrderOutput = new System.Windows.Forms.Label();
            this.lbWaitingCustomers = new System.Windows.Forms.Label();
            this.lbAvailableOrders = new System.Windows.Forms.Label();
            this.gbOrderLine.SuspendLayout();
            this.gbKitchen.SuspendLayout();
            this.gbOrderArea.SuspendLayout();
            this.gbPickUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 553);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(106, 553);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 31);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbCustomerTimeInterval
            // 
            this.tbCustomerTimeInterval.Location = new System.Drawing.Point(182, 17);
            this.tbCustomerTimeInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCustomerTimeInterval.Name = "tbCustomerTimeInterval";
            this.tbCustomerTimeInterval.Size = new System.Drawing.Size(114, 27);
            this.tbCustomerTimeInterval.TabIndex = 2;
            // 
            // tbCookTimeInterval
            // 
            this.tbCookTimeInterval.Location = new System.Drawing.Point(182, 56);
            this.tbCookTimeInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCookTimeInterval.Name = "tbCookTimeInterval";
            this.tbCookTimeInterval.Size = new System.Drawing.Size(114, 27);
            this.tbCookTimeInterval.TabIndex = 3;
            // 
            // lbCustomerTimeInterval
            // 
            this.lbCustomerTimeInterval.AutoSize = true;
            this.lbCustomerTimeInterval.Location = new System.Drawing.Point(14, 20);
            this.lbCustomerTimeInterval.Name = "lbCustomerTimeInterval";
            this.lbCustomerTimeInterval.Size = new System.Drawing.Size(162, 20);
            this.lbCustomerTimeInterval.TabIndex = 4;
            this.lbCustomerTimeInterval.Text = "Customer time interval:";
            // 
            // lbCookTimeInterval
            // 
            this.lbCookTimeInterval.AutoSize = true;
            this.lbCookTimeInterval.Location = new System.Drawing.Point(14, 59);
            this.lbCookTimeInterval.Name = "lbCookTimeInterval";
            this.lbCookTimeInterval.Size = new System.Drawing.Size(133, 20);
            this.lbCookTimeInterval.TabIndex = 5;
            this.lbCookTimeInterval.Text = "Cook time interval:";
            // 
            // gbOrderLine
            // 
            this.gbOrderLine.Controls.Add(this.lbCustomersOutput);
            this.gbOrderLine.Controls.Add(this.lbNumberOfCustomers);
            this.gbOrderLine.Location = new System.Drawing.Point(330, 12);
            this.gbOrderLine.Name = "gbOrderLine";
            this.gbOrderLine.Size = new System.Drawing.Size(215, 149);
            this.gbOrderLine.TabIndex = 6;
            this.gbOrderLine.TabStop = false;
            this.gbOrderLine.Text = "OrderLine";
            // 
            // lbCustomersOutput
            // 
            this.lbCustomersOutput.AutoSize = true;
            this.lbCustomersOutput.Location = new System.Drawing.Point(0, 43);
            this.lbCustomersOutput.Name = "lbCustomersOutput";
            this.lbCustomersOutput.Size = new System.Drawing.Size(0, 20);
            this.lbCustomersOutput.TabIndex = 9;
            // 
            // lbNumberOfCustomers
            // 
            this.lbNumberOfCustomers.AutoSize = true;
            this.lbNumberOfCustomers.Location = new System.Drawing.Point(0, 23);
            this.lbNumberOfCustomers.Name = "lbNumberOfCustomers";
            this.lbNumberOfCustomers.Size = new System.Drawing.Size(155, 20);
            this.lbNumberOfCustomers.TabIndex = 0;
            this.lbNumberOfCustomers.Text = "Number of customers:";
            // 
            // gbKitchen
            // 
            this.gbKitchen.Controls.Add(this.lbPrepOrderOutput);
            this.gbKitchen.Controls.Add(this.lbReadyToCookOutput);
            this.gbKitchen.Controls.Add(this.lbReadyToCook);
            this.gbKitchen.Controls.Add(this.lbPrepOrders);
            this.gbKitchen.Location = new System.Drawing.Point(330, 167);
            this.gbKitchen.Name = "gbKitchen";
            this.gbKitchen.Size = new System.Drawing.Size(215, 171);
            this.gbKitchen.TabIndex = 7;
            this.gbKitchen.TabStop = false;
            this.gbKitchen.Text = "Kitchen";
            // 
            // lbPrepOrderOutput
            // 
            this.lbPrepOrderOutput.AutoSize = true;
            this.lbPrepOrderOutput.Location = new System.Drawing.Point(0, 43);
            this.lbPrepOrderOutput.Name = "lbPrepOrderOutput";
            this.lbPrepOrderOutput.Size = new System.Drawing.Size(0, 20);
            this.lbPrepOrderOutput.TabIndex = 11;
            // 
            // lbReadyToCookOutput
            // 
            this.lbReadyToCookOutput.AutoSize = true;
            this.lbReadyToCookOutput.Location = new System.Drawing.Point(0, 111);
            this.lbReadyToCookOutput.Name = "lbReadyToCookOutput";
            this.lbReadyToCookOutput.Size = new System.Drawing.Size(0, 20);
            this.lbReadyToCookOutput.TabIndex = 13;
            // 
            // lbReadyToCook
            // 
            this.lbReadyToCook.AutoSize = true;
            this.lbReadyToCook.Location = new System.Drawing.Point(0, 91);
            this.lbReadyToCook.Name = "lbReadyToCook";
            this.lbReadyToCook.Size = new System.Drawing.Size(210, 20);
            this.lbReadyToCook.TabIndex = 1;
            this.lbReadyToCook.Text = "Count of orders ready to cook:";
            // 
            // lbPrepOrders
            // 
            this.lbPrepOrders.AutoSize = true;
            this.lbPrepOrders.Location = new System.Drawing.Point(0, 23);
            this.lbPrepOrders.Name = "lbPrepOrders";
            this.lbPrepOrders.Size = new System.Drawing.Size(159, 20);
            this.lbPrepOrders.TabIndex = 2;
            this.lbPrepOrders.Text = "Orders been prepaired";
            // 
            // gbOrderArea
            // 
            this.gbOrderArea.Controls.Add(this.lbOrderOutput);
            this.gbOrderArea.Controls.Add(this.lbOrdersToCook);
            this.gbOrderArea.Location = new System.Drawing.Point(566, 12);
            this.gbOrderArea.Name = "gbOrderArea";
            this.gbOrderArea.Size = new System.Drawing.Size(217, 149);
            this.gbOrderArea.TabIndex = 8;
            this.gbOrderArea.TabStop = false;
            this.gbOrderArea.Text = "OrderArea";
            // 
            // lbOrderOutput
            // 
            this.lbOrderOutput.AutoSize = true;
            this.lbOrderOutput.Location = new System.Drawing.Point(0, 43);
            this.lbOrderOutput.Name = "lbOrderOutput";
            this.lbOrderOutput.Size = new System.Drawing.Size(0, 20);
            this.lbOrderOutput.TabIndex = 10;
            // 
            // lbOrdersToCook
            // 
            this.lbOrdersToCook.AutoSize = true;
            this.lbOrdersToCook.Location = new System.Drawing.Point(0, 23);
            this.lbOrdersToCook.Name = "lbOrdersToCook";
            this.lbOrdersToCook.Size = new System.Drawing.Size(184, 20);
            this.lbOrdersToCook.TabIndex = 1;
            this.lbOrdersToCook.Text = "Number of orders to cook:";
            // 
            // gbPickUp
            // 
            this.gbPickUp.Controls.Add(this.lbWaitingCustomersOutput);
            this.gbPickUp.Controls.Add(this.lbAvailableOrderOutput);
            this.gbPickUp.Controls.Add(this.lbWaitingCustomers);
            this.gbPickUp.Controls.Add(this.lbAvailableOrders);
            this.gbPickUp.Location = new System.Drawing.Point(566, 167);
            this.gbPickUp.Name = "gbPickUp";
            this.gbPickUp.Size = new System.Drawing.Size(217, 171);
            this.gbPickUp.TabIndex = 0;
            this.gbPickUp.TabStop = false;
            this.gbPickUp.Text = "PickUp";
            // 
            // lbWaitingCustomersOutput
            // 
            this.lbWaitingCustomersOutput.AutoSize = true;
            this.lbWaitingCustomersOutput.Location = new System.Drawing.Point(0, 111);
            this.lbWaitingCustomersOutput.Name = "lbWaitingCustomersOutput";
            this.lbWaitingCustomersOutput.Size = new System.Drawing.Size(0, 20);
            this.lbWaitingCustomersOutput.TabIndex = 14;
            // 
            // lbAvailableOrderOutput
            // 
            this.lbAvailableOrderOutput.AutoSize = true;
            this.lbAvailableOrderOutput.Location = new System.Drawing.Point(0, 43);
            this.lbAvailableOrderOutput.Name = "lbAvailableOrderOutput";
            this.lbAvailableOrderOutput.Size = new System.Drawing.Size(0, 20);
            this.lbAvailableOrderOutput.TabIndex = 12;
            // 
            // lbWaitingCustomers
            // 
            this.lbWaitingCustomers.AutoSize = true;
            this.lbWaitingCustomers.Location = new System.Drawing.Point(0, 91);
            this.lbWaitingCustomers.Name = "lbWaitingCustomers";
            this.lbWaitingCustomers.Size = new System.Drawing.Size(208, 20);
            this.lbWaitingCustomers.TabIndex = 3;
            this.lbWaitingCustomers.Text = "Number of waiting customers:";
            // 
            // lbAvailableOrders
            // 
            this.lbAvailableOrders.AutoSize = true;
            this.lbAvailableOrders.Location = new System.Drawing.Point(0, 23);
            this.lbAvailableOrders.Name = "lbAvailableOrders";
            this.lbAvailableOrders.Size = new System.Drawing.Size(139, 20);
            this.lbAvailableOrders.TabIndex = 3;
            this.lbAvailableOrders.Text = " Currently available:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.gbPickUp);
            this.Controls.Add(this.gbOrderArea);
            this.Controls.Add(this.gbKitchen);
            this.Controls.Add(this.gbOrderLine);
            this.Controls.Add(this.lbCookTimeInterval);
            this.Controls.Add(this.lbCustomerTimeInterval);
            this.Controls.Add(this.tbCookTimeInterval);
            this.Controls.Add(this.tbCustomerTimeInterval);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbOrderLine.ResumeLayout(false);
            this.gbOrderLine.PerformLayout();
            this.gbKitchen.ResumeLayout(false);
            this.gbKitchen.PerformLayout();
            this.gbOrderArea.ResumeLayout(false);
            this.gbOrderArea.PerformLayout();
            this.gbPickUp.ResumeLayout(false);
            this.gbPickUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private TextBox tbCustomerTimeInterval;
        private TextBox tbCookTimeInterval;
        private Label lbCustomerTimeInterval;
        private Label lbCookTimeInterval;
        private GroupBox gbOrderLine;
        private GroupBox gbKitchen;
        private GroupBox gbOrderArea;
        private Label lbCustomersOutput;
        private Label lbNumberOfCustomers;
        private Label lbPrepOrderOutput;
        private Label lbReadyToCookOutput;
        private Label lbReadyToCook;
        private Label lbPrepOrders;
        private Label lbOrderOutput;
        private Label lbOrdersToCook;
        private GroupBox gbPickUp;
        private Label lbWaitingCustomersOutput;
        private Label lbAvailableOrderOutput;
        private Label lbWaitingCustomers;
        private Label lbAvailableOrders;
    }
}