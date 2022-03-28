using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace EasyMeal
{
    public class User
    {
        // Fields for user instantiation
        private readonly string firstName;
        private readonly string lastName;
        private readonly string _email;
        private readonly string phone;
        private readonly string _password;
        private readonly int type;

        public string email { get; set; } // property for checking log in email
        public string password { get; set; } // property for checking log in password
        public bool check { get; set; } // property for checking log in password
        public string connect { get; set; } // property to hold connection string

        public User()
        {

        }

        public User(string firstName, string lastName, string email, string phone, string password, int type)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this._email = email;
            this.phone = phone;
            this._password = password;
            this.type = type;
        }

        // need to fix ER DIAGRAM to put customer address and customer card info in the Customer table.
        public void createAccount()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"INSERT INTO TblUser(UserFirstName, UserLastName, UserEmail, UserPhoneNumber, UserPassword, UserTypeID) VALUES (@firstName, @lastName, @email, @phone, @password, @type)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@email", this._email);
            cmd.Parameters.AddWithValue("@phone", this.phone);
            //cmd.Parameters.AddWithValue("@password", Encrypt.hashString(this._password));
            cmd.Parameters.AddWithValue("@password", this._password);
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

        // doesnt work rn. Something with the SQL Statement
        public void logIn ()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT * FROM TblUser WHERE UserEmail = @email AND UserPassword = @password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@password", this.password);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Console.WriteLine("You are logged in!");
                check = true;
            }
            else
            {
                Console.WriteLine("Error, account not found or wrong credentials!");
                check = false;
            }
            con.Dispose();
        }
    }
}
