namespace Project_Team
{
    partial class Login
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
            this.QuitBUT = new MaterialSkin.Controls.MaterialFlatButton();
            this.RegisterBut = new MaterialSkin.Controls.MaterialFlatButton();
            this.okBUT = new MaterialSkin.Controls.MaterialFlatButton();
            this.PassLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // QuitBUT
            // 
            this.QuitBUT.AutoSize = true;
            this.QuitBUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuitBUT.Depth = 0;
            this.QuitBUT.Location = new System.Drawing.Point(301, 239);
            this.QuitBUT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QuitBUT.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuitBUT.Name = "QuitBUT";
            this.QuitBUT.Primary = false;
            this.QuitBUT.Size = new System.Drawing.Size(43, 36);
            this.QuitBUT.TabIndex = 23;
            this.QuitBUT.Text = "Quit";
            this.QuitBUT.UseVisualStyleBackColor = true;
            this.QuitBUT.Click += new System.EventHandler(this.QuitBUT_Click);
            // 
            // RegisterBut
            // 
            this.RegisterBut.AutoSize = true;
            this.RegisterBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterBut.Depth = 0;
            this.RegisterBut.Location = new System.Drawing.Point(181, 239);
            this.RegisterBut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterBut.Name = "RegisterBut";
            this.RegisterBut.Primary = false;
            this.RegisterBut.Size = new System.Drawing.Size(74, 36);
            this.RegisterBut.TabIndex = 22;
            this.RegisterBut.Text = "Register";
            this.RegisterBut.UseVisualStyleBackColor = true;
            this.RegisterBut.Click += new System.EventHandler(this.RegisterBut_Click);
            // 
            // okBUT
            // 
            this.okBUT.AutoSize = true;
            this.okBUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okBUT.Depth = 0;
            this.okBUT.Location = new System.Drawing.Point(263, 239);
            this.okBUT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.okBUT.MouseState = MaterialSkin.MouseState.HOVER;
            this.okBUT.Name = "okBUT";
            this.okBUT.Primary = false;
            this.okBUT.Size = new System.Drawing.Size(30, 36);
            this.okBUT.TabIndex = 21;
            this.okBUT.Text = "OK";
            this.okBUT.UseVisualStyleBackColor = true;
            this.okBUT.Click += new System.EventHandler(this.okBUT_Click);
            // 
            // PassLogin
            // 
            this.PassLogin.Depth = 0;
            this.PassLogin.Hint = "";
            this.PassLogin.Location = new System.Drawing.Point(168, 186);
            this.PassLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.PassLogin.Name = "PassLogin";
            this.PassLogin.PasswordChar = '♥';
            this.PassLogin.SelectedText = "";
            this.PassLogin.SelectionLength = 0;
            this.PassLogin.SelectionStart = 0;
            this.PassLogin.Size = new System.Drawing.Size(290, 23);
            this.PassLogin.TabIndex = 20;
            this.PassLogin.UseSystemPasswordChar = false;
            // 
            // LoginID
            // 
            this.LoginID.Depth = 0;
            this.LoginID.Hint = "";
            this.LoginID.Location = new System.Drawing.Point(168, 125);
            this.LoginID.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginID.Name = "LoginID";
            this.LoginID.PasswordChar = '\0';
            this.LoginID.SelectedText = "";
            this.LoginID.SelectionLength = 0;
            this.LoginID.SelectionStart = 0;
            this.LoginID.Size = new System.Drawing.Size(290, 23);
            this.LoginID.TabIndex = 19;
            this.LoginID.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(192, 86);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(141, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Đăng nhập hệ thống";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(60, 190);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Password";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(60, 129);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "ID";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 313);
            this.Controls.Add(this.QuitBUT);
            this.Controls.Add(this.RegisterBut);
            this.Controls.Add(this.okBUT);
            this.Controls.Add(this.PassLogin);
            this.Controls.Add(this.LoginID);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton QuitBUT;
        private MaterialSkin.Controls.MaterialFlatButton RegisterBut;
        private MaterialSkin.Controls.MaterialFlatButton okBUT;
        private MaterialSkin.Controls.MaterialSingleLineTextField PassLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginID;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}