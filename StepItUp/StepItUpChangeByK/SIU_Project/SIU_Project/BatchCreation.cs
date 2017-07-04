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
    public partial class BatchCreation : Form
    {
        public BatchCreation()
        {
            InitializeComponent();
            addItemToCombo();
        }

        // method to add items to comboBox

        void addItemToCombo()
        {
            
                String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";
                SqlConnection connectionObj = new SqlConnection(connection);
                connectionObj.Open();

                String query = "select BatchName from BatchTable where Status='Active' ";

                SqlCommand command = new SqlCommand(query, connectionObj);
                
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //String item = reader.GetTextReader("BatchName");
                    cmbRemove.Items.Add(reader["BatchName"]);
                    
                }
            }
            catch {
                MessageBox.Show(" adding to combo failed");
            }
           
        }

        private void txtBatchName_TextChanged(object sender, EventArgs e)
        {
            txtBatchName.BackColor = Color.White;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBatchName.Text.Length != 4)
                {
                    txtBatchName.BackColor = Color.IndianRed;
                }
                else { 
                String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";
                SqlConnection connectionObj = new SqlConnection(connection);
                connectionObj.Open();
                String status = "Active";
                String query = "insert into BatchTable(BatchName,Status) VALUES  ( '" + txtBatchName.Text + "','" + status + "')";

                SqlCommand command = new SqlCommand(query, connectionObj);

                command.ExecuteNonQuery();
                connectionObj.Close();

                MessageBox.Show("New Batch Is Created Successfully....\n If you want remove OLDEST BATCH then Select the batch and click Remove Button");
                cmbRemove.Items.Add(txtBatchName.Text);
                cmbRemove.Sorted = true;
            } 
            }
            catch {
                MessageBox.Show("creation failed");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String connection = @"Data Source=DESKTOP-MV18312;Initial Catalog=SIU_database;Integrated Security=True";
            SqlConnection connectionObj = new SqlConnection(connection);
            connectionObj.Open();

            string query = "update BatchTable set Status='Deactive' where BatchName=('" + cmbRemove.Text + "')";    

            SqlCommand command = new SqlCommand(query, connectionObj);
            command.ExecuteNonQuery();


            connectionObj.Close();
            if (cmbRemove.Text!="Select...") {
                cmbRemove.Items.Remove(cmbRemove.Text);

            }
            cmbRemove.Text = "Select...";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRemove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void batchNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
