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

        public int getNumOfEntriesInItemTable()
        {
            int num = 0;
            try
            {
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(RestaurantID) FROM TblRestMenuItem", con);
                con.Open();
                num = (int)cmd.ExecuteScalar();
                con.Dispose();
            }
            catch { }
            return num;
        }

        public List<string> menuItems()
        {
            List<string> itemList = new List<string>();
            int numOfEntries = 0;
            numOfEntries = getNumOfEntriesInItemTable();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT ItemName FROM TblRestMenuItem WHERE ItemName = @itemName AND RestaurantID = restID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@itemName", this.itemName);
            cmd.Parameters.AddWithValue("@restID", this.restID);
            SqlDataReader reader = cmd.ExecuteReader();
            for (int i = 0; i < numOfEntries; i++)
            {
                reader.Read();
                itemList.Add(reader.GetFieldValue<string>(0));
                // increments row 
            }
            con.Dispose();
            return itemList;
        }
        // C) method to pull from the restaurant hours table
    }
}
