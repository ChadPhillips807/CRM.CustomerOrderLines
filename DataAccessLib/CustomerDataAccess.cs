using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public static class CustomerDataAccess
    {
        private const string sqlExcptMsg = "The database is not responding. Please contact support.";
        private const string connectionString = @"Server = SLAVE_1\SQLEXPRESS;Database = NORTHWND;Integrated Security=SSPI";
                
        //b. All columns from the Customer table in the Northwind database should be displayed for each customer.
        private const string selectAllFromCustomers = "SELECT * FROM Customers ORDER BY CustomerID";
        private const string selectAllFromOrders = "SELECT * FROM Orders ORDER BY OrderID";
        
        /*c. When the customer information for a customer is displayed,
        *    a list of that customer’s orders should also be displayed.
        *    
        *          select * 
        *          from Customers C
        *          INNER JOIN Orders as O on C.CustomerID = O.CustomerID
        *
        * 
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
        * Technical Requirements:
        * 
        * 4)	You must include exception handling.
        * 
        * 5)	Data access functionality should be developed in a class in a class library, NOT in the presentation application.
        * 
        * 6)	You must use secure measures to guard against SQL injection and to avoid exposing database information.  (See module 3.)*/
        public static DataSet GetCustomersAndOrders()
        {
            SqlDataAdapter northwindDataAdapter = new SqlDataAdapter();
            
            northwindDataAdapter.SelectCommand = new SqlCommand();
            northwindDataAdapter.SelectCommand.Connection = new SqlConnection();

            DataSet northwndCustOrdersDataSet;
            DataRelation CustToOrdersRelation;

            try
            {
                northwindDataAdapter.SelectCommand.Connection.ConnectionString = connectionString;

                // Create the dataset to store the tables needed for querying
                northwndCustOrdersDataSet = new DataSet("CustomerOrdersDataSet");

                // change command text to select Customers
                northwindDataAdapter.SelectCommand.CommandText = selectAllFromCustomers;

                // Fill the dataset with Customers
                northwindDataAdapter.Fill(northwndCustOrdersDataSet, "Customers");

                // change command text to select orders
                northwindDataAdapter.SelectCommand.CommandText = selectAllFromOrders;

                // Fill the dataset with Orders
                northwindDataAdapter.Fill(northwndCustOrdersDataSet, "Orders");

                // Create the Customers to Orders relationship
                CustToOrdersRelation = new DataRelation("CustToOrdersRel",
                    northwndCustOrdersDataSet.Tables["Customers"].Columns["CustomerID"],
                    northwndCustOrdersDataSet.Tables["Orders"].Columns["CustomerID"]);

                // Add the Customers to Orders relationship to the dataset
                northwndCustOrdersDataSet.Relations.Add(CustToOrdersRelation);

                // returning the filled dataset to whatever calls for it!!
                return northwndCustOrdersDataSet;
            }
            catch (SqlException)
            {
                // Use generic message to not give the actual exception to the hackers
                throw new ApplicationException(sqlExcptMsg);
            }
            finally
            {
                northwindDataAdapter.SelectCommand.Connection.Close();
            }
        }

    }
}
/*SELECT * FROM Customers C INNER JOIN Orders as O on C.CustomerID = O.CustomerID INNER JOIN [Order Details] as OD on O.OrderID = OD.OrderID INNER JOIN Products as P on OD.ProductID = P.ProductID*/