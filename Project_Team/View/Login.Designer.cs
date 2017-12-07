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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControlWelcome = new MaterialSkin.Controls.MaterialTabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.QuitBUT = new MaterialSkin.Controls.MaterialFlatButton();
            this.RegisterBut = new MaterialSkin.Controls.MaterialFlatButton();
            this.okBUT = new MaterialSkin.Controls.MaterialFlatButton();
            this.PassLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabRegisrer = new System.Windows.Forms.TabPage();
            this.CancleBUT = new MaterialSkin.Controls.MaterialFlatButton();
            this.clear_BUT = new MaterialSkin.Controls.MaterialFlatButton();
            this.OkBUT_newRegis = new MaterialSkin.Controls.MaterialFlatButton();
            this.newPass_BOX = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newID_BOX = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabTroGiup = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.TabControlWelcome.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegisrer.SuspendLayout();
            this.tabTroGiup.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TabControlWelcome;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(88, 41);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(309, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // TabControlWelcome
            // 
            this.TabControlWelcome.Controls.Add(this.tabLogin);
            this.TabControlWelcome.Controls.Add(this.tabRegisrer);
            this.TabControlWelcome.Controls.Add(this.tabTroGiup);
            this.TabControlWelcome.Depth = 0;
            this.TabControlWelcome.Location = new System.Drawing.Point(12, 70);
            this.TabControlWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControlWelcome.Name = "TabControlWelcome";
            this.TabControlWelcome.SelectedIndex = 0;
            this.TabControlWelcome.Size = new System.Drawing.Size(495, 242);
            this.TabControlWelcome.TabIndex = 1;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.White;
            this.tabLogin.Controls.Add(this.QuitBUT);
            this.tabLogin.Controls.Add(this.RegisterBut);
            this.tabLogin.Controls.Add(this.okBUT);
            this.tabLogin.Controls.Add(this.PassLogin);
            this.tabLogin.Controls.Add(this.LoginID);
            this.tabLogin.Controls.Add(this.materialLabel3);
            this.tabLogin.Controls.Add(this.materialLabel2);
            this.tabLogin.Controls.Add(this.materialLabel1);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(487, 205);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            // 
            // QuitBUT
            // 
            this.QuitBUT.AutoSize = true;
            this.QuitBUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QuitBUT.Depth = 0;
            this.QuitBUT.Location = new System.Drawing.Point(285, 160);
            this.QuitBUT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QuitBUT.MouseState = MaterialSkin.MouseState.HOVER;
            this.QuitBUT.Name = "QuitBUT";
            this.QuitBUT.Primary = false;
            this.QuitBUT.Size = new System.Drawing.Size(43, 36);
            this.QuitBUT.TabIndex = 31;
            this.QuitBUT.Text = "Quit";
            this.QuitBUT.UseVisualStyleBackColor = true;
            this.QuitBUT.Click += new System.EventHandler(this.QuitBUT_Click);
            // 
            // RegisterBut
            // 
            this.RegisterBut.AutoSize = true;
            this.RegisterBut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterBut.Depth = 0;
            this.RegisterBut.Location = new System.Drawing.Point(165, 160);
            this.RegisterBut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterBut.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterBut.Name = "RegisterBut";
            this.RegisterBut.Primary = false;
            this.RegisterBut.Size = new System.Drawing.Size(74, 36);
            this.RegisterBut.TabIndex = 30;
            this.RegisterBut.Text = "Register";
            this.RegisterBut.UseVisualStyleBackColor = true;
            this.RegisterBut.Click += new System.EventHandler(this.RegisterBut_Click_1);
            // 
            // okBUT
            // 
            this.okBUT.AutoSize = true;
            this.okBUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okBUT.Depth = 0;
            this.okBUT.Location = new System.Drawing.Point(247, 160);
            this.okBUT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.okBUT.MouseState = MaterialSkin.MouseState.HOVER;
            this.okBUT.Name = "okBUT";
            this.okBUT.Primary = false;
            this.okBUT.Size = new System.Drawing.Size(30, 36);
            this.okBUT.TabIndex = 29;
            this.okBUT.Text = "OK";
            this.okBUT.UseVisualStyleBackColor = true;
            this.okBUT.Click += new System.EventHandler(this.okBUT_Click);
            // 
            // PassLogin
            // 
            this.PassLogin.Depth = 0;
            this.PassLogin.Hint = "";
            this.PassLogin.Location = new System.Drawing.Point(152, 114);
            this.PassLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.PassLogin.Name = "PassLogin";
            this.PassLogin.PasswordChar = '♥';
            this.PassLogin.SelectedText = "";
            this.PassLogin.SelectionLength = 0;
            this.PassLogin.SelectionStart = 0;
            this.PassLogin.Size = new System.Drawing.Size(290, 23);
            this.PassLogin.TabIndex = 28;
            this.PassLogin.UseSystemPasswordChar = false;
            this.PassLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassLogin_KeyDown);
            // 
            // LoginID
            // 
            this.LoginID.Depth = 0;
            this.LoginID.Hint = "";
            this.LoginID.Location = new System.Drawing.Point(152, 55);
            this.LoginID.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginID.Name = "LoginID";
            this.LoginID.PasswordChar = '\0';
            this.LoginID.SelectedText = "";
            this.LoginID.SelectionLength = 0;
            this.LoginID.SelectionStart = 0;
            this.LoginID.Size = new System.Drawing.Size(290, 23);
            this.LoginID.TabIndex = 27;
            this.LoginID.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(187, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(141, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Đăng nhập hệ thống";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(44, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 25;
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
            this.materialLabel1.Location = new System.Drawing.Point(44, 59);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "ID";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabRegisrer
            // 
            this.tabRegisrer.BackColor = System.Drawing.Color.White;
            this.tabRegisrer.Controls.Add(this.CancleBUT);
            this.tabRegisrer.Controls.Add(this.clear_BUT);
            this.tabRegisrer.Controls.Add(this.OkBUT_newRegis);
            this.tabRegisrer.Controls.Add(this.newPass_BOX);
            this.tabRegisrer.Controls.Add(this.newID_BOX);
            this.tabRegisrer.Controls.Add(this.materialLabel4);
            this.tabRegisrer.Controls.Add(this.materialLabel5);
            this.tabRegisrer.Controls.Add(this.materialLabel6);
            this.tabRegisrer.Location = new System.Drawing.Point(4, 22);
            this.tabRegisrer.Name = "tabRegisrer";
            this.tabRegisrer.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegisrer.Size = new System.Drawing.Size(487, 205);
            this.tabRegisrer.TabIndex = 1;
            this.tabRegisrer.Text = "Register";
            // 
            // CancleBUT
            // 
            this.CancleBUT.AutoSize = true;
            this.CancleBUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancleBUT.Depth = 0;
            this.CancleBUT.Location = new System.Drawing.Point(285, 157);
            this.CancleBUT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancleBUT.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancleBUT.Name = "CancleBUT";
            this.CancleBUT.Primary = false;
            this.CancleBUT.Size = new System.Drawing.Size(64, 36);
            this.CancleBUT.TabIndex = 39;
            this.CancleBUT.Text = "Cancle";
            this.CancleBUT.UseVisualStyleBackColor = true;
            this.CancleBUT.Click += new System.EventHandler(this.CancleBUT_Click);
            // 
            // clear_BUT
            // 
            this.clear_BUT.AutoSize = true;
            this.clear_BUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear_BUT.Depth = 0;
            this.clear_BUT.Location = new System.Drawing.Point(165, 157);
            this.clear_BUT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clear_BUT.MouseState = MaterialSkin.MouseState.HOVER;
            this.clear_BUT.Name = "clear_BUT";
            this.clear_BUT.Primary = false;
            this.clear_BUT.Size = new System.Drawing.Size(54, 36);
            this.clear_BUT.TabIndex = 38;
            this.clear_BUT.Text = "Clear";
            this.clear_BUT.UseVisualStyleBackColor = true;
            this.clear_BUT.Click += new System.EventHandler(this.clear_BUT_Click);
            // 
            // OkBUT_newRegis
            // 
            this.OkBUT_newRegis.AutoSize = true;
            this.OkBUT_newRegis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OkBUT_newRegis.Depth = 0;
            this.OkBUT_newRegis.Location = new System.Drawing.Point(238, 157);
            this.OkBUT_newRegis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OkBUT_newRegis.MouseState = MaterialSkin.MouseState.HOVER;
            this.OkBUT_newRegis.Name = "OkBUT_newRegis";
            this.OkBUT_newRegis.Primary = false;
            this.OkBUT_newRegis.Size = new System.Drawing.Size(30, 36);
            this.OkBUT_newRegis.TabIndex = 37;
            this.OkBUT_newRegis.Text = "OK";
            this.OkBUT_newRegis.UseVisualStyleBackColor = true;
            this.OkBUT_newRegis.Click += new System.EventHandler(this.OkBUT_newRegis_Click);
            // 
            // newPass_BOX
            // 
            this.newPass_BOX.Depth = 0;
            this.newPass_BOX.Hint = "";
            this.newPass_BOX.Location = new System.Drawing.Point(152, 111);
            this.newPass_BOX.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPass_BOX.Name = "newPass_BOX";
            this.newPass_BOX.PasswordChar = '♥';
            this.newPass_BOX.SelectedText = "";
            this.newPass_BOX.SelectionLength = 0;
            this.newPass_BOX.SelectionStart = 0;
            this.newPass_BOX.Size = new System.Drawing.Size(290, 23);
            this.newPass_BOX.TabIndex = 36;
            this.newPass_BOX.UseSystemPasswordChar = false;
            this.newPass_BOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newPass_BOX_KeyDown);
            // 
            // newID_BOX
            // 
            this.newID_BOX.Depth = 0;
            this.newID_BOX.Hint = "";
            this.newID_BOX.Location = new System.Drawing.Point(152, 52);
            this.newID_BOX.MouseState = MaterialSkin.MouseState.HOVER;
            this.newID_BOX.Name = "newID_BOX";
            this.newID_BOX.PasswordChar = '\0';
            this.newID_BOX.SelectedText = "";
            this.newID_BOX.SelectionLength = 0;
            this.newID_BOX.SelectionStart = 0;
            this.newID_BOX.Size = new System.Drawing.Size(290, 23);
            this.newID_BOX.TabIndex = 35;
            this.newID_BOX.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(187, 11);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(170, 19);
            this.materialLabel4.TabIndex = 34;
            this.materialLabel4.Text = "Đăng ký người dùng mới";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(44, 115);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 33;
            this.materialLabel5.Text = "Password";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(44, 56);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(23, 19);
            this.materialLabel6.TabIndex = 32;
            this.materialLabel6.Text = "ID";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabTroGiup
            // 
            this.tabTroGiup.Controls.Add(this.label1);
            this.tabTroGiup.Controls.Add(this.materialLabel7);
            this.tabTroGiup.Location = new System.Drawing.Point(4, 22);
            this.tabTroGiup.Name = "tabTroGiup";
            this.tabTroGiup.Padding = new System.Windows.Forms.Padding(3);
            this.tabTroGiup.Size = new System.Drawing.Size(487, 216);
            this.tabTroGiup.TabIndex = 2;
            this.tabTroGiup.Text = "Trợ giúp";
            this.tabTroGiup.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(11, 22);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(470, 95);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = resources.GetString("materialLabel7.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "☺ Copyright 2017, 12, dedicated to IT Falcuty.\r\n     By Sinh, Son, Song, Trong.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 313);
            this.Controls.Add(this.TabControlWelcome);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "Login";
            this.Text = "Welcome";
            this.TabControlWelcome.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegisrer.ResumeLayout(false);
            this.tabRegisrer.PerformLayout();
            this.tabTroGiup.ResumeLayout(false);
            this.tabTroGiup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl TabControlWelcome;
        private System.Windows.Forms.TabPage tabLogin;
        private MaterialSkin.Controls.MaterialFlatButton QuitBUT;
        private MaterialSkin.Controls.MaterialFlatButton RegisterBut;
        private MaterialSkin.Controls.MaterialFlatButton okBUT;
        private MaterialSkin.Controls.MaterialSingleLineTextField PassLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginID;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabRegisrer;
        private MaterialSkin.Controls.MaterialFlatButton CancleBUT;
        private MaterialSkin.Controls.MaterialFlatButton clear_BUT;
        private MaterialSkin.Controls.MaterialFlatButton OkBUT_newRegis;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPass_BOX;
        private MaterialSkin.Controls.MaterialSingleLineTextField newID_BOX;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage tabTroGiup;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Label label1;
    }
}