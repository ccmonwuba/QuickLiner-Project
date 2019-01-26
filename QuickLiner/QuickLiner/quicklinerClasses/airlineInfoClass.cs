using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickLiner.quicklinerClasses
{
    class airlineInfoClass
    {
        //Getter and Setter Properties For Application (Data Carrier for application)
        public int ReservationID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string DepartureFrom { get; set; }

        public string DestinationTo { get; set; }

        public string PassengerNumber { get; set; }

        public string PassportNo { get; set; }

        public string TicketClass { get; set; }

        public string TripType { get; set; }

        public string LuggageNo { get; set; }

        public string PhoneReserve { get; set; }

        // Method for Database connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Method to Select Data from Database and show it in Data Grid View
        public DataTable Select()
        {
            //1. Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //2. Write SQL Query
                string sql = "SELECT * FROM passenger_info";
                //Creating cms using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //open connection
                conn.Open();
                //fill data adapter
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //close the connection
                conn.Close();
            }
            //return value
            return dt;
        }

        //Method for Inserting Data into database from application
        public bool Insert (airlineInfoClass c)
        {
            //Create a default return type and setting value to false
            bool isSuccess = false;
            //1.Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //2. Create an SQL query to insert data
                string sql = "INSERT INTO passenger_info (Name, Email, DepartureFrom, DestinationTo, PhoneReserve, PassengerNo, PassportNo, LuggageNo, TicketClass, TripType) VALUES (@Name, @Email, @DepartureFrom, @DestinationTo, @PhoneReserve, @PassengerNumber, @PassportNo, @LuggageNo, @TicketClass, @TripType)";
                //Create SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add data
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@DepartureFrom", c.DepartureFrom);
                cmd.Parameters.AddWithValue("@DestinationTo", c.DestinationTo);
                cmd.Parameters.AddWithValue("@PhoneReserve", c.PhoneReserve);
                cmd.Parameters.AddWithValue("@PassengerNumber", c.PassengerNumber);
                cmd.Parameters.AddWithValue("@PassportNo", c.PassportNo);
                cmd.Parameters.AddWithValue("@LuggageNo", c.LuggageNo);
                cmd.Parameters.AddWithValue("@TicketClass", c.TicketClass);
                cmd.Parameters.AddWithValue("@TripType", c.TripType);
                

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If query is successful, value of rows > zero else value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to Update data in Database from application
        public bool Update(airlineInfoClass c)
        {
            //create a default return type and set its default value to false
            bool isSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql object to update data in database
                string sql = "UPDATE passenger_info SET Name=@Name, Email=@Email, DepartureFrom=@DepartureFrom, DestinationTo=@DestinationTo, PhoneReserve=@PhoneReserve, PassengerNo=@PassengerNo, PassportNo=@PassportNo, LuggageNo=@LuggageNo, TicketClass=@TicketClass, TripType=@TripType WHERE ReservationID=@ReservationID";
                //create sql command to insert data in this query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create Parameters to add value
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@DepartureFrom", c.DepartureFrom);
                cmd.Parameters.AddWithValue("@DestinationTo", c.DestinationTo);
                cmd.Parameters.AddWithValue("@PhoneReserve", c.PhoneReserve);
                cmd.Parameters.AddWithValue("@PassengerNo", c.PassengerNumber);
                cmd.Parameters.AddWithValue("@PassportNo", c.PassportNo);
                cmd.Parameters.AddWithValue("@LuggageNo", c.LuggageNo);
                cmd.Parameters.AddWithValue("@TicketClass", c.TicketClass);
                cmd.Parameters.AddWithValue("@TripType", c.TripType);
                cmd.Parameters.AddWithValue("@ReservationID", c.ReservationID);

                //open database connection
                conn.Open();

                //create integer value
                int rows = cmd.ExecuteNonQuery();

                //if query runs successfully, then value of rows > 0 else value of rows = 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to delete data from Database
        public bool Delete(airlineInfoClass c)
        {
            //create default return value and set value to false
            bool isSuccess = false;

            //create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql object to delete data
                string sql = "DELETE FROM passenger_info WHERE ReservationID=@ReservationID";

                //SQL command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReservationID", c.ReservationID);

                //open sql connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully, then value of rows > 0 else values = 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
