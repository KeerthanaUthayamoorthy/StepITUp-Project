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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();

        }

        void toClear() {
            DataGridViewSelectionMode firstmode = dataGridViewStudent1.SelectionMode;
            dataGridViewStudent1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudent1.ClearSelection();
            dataGridViewStudent1.SelectionMode = firstmode;
        }


        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //int clicked = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //clicked = 1;
            try
            {
                int check = 0;
                toClear();

                foreach (DataGridViewRow row in dataGridViewStudent1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == txtStudentID.Text)
                    {
                        check = 1;
                        row.Selected = true;
                        break;
                    }
                }
                if (check == 0)
                {
                    MessageBox.Show("StudenID is Not found");
                }
                
            }
            catch { MessageBox.Show("Error..."); }


        } 

        private void Details_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'sIU_StudentdatabaseDataSet.StudentMainDetail' table. You can move, or remove it, as needed.
                this.studentMainDetailTableAdapter.Fill(this.sIU_StudentdatabaseDataSet.StudentMainDetail);
            }
            catch { }
        }

        private void dataGridViewStudent1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewStudent1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dataGridViewStudent1.Rows[0].Selected = false;

            }
            catch { }
        }

        private void dataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            dataGridViewStudent1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int index1 = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewStudent1.Rows[index1];
            //txtStudentID.Text = selectedRow.Cells[0].Value.ToString();


            
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
