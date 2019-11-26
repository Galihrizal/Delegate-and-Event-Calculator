namespace Calculator_DEvent
{
    partial class FrmCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHitung = new System.Windows.Forms.Button();
            this.bxHasil = new System.Windows.Forms.GroupBox();
            this.lsbHasil = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.bxHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnHitung, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bxHasil, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnHitung
            // 
            this.btnHitung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHitung.Location = new System.Drawing.Point(3, 291);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(378, 45);
            this.btnHitung.TabIndex = 0;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // bxHasil
            // 
            this.bxHasil.Controls.Add(this.lsbHasil);
            this.bxHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bxHasil.Location = new System.Drawing.Point(3, 3);
            this.bxHasil.Name = "bxHasil";
            this.bxHasil.Size = new System.Drawing.Size(378, 282);
            this.bxHasil.TabIndex = 1;
            this.bxHasil.TabStop = false;
            this.bxHasil.Text = "Hasil";
            // 
            // lsbHasil
            // 
            this.lsbHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbHasil.FormattingEnabled = true;
            this.lsbHasil.Location = new System.Drawing.Point(3, 16);
            this.lsbHasil.Name = "lsbHasil";
            this.lsbHasil.Size = new System.Drawing.Size(372, 263);
            this.lsbHasil.TabIndex = 0;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 339);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCalculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bxHasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.GroupBox bxHasil;
        private System.Windows.Forms.ListBox lsbHasil;
    }
}

