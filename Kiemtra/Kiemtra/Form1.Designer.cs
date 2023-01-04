
namespace Kiemtra
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgDonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgHR = new System.Windows.Forms.DataGridView();
            this.dtgMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgGioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgNoisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbDonvi = new System.Windows.Forms.ComboBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.tbNoisinh = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHR)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 36;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(559, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(437, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(311, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(209, 415);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgDonvi
            // 
            this.dtgDonvi.DataPropertyName = "NameDepartment";
            this.dtgDonvi.HeaderText = "Don vi";
            this.dtgDonvi.MinimumWidth = 6;
            this.dtgDonvi.Name = "dtgDonvi";
            this.dtgDonvi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDonvi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtgDonvi.Width = 125;
            // 
            // dtgHR
            // 
            this.dtgHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgMa,
            this.dtgHoten,
            this.dtgNgaysinh,
            this.dtgGioitinh,
            this.dtgNoisinh,
            this.dtgDonvi});
            this.dtgHR.Location = new System.Drawing.Point(18, 137);
            this.dtgHR.Name = "dtgHR";
            this.dtgHR.RowHeadersWidth = 51;
            this.dtgHR.RowTemplate.Height = 24;
            this.dtgHR.Size = new System.Drawing.Size(736, 243);
            this.dtgHR.TabIndex = 31;
            this.dtgHR.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHR_RowEnter);
            // 
            // dtgMa
            // 
            this.dtgMa.DataPropertyName = "IdEmployee";
            this.dtgMa.HeaderText = "Ma";
            this.dtgMa.MinimumWidth = 6;
            this.dtgMa.Name = "dtgMa";
            this.dtgMa.Width = 108;
            // 
            // dtgHoten
            // 
            this.dtgHoten.DataPropertyName = "Name";
            this.dtgHoten.HeaderText = "Ho ten";
            this.dtgHoten.MinimumWidth = 6;
            this.dtgHoten.Name = "dtgHoten";
            this.dtgHoten.Width = 109;
            // 
            // dtgNgaysinh
            // 
            this.dtgNgaysinh.DataPropertyName = "DateBirth";
            this.dtgNgaysinh.HeaderText = "Ngay sinh";
            this.dtgNgaysinh.MinimumWidth = 6;
            this.dtgNgaysinh.Name = "dtgNgaysinh";
            this.dtgNgaysinh.Width = 108;
            // 
            // dtgGioitinh
            // 
            this.dtgGioitinh.DataPropertyName = "Gender";
            this.dtgGioitinh.HeaderText = "Gioi tinh";
            this.dtgGioitinh.MinimumWidth = 6;
            this.dtgGioitinh.Name = "dtgGioitinh";
            this.dtgGioitinh.Width = 108;
            // 
            // dtgNoisinh
            // 
            this.dtgNoisinh.DataPropertyName = "PlaceBirth";
            this.dtgNoisinh.HeaderText = "Noi sinh";
            this.dtgNoisinh.MinimumWidth = 6;
            this.dtgNoisinh.Name = "dtgNoisinh";
            this.dtgNoisinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgNoisinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtgNoisinh.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(585, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // cbDonvi
            // 
            this.cbDonvi.FormattingEnabled = true;
            this.cbDonvi.Items.AddRange(new object[] {
            "Ke toan",
            "Kinh doanh",
            "Nhan su"});
            this.cbDonvi.Location = new System.Drawing.Point(70, 61);
            this.cbDonvi.Name = "cbDonvi";
            this.cbDonvi.Size = new System.Drawing.Size(121, 24);
            this.cbDonvi.TabIndex = 29;
            // 
            // tbHoten
            // 
            this.tbHoten.Location = new System.Drawing.Point(311, 12);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(145, 22);
            this.tbHoten.TabIndex = 26;
            // 
            // tbNoisinh
            // 
            this.tbNoisinh.Location = new System.Drawing.Point(311, 68);
            this.tbNoisinh.Name = "tbNoisinh";
            this.tbNoisinh.Size = new System.Drawing.Size(145, 22);
            this.tbNoisinh.TabIndex = 27;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(510, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Gioi tinh: Nam";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Noi sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Don vi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngay sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ho ten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ma";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(70, 14);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(121, 22);
            this.tbMa.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgHR);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbDonvi);
            this.Controls.Add(this.tbHoten);
            this.Controls.Add(this.tbNoisinh);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDonvi;
        private System.Windows.Forms.DataGridView dtgHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNgaysinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNoisinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbDonvi;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.TextBox tbNoisinh;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMa;
    }
}

