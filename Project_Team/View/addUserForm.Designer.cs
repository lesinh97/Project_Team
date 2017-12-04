namespace Project_Team
{
    partial class addUserForm
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
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.okButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.newPassBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.newIDBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ClearBUT = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(290, 241);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(43, 36);
            this.materialFlatButton2.TabIndex = 31;
            this.materialFlatButton2.Text = "Quit";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Depth = 0;
            this.okButton.Location = new System.Drawing.Point(242, 241);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Primary = false;
            this.okButton.Size = new System.Drawing.Size(30, 36);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // newPassBox
            // 
            this.newPassBox.Depth = 0;
            this.newPassBox.Hint = "";
            this.newPassBox.Location = new System.Drawing.Point(168, 191);
            this.newPassBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.PasswordChar = '♥';
            this.newPassBox.SelectedText = "";
            this.newPassBox.SelectionLength = 0;
            this.newPassBox.SelectionStart = 0;
            this.newPassBox.Size = new System.Drawing.Size(290, 23);
            this.newPassBox.TabIndex = 28;
            this.newPassBox.UseSystemPasswordChar = false;
            // 
            // newIDBox
            // 
            this.newIDBox.Depth = 0;
            this.newIDBox.Hint = "";
            this.newIDBox.Location = new System.Drawing.Point(168, 135);
            this.newIDBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.newIDBox.Name = "newIDBox";
            this.newIDBox.PasswordChar = '\0';
            this.newIDBox.SelectedText = "";
            this.newIDBox.SelectionLength = 0;
            this.newIDBox.SelectionStart = 0;
            this.newIDBox.Size = new System.Drawing.Size(290, 23);
            this.newIDBox.TabIndex = 27;
            this.newIDBox.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(178, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(155, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Thêm người dùng mới";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(60, 191);
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
            this.materialLabel1.Location = new System.Drawing.Point(60, 135);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "ID";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearBUT
            // 
            this.ClearBUT.AutoSize = true;
            this.ClearBUT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearBUT.Depth = 0;
            this.ClearBUT.Location = new System.Drawing.Point(168, 241);
            this.ClearBUT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClearBUT.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClearBUT.Name = "ClearBUT";
            this.ClearBUT.Primary = false;
            this.ClearBUT.Size = new System.Drawing.Size(54, 36);
            this.ClearBUT.TabIndex = 30;
            this.ClearBUT.Text = "Clear";
            this.ClearBUT.UseVisualStyleBackColor = true;
            this.ClearBUT.Click += new System.EventHandler(this.ClearBUT_Click);
            // 
            // addUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 313);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.ClearBUT);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.newIDBox);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "addUserForm";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton okButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField newPassBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField newIDBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton ClearBUT;
    }
}