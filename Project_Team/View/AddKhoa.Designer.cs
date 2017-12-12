namespace Project_Team
{
    partial class AddKhoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenKhoa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btThoat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Depth = 0;
            this.txtMaKhoa.Hint = "";
            this.txtMaKhoa.Location = new System.Drawing.Point(152, 106);
            this.txtMaKhoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.PasswordChar = '\0';
            this.txtMaKhoa.SelectedText = "";
            this.txtMaKhoa.SelectionLength = 0;
            this.txtMaKhoa.SelectionStart = 0;
            this.txtMaKhoa.Size = new System.Drawing.Size(271, 32);
            this.txtMaKhoa.TabIndex = 3;
            this.txtMaKhoa.UseSystemPasswordChar = false;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Depth = 0;
            this.txtTenKhoa.Hint = "";
            this.txtTenKhoa.Location = new System.Drawing.Point(152, 167);
            this.txtTenKhoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.PasswordChar = '\0';
            this.txtTenKhoa.SelectedText = "";
            this.txtTenKhoa.SelectionLength = 0;
            this.txtTenKhoa.SelectionStart = 0;
            this.txtTenKhoa.Size = new System.Drawing.Size(271, 32);
            this.txtTenKhoa.TabIndex = 4;
            this.txtTenKhoa.UseSystemPasswordChar = false;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.Control;
            this.btClear.Depth = 0;
            this.btClear.Location = new System.Drawing.Point(233, 249);
            this.btClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btClear.Name = "btClear";
            this.btClear.Primary = true;
            this.btClear.Size = new System.Drawing.Size(94, 56);
            this.btClear.TabIndex = 23;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btThoat
            // 
            this.btThoat.Depth = 0;
            this.btThoat.Location = new System.Drawing.Point(367, 249);
            this.btThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btThoat.Name = "btThoat";
            this.btThoat.Primary = true;
            this.btThoat.Size = new System.Drawing.Size(94, 56);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btOk
            // 
            this.btOk.Depth = 0;
            this.btOk.Location = new System.Drawing.Point(41, 249);
            this.btOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btOk.Name = "btOk";
            this.btOk.Primary = true;
            this.btOk.Size = new System.Drawing.Size(136, 56);
            this.btOk.TabIndex = 22;
            this.btOk.Text = "Đồng ý";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // AddKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(505, 326);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddKhoa";
            this.Text = "THÊM KHOA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaKhoa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenKhoa;
        private MaterialSkin.Controls.MaterialRaisedButton btClear;
        private MaterialSkin.Controls.MaterialRaisedButton btThoat;
        private MaterialSkin.Controls.MaterialRaisedButton btOk;
    }
}