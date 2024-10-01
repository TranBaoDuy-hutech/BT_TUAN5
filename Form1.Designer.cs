namespace TH_B4
{
    partial class Form1
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblthongtin = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.AverageScore,
            this.Faculty});
            this.dgvStudent.Location = new System.Drawing.Point(391, 153);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(600, 241);
            this.dgvStudent.TabIndex = 11;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "MSSV";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ Tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 125;
            // 
            // AverageScore
            // 
            this.AverageScore.HeaderText = "Khoa";
            this.AverageScore.MinimumWidth = 6;
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.Width = 125;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Diem";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.Width = 125;
            // 
            // lblthongtin
            // 
            this.lblthongtin.AutoSize = true;
            this.lblthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblthongtin.Location = new System.Drawing.Point(166, 52);
            this.lblthongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthongtin.Name = "lblthongtin";
            this.lblthongtin.Size = new System.Drawing.Size(464, 39);
            this.lblthongtin.TabIndex = 10;
            this.lblthongtin.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(-108, 346);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(263, 392);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(142, 392);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // box
            // 
            this.box.Controls.Add(this.cmbFaculty);
            this.box.Controls.Add(this.txtAverageScore);
            this.box.Controls.Add(this.txtStudentID);
            this.box.Controls.Add(this.txtFullName);
            this.box.Controls.Add(this.label1);
            this.box.Controls.Add(this.lblAverageScore);
            this.box.Controls.Add(this.lblFullName);
            this.box.Controls.Add(this.lblStudentID);
            this.box.Location = new System.Drawing.Point(20, 153);
            this.box.Margin = new System.Windows.Forms.Padding(4);
            this.box.Name = "box";
            this.box.Padding = new System.Windows.Forms.Padding(4);
            this.box.Size = new System.Drawing.Size(343, 203);
            this.box.TabIndex = 12;
            this.box.TabStop = false;
            this.box.Text = "Thông Tin Sinh Viên";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(132, 146);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(121, 24);
            this.cmbFaculty.TabIndex = 7;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(132, 107);
            this.txtAverageScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(79, 22);
            this.txtAverageScore.TabIndex = 6;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(132, 30);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(128, 22);
            this.txtStudentID.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(132, 65);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(201, 22);
            this.txtFullName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khoa";
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(20, 113);
            this.lblAverageScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(59, 16);
            this.lblAverageScore.TabIndex = 5;
            this.lblAverageScore.Text = "Điểm TB";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 69);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(52, 16);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Họ Tên";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(20, 33);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(85, 16);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Mã Sinh Viên";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(13, 392);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 557);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.box);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lblthongtin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblthongtin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
    }
}

