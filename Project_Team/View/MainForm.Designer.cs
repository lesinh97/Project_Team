namespace Project_Team
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl_Main = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Add = new System.Windows.Forms.PictureBox();
            this.pictureBox_Search = new System.Windows.Forms.PictureBox();
            this.pictureBox_Khac = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBTenLop = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.cBTenKhoa = new System.Windows.Forms.ComboBox();
            this.cBNienKhoa = new System.Windows.Forms.ComboBox();
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
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btEditThongTin = new System.Windows.Forms.Button();
            this.btEditDiem = new System.Windows.Forms.Button();
            this.cBSearchNienKhoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.bTSearch = new System.Windows.Forms.Button();
            this.cBSearchTenMonHoc = new System.Windows.Forms.ComboBox();
            this.cBSearchGVCN = new System.Windows.Forms.ComboBox();
            this.cBSearchTenKhoa = new System.Windows.Forms.ComboBox();
            this.cBSearchTenLop = new System.Windows.Forms.ComboBox();
            this.txtSearchTenSinhVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSearchMaSinhVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabKhac = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Add_GV = new System.Windows.Forms.PictureBox();
            this.pictureBox_Add_Lop = new System.Windows.Forms.PictureBox();
            this.pictureBox_Add_Khoa = new System.Windows.Forms.PictureBox();
            this.pictureBox_Excel = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl_Main.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Khac)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabKhac.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add_Khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.tabHome);
            this.TabControl_Main.Controls.Add(this.tabAdd);
            this.TabControl_Main.Controls.Add(this.tabSearch);
            this.TabControl_Main.Controls.Add(this.tabKhac);
            this.TabControl_Main.Depth = 0;
            resources.ApplyResources(this.TabControl_Main, "TabControl_Main");
            this.TabControl_Main.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.groupBox1);
            this.tabHome.Controls.Add(this.label1);
            resources.ApplyResources(this.tabHome, "tabHome");
            this.tabHome.Name = "tabHome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Add);
            this.groupBox1.Controls.Add(this.pictureBox_Search);
            this.groupBox1.Controls.Add(this.pictureBox_Khac);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox_Add
            // 
            this.pictureBox_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_Add, "pictureBox_Add");
            this.pictureBox_Add.Name = "pictureBox_Add";
            this.pictureBox_Add.TabStop = false;
            this.pictureBox_Add.Click += new System.EventHandler(this.pictureBox_Add_Click);
            // 
            // pictureBox_Search
            // 
            resources.ApplyResources(this.pictureBox_Search, "pictureBox_Search");
            this.pictureBox_Search.Name = "pictureBox_Search";
            this.pictureBox_Search.TabStop = false;
            this.pictureBox_Search.Click += new System.EventHandler(this.pictureBox_Search_Click);
            // 
            // pictureBox_Khac
            // 
            resources.ApplyResources(this.pictureBox_Khac, "pictureBox_Khac");
            this.pictureBox_Khac.Name = "pictureBox_Khac";
            this.pictureBox_Khac.TabStop = false;
            this.pictureBox_Khac.Click += new System.EventHandler(this.pictureBox_Khac_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.Controls.Add(this.lbTieuDe);
            this.tabAdd.Controls.Add(this.groupBox3);
            this.tabAdd.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabAdd, "tabAdd");
            this.tabAdd.Name = "tabAdd";
            // 
            // lbTieuDe
            // 
            resources.ApplyResources(this.lbTieuDe, "lbTieuDe");
            this.lbTieuDe.Name = "lbTieuDe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBTenLop);
            this.groupBox3.Controls.Add(this.btAdd);
            this.groupBox3.Controls.Add(this.cBTenKhoa);
            this.groupBox3.Controls.Add(this.cBNienKhoa);
            this.groupBox3.Controls.Add(this.lbNienKhoa);
            this.groupBox3.Controls.Add(this.lbKhoa);
            this.groupBox3.Controls.Add(this.lbLop);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cBTenLop
            // 
            this.cBTenLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTenLop.FormattingEnabled = true;
            resources.ApplyResources(this.cBTenLop, "cBTenLop");
            this.cBTenLop.Name = "cBTenLop";
            // 
            // btAdd
            // 
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Name = "btAdd";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cBTenKhoa
            // 
            this.cBTenKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBTenKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTenKhoa.FormattingEnabled = true;
            resources.ApplyResources(this.cBTenKhoa, "cBTenKhoa");
            this.cBTenKhoa.Name = "cBTenKhoa";
            // 
            // cBNienKhoa
            // 
            this.cBNienKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBNienKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNienKhoa.FormattingEnabled = true;
            resources.ApplyResources(this.cBNienKhoa, "cBNienKhoa");
            this.cBNienKhoa.Name = "cBNienKhoa";
            // 
            // lbNienKhoa
            // 
            resources.ApplyResources(this.lbNienKhoa, "lbNienKhoa");
            this.lbNienKhoa.Name = "lbNienKhoa";
            // 
            // lbKhoa
            // 
            resources.ApplyResources(this.lbKhoa, "lbKhoa");
            this.lbKhoa.Name = "lbKhoa";
            // 
            // lbLop
            // 
            resources.ApplyResources(this.lbLop, "lbLop");
            this.lbLop.Name = "lbLop";
            // 
            // groupBox2
            // 
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rBNu
            // 
            resources.ApplyResources(this.rBNu, "rBNu");
            this.rBNu.Name = "rBNu";
            this.rBNu.TabStop = true;
            this.rBNu.UseVisualStyleBackColor = true;
            // 
            // rBNam
            // 
            resources.ApplyResources(this.rBNam, "rBNam");
            this.rBNam.Checked = true;
            this.rBNam.Name = "rBNam";
            this.rBNam.TabStop = true;
            this.rBNam.UseVisualStyleBackColor = true;
            // 
            // cBQueQuan
            // 
            this.cBQueQuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBQueQuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBQueQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBQueQuan.FormattingEnabled = true;
            this.cBQueQuan.Items.AddRange(new object[] {
            resources.GetString("cBQueQuan.Items"),
            resources.GetString("cBQueQuan.Items1"),
            resources.GetString("cBQueQuan.Items2"),
            resources.GetString("cBQueQuan.Items3"),
            resources.GetString("cBQueQuan.Items4"),
            resources.GetString("cBQueQuan.Items5"),
            resources.GetString("cBQueQuan.Items6"),
            resources.GetString("cBQueQuan.Items7"),
            resources.GetString("cBQueQuan.Items8"),
            resources.GetString("cBQueQuan.Items9"),
            resources.GetString("cBQueQuan.Items10"),
            resources.GetString("cBQueQuan.Items11"),
            resources.GetString("cBQueQuan.Items12"),
            resources.GetString("cBQueQuan.Items13"),
            resources.GetString("cBQueQuan.Items14"),
            resources.GetString("cBQueQuan.Items15"),
            resources.GetString("cBQueQuan.Items16"),
            resources.GetString("cBQueQuan.Items17"),
            resources.GetString("cBQueQuan.Items18"),
            resources.GetString("cBQueQuan.Items19"),
            resources.GetString("cBQueQuan.Items20"),
            resources.GetString("cBQueQuan.Items21"),
            resources.GetString("cBQueQuan.Items22"),
            resources.GetString("cBQueQuan.Items23"),
            resources.GetString("cBQueQuan.Items24"),
            resources.GetString("cBQueQuan.Items25"),
            resources.GetString("cBQueQuan.Items26"),
            resources.GetString("cBQueQuan.Items27"),
            resources.GetString("cBQueQuan.Items28"),
            resources.GetString("cBQueQuan.Items29"),
            resources.GetString("cBQueQuan.Items30"),
            resources.GetString("cBQueQuan.Items31"),
            resources.GetString("cBQueQuan.Items32"),
            resources.GetString("cBQueQuan.Items33"),
            resources.GetString("cBQueQuan.Items34"),
            resources.GetString("cBQueQuan.Items35"),
            resources.GetString("cBQueQuan.Items36"),
            resources.GetString("cBQueQuan.Items37"),
            resources.GetString("cBQueQuan.Items38"),
            resources.GetString("cBQueQuan.Items39"),
            resources.GetString("cBQueQuan.Items40"),
            resources.GetString("cBQueQuan.Items41"),
            resources.GetString("cBQueQuan.Items42"),
            resources.GetString("cBQueQuan.Items43"),
            resources.GetString("cBQueQuan.Items44"),
            resources.GetString("cBQueQuan.Items45"),
            resources.GetString("cBQueQuan.Items46"),
            resources.GetString("cBQueQuan.Items47"),
            resources.GetString("cBQueQuan.Items48"),
            resources.GetString("cBQueQuan.Items49"),
            resources.GetString("cBQueQuan.Items50"),
            resources.GetString("cBQueQuan.Items51"),
            resources.GetString("cBQueQuan.Items52"),
            resources.GetString("cBQueQuan.Items53"),
            resources.GetString("cBQueQuan.Items54"),
            resources.GetString("cBQueQuan.Items55"),
            resources.GetString("cBQueQuan.Items56"),
            resources.GetString("cBQueQuan.Items57"),
            resources.GetString("cBQueQuan.Items58"),
            resources.GetString("cBQueQuan.Items59"),
            resources.GetString("cBQueQuan.Items60"),
            resources.GetString("cBQueQuan.Items61"),
            resources.GetString("cBQueQuan.Items62")});
            resources.ApplyResources(this.cBQueQuan, "cBQueQuan");
            this.cBQueQuan.Name = "cBQueQuan";
            // 
            // dTNgaySinh
            // 
            this.dTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dTNgaySinh, "dTNgaySinh");
            this.dTNgaySinh.Name = "dTNgaySinh";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Depth = 0;
            this.txtTenSinhVien.Hint = "";
            resources.ApplyResources(this.txtTenSinhVien, "txtTenSinhVien");
            this.txtTenSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.PasswordChar = '\0';
            this.txtTenSinhVien.SelectedText = "";
            this.txtTenSinhVien.SelectionLength = 0;
            this.txtTenSinhVien.SelectionStart = 0;
            this.txtTenSinhVien.UseSystemPasswordChar = false;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Depth = 0;
            this.txtMaSinhVien.Hint = "";
            resources.ApplyResources(this.txtMaSinhVien, "txtMaSinhVien");
            this.txtMaSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.PasswordChar = '\0';
            this.txtMaSinhVien.SelectedText = "";
            this.txtMaSinhVien.SelectionLength = 0;
            this.txtMaSinhVien.SelectionStart = 0;
            this.txtMaSinhVien.UseSystemPasswordChar = false;
            // 
            // lbGioiTinh
            // 
            resources.ApplyResources(this.lbGioiTinh, "lbGioiTinh");
            this.lbGioiTinh.Name = "lbGioiTinh";
            // 
            // lbNgaySinh
            // 
            resources.ApplyResources(this.lbNgaySinh, "lbNgaySinh");
            this.lbNgaySinh.Name = "lbNgaySinh";
            // 
            // lbQueQuan
            // 
            resources.ApplyResources(this.lbQueQuan, "lbQueQuan");
            this.lbQueQuan.Name = "lbQueQuan";
            // 
            // lbHoTen
            // 
            resources.ApplyResources(this.lbHoTen, "lbHoTen");
            this.lbHoTen.Name = "lbHoTen";
            // 
            // lbMSSV
            // 
            resources.ApplyResources(this.lbMSSV, "lbMSSV");
            this.lbMSSV.Name = "lbMSSV";
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.White;
            this.tabSearch.Controls.Add(this.btEditThongTin);
            this.tabSearch.Controls.Add(this.btEditDiem);
            this.tabSearch.Controls.Add(this.cBSearchNienKhoa);
            this.tabSearch.Controls.Add(this.label9);
            this.tabSearch.Controls.Add(this.groupBox4);
            this.tabSearch.Controls.Add(this.label2);
            this.tabSearch.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabSearch, "tabSearch");
            this.tabSearch.Name = "tabSearch";
            // 
            // btEditThongTin
            // 
            resources.ApplyResources(this.btEditThongTin, "btEditThongTin");
            this.btEditThongTin.Name = "btEditThongTin";
            this.btEditThongTin.UseVisualStyleBackColor = true;
            this.btEditThongTin.Click += new System.EventHandler(this.btEditThongTin_Click);
            // 
            // btEditDiem
            // 
            resources.ApplyResources(this.btEditDiem, "btEditDiem");
            this.btEditDiem.Name = "btEditDiem";
            this.btEditDiem.UseVisualStyleBackColor = true;
            this.btEditDiem.Click += new System.EventHandler(this.btEditDiem_Click);
            // 
            // cBSearchNienKhoa
            // 
            this.cBSearchNienKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBSearchNienKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBSearchNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSearchNienKhoa.FormattingEnabled = true;
            resources.ApplyResources(this.cBSearchNienKhoa, "cBSearchNienKhoa");
            this.cBSearchNienKhoa.Name = "cBSearchNienKhoa";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btClear);
            this.groupBox4.Controls.Add(this.bTSearch);
            this.groupBox4.Controls.Add(this.cBSearchTenMonHoc);
            this.groupBox4.Controls.Add(this.cBSearchGVCN);
            this.groupBox4.Controls.Add(this.cBSearchTenKhoa);
            this.groupBox4.Controls.Add(this.cBSearchTenLop);
            this.groupBox4.Controls.Add(this.txtSearchTenSinhVien);
            this.groupBox4.Controls.Add(this.txtSearchMaSinhVien);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // btClear
            // 
            resources.ApplyResources(this.btClear, "btClear");
            this.btClear.Name = "btClear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // bTSearch
            // 
            resources.ApplyResources(this.bTSearch, "bTSearch");
            this.bTSearch.Name = "bTSearch";
            this.bTSearch.UseVisualStyleBackColor = true;
            this.bTSearch.Click += new System.EventHandler(this.bTSearch_Click);
            // 
            // cBSearchTenMonHoc
            // 
            this.cBSearchTenMonHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBSearchTenMonHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBSearchTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSearchTenMonHoc.FormattingEnabled = true;
            resources.ApplyResources(this.cBSearchTenMonHoc, "cBSearchTenMonHoc");
            this.cBSearchTenMonHoc.Name = "cBSearchTenMonHoc";
            // 
            // cBSearchGVCN
            // 
            this.cBSearchGVCN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBSearchGVCN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBSearchGVCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSearchGVCN.FormattingEnabled = true;
            resources.ApplyResources(this.cBSearchGVCN, "cBSearchGVCN");
            this.cBSearchGVCN.Name = "cBSearchGVCN";
            // 
            // cBSearchTenKhoa
            // 
            this.cBSearchTenKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBSearchTenKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBSearchTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSearchTenKhoa.FormattingEnabled = true;
            resources.ApplyResources(this.cBSearchTenKhoa, "cBSearchTenKhoa");
            this.cBSearchTenKhoa.Name = "cBSearchTenKhoa";
            // 
            // cBSearchTenLop
            // 
            this.cBSearchTenLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBSearchTenLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBSearchTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSearchTenLop.FormattingEnabled = true;
            resources.ApplyResources(this.cBSearchTenLop, "cBSearchTenLop");
            this.cBSearchTenLop.Name = "cBSearchTenLop";
            // 
            // txtSearchTenSinhVien
            // 
            this.txtSearchTenSinhVien.Depth = 0;
            this.txtSearchTenSinhVien.Hint = "";
            resources.ApplyResources(this.txtSearchTenSinhVien, "txtSearchTenSinhVien");
            this.txtSearchTenSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchTenSinhVien.Name = "txtSearchTenSinhVien";
            this.txtSearchTenSinhVien.PasswordChar = '\0';
            this.txtSearchTenSinhVien.SelectedText = "";
            this.txtSearchTenSinhVien.SelectionLength = 0;
            this.txtSearchTenSinhVien.SelectionStart = 0;
            this.txtSearchTenSinhVien.UseSystemPasswordChar = false;
            // 
            // txtSearchMaSinhVien
            // 
            this.txtSearchMaSinhVien.Depth = 0;
            this.txtSearchMaSinhVien.Hint = "";
            resources.ApplyResources(this.txtSearchMaSinhVien, "txtSearchMaSinhVien");
            this.txtSearchMaSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchMaSinhVien.Name = "txtSearchMaSinhVien";
            this.txtSearchMaSinhVien.PasswordChar = '\0';
            this.txtSearchMaSinhVien.SelectedText = "";
            this.txtSearchMaSinhVien.SelectionLength = 0;
            this.txtSearchMaSinhVien.SelectionStart = 0;
            this.txtSearchMaSinhVien.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tabKhac
            // 
            this.tabKhac.BackColor = System.Drawing.Color.White;
            this.tabKhac.Controls.Add(this.label10);
            this.tabKhac.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.tabKhac, "tabKhac");
            this.tabKhac.Name = "tabKhac";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox_Add_GV);
            this.groupBox5.Controls.Add(this.pictureBox_Add_Lop);
            this.groupBox5.Controls.Add(this.pictureBox_Add_Khoa);
            this.groupBox5.Controls.Add(this.pictureBox_Excel);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // pictureBox_Add_GV
            // 
            this.pictureBox_Add_GV.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox_Add_GV, "pictureBox_Add_GV");
            this.pictureBox_Add_GV.Name = "pictureBox_Add_GV";
            this.pictureBox_Add_GV.TabStop = false;
            this.pictureBox_Add_GV.Click += new System.EventHandler(this.pictureBox_Add_GV_Click);
            // 
            // pictureBox_Add_Lop
            // 
            resources.ApplyResources(this.pictureBox_Add_Lop, "pictureBox_Add_Lop");
            this.pictureBox_Add_Lop.Name = "pictureBox_Add_Lop";
            this.pictureBox_Add_Lop.TabStop = false;
            this.pictureBox_Add_Lop.Click += new System.EventHandler(this.pictureBox_Add_Lop_Click);
            // 
            // pictureBox_Add_Khoa
            // 
            resources.ApplyResources(this.pictureBox_Add_Khoa, "pictureBox_Add_Khoa");
            this.pictureBox_Add_Khoa.Name = "pictureBox_Add_Khoa";
            this.pictureBox_Add_Khoa.TabStop = false;
            this.pictureBox_Add_Khoa.Click += new System.EventHandler(this.pictureBox_Add_Khoa_Click);
            // 
            // pictureBox_Excel
            // 
            resources.ApplyResources(this.pictureBox_Excel, "pictureBox_Excel");
            this.pictureBox_Excel.Name = "pictureBox_Excel";
            this.pictureBox_Excel.TabStop = false;
            this.pictureBox_Excel.Click += new System.EventHandler(this.pictureBox_Excel_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TabControl_Main;
            this.materialTabSelector1.Depth = 0;
            resources.ApplyResources(this.materialTabSelector1, "materialTabSelector1");
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TabControl_Main);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.TabControl_Main.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Khac)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabKhac.ResumeLayout(false);
            this.tabKhac.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add_Khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Excel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl_Main;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabAdd;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Add;
        private System.Windows.Forms.PictureBox pictureBox_Khac;
        private System.Windows.Forms.PictureBox pictureBox_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbQueQuan;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.ComboBox cBQueQuan;
        private System.Windows.Forms.DateTimePicker dTNgaySinh;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenSinhVien;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaSinhVien;
        private System.Windows.Forms.Label lbNienKhoa;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.ComboBox cBTenKhoa;
        private System.Windows.Forms.ComboBox cBNienKhoa;
        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchTenSinhVien;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchMaSinhVien;
        private System.Windows.Forms.ComboBox cBSearchTenMonHoc;
        private System.Windows.Forms.ComboBox cBSearchGVCN;
        private System.Windows.Forms.ComboBox cBSearchTenKhoa;
        private System.Windows.Forms.ComboBox cBSearchTenLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBSearchNienKhoa;
        private System.Windows.Forms.Button bTSearch;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btEditThongTin;
        private System.Windows.Forms.Button btEditDiem;
        private System.Windows.Forms.ComboBox cBTenLop;
        private System.Windows.Forms.TabPage tabKhac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox_Add_GV;
        private System.Windows.Forms.PictureBox pictureBox_Add_Lop;
        private System.Windows.Forms.PictureBox pictureBox_Add_Khoa;
        private System.Windows.Forms.PictureBox pictureBox_Excel;
        private System.Windows.Forms.RadioButton rBNu;
        private System.Windows.Forms.RadioButton rBNam;
    }
}