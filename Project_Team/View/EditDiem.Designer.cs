namespace Project_Team
{
    partial class EditDiem
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBMaMonHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSinhVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btThoat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtMaSinhVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.numbCuoiKi = new System.Windows.Forms.NumericUpDown();
            this.numbGiuaKi = new System.Windows.Forms.NumericUpDown();
            this.numbChuyenCan = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numbCuoiKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbGiuaKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbChuyenCan)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(77, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên cần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(236, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giữa kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(397, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuối kỳ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(77, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Môn học";
            // 
            // cBMaMonHoc
            // 
            this.cBMaMonHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBMaMonHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMaMonHoc.FormattingEnabled = true;
            this.cBMaMonHoc.Location = new System.Drawing.Point(197, 197);
            this.cBMaMonHoc.Name = "cBMaMonHoc";
            this.cBMaMonHoc.Size = new System.Drawing.Size(217, 28);
            this.cBMaMonHoc.TabIndex = 7;
            this.cBMaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cBMaMonHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên sinh viên";
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenSinhVien.Depth = 0;
            this.txtTenSinhVien.Enabled = false;
            this.txtTenSinhVien.Hint = "";
            this.txtTenSinhVien.Location = new System.Drawing.Point(197, 151);
            this.txtTenSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.PasswordChar = '\0';
            this.txtTenSinhVien.SelectedText = "";
            this.txtTenSinhVien.SelectionLength = 0;
            this.txtTenSinhVien.SelectionStart = 0;
            this.txtTenSinhVien.Size = new System.Drawing.Size(291, 32);
            this.txtTenSinhVien.TabIndex = 14;
            this.txtTenSinhVien.UseSystemPasswordChar = false;
            // 
            // btOk
            // 
            this.btOk.Depth = 0;
            this.btOk.Location = new System.Drawing.Point(81, 338);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.Primary = true;
            this.btOk.Size = new System.Drawing.Size(136, 56);
            this.btOk.TabIndex = 16;
            this.btOk.Text = "Đồng ý";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btThoat
            // 
            this.btThoat.Depth = 0;
            this.btThoat.Location = new System.Drawing.Point(407, 338);
            this.btThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThoat.Name = "btThoat";
            this.btThoat.Primary = true;
            this.btThoat.Size = new System.Drawing.Size(94, 56);
            this.btThoat.TabIndex = 18;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.Depth = 0;
            this.btReset.Location = new System.Drawing.Point(273, 338);
            this.btReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btReset.Name = "btReset";
            this.btReset.Primary = true;
            this.btReset.Size = new System.Drawing.Size(94, 56);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaSinhVien.Depth = 0;
            this.txtMaSinhVien.Enabled = false;
            this.txtMaSinhVien.Hint = "";
            this.txtMaSinhVien.Location = new System.Drawing.Point(197, 100);
            this.txtMaSinhVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.PasswordChar = '\0';
            this.txtMaSinhVien.SelectedText = "";
            this.txtMaSinhVien.SelectionLength = 0;
            this.txtMaSinhVien.SelectionStart = 0;
            this.txtMaSinhVien.Size = new System.Drawing.Size(291, 32);
            this.txtMaSinhVien.TabIndex = 12;
            this.txtMaSinhVien.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã sinh viên";
            // 
            // numbCuoiKi
            // 
            this.numbCuoiKi.DecimalPlaces = 1;
            this.numbCuoiKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numbCuoiKi.Location = new System.Drawing.Point(402, 284);
            this.numbCuoiKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numbCuoiKi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numbCuoiKi.Name = "numbCuoiKi";
            this.numbCuoiKi.Size = new System.Drawing.Size(99, 26);
            this.numbCuoiKi.TabIndex = 24;
            // 
            // numbGiuaKi
            // 
            this.numbGiuaKi.DecimalPlaces = 1;
            this.numbGiuaKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numbGiuaKi.Location = new System.Drawing.Point(240, 284);
            this.numbGiuaKi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numbGiuaKi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numbGiuaKi.Name = "numbGiuaKi";
            this.numbGiuaKi.Size = new System.Drawing.Size(106, 26);
            this.numbGiuaKi.TabIndex = 23;
            // 
            // numbChuyenCan
            // 
            this.numbChuyenCan.DecimalPlaces = 1;
            this.numbChuyenCan.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numbChuyenCan.Location = new System.Drawing.Point(81, 284);
            this.numbChuyenCan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numbChuyenCan.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numbChuyenCan.Name = "numbChuyenCan";
            this.numbChuyenCan.Size = new System.Drawing.Size(102, 26);
            this.numbChuyenCan.TabIndex = 22;
            // 
            // EditDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 436);
            this.Controls.Add(this.numbCuoiKi);
            this.Controls.Add(this.numbGiuaKi);
            this.Controls.Add(this.numbChuyenCan);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBMaMonHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "EditDiem";
            this.Text = "Chỉnh sửa điểm";
            ((System.ComponentModel.ISupportInitialize)(this.numbCuoiKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbGiuaKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbChuyenCan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBMaMonHoc;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenSinhVien;
        private MaterialSkin.Controls.MaterialRaisedButton btOk;
        private MaterialSkin.Controls.MaterialRaisedButton btThoat;
        private MaterialSkin.Controls.MaterialRaisedButton btReset;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numbCuoiKi;
        private System.Windows.Forms.NumericUpDown numbGiuaKi;
        private System.Windows.Forms.NumericUpDown numbChuyenCan;
    }
}