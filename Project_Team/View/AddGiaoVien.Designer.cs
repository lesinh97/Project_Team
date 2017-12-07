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
            this.btThoat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTenGiaoVien
            // 
            this.txtTenGiaoVien.Depth = 0;
            this.txtTenGiaoVien.Hint = "";
            this.txtTenGiaoVien.Location = new System.Drawing.Point(184, 168);
            this.txtTenGiaoVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenGiaoVien.Name = "txtTenGiaoVien";
            this.txtTenGiaoVien.PasswordChar = '\0';
            this.txtTenGiaoVien.SelectedText = "";
            this.txtTenGiaoVien.SelectionLength = 0;
            this.txtTenGiaoVien.SelectionStart = 0;
            this.txtTenGiaoVien.Size = new System.Drawing.Size(271, 32);
            this.txtTenGiaoVien.TabIndex = 10;
            this.txtTenGiaoVien.UseSystemPasswordChar = false;
            // 
            // txtMaGiaoVien
            // 
            this.txtMaGiaoVien.Depth = 0;
            this.txtMaGiaoVien.Hint = "";
            this.txtMaGiaoVien.Location = new System.Drawing.Point(184, 107);
            this.txtMaGiaoVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaGiaoVien.Name = "txtMaGiaoVien";
            this.txtMaGiaoVien.PasswordChar = '\0';
            this.txtMaGiaoVien.SelectedText = "";
            this.txtMaGiaoVien.SelectionLength = 0;
            this.txtMaGiaoVien.SelectionStart = 0;
            this.txtMaGiaoVien.Size = new System.Drawing.Size(271, 32);
            this.txtMaGiaoVien.TabIndex = 9;
            this.txtMaGiaoVien.UseSystemPasswordChar = false;
            // 
            // btThoat
            // 
            this.btThoat.Depth = 0;
            this.btThoat.Location = new System.Drawing.Point(361, 247);
            this.btThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThoat.Name = "btThoat";
            this.btThoat.Primary = true;
            this.btThoat.Size = new System.Drawing.Size(94, 56);
            this.btThoat.TabIndex = 12;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Depth = 0;
            this.btOk.Location = new System.Drawing.Point(64, 247);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.Primary = true;
            this.btOk.Size = new System.Drawing.Size(136, 56);
            this.btOk.TabIndex = 11;
            this.btOk.Text = "Đồng ý";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(60, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // AddGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 328);
            this.Controls.Add(this.txtTenGiaoVien);
            this.Controls.Add(this.txtMaGiaoVien);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddGiaoVien";
            this.Text = "Thêm giáo viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenGiaoVien;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaGiaoVien;
        private MaterialSkin.Controls.MaterialRaisedButton btThoat;
        private MaterialSkin.Controls.MaterialRaisedButton btOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}