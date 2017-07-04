using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Step_It_Up_Institute_Management
{
    public partial class TeacherRegistration : Form
    {

        public TeacherRegistration()
        {
            InitializeComponent();
            BirthMonth.Text = "Month";
            BirthDate.Text = "Day";
            Subject.Text = "Choose.....";
        }


        //String TeacherID=" ";
        private void AddTeacherbutton_Click(object sender, EventArgs e)
        {
            //String TeacherIDNo = "TID";
            
            /*
            int count = 1;
            count = count+1;
            TeacherID = ID + string(count);  */
            String Sex = " ";

          
            
                
                try
                {
                if (FirstName.Text.Length < 1 || LastName.Text.Length < 1 || BirthYear.Text.Length < 1 || BirthMonth.Text == "Month" || BirthDate.Text == "Day" || Subject.Text=="Choose....." || Address.Text.Length < 1 || StudentFee.Text.Length < 1 || (MaleButton.Checked != true && FemaleButton.Checked != true))
                {
                    MessageBox.Show("Please fill all the required Boxes");
                }
                if(TelephoneNo.Text.Length != 10 && TelephoneNo.Text.Length != 0)
                {
                    TelephoneNo.BackColor=Color.Red;
                }
                else
                {
                    if (MaleButton.Checked)
                    {
                        Sex = MaleButton.Text;

                    }
                    if (FemaleButton.Checked)
                    {
                        Sex = FemaleButton.Text;

                    }
                    
                    string conn = @"Data Source=desktop-d852h6d;Initial Catalog=master;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(conn);
                    connection.Open(); //query
                    
                    //For TeacherID
                    String forId = "SELECT COUNT(*) FROM Teacher_Details";
                    int count = 0;
                    SqlCommand cmdCount = new SqlCommand(forId, connection);
                    //thisConnec.Open();
                    count = (int)cmdCount.ExecuteScalar();

                    String preId = "TID";
                    //StaticClass1.studentIDVal();
                    String postId1 = Convert.ToString(count);
                    // int s = StudentMainDetail.Data.Count();
                    for (int i = 0; i <= (3 - postId1.Length); i++)
                    {
                        preId += '0';
                    }
                    String TeacherIDNo = preId + postId1;

    

                    string query = "insert into Teacher_Details(TeacherID,FirstName,LastName,BirthYear,BirthMonth,BirthDate,Sex,Subject,Address,TelephoneNo,StudentFee,EmailID) VALUES  ('" + TeacherIDNo + "','" + FirstName.Text + "', '" + LastName.Text + "', '" + BirthYear.Text + "', '" + BirthMonth.Text + "', '" + BirthDate.Text + "', '" + Sex + "', '" + Subject.Text + "', '" + Address.Text + "', '" + TelephoneNo.Text + "', '" + StudentFee.Text + "', '" + EmailID.Text + "')";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Teacher Details has been successfully added");
                    ClearAll();
                }
                }
            
            catch
            {
                MessageBox.Show("Error occured in teacher addition");

            }
        }
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {

            FirstName.Text = " ";
            LastName.Text = " ";
            BirthYear.Text = " ";
            BirthMonth.Text = "Month";
            BirthDate.Text = "Day";
            Subject.Text = "Choose.....";
            Address.Text = " ";
            TelephoneNo.Text = " ";
            StudentFee.Text = " ";
            EmailID.Text = " ";
            MaleButton.Checked = false;
            FemaleButton.Checked = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FirstNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void LastNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }

        }

        private void YearKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }

        }

        

        private void AddressKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) & !Char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' ') & e.KeyChar != (',') & e.KeyChar != ('"') & e.KeyChar != ('.') & e.KeyChar != ('/'))
            {
                e.Handled = true;
            }

        }

        private void TelephoneKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void StudentFeeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.'))
            {
                e.Handled = true;
            }

        }

        private void EmailIDKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) & !Char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('.') & e.KeyChar != ('@'))
            {
                e.Handled = true;
            }

        }
        private void TelephoneNo_TextChanged(object sender, EventArgs e)
        {
            TelephoneNo.BackColor = Color.White;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BirthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void Subject_TextChanged(object sender, EventArgs e)
        {


        }

        private void BirthYear_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
