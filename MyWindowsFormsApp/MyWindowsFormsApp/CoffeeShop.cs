using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class CoffeeShop : Form

    {
        int price = 0, index = 0;
        List<String> customerNames = new List<string>();
        List<string> contactNumbers = new List<string>();
        List<String> addresses = new List<String>();
        List<string> orders = new List<string>();
        List<int> queintityes = new List<int>();
        List<int> totalPrices = new List<int>();



        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Text = "";

            customerNameTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            
            showCustomer();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            string contactNumber = contactTextBox.Text;
            string address = addressTextBox.Text;
            string orderItem = orderComboBox.Text;
            string queintity = quantityTextBox.Text;


            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Please enter Quantity!");
                return;
            }

            
            int Amount = 0;

            if (orderComboBox.Text == "Black")
            {
                Amount = 120;
            }
            else if (orderComboBox.Text == "Cold")
            {
                Amount = 100;
            }
            else if (orderComboBox.Text == "Hot")
            {
                Amount = 90;
            }
            else if (orderComboBox.Text == "Reguler")
            {
                Amount = 80;
            }

            int totalPrice = Amount * Convert.ToInt32(queintity);

            for (int i = 0; i < contactNumbers.Count(); i++)
            {
                if (contactNumber == contactNumbers[i])
                {
                    MessageBox.Show("Contact Number already exist plz enter another number ");
                    return;
                }

            }
            customerNames.Add(customerName);
            contactNumbers.Add(contactNumber);
            addresses.Add(address);
            orders.Add(orderItem);
            queintityes.Add(Convert.ToInt32(queintity));
            totalPrices.Add(totalPrice);

            showRichTextBox.Text += "";
            for (int i = 0; i < customerNames.Count(); i++)
            {
               showRichTextBox.Text = "\n Customer Name: " + customerNames[i] + "\n" + "Contact Number: " + contactNumbers[i] + "\n" +
              "Address: " + addresses[i] + "\n " + "Order Amount:" + orders[i] + "\n" + "Quantity Value: " + queintityes[i] + "\n" +
              "Total Price: " + totalPrices[i] + "\n \n";
            }
            

            index++;


            //customerNameTextBox.Text = "";
            //contactTextBox.Text = "";
            //addressTextBox.Text = "";
            //orderComboBox.Text = "";
            //quantityTextBox.Text = "";

        }
        private void showCustomer()
        {
           string message= "";
            for (int i = 0; i < customerNames.Count(); i++)
            {
                message += "\n Customer Name: " + customerNames[i] + "\n" + "Contact Number: " + contactNumbers[i] + "\n" +
               "Address: " + addresses[i] + "\n " + "Order Amount:" + orders[i] + "\n" +
               "Quantity Value: " + queintityes[i] + "\n" +"Total Price: " + totalPrices[i] + "\n \n";
            }
            showRichTextBox.Text = message;
        }

    }
}
