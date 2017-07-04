using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIU_Project
{
    public partial class ConfirmRemovalOfStudent : Form
    {
        String valueS1;
        public ConfirmRemovalOfStudent(String s1)
        {
            InitializeComponent();
            valueS1 = s1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void showDetailBack() {
            try
            {


                // int check1 = 0;
                String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";

                String queryString1 = "SELECT StudentID,FirstName,LastName,Batch,Stream,DateOfBirth,Sex,SchoolName,HomeAddress,TelephoneNumber,EmailAddress,AdmissionDate FROM StudentMainDetail where StudentID ='"+valueS1+"'";
                using (SqlConnection connectionObj1 = new SqlConnection(
                           connection))
                {
                    SqlCommand command1 = new SqlCommand(
                        queryString1, connectionObj1);
                    connectionObj1.Open();
                    SqlDataReader reader = command1.ExecuteReader();
                    try
                    {
                        Console.WriteLine(reader);
                        while (reader.Read())
                        {
                            String t1 = (String)reader[0];
                            String t2 = (String)reader[1];
                            String t3 = (String)reader[2];
                            String t4 = (String)reader[3];
                            String t5 = (String)reader[4];
                            String t6 = (String)reader[5];
                            String t7 = (String)reader[6];
                            String t8 = (String)reader[7];
                            String t9 = (String)reader[8];
                            String t10 = (String)reader[9];
                            String t11 = (String)reader[10];
                            String t12 = (String)reader[11];


                            DetailOfAStudent detailOfStudent = new DetailOfAStudent(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
                            detailOfStudent.Show();
                           
                            this.Close();
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }
                }

                //-----------------------------------------------------------------------------


                //connectionObj.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yes_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show();
                String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";
                SqlConnection connectionObj = new SqlConnection(connection);
                connectionObj.Open();
                MessageBox.Show(valueS1);
                string query = "update StudentMainDetail set StudentStatus='Deactive' where StudentID='"+valueS1+"'";

                SqlCommand command = new SqlCommand(query, connectionObj);
                


                
                
              // MessageBox.Show();

                command.ExecuteNonQuery();
                MessageBox.Show("Student is removed");
                connectionObj.Close();

                
                


            }
            catch { }
            showDetailBack();
        }

        private void no_Click(object sender, EventArgs e)
        {
            showDetailBack();
        }
    }
}
