namespace TugasCalculator
{
    partial class FormEntryData
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
            this.operasi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operasi
            // 
            this.operasi.FormattingEnabled = true;
            this.operasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.operasi.Location = new System.Drawing.Point(79, 33);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(121, 21);
            this.operasi.TabIndex = 25;
            this.operasi.Text = "Penjumlahan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Operasi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(79, 85);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(121, 20);
            this.txtNilaiB.TabIndex = 22;
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(79, 60);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(121, 20);
            this.txtNilaiA.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nilai B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nilai A";
            // 
            // FormEntryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 153);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "FormEntryData";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormEntryData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox operasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}