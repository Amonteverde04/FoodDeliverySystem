using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace EasyMeal
{
    public class DataUploadModel
    {
        public string connect { get; set; } // property to hold connection string
        
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
        // B) method to pull from the restaurant menu items table

        // C) method to pull from the restaurant hours table
    }
}
