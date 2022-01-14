
namespace Cau1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlaceBirth = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(61, 12);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(125, 27);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(268, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(479, 14);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(250, 27);
            this.dtBirth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn vị ";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(61, 57);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(151, 28);
            this.cbDepartment.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nơi sinh";
            // 
            // tbPlaceBirth
            // 
            this.tbPlaceBirth.Location = new System.Drawing.Point(287, 55);
            this.tbPlaceBirth.Name = "tbPlaceBirth";
            this.tbPlaceBirth.Size = new System.Drawing.Size(320, 27);
            this.tbPlaceBirth.TabIndex = 10;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 124);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(843, 336);
            this.dgvEmployee.TabIndex = 11;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdEmployee";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateBirth";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gender";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PlaceBirth";
            this.Column5.HeaderText = "Nơi sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Department";
            this.Column6.HeaderText = "Đơn vị";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(379, 505);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(494, 505);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(620, 505);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(735, 504);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(735, 16);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(120, 24);
            this.cbGender.TabIndex = 6;
            this.cbGender.Text = "Giới tính nam";
            this.cbGender.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.tbPlaceBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlaceBirth;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox cbGender;
    }
}

