﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLib;

/* 
 * The application must provide the following functionality:
 * 
 * 1)Provide a form that displays Customers and their orders.
 * a. The form should display information for 1 customer at a time.
 * b. All columns from the Customer table in the Northwind database should be displayed for each customer.
 * c. When the customer information for a customer is displayed,
 *    a list of that customer’s orders should also be displayed.
 *    The orders should be displayed in grid format.
 *    Data for the orders should come from the Orders table in the Northwind database.
 * d.	The ability to navigate through all customer records should be provided.
 * i.	The user should be able to move to the first customer record directly.
 * ii.	The user should be able to move to the last customer record directly.  
 * iii.	The user should be able to move to the next customer record.
 * iv.	The user should be able to move to the previous customer record.
 * v.	Note:  When the customer changes, the list of orders must also change.
 * 
 * 2)	 Provide the capability to delete customers (those who have not placed orders).
 * 
 * 3)	You may choose a very simple user interface.
 * 
 * 
 * Note:  This is just a sample app with limited functionality.  It does not contain all the functionality that would be expected in a real application.  You do not have to develop functionality to enter new customers or update existing customers.
 *    
 * 
 * Technical Requirements:
 * 
 * 4)	You must include exception handling.
 * 
 * 5)	Data access functionality should be developed in a class in a class library, NOT in the presentation application.
 * 
 * 6)	You must use secure measures to guard against SQL injection and to avoid exposing database information.  (See module 3.)
*/

namespace Customer.DetailsDisplay
{
    public partial class customerDetailsDisplayForm : Form
    {
        private DataSet northwndCustOrdersDataSet;
        
        public customerDetailsDisplayForm()
        {
            InitializeComponent();
        }

        private void customerDetailsDisplayForm_Load(object sender, EventArgs e)
        {
            northwndCustOrdersDataSet = CustomerDataAccess.GetCustomersAndOrders();

            customerNameTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.CompanyName");
            contactNameTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.ContactName");
            contactTitleTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.ContactTitle");
            addressTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.Address");
            cityTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.City");
            regionTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.Region");
            zipTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.PostalCode");
            countryTextBox.DataBindings.Add("Text", northwndCustOrdersDataSet, "Customers.Country");

            customerDataGridView.DataSource = northwndCustOrdersDataSet;

            customerDataGridView.DataMember = "Customers.CustToOrdersRel";    
        }
       
        /// <summary>
        /// Moves to row 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topOfListButton_Click(object sender, EventArgs e)
        {
            if (BindingContext[northwndCustOrdersDataSet, "Customers"].Position != 0)// If you're at the top of the list already
            {
                BindingContext[northwndCustOrdersDataSet, "Customers"].Position = 0;
            }
            else
            {
                MessageBox.Show("Can't go up any higher");
            }
        }

        /// <summary>
        /// Moves to up 1 row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upButton_Click(object sender, EventArgs e)
        {
            if (BindingContext[northwndCustOrdersDataSet, "Customers"].Position != 0)// If you're at the top of the list already
            {
                BindingContext[northwndCustOrdersDataSet, "Customers"].Position -= 1;
            }
            else
            {
                MessageBox.Show("Can't go up any higher");
            }

        }

        /// <summary>
        /// Moves down 1 row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downButton_Click(object sender, EventArgs e)
        {
            if (BindingContext[northwndCustOrdersDataSet, "Customers"].Position != BindingContext[northwndCustOrdersDataSet, "Customers"].Count - 1)// If you're at the Bottom of the list already
            {
                BindingContext[northwndCustOrdersDataSet, "Customers"].Position += 1;
            }
            else
            {
                MessageBox.Show("Can't go down any LOWER");
            }
            
        }

        /// <summary>
        /// Moves to last row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bottomOfListButton_Click(object sender, EventArgs e)
        {
            if (BindingContext[northwndCustOrdersDataSet, "Customers"].Position != BindingContext[northwndCustOrdersDataSet, "Customers"].Count - 1)// If you're at the Bottom of the list already
            {
                BindingContext[northwndCustOrdersDataSet, "Customers"].Position = BindingContext[northwndCustOrdersDataSet, "Customers"].Count - 1;
            }
            else
            {
                MessageBox.Show("Can't go down any LOWER");
            }
        }
    }
}
