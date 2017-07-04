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
    public partial class StudentDetailCheck : Form
    {
        public StudentDetailCheck()
        {
            InitializeComponent();
            searchId.Visible = false;
            searchName.Visible = false;
        }

        private void searchId_Click(object sender, EventArgs e)
        {
            try {


                // int check1 = 0;
                String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";

                string queryString = "SELECT StudentID,FirstName,LastName,Batch,Stream,DateOfBirth,Sex,SchoolName,HomeAddress,TelephoneNumber,EmailAddress,AdmissionDate FROM StudentMainDetail where StudentID ='" + txtStudentID.Text + "';";
                using (SqlConnection connectionObj = new SqlConnection(
                           connection))
                {
                    SqlCommand command = new SqlCommand(
                        queryString, connectionObj);
                    connectionObj.Open();
                    SqlDataReader reader = command.ExecuteReader();
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
                            this.Visible=false;
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
        void toClear()
        {
            DataGridViewSelectionMode firstmode = dataGridViewByName.SelectionMode;
            dataGridViewByName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewByName.ClearSelection();
            dataGridViewByName.SelectionMode = firstmode;
        }

        public void dataGridViewEntry(String textBoxValue) {
            try
            {


                // int check1 = 0;
                String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";

                string queryString = "SELECT StudentID,FirstName,LastName,Batch,Stream,DateOfBirth,Sex,SchoolName,HomeAddress,TelephoneNumber,EmailAddress,AdmissionDate FROM StudentMainDetail where FirstName ='" + textBoxValue + "';";
                using (SqlConnection connectionObj = new SqlConnection(
                           connection))
                {
                    SqlCommand command = new SqlCommand(
                        queryString, connectionObj);
                    connectionObj.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        int rowNum = 0;
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

                            this.dataGridViewByName.Rows.Add();
                            this.dataGridViewByName.Rows[rowNum].Cells[0].Value = t1;
                            this.dataGridViewByName.Rows[rowNum].Cells[1].Value = t2;
                            this.dataGridViewByName.Rows[rowNum].Cells[2].Value = t3;
                            this.dataGridViewByName.Rows[rowNum].Cells[3].Value = t4;
                            this.dataGridViewByName.Rows[rowNum].Cells[4].Value = t5;
                            this.dataGridViewByName.Rows[rowNum].Cells[5].Value = t6;
                            this.dataGridViewByName.Rows[rowNum].Cells[6].Value = t7;
                            this.dataGridViewByName.Rows[rowNum].Cells[7].Value = t8;
                            this.dataGridViewByName.Rows[rowNum].Cells[8].Value = t9;
                            this.dataGridViewByName.Rows[rowNum].Cells[9].Value = t10;
                            this.dataGridViewByName.Rows[rowNum].Cells[10].Value = t11;
                            this.dataGridViewByName.Rows[rowNum].Cells[11].Value = t12;
                            rowNum += 1;

                            /*DetailOfAStudent detailOfStudent = new DetailOfAStudent(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
                            detailOfStudent.Show();
                            this.Hide();
                            */
                        }
                        toClear();

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

        public void searchName_Click(object sender, EventArgs e)
        {
            dataGridViewByName.Rows.Clear();
            dataGridViewEntry(txtName.Text);
        }

        
        

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentDetailCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sIU_StudentdatabaseDataSet.StudentMainDetail' table. You can move, or remove it, as needed.
            this.studentMainDetailTableAdapter.Fill(this.sIU_StudentdatabaseDataSet.StudentMainDetail);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dataGridViewByName.Rows[0].Selected = false;

            }
            catch { }
        }

        private void dataGridViewByName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewByName.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int index1 = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewByName.Rows[index1];
            String t1 = selectedRow.Cells[0].Value.ToString();
            String t2 = selectedRow.Cells[1].Value.ToString();
            String t3 = selectedRow.Cells[2].Value.ToString();
            String t4 = selectedRow.Cells[3].Value.ToString();
            String t5 = selectedRow.Cells[4].Value.ToString();
            String t6 = selectedRow.Cells[5].Value.ToString();
            String t7 = selectedRow.Cells[6].Value.ToString();
            String t8 = selectedRow.Cells[7].Value.ToString();
            String t9 = selectedRow.Cells[8].Value.ToString();
            String t10 = selectedRow.Cells[9].Value.ToString();
            String t11= selectedRow.Cells[10].Value.ToString();
            String t12 = selectedRow.Cells[11].Value.ToString();

            DetailOfAStudent detailOfStudent = new DetailOfAStudent(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            detailOfStudent.Show();
            this.Hide();
        }

        private void textChangeID(object sender, EventArgs e)
        {
            searchId.Visible = true;
            searchName.Visible = false;
            txtName.Text = "";

        }

        private void textChangeName(object sender, EventArgs e)
        {
            searchId.Visible = false;
            searchName.Visible = true;
            txtStudentID.Text = "";
        }

        private void keyPressID(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.B & (Keys)e.KeyChar != Keys.M & (Keys)e.KeyChar != Keys.T)
            {
                e.Handled = true;
            }
        }

        private void keyPressName(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
