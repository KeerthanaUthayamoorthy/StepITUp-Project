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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txtAdmin.Text = DateTime.Now.ToShortDateString();
            txtAdmin.ReadOnly = true;
            comboBatchItem();
        }

        void comboBatchItem() {
            try{
                String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";
                SqlConnection connecObj = new SqlConnection(connection);
                connecObj.Open();
                String batches = "select BatchName from BatchTable where Status='Active'";
                SqlCommand command = new SqlCommand(batches, connecObj);
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                   
                    Console.WriteLine(reader);
                    while (reader.Read())
                    {
                        String t1 = (String)reader[0];
                        cmbBatch.Items.Add(t1);
                    }cmbBatch.Sorted = true;
                }
                catch { }
            
            }catch{}
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.BackColor = Color.White;
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.BackColor = Color.White;
        }

        private void lblBatch_Click(object sender, EventArgs e)
        {

        }

        

        private void lblStream_Click(object sender, EventArgs e)
        {

        }

        private void cmbStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStream.BackColor = Color.White;
        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        

        private void cmbDOBMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDOBMonth.BackColor = Color.White;
        }

        private void cmbDOBDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDOBDay.BackColor = Color.White;
        }

        private void lblSex_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnMale.BackColor = Color.White;
            radioBtnFemale.BackColor = Color.White;
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnFemale.BackColor = Color.White;
            radioBtnMale.BackColor = Color.White;
        }

        private void lblSchoolName_Click(object sender, EventArgs e)
        {

        }

        private void txtSchoolName_TextChanged(object sender, EventArgs e)
        {
           txtSchoolName.BackColor = Color.White;
        }

        private void lblHomeAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtHomeAddress_TextChanged(object sender, EventArgs e)
        {
            txtHomeAddress.BackColor = Color.White;
        }

        private void lblTPNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtTPNumber_TextChanged(object sender, EventArgs e)
        {
            txtTPNumber.BackColor = Color.White;
        }

        private void lblAdmissionDate_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtFirstName.Text.Length < 1 || txtLastName.Text.Length < 1 || cmbBatch.Text=="(none)" || cmbStream.Text == "Choose..." || txtYear.Text == "Year" || cmbDOBMonth.Text == "Month" || cmbDOBDay.Text == "Day" || txtSchoolName.Text.Length < 1 || txtHomeAddress.Text.Length < 1  || (radioBtnFemale.Checked == false && radioBtnMale.Checked == false)|| txtTPNumber.Text.Length<1)
                {
                    MessageBox.Show("Please recheck...");

                    if (txtTPNumber.Text.Length != 10 && txtTPNumber.Text.Length !=0) {
                        txtTPNumber.BackColor = Color.IndianRed;
                    }

                    if (txtFirstName.Text.Length == 0) {
                        txtFirstName.BackColor = Color.IndianRed;
                    }
                    if (txtLastName.Text.Length == 0)
                    {
                        txtLastName.BackColor = Color.IndianRed;
                    }
                    if (cmbStream.Text== "Choose...")
                    {
                        cmbStream.BackColor = Color.IndianRed;
                    }
                    if (cmbBatch.Text=="(none)") {
                        cmbBatch.BackColor = Color.IndianRed;
                    }

                    if (radioBtnFemale.Checked==false && radioBtnMale.Checked==false) {
                        radioBtnFemale.BackColor = Color.IndianRed;
                        radioBtnMale.BackColor = Color.IndianRed;
                    }


                    if (cmbDOBDay.Text == "Day") { cmbDOBDay.BackColor = Color.IndianRed; }
                    if (cmbDOBMonth.Text == "Month") { cmbDOBMonth.BackColor = Color.IndianRed; }
                    if (txtYear.Text == "Year") { txtYear.BackColor = Color.IndianRed; }

                   
                    if (txtHomeAddress.Text.Length == 0)
                    {
                        txtHomeAddress.BackColor = Color.IndianRed;
                    }
                    if (txtSchoolName.Text.Length == 0)
                    {
                        txtSchoolName.BackColor = Color.IndianRed;
                    }
                }

                else
                {

                    String DOB = txtYear.Text + '-' + cmbDOBMonth.Text + '-' + cmbDOBDay.Text;
                    //String AdmissionDate = txtAdmin.Text;
                   // MessageBox.Show(AdmissionDate);
                    String Sex = "";
                    //int studentID = 0;

                    if (radioBtnMale.Checked)
                    {
                        Sex = "Male";
                    }
                    if (radioBtnFemale.Checked)
                    {
                        Sex = "Female";
                    }

                    //Connection string
                    String connec = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";
                    //open connection
                    SqlConnection connecObj = new SqlConnection(connec);
                    connecObj.Open();

                    //For studentID
                    String forId = "SELECT COUNT(*) FROM StudentMainDetail";
                    int count = 0;
                    //SqlConnection thisConnec = new SqlConnection(@"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True");
                    SqlCommand cmdCount = new SqlCommand(forId, connecObj);
                    //thisConnec.Open();
                    count = (int)cmdCount.ExecuteScalar();

                    String cmbStreamItem = cmbStream.SelectedItem.ToString();
                    String preLetter = cmbStreamItem.Substring(0,1);
                    String cmbBatchItem = cmbBatch.SelectedItem.ToString();
                    String preId1 = cmbBatchItem.Substring(2,2);
                    String preId = preLetter + preId1;
                    //StaticClass1.studentIDVal();
                    String postId1 = Convert.ToString(count);
                    // int s = StudentMainDetail.Data.Count();
                    for (int i = 0; i < (4 - postId1.Length); i++)
                    {
                        preId += '0';
                    }
                    String studentIDNo = preId + postId1;
                    //--------------------------------------------------------------------------------

                    //query
                    string query = "insert into StudentMainDetail(StudentID,FirstName,LastName,Batch,Stream,DateOfBirth,Sex,SchoolName,HomeAddress,TelephoneNumber,EmailAddress,AdmissionDate,StudentStatus) VALUES  ( '" + studentIDNo + "','" + txtFirstName.Text + "', '" + txtLastName.Text + "','" + cmbBatch.Text+ "','" + cmbStream.Text + "','" + DOB + "', '" + Sex + "', '" + txtSchoolName.Text + "', '" + txtHomeAddress.Text + "', '" + txtTPNumber.Text + "','" + txtEmail.Text + "', '" + txtAdmin.Text + "','Active')";

                    SqlCommand command = new SqlCommand(query, connecObj);


                    command.ExecuteNonQuery();

                    connecObj.Close();

                    MessageBox.Show("Student detail has been updated successfully....");
                    clearAll();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll() {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbBatch.Text = "(none)";
            cmbStream.Text = "Choose...";
            txtYear.Text = "Year";
            cmbDOBMonth.Text = "Month";
            cmbDOBDay.Text = "Day";
            txtSchoolName.Text = "";
            txtHomeAddress.Text = "";
            txtTPNumber.Text = "";
            txtEmail.Text = "";
            radioBtnFemale.Checked = false;
            radioBtnMale.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void keyPressFName(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' ')) {
                e.Handled = true;
            }
        }

        private void keyPressLName(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != (' '))
            {
                e.Handled = true;
            }

        }

        private void keyPressBatch(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void keyPressSchoolName(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('/'))
            {
                e.Handled = true;
            }
        }

        

        private void keyPressTelephoneNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void keyPressEmail(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTPNumber_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBatch.BackColor = Color.White;
        }

        private void textChangeYear(object sender, EventArgs e)
        {
            txtYear.BackColor = Color.White;
        }

        private void keyPressYear(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
