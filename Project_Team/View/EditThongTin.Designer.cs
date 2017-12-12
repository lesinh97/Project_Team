namespace Project_Team
{
    partial class EditThongTin
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBChuaTN = new System.Windows.Forms.RadioButton();
            this.rBDaTN = new System.Windows.Forms.RadioButton();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.cbTenKhoa = new System.Windows.Forms.ComboBox();
            this.cbNienKhoa = new System.Windows.Forms.ComboBox();
            this.lbNienKhoa = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBNu = new System.Windows.Forms.RadioButton();
            this.rBNam = new System.Windows.Forms.RadioButton();
            this.cBQueQuan = new System.Windows.Forms.ComboBox();
            this.dTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenSinhVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMaSinhVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbQueQuan = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.btReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btThoat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.rBChuaTN);
            this.groupBox3.Controls.Add(this.rBDaTN);
            this.groupBox3.Controls.Add(this.cbTenLop);
            this.groupBox3.Controls.Add(this.cbTenKhoa);
            this.groupBox3.Controls.Add(this.cbNienKhoa);
            this.groupBox3.Controls.Add(this.lbNienKhoa);
            this.groupBox3.Controls.Add(this.lbKhoa);
            this.groupBox3.Controls.Add(this.lbLop);
            this.groupBox3.Location = new System.Drawing.Point(718, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 288);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // rBChuaTN
            // 
            this.rBChuaTN.AutoSize = true;
            this.rBChuaTN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBChuaTN.Location = new System.Drawing.Point(255, 217);
            this.rBChuaTN.Name = "rBChuaTN";
            this.rBChuaTN.Size = new System.Drawing.Size(147, 24);
            this.rBChuaTN.TabIndex = 15;
            this.rBChuaTN.TabStop = true;
            this.rBChuaTN.Text = "Chưa tốt nghiệp";
            this.rBChuaTN.UseVisualStyleBackColor = true;
            // 
            // rBDaTN
            // 
            this.rBDaTN.AutoSize = true;
            this.rBDaTN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBDaTN.Location = new System.Drawing.Point(39, 217);
            this.rBDaTN.Name = "rBDaTN";
            this.rBDaTN.Size = new System.Drawing.Size(130, 24);
            this.rBDaTN.TabIndex = 14;
            this.rBDaTN.TabStop = true;
            this.rBDaTN.Text = "Đã tốt nghiệp";
            this.rBDaTN.UseVisualStyleBackColor = true;
            // 
            // cbTenLop
            // 
            this.cbTenLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(140, 105);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(176, 28);
            this.cbTenLop.TabIndex = 4;
            // 
            // cbTenKhoa
            // 
            this.cbTenKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenKhoa.FormattingEnabled = true;
            this.cbTenKhoa.Location = new System.Drawing.Point(140, 56);
            this.cbTenKhoa.Name = "cbTenKhoa";
            this.cbTenKhoa.Size = new System.Drawing.Size(176, 28);
            this.cbTenKhoa.TabIndex = 6;
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNienKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.Location = new System.Drawing.Point(140, 166);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(176, 28);
            this.cbNienKhoa.TabIndex = 5;
            // 
            // lbNienKhoa
            // 
            this.lbNienKhoa.AutoSize = true;
            this.lbNienKhoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNienKhoa.Location = new System.Drawing.Point(35, 166);
            this.lbNienKhoa.Name = "lbNienKhoa";
            this.lbNienKhoa.Size = new System.Drawing.Size(82, 20);
            this.lbNienKhoa.TabIndex = 2;
            this.lbNienKhoa.Text = "Niên Khóa";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbKhoa.Location = new System.Drawing.Point(35, 61);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(46, 20);
            this.lbKhoa.TabIndex = 1;
            this.lbKhoa.Text = "Khoa";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLop.Location = new System.Drawing.Point(35, 112);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(36, 20);
            this.lbLop.TabIndex = 0;
            this.lbLop.Text = "Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.rBNu);
            this.groupBox2.Controls.Add(this.rBNam);
            this.groupBox2.Controls.Add(this.cBQueQuan);
            this.groupBox2.Controls.Add(this.dTNgaySinh);
            this.groupBox2.Controls.Add(this.txtTenSinhVien);
            this.groupBox2.Controls.Add(this.txtMaSinhVien);
            this.groupBox2.Controls.Add(this.lbGioiTinh);
            this.groupBox2.Controls.Add(this.lbNgaySinh);
            this.groupBox2.Controls.Add(this.lbQueQuan);
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Controls.Add(this.lbMSSV);
            this.groupBox2.Location = new System.Drawing.Point(23, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 288);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cá nhân";
            // 
            // rBNu
            // 
            this.rBNu.AutoSize = true;
            this.rBNu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBNu.Location = new System.Drawing.Point(317, 252);
            this.rBNu.Name = "rBNu";
            this.rBNu.Size = new System.Drawing.Size(54, 24);
            this.rBNu.TabIndex = 12;
            this.rBNu.TabStop = true;
            this.rBNu.Text = "Nữ";
            this.rBNu.UseVisualStyleBackColor = true;
            // 
            // rBNam
            // 
            this.rBNam.AutoSize = true;
            this.rBNam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rBNam.Location = new System.Drawing.Point(143, 252);
            this.rBNam.Name = "rBNam";
            this.rBNam.Size = new System.Drawing.Size(67, 24);
            this.rBNam.TabIndex = 11;
            this.rBNam.TabStop = true;
            this.rBNam.Text = "Nam";
            this.rBNam.UseVisualStyleBackColor = true;
            // 
            // cBQueQuan
            // 
            this.cBQueQuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBQueQuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBQueQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBQueQuan.FormattingEnabled = true;
            this.cBQueQuan.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên ",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hồ Chí Minh",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam ",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên - Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cBQueQuan.Location = new System.Drawing.Point(143, 143);
            this.cBQueQuan.Name = "cBQueQuan";
            this.cBQueQuan.Size = new System.Drawing.Size(186, 28);
            this.cBQueQuan.TabIndex = 7;
            // 
            // dTNgaySinh
            // 
            this.dTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTNgaySinh.Location = new System.Drawing.Point(143, 195);
            this.dTNgaySinh.Name = "dTNgaySinh";
            this.dTNgaySinh.Size = new System.Drawing.Size(201, 26);
            this.dTNgaySinh.TabIndex = 8;
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Depth = 0;
            this.txtTenSinhVien.Hint = "";
            this.txtTenSinhVien.Location = new System.Drawing.Point(143, 83);
            this.txtTenSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.PasswordChar = '\0';
            this.txtTenSinhVien.SelectedText = "";
            this.txtTenSinhVien.SelectionLength = 0;
            this.txtTenSinhVien.SelectionStart = 0;
            this.txtTenSinhVien.Size = new System.Drawing.Size(304, 32);
            this.txtTenSinhVien.TabIndex = 6;
            this.txtTenSinhVien.UseSystemPasswordChar = false;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Depth = 0;
            this.txtMaSinhVien.Hint = "";
            this.txtMaSinhVien.Location = new System.Drawing.Point(143, 41);
            this.txtMaSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.PasswordChar = '\0';
            this.txtMaSinhVien.SelectedText = "";
            this.txtMaSinhVien.SelectionLength = 0;
            this.txtMaSinhVien.SelectionStart = 0;
            this.txtMaSinhVien.Size = new System.Drawing.Size(304, 32);
            this.txtMaSinhVien.TabIndex = 5;
            this.txtMaSinhVien.UseSystemPasswordChar = false;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbGioiTinh.Location = new System.Drawing.Point(36, 254);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới Tính";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNgaySinh.Location = new System.Drawing.Point(31, 201);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Ngày Sinh";
            // 
            // lbQueQuan
            // 
            this.lbQueQuan.AutoSize = true;
            this.lbQueQuan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbQueQuan.Location = new System.Drawing.Point(30, 146);
            this.lbQueQuan.Name = "lbQueQuan";
            this.lbQueQuan.Size = new System.Drawing.Size(82, 20);
            this.lbQueQuan.TabIndex = 2;
            this.lbQueQuan.Text = "Quê Quán";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbHoTen.Location = new System.Drawing.Point(30, 95);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(77, 20);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Họ và tên";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMSSV.Location = new System.Drawing.Point(30, 41);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(55, 20);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "MSSV";
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbTieuDe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTieuDe.Location = new System.Drawing.Point(222, 106);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(750, 52);
            this.lbTieuDe.TabIndex = 4;
            this.lbTieuDe.Text = "CHỈNH SỬA THÔNG TIN SINH VIÊN";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.Depth = 0;
            this.btReset.Location = new System.Drawing.Point(584, 500);
            this.btReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btReset.Name = "btReset";
            this.btReset.Primary = true;
            this.btReset.Size = new System.Drawing.Size(94, 56);
            this.btReset.TabIndex = 20;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btThoat
            // 
            this.btThoat.Depth = 0;
            this.btThoat.Location = new System.Drawing.Point(718, 500);
            this.btThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThoat.Name = "btThoat";
            this.btThoat.Primary = true;
            this.btThoat.Size = new System.Drawing.Size(94, 56);
            this.btThoat.TabIndex = 21;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btOk
            // 
            this.btOk.Depth = 0;
            this.btOk.Location = new System.Drawing.Point(392, 500);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.Primary = true;
            this.btOk.Size = new System.Drawing.Size(136, 56);
            this.btOk.TabIndex = 19;
            this.btOk.Text = "Đồng ý";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // EditThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 569);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "EditThongTin";
            this.Text = "Chỉnh sửa thông tin";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTenKhoa;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private System.Windows.Forms.Label lbNienKhoa;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBQueQuan;
        private System.Windows.Forms.DateTimePicker dTNgaySinh;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenSinhVien;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaSinhVien;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.ComboBox cbTenLop;
        private MaterialSkin.Controls.MaterialRaisedButton btReset;
        private MaterialSkin.Controls.MaterialRaisedButton btThoat;
        private MaterialSkin.Controls.MaterialRaisedButton btOk;
        private System.Windows.Forms.RadioButton rBNu;
        private System.Windows.Forms.RadioButton rBNam;
        private System.Windows.Forms.RadioButton rBChuaTN;
        private System.Windows.Forms.RadioButton rBDaTN;
    }
}