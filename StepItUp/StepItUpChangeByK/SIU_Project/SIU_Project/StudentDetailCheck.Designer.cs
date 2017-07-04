namespace SIU_Project
{
    partial class StudentDetailCheck
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.searchId = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.Button();
            this.studentMainDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sIU_StudentdatabaseDataSet = new SIU_Project.SIU_StudentdatabaseDataSet();
            this.studentMainDetailTableAdapter = new SIU_Project.SIU_StudentdatabaseDataSetTableAdapters.StudentMainDetailTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridViewByName = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentMainDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIU_StudentdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewByName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Student Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name(only)";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(271, 66);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 3;
            this.txtStudentID.TextChanged += new System.EventHandler(this.textChangeID);
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressID);
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(388, 66);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(75, 23);
            this.searchId.TabIndex = 6;
            this.searchId.Text = "Search";
            this.searchId.UseVisualStyleBackColor = true;
            this.searchId.Click += new System.EventHandler(this.searchId_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(389, 105);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(75, 23);
            this.searchName.TabIndex = 7;
            this.searchName.Text = "Search";
            this.searchName.UseVisualStyleBackColor = true;
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // studentMainDetailBindingSource
            // 
            this.studentMainDetailBindingSource.DataMember = "StudentMainDetail";
            this.studentMainDetailBindingSource.DataSource = this.sIU_StudentdatabaseDataSet;
            // 
            // sIU_StudentdatabaseDataSet
            // 
            this.sIU_StudentdatabaseDataSet.DataSetName = "SIU_StudentdatabaseDataSet";
            this.sIU_StudentdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentMainDetailTableAdapter
            // 
            this.studentMainDetailTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(290, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.textChangeName);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressName);
            // 
            // dataGridViewByName
            // 
            this.dataGridViewByName.AllowUserToAddRows = false;
            this.dataGridViewByName.AllowUserToDeleteRows = false;
            this.dataGridViewByName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewByName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Batch,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridViewByName.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewByName.Name = "dataGridViewByName";
            this.dataGridViewByName.ReadOnly = true;
            this.dataGridViewByName.Size = new System.Drawing.Size(445, 150);
            this.dataGridViewByName.TabIndex = 11;
            this.dataGridViewByName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewByName_CellClick);
            this.dataGridViewByName.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Batch
            // 
            this.Batch.HeaderText = "Batch";
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stream";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Of Birth";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sex";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "School Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Home Address";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Telephone Number";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Email Address";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Admission Date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Student ID";
            // 
            // StudentDetailCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewByName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDetailCheck";
            this.Text = "StudentDetailCheck";
            this.Load += new System.EventHandler(this.StudentDetailCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentMainDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIU_StudentdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewByName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button searchId;
        private System.Windows.Forms.Button searchName;
        private SIU_StudentdatabaseDataSet sIU_StudentdatabaseDataSet;
        private System.Windows.Forms.BindingSource studentMainDetailBindingSource;
        private SIU_StudentdatabaseDataSetTableAdapters.StudentMainDetailTableAdapter studentMainDetailTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridViewByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}