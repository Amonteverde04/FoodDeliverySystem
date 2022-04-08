using System;
using Microsoft.Data.SqlClient;

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
        private readonly int _type;
        private int _userType;

        public int userID { get; set; }
        public int userType { get { return _userType; } set { _userType = value; } } // property to get user type


        public string email { get; set; } // property for checking log in email
        public string password { get; set; } // property for checking log in password
        public bool check { get; set; } // property for checking log in password
        public string connect { get; set; } // property to hold connection string

        public User()
        {

        }

        public User(string firstName, string lastName, string email, string phone, string password, int _type)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this._email = email;
            this.phone = phone;
            this._password = password;
            this._type = _type;
        }

        public void createAccount()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"INSERT INTO TblUsers(UserFirstName, UserLastName, UserEmail, UserPhoneNumber, UserPassword, UserType) VALUES (@firstName, @lastName, @email, @phone, @password, @type)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@firstName", this.firstName);
            cmd.Parameters.AddWithValue("@lastName", this.lastName);
            cmd.Parameters.AddWithValue("@email", this._email);
            cmd.Parameters.AddWithValue("@phone", this.phone);
            //cmd.Parameters.AddWithValue("@password", Encrypt.hashString(this._password));
            cmd.Parameters.AddWithValue("@password", this._password);
            cmd.Parameters.AddWithValue("@type", this._type);
            int checker = cmd.ExecuteNonQuery();
            if (checker != 0)
            {
                Console.WriteLine("Account created!");
                check = true;
            }
            else
            {
                Console.WriteLine("Error, account not created!");
                check = false;
            }
            con.Dispose();
        }

        public void logIn ()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT UserID FROM TblUsers WHERE UserEmail = @email AND UserPassword = @password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@password", this.password);
            try { userID = (int)cmd.ExecuteScalar(); }
            catch { Console.WriteLine("Failure"); }
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

        public void grabUserID()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT UserID FROM TblUsers WHERE UserEmail = @email AND UserPassword = @password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@password", this.password);
            userID = (int)cmd.ExecuteScalar();
        } // sets the UserID by going to the table and grabbing it

        public void grabUserType()
        {
            try { 
            grabUserID();
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT UserType FROM TblUsers WHERE UserID = @ID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ID", this.userID);
            _userType = (int)cmd.ExecuteScalar();
            } catch { 
            }
        } // sets the _userType by going to the table and grabbing it

        public int getUserID()
        {
            return this.userID;
        }

        public int getUserType()
        {
            return this._userType;
        }
    }
}
