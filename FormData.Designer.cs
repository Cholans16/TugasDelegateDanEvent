namespace TugasCalculator
{
    partial class form_induk
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IstHasil = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IstHasil);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 198);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Hasil]";
            // 
            // IstHasil
            // 
            this.IstHasil.FormattingEnabled = true;
            this.IstHasil.Location = new System.Drawing.Point(7, 20);
            this.IstHasil.Name = "IstHasil";
            this.IstHasil.Size = new System.Drawing.Size(229, 173);
            this.IstHasil.TabIndex = 0;
            this.IstHasil.SelectedIndexChanged += new System.EventHandler(this.IstHasil_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(12, 220);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(242, 23);
            this.btnHitung.TabIndex = 7;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // form_induk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 255);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_induk";
            this.Text = "Hasil Perhitungan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox IstHasil;
        private System.Windows.Forms.Button btnHitung;
    }
}

