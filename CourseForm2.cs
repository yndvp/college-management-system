/** Application Purpose: A form to register courses
* Author: Tom Childs 200409679
* Date: 21/4/2021
* Time: 1:30AM
*/
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CollegeManagementSystem
{
    public partial class CourseForm2 : Form //CourseForm seemed to of broke so i made a new one
    {
        public CourseForm2()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CollegeDB.accdb; Persist Security Info=True");

        private void CourseForm2_Load(object sender, EventArgs e)
        {
            setTable();
        }
        public bool isIDboxempty()//function to check if ID box is null or not
        {
            //from Avi

            /*
            * This method check is the ID box has text
            */
            if (coursecodeBox.Text == "" || coursecodeBox.Text == " ")
                return true;
            return false;
        }
        private void setTable()//function to set up the table
        {

            try
            {
                if (!connection.State.Equals(ConnectionState.Open))
                {
                    connection.Open();
                }
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from courses";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlTable.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();// if fatel it should still close

            }


        }

        private void btnsave_Click_1(object sender, EventArgs e)// add button
        {
            try
            {
                // Open the connection
                connection.Open();
                // Make a command object
                OleDbCommand command = new OleDbCommand();
                // Connect the command object to the database
                command.Connection = connection;

                // Prepare the insert query
                command.CommandText = "Insert into courses (courseName, numOfSem, degree) Values (@courseName, "+ numberofsemestersBox.Text + ", @degree)";
                // Fill the query parameters
                //command.Parameters.AddWithValue("@courseCode", coursecodeBox.Text);//auto-gen
                command.Parameters.AddWithValue("@courseName", coursenameBox.Text);
                command.Parameters.AddWithValue("@degree", degreeBox.Text);

                // Execute the query
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully Saved");
                setTable();
                ClearAllBox();
            }
            catch (Exception ex)
            {
                // Show Error message box if there is an error
                MessageBox.Show("Error" + ex);
                connection.Close();

            }
        }
        private void ClearAllBox()
        {
            coursecodeBox.Clear();
            coursenameBox.Clear();
            numberofsemestersBox.Clear();
            degreeBox.Clear();
        }
        private void btnreset_Click_1(object sender, EventArgs e)//reset button
        {
            //Clear all text boxes on click
            ClearAllBox();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
         
            if (isIDboxempty())
                MessageBox.Show("Error: ", "Enter courses ID");
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command code
                    // Prepare the insert query
                    // Fill the query parameters
                    command.CommandText = "UPDATE courses SET courseName = '"
                        + coursenameBox.Text
                        + "', numOfSem = '"
                        + numberofsemestersBox.Text
                        + "', degree = '"
                        + degree.Text
                        + "' WHERE courseCode = "
                        + coursecodeBox.Text + "";

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isIDboxempty())
                MessageBox.Show("Enter courses ID", "Error");
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command code
                    command.CommandText = "DELETE FROM courses WHERE courseCode = " + coursecodeBox.Text;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
