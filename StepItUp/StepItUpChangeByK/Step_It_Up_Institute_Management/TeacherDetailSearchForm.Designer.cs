namespace Step_It_Up_Institute_Management
{
    partial class Clickbutton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.ViewDetailsbutton = new System.Windows.Forms.Button();
            this.TeacherDetaildataGridView = new System.Windows.Forms.DataGridView();
            this.teacherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherData = new Step_It_Up_Institute_Management.TeacherData();
            this.teacher_DetailsTableAdapter = new Step_It_Up_Institute_Management.TeacherDataTableAdapters.Teacher_DetailsTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDetaildataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher ID";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(166, 32);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(190, 20);
            this.FirstName.TabIndex = 1;
            // 
            // ViewDetailsbutton
            // 
            this.ViewDetailsbutton.Location = new System.Drawing.Point(412, 29);
            this.ViewDetailsbutton.Name = "ViewDetailsbutton";
            this.ViewDetailsbutton.Size = new System.Drawing.Size(97, 22);
            this.ViewDetailsbutton.TabIndex = 2;
            this.ViewDetailsbutton.Text = "ViewDetails";
            this.ViewDetailsbutton.UseVisualStyleBackColor = true;
            this.ViewDetailsbutton.Click += new System.EventHandler(this.ViewDetailsbutton_Click);
            // 
            // TeacherDetaildataGridView
            // 
            this.TeacherDetaildataGridView.AllowUserToAddRows = false;
            this.TeacherDetaildataGridView.AllowUserToDeleteRows = false;
            this.TeacherDetaildataGridView.AutoGenerateColumns = false;
            this.TeacherDetaildataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDetaildataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthYearDataGridViewTextBoxColumn,
            this.birthMonthDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn,
            this.studentFeeDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn});
            this.TeacherDetaildataGridView.DataSource = this.teacherDetailsBindingSource;
            this.TeacherDetaildataGridView.Location = new System.Drawing.Point(53, 115);
            this.TeacherDetaildataGridView.Name = "TeacherDetaildataGridView";
            this.TeacherDetaildataGridView.ReadOnly = true;
            this.TeacherDetaildataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeacherDetaildataGridView.Size = new System.Drawing.Size(738, 215);
            this.TeacherDetaildataGridView.TabIndex = 3;
            this.TeacherDetaildataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TeacherDetaildataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TeacherDetaildataGridview_click);
            // 
            // teacherIDDataGridViewTextBoxColumn
            // 
            this.teacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID";
            this.teacherIDDataGridViewTextBoxColumn.Name = "teacherIDDataGridViewTextBoxColumn";
            this.teacherIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthYearDataGridViewTextBoxColumn
            // 
            this.birthYearDataGridViewTextBoxColumn.DataPropertyName = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.HeaderText = "BirthYear";
            this.birthYearDataGridViewTextBoxColumn.Name = "birthYearDataGridViewTextBoxColumn";
            this.birthYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthMonthDataGridViewTextBoxColumn
            // 
            this.birthMonthDataGridViewTextBoxColumn.DataPropertyName = "BirthMonth";
            this.birthMonthDataGridViewTextBoxColumn.HeaderText = "BirthMonth";
            this.birthMonthDataGridViewTextBoxColumn.Name = "birthMonthDataGridViewTextBoxColumn";
            this.birthMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "TelephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            this.telephoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentFeeDataGridViewTextBoxColumn
            // 
            this.studentFeeDataGridViewTextBoxColumn.DataPropertyName = "StudentFee";
            this.studentFeeDataGridViewTextBoxColumn.HeaderText = "StudentFee";
            this.studentFeeDataGridViewTextBoxColumn.Name = "studentFeeDataGridViewTextBoxColumn";
            this.studentFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "EmailID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "EmailID";
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            this.emailIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherDetailsBindingSource
            // 
            this.teacherDetailsBindingSource.DataMember = "Teacher_Details";
            this.teacherDetailsBindingSource.DataSource = this.teacherData;
            // 
            // teacherData
            // 
            this.teacherData.DataSetName = "TeacherData";
            this.teacherData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacher_DetailsTableAdapter
            // 
            this.teacher_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 366);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(265, 366);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(371, 366);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(477, 366);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(583, 366);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(691, 366);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(53, 408);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(159, 408);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 14;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(265, 408);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(371, 408);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 16;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(477, 408);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 17;
            // 
            // Clickbutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 453);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TeacherDetaildataGridView);
            this.Controls.Add(this.ViewDetailsbutton);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Name = "Clickbutton";
            this.Text = "TeacherDetailSearchForm";
            this.Load += new System.EventHandler(this.TeacherDetailSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDetaildataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button ViewDetailsbutton;
        private System.Windows.Forms.DataGridView TeacherDetaildataGridView;
        private TeacherData teacherData;
        private System.Windows.Forms.BindingSource teacherDetailsBindingSource;
        private TeacherDataTableAdapters.Teacher_DetailsTableAdapter teacher_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}