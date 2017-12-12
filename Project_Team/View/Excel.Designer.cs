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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPath
            // 
            this.btPath.Location = new System.Drawing.Point(679, 35);
            this.btPath.Name = "btPath";
            this.btPath.Size = new System.Drawing.Size(104, 39);
            this.btPath.TabIndex = 0;
            this.btPath.Text = "Path";
            this.btPath.UseVisualStyleBackColor = true;
            this.btPath.Click += new System.EventHandler(this.btPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(61, 41);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(584, 26);
            this.txtPath.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(902, 282);
            this.dataGridView1.TabIndex = 2;
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(826, 35);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(104, 39);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 425);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btPath);
            this.Name = "Excel";
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btImport;
    }
}