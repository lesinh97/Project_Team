namespace Project_Team
{
    partial class AddLop
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
            this.txtTenLop = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMaLop = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBMaKhoa = new System.Windows.Forms.ComboBox();
            this.cBMaGV = new System.Windows.Forms.ComboBox();
            this.btClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btThoat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtTenLop
            // 
            this.txtTenLop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenLop.Depth = 0;
            this.txtTenLop.Hint = "";
            this.txtTenLop.Location = new System.Drawing.Point(111, 111);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLop.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PasswordChar = '\0';
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.SelectionLength = 0;
            this.txtTenLop.SelectionStart = 0;
            this.txtTenLop.Size = new System.Drawing.Size(181, 23);
            this.txtTenLop.TabIndex = 10;
            this.txtTenLop.UseSystemPasswordChar = false;
            // 
            // txtMaLop
            // 
            this.txtMaLop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaLop.Depth = 0;
            this.txtMaLop.Hint = "";
            this.txtMaLop.Location = new System.Drawing.Point(111, 71);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLop.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.PasswordChar = '\0';
            this.txtMaLop.SelectedText = "";
            this.txtMaLop.SelectionLength = 0;
            this.txtMaLop.SelectionStart = 0;
            this.txtMaLop.Size = new System.Drawing.Size(181, 23);
            this.txtMaLop.TabIndex = 9;
            this.txtMaLop.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(44, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã GVCN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Khoa";
            // 
            // cBMaKhoa
            // 
            this.cBMaKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBMaKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMaKhoa.FormattingEnabled = true;
            this.cBMaKhoa.Location = new System.Drawing.Point(111, 153);
            this.cBMaKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBMaKhoa.Name = "cBMaKhoa";
            this.cBMaKhoa.Size = new System.Drawing.Size(182, 21);
            this.cBMaKhoa.TabIndex = 15;
            // 
            // cBMaGV
            // 
            this.cBMaGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBMaGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMaGV.FormattingEnabled = true;
            this.cBMaGV.Location = new System.Drawing.Point(111, 183);
            this.cBMaGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBMaGV.Name = "cBMaGV";
            this.cBMaGV.Size = new System.Drawing.Size(182, 21);
            this.cBMaGV.TabIndex = 16;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.Control;
            this.btClear.Depth = 0;
            this.btClear.Location = new System.Drawing.Point(169, 224);
            this.btClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btClear.Name = "btClear";
            this.btClear.Primary = true;
            this.btClear.Size = new System.Drawing.Size(63, 36);
            this.btClear.TabIndex = 20;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btThoat
            // 
            this.btThoat.Depth = 0;
            this.btThoat.Location = new System.Drawing.Point(259, 224);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThoat.Name = "btThoat";
            this.btThoat.Primary = true;
            this.btThoat.Size = new System.Drawing.Size(63, 36);
            this.btThoat.TabIndex = 21;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btOk
            // 
            this.btOk.Depth = 0;
            this.btOk.Location = new System.Drawing.Point(41, 224);
            this.btOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.Primary = true;
            this.btOk.Size = new System.Drawing.Size(91, 36);
            this.btOk.TabIndex = 19;
            this.btOk.Text = "Đồng ý";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // AddLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 276);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cBMaGV);
            this.Controls.Add(this.cBMaKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddLop";
            this.Text = "Thêm Lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenLop;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBMaKhoa;
        private System.Windows.Forms.ComboBox cBMaGV;
        private MaterialSkin.Controls.MaterialRaisedButton btClear;
        private MaterialSkin.Controls.MaterialRaisedButton btThoat;
        private MaterialSkin.Controls.MaterialRaisedButton btOk;
    }
}