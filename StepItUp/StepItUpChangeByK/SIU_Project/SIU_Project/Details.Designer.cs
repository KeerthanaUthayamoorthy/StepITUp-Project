namespace SIU_Project
{
    partial class Details
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
            this.sIU_StudentdatabaseDataSet = new SIU_Project.SIU_StudentdatabaseDataSet();
            this.sIUStudentdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStudentDetail = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.dataGridViewStudent1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMainDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMainDetailTableAdapter = new SIU_Project.SIU_StudentdatabaseDataSetTableAdapters.StudentMainDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sIU_StudentdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIUStudentdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMainDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // sIU_StudentdatabaseDataSet
            // 
            this.sIU_StudentdatabaseDataSet.DataSetName = "SIU_StudentdatabaseDataSet";
            this.sIU_StudentdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sIUStudentdatabaseDataSetBindingSource
            // 
            this.sIUStudentdatabaseDataSetBindingSource.DataSource = this.sIU_StudentdatabaseDataSet;
            this.sIUStudentdatabaseDataSetBindingSource.Position = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(261, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(445, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStudentDetail
            // 
            this.lblStudentDetail.AutoSize = true;
            this.lblStudentDetail.Location = new System.Drawing.Point(37, 29);
            this.lblStudentDetail.Name = "lblStudentDetail";
            this.lblStudentDetail.Size = new System.Drawing.Size(107, 13);
            this.lblStudentDetail.TabIndex = 6;
            this.lblStudentDetail.Text = "STUDENT DETAILS";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(32, 69);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(58, 13);
            this.lblStudentId.TabIndex = 7;
            this.lblStudentId.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(100, 60);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(148, 20);
            this.txtStudentID.TabIndex = 8;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // dataGridViewStudent1
            // 
            this.dataGridViewStudent1.AllowUserToAddRows = false;
            this.dataGridViewStudent1.AllowUserToDeleteRows = false;
            this.dataGridViewStudent1.AutoGenerateColumns = false;
            this.dataGridViewStudent1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.batchDataGridViewTextBoxColumn,
            this.streamDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.schoolNameDataGridViewTextBoxColumn,
            this.homeAddressDataGridViewTextBoxColumn,
            this.telephoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.admissionDateDataGridViewTextBoxColumn});
            this.dataGridViewStudent1.DataSource = this.studentMainDetailBindingSource;
            this.dataGridViewStudent1.Location = new System.Drawing.Point(76, 146);
            this.dataGridViewStudent1.Name = "dataGridViewStudent1";
            this.dataGridViewStudent1.ReadOnly = true;
            this.dataGridViewStudent1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent1.Size = new System.Drawing.Size(352, 235);
            this.dataGridViewStudent1.TabIndex = 9;
            this.dataGridViewStudent1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCellClick);
            this.dataGridViewStudent1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent1_CellContentClick);
            this.dataGridViewStudent1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataBindingComplete);
            this.dataGridViewStudent1.DoubleClick += new System.EventHandler(this.dataGridViewStudent1_DoubleClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "Batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "Batch";
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            this.batchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streamDataGridViewTextBoxColumn
            // 
            this.streamDataGridViewTextBoxColumn.DataPropertyName = "Stream";
            this.streamDataGridViewTextBoxColumn.HeaderText = "Stream";
            this.streamDataGridViewTextBoxColumn.Name = "streamDataGridViewTextBoxColumn";
            this.streamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolNameDataGridViewTextBoxColumn
            // 
            this.schoolNameDataGridViewTextBoxColumn.DataPropertyName = "SchoolName";
            this.schoolNameDataGridViewTextBoxColumn.HeaderText = "SchoolName";
            this.schoolNameDataGridViewTextBoxColumn.Name = "schoolNameDataGridViewTextBoxColumn";
            this.schoolNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeAddressDataGridViewTextBoxColumn
            // 
            this.homeAddressDataGridViewTextBoxColumn.DataPropertyName = "HomeAddress";
            this.homeAddressDataGridViewTextBoxColumn.HeaderText = "HomeAddress";
            this.homeAddressDataGridViewTextBoxColumn.Name = "homeAddressDataGridViewTextBoxColumn";
            this.homeAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneNumberDataGridViewTextBoxColumn
            // 
            this.telephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.HeaderText = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.Name = "telephoneNumberDataGridViewTextBoxColumn";
            this.telephoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // admissionDateDataGridViewTextBoxColumn
            // 
            this.admissionDateDataGridViewTextBoxColumn.DataPropertyName = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.HeaderText = "AdmissionDate";
            this.admissionDateDataGridViewTextBoxColumn.Name = "admissionDateDataGridViewTextBoxColumn";
            this.admissionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentMainDetailBindingSource
            // 
            this.studentMainDetailBindingSource.DataMember = "StudentMainDetail";
            this.studentMainDetailBindingSource.DataSource = this.sIUStudentdatabaseDataSetBindingSource;
            // 
            // studentMainDetailTableAdapter
            // 
            this.studentMainDetailTableAdapter.ClearBeforeFill = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 472);
            this.Controls.Add(this.dataGridViewStudent1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblStudentDetail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sIU_StudentdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIUStudentdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMainDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sIUStudentdatabaseDataSetBindingSource;
        private SIU_StudentdatabaseDataSet sIU_StudentdatabaseDataSet;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStudentDetail;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.DataGridView dataGridViewStudent1;
        private System.Windows.Forms.BindingSource studentMainDetailBindingSource;
        private SIU_StudentdatabaseDataSetTableAdapters.StudentMainDetailTableAdapter studentMainDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionDateDataGridViewTextBoxColumn;
    }
}