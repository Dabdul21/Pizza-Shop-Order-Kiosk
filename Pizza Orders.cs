namespace Assignment02___Pizza_Shop
{
    public partial class frmPizzaOrders : Form
    {
        //variables needed
        private int pizzaOrders = 0;
        private int pickupOrders = 0;
        private int deliveryOrders = 0;
        private decimal totalSales = 0m;
        public frmPizzaOrders()
        {
            InitializeComponent();
            LoadFormData(); 
        }

        private void tolButtons_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { // Toolbar control was clicked so based upon the button
          // that was clicked execute the correct method.

            switch (e.ClickedItem.Name)  //use name of Toolbar button to
            {                          //determine which button was clicked
                case "tolbtnSubmit":
                    Perform_Calculations();
                    break;
                case "tolbtnCancel":
                    Cancel_Order();
                    break;
                case "tolbtnExit":
                    Exit_Application();
                    break;

            }
        }

        private void LoadFormData()
        {
            // crust Styles ListBox
            lstCrustStyles.Items.Add("Deep Dish (2.00)");
            lstCrustStyles.Items.Add("Hand-Tossed Round (1.50)");
            lstCrustStyles.Items.Add("Thin (1.35)");
            lstCrustStyles.Items.Add("NY Style (1.50)");
            lstCrustStyles.Items.Add("Seasoned Cauliflower (3.00)");
            lstCrustStyles.Items.Add("Gluten-Free (5.00)");

            // pizza Size ListBox
            lstPizzaSize.Items.Add("Small (9.00)");
            lstPizzaSize.Items.Add("Medium (15.00)");
            lstPizzaSize.Items.Add("Large (20.00)");
            lstPizzaSize.Items.Add("Party-Size (30.00)");

            // first item in both ListBoxes
            lstCrustStyles.SelectedIndex = 0;
            lstPizzaSize.SelectedIndex = 0;

            // checked options for radio buttons
            rdoPickUp.Checked = true;
            rdoMozzarella.Checked = true;
        }

        private void rdoPickUp_Click(object sender, EventArgs e)
        {
            //hide phone number and text
            lblPhoneCaption.Visible = false;
            txtPhoneNumber.Visible = false;
            //hide streetlabel and text 
            lblStreetCaption.Visible = false;
            txtStreetAddress.Visible = false;
        }

        private void rdoDelivery_Click(object sender, EventArgs e)
        {
            //show phone number and text
            lblPhoneCaption.Visible = false;
            txtPhoneNumber.Visible = false;
            //show streetlabel and text 
            lblStreetCaption.Visible = false;
            txtStreetAddress.Visible = false;
        }
        private void Perform_Calculations()
        { // when user clicks Calculate toolbar button then
          // this method should be called

        }


        private void Cancel_Order()
        {
            // when user clicks Clear toolbar button then
            // this method should be called
            // Clears all text fields and resets form controls
            foreach (Control parent in this.Controls)
            {
                foreach (Control control in parent.Controls)
                {
                    // Clear all TextBox controls except txtPizzaOrders
                    if (control is TextBox textBox && textBox.Name != "txtPizzaOrders")
                    {
                        textBox.Clear();
                    }

                    // Uncheck all CheckBox controls
                    if (control is CheckBox checkBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }

            // reset Listbox selection
            lstCrustStyles.SelectedIndex = 0;
            lstPizzaSize.SelectedIndex = 0;

            // reset radio button selection
            rdoPickUp.Checked = true;
            rdoMozzarella.Checked = true;
            
         
            ////added message to show its been canceled 
            //MessageBox.Show("Order has been canceled!");
        }

        private void Exit_Application()

        {
            Application.Exit();
            // when user clicks Exit toolbar button then
            // this method should be called


        }

      
    }
}
