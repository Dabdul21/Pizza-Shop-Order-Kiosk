﻿namespace Assignment02___Pizza_Shop
{
    partial class frmPizzaOrders
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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            lblPhoneCaption = new Label();
            txtPhoneNumber = new TextBox();
            rdoDelivery = new RadioButton();
            rdoPickUp = new RadioButton();
            lblStreetCaption = new Label();
            txtStreetAddress = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            lstCrustStyles = new ListBox();
            groupBox3 = new GroupBox();
            rdoNoCheese = new RadioButton();
            rdoMozzarella = new RadioButton();
            chkGreenPeppers = new CheckBox();
            chkMushrooms = new CheckBox();
            chkOnions = new CheckBox();
            chkSausage = new CheckBox();
            chkHam = new CheckBox();
            chkPepperoni = new CheckBox();
            groupBox2 = new GroupBox();
            lstPizzaSize = new ListBox();
            label4 = new Label();
            txtPizzaOrders = new TextBox();
            tolButtons = new ToolStrip();
            tolbtnSubmit = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tolbtnCancel = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tolbtnExit = new ToolStripButton();
            lblErrorMessage = new ToolStripLabel();
            stsOrderSummary = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblPizzaCount = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblPickupCount = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            lblDeliveryCount = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            lblTotalPizzaSalesWithTax = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tolButtons.SuspendLayout();
            stsOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Location = new Point(20, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblPhoneCaption);
            groupBox4.Controls.Add(txtPhoneNumber);
            groupBox4.Controls.Add(rdoDelivery);
            groupBox4.Controls.Add(rdoPickUp);
            groupBox4.Controls.Add(lblStreetCaption);
            groupBox4.Controls.Add(txtStreetAddress);
            groupBox4.Location = new Point(6, 112);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(327, 170);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Order Type";
            // 
            // lblPhoneCaption
            // 
            lblPhoneCaption.AutoSize = true;
            lblPhoneCaption.Location = new Point(0, 124);
            lblPhoneCaption.Name = "lblPhoneCaption";
            lblPhoneCaption.Size = new Size(82, 21);
            lblPhoneCaption.TabIndex = 4;
            lblPhoneCaption.Text = "&Phone no.:";
            lblPhoneCaption.Visible = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(87, 121);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(226, 29);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.Visible = false;
            // 
            // rdoDelivery
            // 
            rdoDelivery.AutoSize = true;
            rdoDelivery.Location = new Point(214, 28);
            rdoDelivery.Name = "rdoDelivery";
            rdoDelivery.Size = new Size(85, 25);
            rdoDelivery.TabIndex = 1;
            rdoDelivery.Text = "&Delivery";
            rdoDelivery.UseVisualStyleBackColor = true;
            // 
            // rdoPickUp
            // 
            rdoPickUp.AutoSize = true;
            rdoPickUp.Location = new Point(117, 27);
            rdoPickUp.Name = "rdoPickUp";
            rdoPickUp.Size = new Size(80, 25);
            rdoPickUp.TabIndex = 0;
            rdoPickUp.Text = "Pick-&up";
            rdoPickUp.UseVisualStyleBackColor = true;
            // 
            // lblStreetCaption
            // 
            lblStreetCaption.AutoSize = true;
            lblStreetCaption.Location = new Point(6, 76);
            lblStreetCaption.Name = "lblStreetCaption";
            lblStreetCaption.Size = new Size(53, 21);
            lblStreetCaption.TabIndex = 2;
            lblStreetCaption.Text = "&Street:";
            lblStreetCaption.Visible = false;
            // 
            // txtStreetAddress
            // 
            txtStreetAddress.Location = new Point(87, 73);
            txtStreetAddress.Name = "txtStreetAddress";
            txtStreetAddress.Size = new Size(224, 29);
            txtStreetAddress.TabIndex = 3;
            txtStreetAddress.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 71);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 2;
            label2.Text = "&Last name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(130, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 29);
            txtLastName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 31);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "&First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(130, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 29);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 24);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 0;
            label3.Text = "&Crust Styles:";
            // 
            // lstCrustStyles
            // 
            lstCrustStyles.FormattingEnabled = true;
            lstCrustStyles.ItemHeight = 21;
            lstCrustStyles.Location = new Point(106, 28);
            lstCrustStyles.Name = "lstCrustStyles";
            lstCrustStyles.Size = new Size(242, 109);
            lstCrustStyles.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdoNoCheese);
            groupBox3.Controls.Add(rdoMozzarella);
            groupBox3.Controls.Add(chkGreenPeppers);
            groupBox3.Controls.Add(chkMushrooms);
            groupBox3.Controls.Add(chkOnions);
            groupBox3.Controls.Add(chkSausage);
            groupBox3.Controls.Add(chkHam);
            groupBox3.Controls.Add(chkPepperoni);
            groupBox3.Location = new Point(725, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 293);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Toppings";
            // 
            // rdoNoCheese
            // 
            rdoNoCheese.AutoSize = true;
            rdoNoCheese.Location = new Point(19, 55);
            rdoNoCheese.Name = "rdoNoCheese";
            rdoNoCheese.Size = new Size(100, 25);
            rdoNoCheese.TabIndex = 1;
            rdoNoCheese.Text = "N&o cheese";
            rdoNoCheese.UseVisualStyleBackColor = true;
            // 
            // rdoMozzarella
            // 
            rdoMozzarella.AutoSize = true;
            rdoMozzarella.Location = new Point(19, 24);
            rdoMozzarella.Name = "rdoMozzarella";
            rdoMozzarella.Size = new Size(189, 25);
            rdoMozzarella.TabIndex = 0;
            rdoMozzarella.Text = "Mo&zzarella cheese (.50)";
            rdoMozzarella.UseVisualStyleBackColor = true;
            // 
            // chkGreenPeppers
            // 
            chkGreenPeppers.AutoSize = true;
            chkGreenPeppers.Location = new Point(19, 258);
            chkGreenPeppers.Name = "chkGreenPeppers";
            chkGreenPeppers.Size = new Size(165, 25);
            chkGreenPeppers.TabIndex = 7;
            chkGreenPeppers.Text = "&Green Peppers (.60)";
            chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(19, 227);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(148, 25);
            chkMushrooms.TabIndex = 6;
            chkMushrooms.Text = "&Mushrooms (.65)";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            chkOnions.AutoSize = true;
            chkOnions.Location = new Point(19, 196);
            chkOnions.Name = "chkOnions";
            chkOnions.Size = new Size(114, 25);
            chkOnions.TabIndex = 5;
            chkOnions.Text = "&Onions (.65)";
            chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            chkSausage.AutoSize = true;
            chkSausage.Location = new Point(19, 163);
            chkSausage.Name = "chkSausage";
            chkSausage.Size = new Size(122, 25);
            chkSausage.TabIndex = 4;
            chkSausage.Text = "Sa&usage (.80)";
            chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            chkHam.AutoSize = true;
            chkHam.Location = new Point(19, 128);
            chkHam.Name = "chkHam";
            chkHam.Size = new Size(97, 25);
            chkHam.TabIndex = 3;
            chkHam.Text = "&Ham (.70)";
            chkHam.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(19, 91);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(134, 25);
            chkPepperoni.TabIndex = 2;
            chkPepperoni.Text = "Pepperon&i (.75)";
            chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstPizzaSize);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lstCrustStyles);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(365, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 293);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pizza Crust";
            // 
            // lstPizzaSize
            // 
            lstPizzaSize.FormattingEnabled = true;
            lstPizzaSize.ItemHeight = 21;
            lstPizzaSize.Location = new Point(106, 154);
            lstPizzaSize.Name = "lstPizzaSize";
            lstPizzaSize.Size = new Size(242, 109);
            lstPizzaSize.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 2;
            label4.Text = "Pizza si&ze:";
            // 
            // txtPizzaOrders
            // 
            txtPizzaOrders.Location = new Point(20, 327);
            txtPizzaOrders.Multiline = true;
            txtPizzaOrders.Name = "txtPizzaOrders";
            txtPizzaOrders.ReadOnly = true;
            txtPizzaOrders.ScrollBars = ScrollBars.Both;
            txtPizzaOrders.Size = new Size(922, 387);
            txtPizzaOrders.TabIndex = 3;
            // 
            // tolButtons
            // 
            tolButtons.Font = new Font("Segoe UI", 12F);
            tolButtons.Items.AddRange(new ToolStripItem[] { tolbtnSubmit, toolStripSeparator1, tolbtnCancel, toolStripSeparator2, tolbtnExit, lblErrorMessage });
            tolButtons.Location = new Point(0, 0);
            tolButtons.Name = "tolButtons";
            tolButtons.Size = new Size(947, 28);
            tolButtons.TabIndex = 5;
            tolButtons.Text = "toolStrip1";
            tolButtons.ItemClicked += tolButtons_ItemClicked;
            // 
            // tolbtnSubmit
            // 
            tolbtnSubmit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnSubmit.ImageTransparentColor = Color.Magenta;
            tolbtnSubmit.Name = "tolbtnSubmit";
            tolbtnSubmit.Size = new Size(109, 25);
            tolbtnSubmit.Text = "Submit Order";
            tolbtnSubmit.ToolTipText = "Submit Order";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // tolbtnCancel
            // 
            tolbtnCancel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnCancel.ImageTransparentColor = Color.Magenta;
            tolbtnCancel.Name = "tolbtnCancel";
            tolbtnCancel.Size = new Size(60, 25);
            tolbtnCancel.Text = "Cancel";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // tolbtnExit
            // 
            tolbtnExit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tolbtnExit.ImageTransparentColor = Color.Magenta;
            tolbtnExit.Name = "tolbtnExit";
            tolbtnExit.Size = new Size(38, 25);
            tolbtnExit.Text = "Exit";
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 25);
            // 
            // stsOrderSummary
            // 
            stsOrderSummary.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblPizzaCount, toolStripStatusLabel2, lblPickupCount, toolStripStatusLabel4, lblDeliveryCount, toolStripStatusLabel6, lblTotalPizzaSalesWithTax });
            stsOrderSummary.Location = new Point(0, 717);
            stsOrderSummary.Name = "stsOrderSummary";
            stsOrderSummary.Size = new Size(947, 22);
            stsOrderSummary.TabIndex = 4;
            stsOrderSummary.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(70, 17);
            toolStripStatusLabel1.Text = "Pizza count:";
            // 
            // lblPizzaCount
            // 
            lblPizzaCount.AutoSize = false;
            lblPizzaCount.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblPizzaCount.Name = "lblPizzaCount";
            lblPizzaCount.Size = new Size(50, 17);
            lblPizzaCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(114, 17);
            toolStripStatusLabel2.Text = "Total Pick-up Orders";
            // 
            // lblPickupCount
            // 
            lblPickupCount.AutoSize = false;
            lblPickupCount.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblPickupCount.Name = "lblPickupCount";
            lblPickupCount.Size = new Size(50, 17);
            lblPickupCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(115, 17);
            toolStripStatusLabel4.Text = "Total Delivery Orders";
            // 
            // lblDeliveryCount
            // 
            lblDeliveryCount.AutoSize = false;
            lblDeliveryCount.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblDeliveryCount.Name = "lblDeliveryCount";
            lblDeliveryCount.Size = new Size(50, 17);
            lblDeliveryCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(138, 17);
            toolStripStatusLabel6.Text = "Total Pizza Sales with tax:";
            // 
            // lblTotalPizzaSalesWithTax
            // 
            lblTotalPizzaSalesWithTax.AutoSize = false;
            lblTotalPizzaSalesWithTax.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            lblTotalPizzaSalesWithTax.Name = "lblTotalPizzaSalesWithTax";
            lblTotalPizzaSalesWithTax.Size = new Size(50, 17);
            lblTotalPizzaSalesWithTax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmPizzaOrders
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 739);
            ControlBox = false;
            Controls.Add(stsOrderSummary);
            Controls.Add(tolButtons);
            Controls.Add(txtPizzaOrders);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Name = "frmPizzaOrders";
            Text = "Pizza Orders";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tolButtons.ResumeLayout(false);
            tolButtons.PerformLayout();
            stsOrderSummary.ResumeLayout(false);
            stsOrderSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCrustStyles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPizzaOrders;
        private System.Windows.Forms.ToolStrip tolButtons;
        private System.Windows.Forms.ToolStripButton tolbtnSubmit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tolbtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tolbtnExit;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.ListBox lstPizzaSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip stsOrderSummary;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPizzaCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPhoneCaption;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.RadioButton rdoPickUp;
        private System.Windows.Forms.Label lblStreetCaption;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.RadioButton rdoNoCheese;
        private System.Windows.Forms.RadioButton rdoMozzarella;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.ToolStripStatusLabel lblPickupCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblDeliveryCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalPizzaSalesWithTax;
        private System.Windows.Forms.ToolStripLabel lblErrorMessage;
    }
}
