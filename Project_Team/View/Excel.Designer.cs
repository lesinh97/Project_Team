namespace Project_Team.View
{
    partial class Excel
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
            this.btPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPath
            // 
            this.btPath.Location = new System.Drawing.Point(660, 68);
            this.btPath.Name = "btPath";
            this.btPath.Size = new System.Drawing.Size(104, 39);
            this.btPath.TabIndex = 0;
            this.btPath.Text = "Path";
            this.btPath.UseVisualStyleBackColor = true;
            this.btPath.Click += new System.EventHandler(this.btPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(42, 74);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(584, 26);
            this.txtPath.TabIndex = 1;
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(807, 68);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(104, 39);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn file điểm";
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btPath);
            this.Name = "Excel";
            this.Text = "Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Label label1;
    }
}