namespace SIU_Project
{
    partial class BatchCreation
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
            this.lblbatchCreation = new System.Windows.Forms.Label();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRemove = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbRemove = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblbatchCreation
            // 
            this.lblbatchCreation.AutoSize = true;
            this.lblbatchCreation.Location = new System.Drawing.Point(141, 22);
            this.lblbatchCreation.Name = "lblbatchCreation";
            this.lblbatchCreation.Size = new System.Drawing.Size(130, 13);
            this.lblbatchCreation.TabIndex = 0;
            this.lblbatchCreation.Text = "NEW BATCH CREATION";
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.Location = new System.Drawing.Point(76, 113);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(91, 13);
            this.lblBatchName.TabIndex = 1;
            this.lblBatchName.Text = "New Batch Name";
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(244, 113);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(100, 20);
            this.txtBatchName.TabIndex = 2;
            this.txtBatchName.TextChanged += new System.EventHandler(this.txtBatchName_TextChanged);
            this.txtBatchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.batchNameKeyPress);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(244, 156);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(382, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(76, 258);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(111, 13);
            this.lblRemove.TabIndex = 5;
            this.lblRemove.Text = "Remove Oldest Batch";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(255, 278);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmbRemove
            // 
            this.cmbRemove.FormattingEnabled = true;
            this.cmbRemove.Location = new System.Drawing.Point(244, 250);
            this.cmbRemove.Name = "cmbRemove";
            this.cmbRemove.Size = new System.Drawing.Size(98, 21);
            this.cmbRemove.TabIndex = 7;
            this.cmbRemove.Text = "Select...";
            this.cmbRemove.SelectedIndexChanged += new System.EventHandler(this.cmbRemove_SelectedIndexChanged);
            // 
            // BatchCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 430);
            this.Controls.Add(this.cmbRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBatchName);
            this.Controls.Add(this.lblBatchName);
            this.Controls.Add(this.lblbatchCreation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatchCreation";
            this.Text = "BatchCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbatchCreation;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbRemove;
    }
}