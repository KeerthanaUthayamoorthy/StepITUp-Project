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
    public partial class DetailOfAStudent : Form
    {
        //ConfirmRemovalOfStudent COS1 = new ConfirmRemovalOfStudent();
        StudentDetailCheck studentCheckForm = new StudentDetailCheck();
        public DetailOfAStudent(String t1, String t2, String t3, String t4, String t5, String t6, String t7, String t8, String t9, String t10, String t11, String t12)
        {
            InitializeComponent();
            StudentID.Text = t1;
            
            FirstName.Text = t2;
            LastName.Text = t3;
            Batch.Text = t4;
            Stream.Text = t5;
            DateOfBirth.Text = t6;
            Sex.Text = t7;
            SchoolName.Text = t8;
            HomeAddress.Text = t9;
            TelephoneNumber.Text = t10;
            EmailAddress.Text = t11;
            AdmissionDate.Text = t12;
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            studentCheckForm.Show();
        }

        static string valueget(String t1) {
            return t1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String connec = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";
                //open connection
                SqlConnection connecObj = new SqlConnection(connec);
                connecObj.Open();
                string query = "update StudentMainDetail set FirstName='" + FirstName.Text + "',LastName='" + LastName.Text + "',Batch='" + Batch.Text + "',Stream='" + Stream.Text + "',DateOfBirth='" + DateOfBirth.Text + "',Sex='" + Sex.Text + "',SchoolName='" + SchoolName.Text + "',HomeAddress='" + HomeAddress.Text + "',TelephoneNumber='" + TelephoneNumber.Text + "',EmailAddress='" + EmailAddress.Text + "',AdmissionDate='" + AdmissionDate.Text + "' where StudentID='" + StudentID.Text + "'";

                SqlCommand command = new SqlCommand(query, connecObj);


                command.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");
                connecObj.Close();

            }
            catch
            {
                MessageBox.Show("Error warning");
            }
            
                
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            
            studentCheckForm.dataGridViewEntry(FirstName.Text);
            studentCheckForm.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Hide();

            ConfirmRemovalOfStudent cRS = new ConfirmRemovalOfStudent(StudentID.Text);
            MessageBox.Show(StudentID.Text);
            cRS.Show();
        }
    }
}
