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
        public int getNumOfEntriesInMenuItemTable(int restID)
        {
            int num = 0;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(RestItemID) FROM TblRestMenuItem WHERE RestaurantID = @restID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@restID", restID);
                num = (int)cmd.ExecuteScalar();
                con.Dispose();
            }
            catch { }
            return num;
        }

        public List<string>[] getAllMenuItems(int restID)
        {
            List<string>[] theListArray = new List<string>[4];
            List<string> listOfMenuCats = new List<string>();
            List<string> listOfMenuNames = new List<string>();
            List<string> listOfMenuDescs = new List<string>();
            List<string> listOfMenuPrices = new List<string>();
            decimal holder = 0;
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT Category, ItemName, ItemDesc, Price FROM TblRestMenuItem WHERE RestaurantID = @restID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@restID", restID);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                listOfMenuCats.Add(reader.GetFieldValue<string>(0));
                listOfMenuNames.Add(reader.GetFieldValue<string>(1));
                listOfMenuDescs.Add(reader.GetFieldValue<string>(2));
                holder = reader.GetFieldValue<decimal>(3);
                listOfMenuPrices.Add(holder.ToString());
            }
            con.Dispose();
            theListArray[0] = listOfMenuCats;
            theListArray[1] = listOfMenuNames;
            theListArray[2] = listOfMenuDescs;
            theListArray[3] = listOfMenuPrices;
            return theListArray;
        }
    }
}
