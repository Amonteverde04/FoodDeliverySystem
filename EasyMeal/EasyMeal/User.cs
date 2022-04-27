using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public int savedRestaurant { get; set; }
        public List<string> cartItemsById = new List<string>();
        public List<string> cartItemsByName = new List<string>();
        public List<decimal> cartItemsByPrice = new List<decimal>();

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
            int? holder = 0;
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT UserID FROM TblUsers WHERE UserEmail = @email AND UserPassword = @password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@password", this.password);
            holder= (int?)cmd.ExecuteScalar();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() && holder != null)
            {
                Console.WriteLine("You are logged in!");
                userID = (int)holder;
                check = true;
            }
            else
            {
                Console.WriteLine("Error, account not found or wrong credentials!");
                check = false;
            }
            con.Dispose();
        }

        public void logOut()
        {
            userID = 0;
        }

        public void grabUserID()
        {
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT UserID FROM TblUsers WHERE UserEmail = @email AND UserPassword = @password", con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@password", this.password);
            userID = (int)cmd.ExecuteScalar();
            con.Dispose();
        } // sets the UserID by going to the table and grabbing it

        public void grabUserType()
        {
            int? holder = 0;
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT UserType FROM TblUsers WHERE UserID = @ID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ID", this.userID);
            holder = (int?)cmd.ExecuteScalar();
            if(holder == null)
            {
                _userType = 0;
            } else
            {
                _userType = (int)holder;
            }
            con.Dispose();
        } // sets the _userType by going to the table and grabbing it

        public int getUserID()
        {
            return this.userID;
        }

        public int getUserType()
        {
            return this._userType;
        }

        public int uploadCustomer(int userIdent,string street, string city, string state, string zip, string cardNumber, string fullName, string month, string year, string cVV) {
            if (alreadyExists("TblCustomer") == 1)
            {
                return 0;
            }
            else
            {
                int requestWentThrough = 0;
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"INSERT INTO TblCustomer(UserID, CustomerStreet, CustomerCity, CustomerState, CustomerZip, CustomerCardNumber, CustomerCardExpDate, CustomerCardCVV, CustomerCardName)" +
                            $" VALUES (@UserID, @street, @city, @state, @zip, @cardNum, @expDate, @cardCVV, @cardName)", con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserID", userIdent);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@zip", zip);
                    cmd.Parameters.AddWithValue("@cardNum", cardNumber);
                    cmd.Parameters.AddWithValue("@expDate", month + year);
                    cmd.Parameters.AddWithValue("@cardCVV", cVV);
                    cmd.Parameters.AddWithValue("@cardName", fullName);
                    int checker = cmd.ExecuteNonQuery();
                    if (checker != 0)
                    {
                        Console.WriteLine("Details Added!");
                        requestWentThrough = 1;
                    }
                    else
                    {
                        Console.WriteLine("Error, details not added!");
                    }
                    con.Dispose();
                }
                catch { Console.WriteLine("Error, details not added!"); }
                return requestWentThrough;
            }
        }

        public int uploadDriver(int userIdent, string driverMake, string driverModel, string driverYear, string driverColor, string driverLicensePlate)
        {
            if (alreadyExists("TblDriver") == 1)
            {
                return 0;
            }
            else
            {
                int requestWentThrough = 0;
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"INSERT INTO TblDriver(UserID, DriverMake, DriverModel, DriverYear, DriverColor, DriverLicensePlate)" +
                            $" VALUES (@UserID, @driverMake, @driverModel, @driverYear, @driverColor, @driverLicensePlate)", con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserID", userIdent);
                    cmd.Parameters.AddWithValue("@driverMake", driverMake);
                    cmd.Parameters.AddWithValue("@driverModel", driverModel);
                    cmd.Parameters.AddWithValue("@driverYear", driverYear);
                    cmd.Parameters.AddWithValue("@driverColor", driverColor);
                    cmd.Parameters.AddWithValue("@driverLicensePlate", driverLicensePlate);
                    int checker = cmd.ExecuteNonQuery();
                    if (checker != 0)
                    {
                        Console.WriteLine("Details Added!");
                        requestWentThrough = 1;
                    }
                    else
                    {
                        Console.WriteLine("Error, details not added!");
                    }
                    con.Dispose();
                }
                catch { Console.WriteLine("Error, details not added!"); }
                return requestWentThrough;
            }
        }

        public int uploadRestaurant(int userIdent, string street, string city, string state, string zip, string restName, string foodtype, string phoneNum)
        {
            if(alreadyExists("TblRestaurant") == 1)
            {
                return 0;
            } else { 
                int requestWentThrough = 0;
                SqlConnection con = new SqlConnection(connect);
                SqlCommand cmd = new SqlCommand($"INSERT INTO TblRestaurant(UserID, RestStreet, RestCity, RestState, RestZip, RestName, RestType, RestPhoneNumber)" +
                            $" VALUES (@UserID, @street, @city, @state, @zip, @restName, @foodType, @phoneNum)", con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserID", userIdent);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@zip", zip);
                    cmd.Parameters.AddWithValue("@restName", restName);
                    cmd.Parameters.AddWithValue("@foodType", foodtype);
                    cmd.Parameters.AddWithValue("@phoneNum", phoneNum);
                    int checker = cmd.ExecuteNonQuery();
                    if (checker != 0)
                    {
                        Console.WriteLine("Details Added!");
                        requestWentThrough = 1;
                    }
                    else
                    {
                        Console.WriteLine("Error, details not added!");
                    }
                    con.Dispose();
                } catch { Console.WriteLine("Error, details not added!"); }
                return requestWentThrough;
            }
        }

        public int alreadyExists(string tbl) {
             int? holder = 0;
             // select the user id in the desired table.
             SqlConnection con = new SqlConnection(connect);
             SqlCommand cmd = new SqlCommand($"SELECT UserID FROM {tbl} WHERE UserID = @ID", con);
             con.Open();
             cmd.Parameters.AddWithValue("@ID", this.userID);
             holder = (int?)cmd.ExecuteScalar();
            // if the user exists in the table then return 1
            if (holder > 0)
            {
                return 1;
            }
            // other wise return 0
            if (holder == null)
            {
                return 0;
            } else { return 0; }
        }

        public string getOrderID(DateTime theDate)
        {
            string orderID = "";

            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"SELECT OrderID FROM TblOrders WHERE StampTime = @date", con);
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@date", theDate);
                orderID = Convert.ToString(cmd.ExecuteScalar());
            } catch
            {

            }
            // if the user exists in the table then return 1
            return orderID;
        }

        public void addOrderLine(string item, DateTime theDate)
        {
            string orderID;
            int checker2;
            orderID = getOrderID(theDate);
            SqlConnection con2 = new SqlConnection(connect);
            SqlCommand cmd2 = new SqlCommand($"INSERT INTO TblOrderLine(OrderID, RestItemID)" +
                            $" VALUES (@orderID, @restItemID)", con2);

            con2.Open();
            cmd2.Parameters.AddWithValue("@orderID", orderID);
            cmd2.Parameters.AddWithValue("@restItemID", item);
            checker2 = cmd2.ExecuteNonQuery();
            if (checker2 != 0)
            {
                Console.WriteLine("Order Line added!");
            }
            else
            {
                Console.WriteLine("Problem in order line add");
                return;
            }
            con2.Close();
        }

        public int sendOrder()
        {
            decimal total = 0;
            DateTime theDate = DateTime.Now;
            foreach (decimal item in cartItemsByPrice)
            {
                total = total + item;
            }
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"INSERT INTO TblOrders(OrderTotal, StampTime, UserID)" +
                            $" VALUES (@total, @orderTime, @userID)", con);
            try
            {
                if (total == 0 || userID == 0)
                {
                    Console.WriteLine("Error: Cart empty or user not logged in!");
                    return 0;
                }
                con.Open();
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@orderTime", theDate);
                cmd.Parameters.AddWithValue("@userID", userID);
                int checker = cmd.ExecuteNonQuery();
                if (checker != 0)
                {
                    Console.WriteLine("Details Added!");
                    con.Dispose();
                }
                else
                {
                    Console.WriteLine("Error, details not added!");
                    con.Dispose();
                    return 0;
                }
                foreach(string item in cartItemsById)
                {
                    addOrderLine(item, theDate);
                }
                return 1;
            }
            catch
            {
                Console.WriteLine("Error");
                con.Dispose();
                return 0;
            }
        }
    }
}
