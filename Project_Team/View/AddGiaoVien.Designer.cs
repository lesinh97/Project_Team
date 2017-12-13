namespace Project_Team
{
    partial class AddGiaoVien
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
            this.txtTenGiaoVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMaGiaoVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btThoat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.txtGV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenGiaoVien.Depth = 0;
            this.txtTenGiaoVien.Hint = "";
            this.txtTenGiaoVien.Location = new System.Drawing.Point(123, 109);
            this.txtTenGiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenGiaoVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.PasswordChar = '\0';
            this.txtTenGiaoVien.SelectedText = "";
            this.txtTenGiaoVien.SelectionLength = 0;
            this.txtTenGiaoVien.SelectionStart = 0;
            this.txtTenGiaoVien.Size = new System.Drawing.Size(181, 23);
            this.txtTenGiaoVien.TabIndex = 10;
            this.txtTenGiaoVien.UseSystemPasswordChar = false;
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaGiaoVien.Depth = 0;
            this.txtMaGiaoVien.Hint = "";
            this.txtMaGiaoVien.Location = new System.Drawing.Point(264, 70);
            this.txtMaGiaoVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaGiaoVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.PasswordChar = '\0';
            this.txtMaGiaoVien.SelectedText = "";
            this.txtMaGiaoVien.SelectionLength = 0;
            this.txtMaGiaoVien.SelectionStart = 0;
            this.txtMaGiaoVien.Size = new System.Drawing.Size(40, 23);
            this.txtMaGiaoVien.TabIndex = 9;
            this.txtMaGiaoVien.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.Control;
            this.btClear.Depth = 0;
            this.btClear.Location = new System.Drawing.Point(151, 159);
            this.btClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btClear.Name = "btClear";
            this.btClear.Primary = true;
            this.btClear.Size = new System.Drawing.Size(63, 36);
            this.btClear.TabIndex = 23;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btThoat
            // 
            this.btThoat.Depth = 0;
            this.btThoat.Location = new System.Drawing.Point(240, 159);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThoat.Name = "btThoat";
            this.btThoat.Primary = true;
            this.btThoat.Size = new System.Drawing.Size(63, 36);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btOk
            // 
            this.btOk.Depth = 0;
            this.btOk.Location = new System.Drawing.Point(23, 159);
            this.btOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.Primary = true;
            this.btOk.Size = new System.Drawing.Size(91, 36);
            this.btOk.TabIndex = 22;
            this.btOk.Text = "Đồng ý";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.Location = new System.Drawing.Point(178, 70);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(81, 21);
            this.cbMaKhoa.TabIndex = 25;
            // 
            // txtGV
            // 
            this.txtGV.Depth = 0;
            this.txtGV.Enabled = false;
            this.txtGV.Hint = "";
            this.txtGV.Location = new System.Drawing.Point(123, 70);
            this.txtGV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGV.Name = "txtGV";
            this.txtGV.PasswordChar = '\0';
            this.txtGV.SelectedText = "";
            this.txtGV.SelectionLength = 0;
            this.txtGV.SelectionStart = 0;
            this.txtGV.Size = new System.Drawing.Size(49, 23);
            this.txtGV.TabIndex = 26;
            this.txtGV.Text = "GV_";
            this.txtGV.UseSystemPasswordChar = false;
            // 
            // AddGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 213);
            this.Controls.Add(this.txtGV);
            this.Controls.Add(this.cbMaKhoa);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtTenGiaoVien);
            this.Controls.Add(this.txtMaGiaoVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddGiaoVien";
            this.Text = "Thêm giáo viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenGiaoVien;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaGiaoVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton btClear;
        private MaterialSkin.Controls.MaterialRaisedButton btThoat;
        private MaterialSkin.Controls.MaterialRaisedButton btOk;
        private System.Windows.Forms.ComboBox cbMaKhoa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGV;
    }
}