using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
/*
 * Aviraj Gill
 * 4:35
 * 2021-04-20
 * This part takes care of students lets you add them and edit also delete
 * List blow
 Student Management
- Profile form
•    student ID (auto-created) added(function)
•    first name added(UI)
•    last name added(UI) 
•    gender added(UI)
•    date of birth added(UI)
•    email added(UI) 
•    address added(UI) 
•    enrolled program added(UI)
•    start date added(UI)
•    semester status added(UI)
-  Add / edit/ delete button added(UI) added(function)
- Table that shows all students added(UI) added(function)
- 
 */
namespace CollegeManagementSystem
{
    public partial class StudentForm : Form
    {
        //thanks to Yunna for the Connection Queries help
        //DB connection
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CollegeDB.accdb; Persist Security Info=True");

        public StudentForm()
        {
            InitializeComponent();
            AddListToCombobox();//set the drop down options
        }
        private void setTable()// function to set up the table
        {

            try
            {
                if (!connection.State.Equals(ConnectionState.Open))
                {
                    connection.Open();
                }
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from students";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataview.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();// if fatel it should still close

            }


        }
        private int RandomStudentID()// makes a random num 16 long
        {
            for (int i = 0; i < 16;)
                return new Random().Next();
            return 0;
        }
        private void AddListToCombobox()// function fills the combobox
        {
            //Gender box
            genderBox.Items.Add("Male");
            genderBox.Items.Add("Female");
            //Status for Attending
            Status.Items.Add("Attending");
            Status.Items.Add("Not attending");
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            /*
            * This method On load will set the table
            */
            setTable();//on load it'll set table
        }
        public bool isIDboxempty()//function to check if ID box is null or not
        {
            /*
            * This method check is the ID box has text
            */
            if (idbox.Text == "" || idbox.Text == " ")
                return true;
            return false;
        }
        private void addbutton_Click_1(object sender, EventArgs e)
        {
            /*
             * This method Add a new user when click
             */

            try
            {
                if (!connection.State.Equals(ConnectionState.Open)) connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //command for sql
                command.CommandText = "Insert into students (firstName, lastName, gender, DateOfBirth, email, address, course, startDate) Values (@firstName, @lastName, @gender, @DateOfBirth, @email, @address, @course,'2020-09-14')";
                //command.CommandText = "Insert into students (firstName) Values (@firstName)";//Test var

                //fill parameters
                command.Parameters.AddWithValue("@firstName", fNameBox.Text);
                command.Parameters.AddWithValue("@lastName", lNameBox.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dobpicker.Value.Date);
                //command.Parameters.AddWithValue("@startDate", startdatapicker.Value.Date);//Test Parameter
                command.Parameters.AddWithValue("@gender", genderBox.Text);
                command.Parameters.AddWithValue("@course", enrolledprogramBox.Text);
                command.Parameters.AddWithValue("@address", richTextBox1.Text);
                //command.Parameters.AddWithValue("@ID", RandomStudentID());//Test Parameter

                //Executes the Query
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully Added");
                setTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                connection.Close();//so you can try again
            }
        }

        private void editbutton_Click_1(object sender, EventArgs e)
        {
            /*
           * This method edits a user when clicked but the ID box has to have a number in it
           */
            if (isIDboxempty())
                MessageBox.Show("Error: ", "Enter student ID(Top left)");
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command code
                    command.CommandText = "UPDATE students SET firstName = '"
                        + fNameBox.Text
                        + "', lastName = '"
                        + lNameBox.Text
                        + "', gender = '" + genderBox.Text
                        + "', DateOfBirth = '" + dobpicker.Value.Date
                        + "', email = '" + email.Text
                        + "', address = '" + richTextBox1.Text
                        + "', course = '" + enrolledprogramBox.Text
                        + "', startDate = '" + startdatapicker.Value.Date
                        + "' WHERE ID = "
                        + idbox.Text + "";

                    //Executes the Query
                    command.ExecuteNonQuery();
                    //closes the connection once done
                    connection.Close();
                    MessageBox.Show("Successfully Edited");
                    setTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();//so you can try again
                }
            }
        }

        private void deletebutton_Click_1(object sender, EventArgs e)
        {
            /*
            * This method deletes a user when clicked but the ID box has to have a number in it
            */
            if (isIDboxempty())
                MessageBox.Show("Enter student ID(Top left)", "Error");
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command code
                    command.CommandText = "DELETE FROM students WHERE ID = "
                        + idbox.Text + "";

                    //Executes the Query
                    command.ExecuteNonQuery();
                    //closes the connection once done          
                    connection.Close();
                    MessageBox.Show("Successfully Deleted");
                    setTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();//so you can try again
                }
            }
        }
        

        private void mainformButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}