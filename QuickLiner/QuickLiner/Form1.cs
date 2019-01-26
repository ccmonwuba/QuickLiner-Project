using QuickLiner.quicklinerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickLiner
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        airlineInfoClass c = new airlineInfoClass();

        


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvAirlineInfo.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void PhoneRetrieveTexttBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void add_saveButton_Click(object sender, EventArgs e)
        {
            //get value from input fields
            c.Name = nameTextBox.Text;
            c.Email = emailTextBox.Text;
            c.PhoneReserve = phoneReserveTextBox.Text;
            c.DepartureFrom = departureTextbox.Text;
            c.DestinationTo = destinationTextbox.Text;
            c.PassengerNumber = passengerTextBox.Text;
            c.PassportNo = PassportTextBox.Text;
            c.TicketClass = ticketClasstextBox.Text;
            c.TripType = tripTypeTextbox.Text;
            c.LuggageNo = luggageTextbox.Text;
            
            //inserting data into database using method 
            bool success = c.Insert(c);

            if(success == true)
            {
                //successfully inserted
                MessageBox.Show("New Reservation Successfully Added");

                //Call the Clear method here to clear the fields
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new reservation, Try Again!");
            }

            //Load Data on Data Grid View
            DataTable dt = c.Select();
            dgvAirlineInfo.DataSource = dt;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PassportTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            //get value from text box
            string keyword = searchTextbox.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM passenger_info WHERE Name LIKE '%" + keyword + "%' OR PassportNo LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAirlineInfo.DataSource = dt;
            
           
        }

        //method to clear fields
        public void Clear()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneReserveTextBox.Text = "";
            departureTextbox.Text = "";
            destinationTextbox.Text = "";
            passengerTextBox.Text = "";
            PassportTextBox.Text = "";
            ticketClasstextBox.Text = "";
            tripTypeTextbox.Text = "";
            luggageTextbox.Text = "";
        }

        private void dgvAirlineInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data from Data grid view and populate text boxes respectively
            //Identify the row on which the mouse is clicked
            int rowindex = e.RowIndex;
            reservationIDtextBox.Text = dgvAirlineInfo.Rows[rowindex].Cells[0].Value.ToString();
            nameTextBox.Text = dgvAirlineInfo.Rows[rowindex].Cells[1].Value.ToString();
            emailTextBox.Text = dgvAirlineInfo.Rows[rowindex].Cells[2].Value.ToString();
            departureTextbox.Text = dgvAirlineInfo.Rows[rowindex].Cells[3].Value.ToString();
            destinationTextbox.Text = dgvAirlineInfo.Rows[rowindex].Cells[4].Value.ToString();
            phoneReserveTextBox.Text = dgvAirlineInfo.Rows[rowindex].Cells[5].Value.ToString();
            passengerTextBox.Text = dgvAirlineInfo.Rows[rowindex].Cells[6].Value.ToString();
            PassportTextBox.Text = dgvAirlineInfo.Rows[rowindex].Cells[7].Value.ToString();
            luggageTextbox.Text = dgvAirlineInfo.Rows[rowindex].Cells[8].Value.ToString();
            ticketClasstextBox.Text = dgvAirlineInfo.Rows[rowindex].Cells[9].Value.ToString();
            tripTypeTextbox.Text = dgvAirlineInfo.Rows[rowindex].Cells[10].Value.ToString();


        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            //get data from textboxes
            c.ReservationID = int.Parse(reservationIDtextBox.Text);
            c.Name = nameTextBox.Text;
            c.Email = emailTextBox.Text;
            c.DepartureFrom = departureTextbox.Text;
            c.DestinationTo = destinationTextbox.Text;
            c.PhoneReserve = phoneReserveTextBox.Text;
            c.PassengerNumber = passengerTextBox.Text;
            c.PassportNo = PassportTextBox.Text;
            c.LuggageNo = luggageTextbox.Text;
            c.TicketClass = ticketClasstextBox.Text;
            c.TripType = tripTypeTextbox.Text;

            //update date in Database
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Contact Update Successful!");
            }
            else
            {
                MessageBox.Show("Contact Update Unsuccessful, Try Again!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Get contact ID from the application
            c.ReservationID = Convert.ToInt32(reservationIDtextBox.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Reservation Deleted Succcessfully!");

                //Refresh the data grid view
                DataTable dt = c.Select();
                dgvAirlineInfo.DataSource = dt;

                //call the clear method
                Clear();
            }
            else
            {
                MessageBox.Show("Deletion Failed, Try Again");
            }
        }
    }



    
    }

