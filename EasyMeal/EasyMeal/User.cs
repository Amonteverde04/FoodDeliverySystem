using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace EasyMeal
{
    public class User
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly string email;
        private readonly string phone;
        private readonly string password;
        private readonly int type;

        public string connect { get; set; }

        public User(string firstName, string lastName, string email, string phone, string password, int type)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.password = password;
            this.type = type;
        }

        // need to fix ER DIAGRAM to put customer address and customer card info in the Customer table.
        // also need to make createAccount method put info into a USER table
        // lastley need to add usertype integer type to insert
        public void createAccount()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"INSERT INTO UserTable(UserFirstName, UserLastName, UserEmail, UserPhoneNumber, UserPassword, UserTypeID) VALUES (@firstName, @lastName, @email, @phone, @password, @type)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@phone", this.phone);
            cmd.Parameters.AddWithValue("@password", Encrypt.hashString(this.password));
            cmd.Parameters.AddWithValue("@type", this.type);
            int check = cmd.ExecuteNonQuery();
            if (check != 0)
            {
                Console.WriteLine("Account created!");
            }
            else
            {
                Console.WriteLine("Error, account not created!");
            }
            con.Dispose();
        }
    }
}
