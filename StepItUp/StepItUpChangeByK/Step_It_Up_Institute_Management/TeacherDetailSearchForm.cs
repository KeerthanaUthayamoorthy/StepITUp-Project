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

namespace Step_It_Up_Institute_Management
{
    public partial class Clickbutton : Form
    {
        

        public Clickbutton()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* DataTable Table = new DataTable();
             Table.Columns.Add("TeacherID",typeof(String));
             Table.Columns.Add("FirstName", typeof(String));
             Table.Columns.Add("LastName", typeof(String));
             Table.Columns.Add("BirthMonth", typeof(String));
             Table.Columns.Add("Sex", typeof(String));
             Table.Columns.Add("Subject", typeof(String));
             Table.Columns.Add("Address", typeof(String));
             Table.Columns.Add("TelephoneNo", typeof(int));
             Table.Columns.Add("StudentFee", typeof(int));
             Table.Columns.Add("EmailID", typeof(String));

             Table.Rows.Add(1,);
             TeacherDetaildataGridView.DataSource = Table;
             */
        }

        private void ViewDetailsbutton_Click(object sender, EventArgs e)
        {
            /*
            string conn = @"Data Source=desktop-d852h6d;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            String TeacherDetail = "SELECT COUNT(*) FROM Teacher_Details WHERE TeacherID=TeacherID.Text";

            SqlCommand cmd = new SqlCommand(TeacherDetail, connection);
           
            

            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.SelectCommand = cmd;
            DataTable DTable = new DataTable();
            SDA.Fill(DTable);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = DTable;
            TeacherDetaildataGridView.DataSource = bsource;
            SDA.Update(DTable);
            */
        }



        private void TeacherDetailSearchForm_Load(object sender, EventArgs e)
        {

            this.teacher_DetailsTableAdapter.Fill(this.teacherData.Teacher_Details);
        }

        private void button1_Click(object sender, EventArgs e)

        {/*
            string conn = @"Data Source=desktop-d852h6d;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            String TeacherDetail = "SELECT COUNT(*) FROM Teacher_Details WHERE TeacherID=TeacherID.Text";

            SqlCommand cmd = new SqlCommand(TeacherDetail, connection);
            SqlDataReader Line = cmd.ExecuteReader();
            if (Line.Read())
            {

                //string FirstName =Line.GetString("FirstName");
                textBox1.Text = Line.GetString("FirstName");
                   // Line["FirstName"]);

            }
            */

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            {
                /*
                String TeacherID = TeacherDetaildataGridView.SelectedRows[0].Cells[0].Value.ToString();
                String FirstName = TeacherDetaildataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string LastName = TeacherDetaildataGridView.SelectedRows[0].Cells[2].Value.ToString();
                String BirthYear = TeacherDetaildataGridView.SelectedRows[0].Cells[3].Value.ToString();
                String BirthMonth = TeacherDetaildataGridView.SelectedRows[0].Cells[4].Value.ToString();
                String BirthDate = TeacherDetaildataGridView.SelectedRows[0].Cells[5].Value.ToString();
                String Sex = TeacherDetaildataGridView.SelectedRows[0].Cells[6].Value.ToString();
                String Subject = TeacherDetaildataGridView.SelectedRows[0].Cells[7].Value.ToString();
                String Address= TeacherDetaildataGridView.SelectedRows[0].Cells[8].Value.ToString();
                String TelephoneNo = TeacherDetaildataGridView.SelectedRows[0].Cells[9].Value.ToString();
                String StudentFee = TeacherDetaildataGridView.SelectedRows[0].Cells[10].Value.ToString();
                String EmailID = TeacherDetaildataGridView.SelectedRows[0].Cells[11].Value.ToString();
                */
                textBox2.Text = TeacherDetaildataGridView.SelectedRows[0].Cells[0].Value.ToString();
                textBox3.Text = TeacherDetaildataGridView.SelectedRows[0].Cells[1].Value.ToString();

                //textBox4.Text = TeacherDetaildataGridView.SelectedRows[0].Cells[10].Value.ToString();


            }
        }
    }
}
