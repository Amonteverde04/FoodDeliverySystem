using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace EasyMeal
{
    public class DataUploadModel
    {
        public string connect { get; set; } // property to hold connection string
        public int userID { get; set; }
        public int restID { get; set; }
        public string category { get; set; }
        public string itemName { get; set; }
        public string itemDesc { get; set; }
        public string price { get; set; }
        public string time { get; set; }
        public int failure { get; set; }
        public int restPageID { get; set; }
        public List<int> listOfIDs = new List<int>();
        public List<string> listOfRestNames = new List<string>();
        public List<int> listOfStatus = new List<int>();

        public List<string> listOfPrepTime = new List<string>();


        public List<string> listOfRestNameForOrder = new List<string>();
        public List<string> listOfRestAddy = new List<string>();
        public List<string> listOfCustName = new List<string>();
        public List<string> listOfCustAddy = new List<string>();

        // constructor
        public DataUploadModel()
        {

        }

        // get number of entries in table
        public int getNumOfEntriesInRestTable ()
        {
            int num = 0;
            try { 
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(RestaurantID) FROM TblRestaurant", con);
                con.Open();
                num = (int)cmd.ExecuteScalar();
                con.Dispose();
            } catch { }
            return num;
        }

        public int getNumOfEntriesInOrderTable()
        {
            int num = 0;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(OrderID) FROM TblOrders", con);
                con.Open();
                num = (int)cmd.ExecuteScalar();
                con.Dispose();
            }
            catch { }
            return num;
        }

        public int getNumOfEntriesInOrderLine()
        {
            int num = 0;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(OrderLineID) FROM TblOrderLine", con);
                con.Open();
                num = (int)cmd.ExecuteScalar();
                con.Dispose();
            }
            catch { }
            return num;
        }

        // A) methods to pull from restaurant table
        public List<string> getAllRestaurantNames()
        {
            List<string> listOfRest = new List<string>();
            int numOfEntries = 0;
            numOfEntries = getNumOfEntriesInRestTable();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT RestName FROM TblRestaurant", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            // iterator limit needs to be changed based on how many entries we have in the restaurant table.
            for (int i = 0; i < numOfEntries; i++)
            {
                reader.Read();
                listOfRest.Add(reader.GetFieldValue<string>(0));
                // increments row 
            }
            con.Dispose();
            return listOfRest;
        }

        public List<int> getAllRestaurantIDs()
        {
            List<int> listOfRestID = new List<int>();
            int numOfEntries = 0;
            numOfEntries = getNumOfEntriesInRestTable();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT RestaurantID FROM TblRestaurant", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            // iterator limit needs to be changed based on how many entries we have in the restaurant table.
            for (int i = 0; i < numOfEntries; i++)
            {
                reader.Read();
                listOfRestID.Add(reader.GetFieldValue<int>(0));
                // increments row 
            }
            con.Dispose();
            return listOfRestID;
        }

        public List<string> getAllRestaurantTypes()
        {
            List<string> listOfType = new List<string>();
            int numOfEntries = 0;
            numOfEntries = getNumOfEntriesInRestTable();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT RestType FROM TblRestaurant", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            // iterator limit needs to be changed based on how many entries we have in the restaurant table.
            for (int i = 0; i < numOfEntries; i++)
            {
                reader.Read();
                listOfType.Add(reader.GetFieldValue<string>(0));
                // increments row 
            }
            con.Dispose();
            return listOfType;
        }

        public List<string>[] getAllRestaurantAddress()
        {
            List<string>[] listArray = new List<string>[4];
            List<string> listOfStreet = new List<string>();
            List<string> listOfCity = new List<string>();
            List<string> listOfState = new List<string>();
            List<string> listOfZip = new List<string>();
            int numOfEntries = 0;
            numOfEntries = getNumOfEntriesInRestTable();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT RestStreet, RestCity, RestState, RestZip FROM TblRestaurant", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            // iterator limit needs to be changed based on how many entries we have in the restaurant table.
            for (int i = 0; i < numOfEntries; i++)
            {
                reader.Read();
                listOfStreet.Add(reader.GetFieldValue<string>(0));
                listOfCity.Add(reader.GetFieldValue<string>(1));
                listOfState.Add(reader.GetFieldValue<string>(2));
                listOfZip.Add(reader.GetFieldValue<string>(3));
                // increments row 
            }
            con.Dispose();
            listArray[0] = listOfStreet;
            listArray[1] = listOfCity;
            listArray[2] = listOfState;
            listArray[3] = listOfZip;
            return listArray;
        }

        // B) method to put items in the restaurant menu items table
        public void grabRestID()
        {
            int? num = 0;
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT RestaurantID FROM TblRestaurant WHERE UserID = @ID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ID", this.userID);
            num = (int?)cmd.ExecuteScalar();
            if (num > 0)
            {
                restID = (int)num;
            }
            // other wise return 0
            if (num == null)
            {
                restID = 0;
            }
            con.Dispose();
        }

        public void uploadItems()
        {
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"INSERT INTO TblRestMenuItem(Category, ItemName, ItemDesc, Price, PrepTime, RestaurantID) VALUES (@category, @itemName, @itemDesc, @price, @time, @restID)", con);
                con.Open();
            try
            {
                cmd.Parameters.AddWithValue("@category", this.category);
                cmd.Parameters.AddWithValue("@itemName", this.itemName);
                cmd.Parameters.AddWithValue("@itemDesc", this.itemDesc);
                cmd.Parameters.AddWithValue("@price", this.price);
                cmd.Parameters.AddWithValue("@time", this.time);
                cmd.Parameters.AddWithValue("@restID", this.restID);
                int checker = cmd.ExecuteNonQuery();
                if (checker != 0)
                {
                    Console.WriteLine("Items uploaded!");
                    failure = 0;
                }
                else
                {
                    Console.WriteLine("Items not uploaded!");
                    failure = 1;
                }
            } catch { failure = 1; }
            con.Dispose();
        }

        // C) method to pull items from the restaurant items table
        // get number of entries in table
        public int getNumOfEntriesInMenuItemTable(int ID)
        {
            int num = 0;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(RestItemID) FROM TblRestMenuItem WHERE RestaurantID = @restID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@restID", ID);
                num = (int)cmd.ExecuteScalar();
                con.Dispose();
            }
            catch { }
            return num;
        }

        public List<string>[] getAllMenuItems(int ID)
        {
            List<string>[] theListArray = new List<string>[5];
            List<string> listOfMenuCats = new List<string>();
            List<string> listOfMenuNames = new List<string>();
            List<string> listOfMenuDescs = new List<string>();
            List<string> listOfMenuPrices = new List<string>();
            List<string> listOfMenuIDs = new List<string>();
            decimal holder = 0;
            int holder2 = 0;
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT RestItemID, Category, ItemName, ItemDesc, Price FROM TblRestMenuItem WHERE RestaurantID = @restID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@restID", ID);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                holder2 = reader.GetFieldValue<int>(0);
                listOfMenuIDs.Add(holder2.ToString());
                listOfMenuCats.Add(reader.GetFieldValue<string>(1));
                listOfMenuNames.Add(reader.GetFieldValue<string>(2));
                listOfMenuDescs.Add(reader.GetFieldValue<string>(3));
                holder = reader.GetFieldValue<decimal>(4);
                listOfMenuPrices.Add(holder.ToString());
            }
            con.Dispose();
            theListArray[0] = listOfMenuIDs;
            theListArray[1] = listOfMenuCats;
            theListArray[2] = listOfMenuNames;
            theListArray[3] = listOfMenuDescs;
            theListArray[4] = listOfMenuPrices;
            return theListArray;
        }

        public void getOrders()
        {
            
            int numOfEntries = 0;
            numOfEntries = getNumOfEntriesInOrderTable();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT TblOrders.OrderID, TblOrders.Status, TblRestaurant.RestName" +
                $"                            FROM TblOrders" +
                $"                            LEFT JOIN TblRestaurant" +
                $"                            ON TblOrders.RestID = TblRestaurant.RestaurantID" +
                $"                                              ", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            // iterator limit needs to be changed based on how many entries we have in the restaurant table.
            for (int i = 0; i < numOfEntries; i++)
            {
                reader.Read();
                listOfIDs.Add(reader.GetFieldValue<int>(0));
                listOfStatus.Add(reader.GetFieldValue<int>(1));
                listOfRestNames.Add(reader.GetFieldValue<string>(2));
            }
            con.Dispose();
        }

        // 
        public int? orderPrepTime(int ID)
        {
            int? num;
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT MAX(TblRestMenuItem.PrepTime)" +
                $"                            FROM TblOrderLine" +
                $"                            LEFT JOIN TblOrders" +
                $"                            ON TblOrderLine.OrderID = TblOrders.OrderID" +
                $"                            LEFT JOIN TblRestMenuItem" +
                $"                            ON TblOrderLine.RestItemID = TblRestMenuItem.RestItemID" +
                $"                            WHERE TblOrderLine.OrderID = @orderID" +
                $"                                              ", con);
            con.Open();
            cmd.Parameters.AddWithValue("@orderID", ID);
            num = (int?)cmd.ExecuteScalar();
            return num;
        }

        public void getOrderInfo()
        {

            int numOfEntries = 0;
            numOfEntries = getNumOfEntriesInOrderTable();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("SELECT TblRestaurant.RestName, CONCAT(TblRestaurant.RestStreet , ' ',TblRestaurant.RestCity, ' ', TblRestaurant.RestState, ' ', TblRestaurant.RestZip) AS RestAddy, CONCAT(TblUsers.UserFirstName, ' ', TblUsers.UserLastName) AS CustName, CONCAT(TblCustomer.CustomerStreet,  ' ', TblCustomer.CustomerCity, ' ',TblCustomer.CustomerState, ' ', TblCustomer.CustomerZip) AS CustAddy" +
                                            $" FROM TblOrders" + 
                                            $" LEFT JOIN TblRestaurant" +
                                            $" ON TblOrders.RestID = TblRestaurant.RestaurantID" +
                                            $" LEFT JOIN TblCustomer" +
                                            $" ON TblOrders.UserID = TblCustomer.UserID" +
                                            $" LEFT JOIN TblUsers" +
                                            $" ON TblCustomer.UserID = TblUsers.UserID", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            // iterator limit needs to be changed based on how many entries we have in the restaurant table.
            for (int i = 0; i < numOfEntries; i++)
            {
                reader.Read();
                listOfRestNameForOrder.Add(reader.GetFieldValue<string>(0));
                listOfRestAddy.Add(reader.GetFieldValue<string>(1));
                listOfCustName.Add(reader.GetFieldValue<string>(2));
                listOfCustAddy.Add(reader.GetFieldValue<string>(3));
            }
            con.Dispose();
        }
    }
}
