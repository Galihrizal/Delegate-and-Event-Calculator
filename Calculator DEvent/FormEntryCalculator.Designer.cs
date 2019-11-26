namespace Calculator_DEvent
{
    partial class EntryCalculator
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
            this.frmEntryCalculator = new System.Windows.Forms.TableLayoutPanel();
            this.oprCalculator = new System.Windows.Forms.Label();
            this.nlaiA = new System.Windows.Forms.Label();
            this.nlaiB = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.cbOperasi = new System.Windows.Forms.ComboBox();
            this.tbNilaiA = new System.Windows.Forms.TextBox();
            this.tbNilaiB = new System.Windows.Forms.TextBox();
            this.frmEntryCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmEntryCalculator
            // 
            this.frmEntryCalculator.ColumnCount = 2;
            this.frmEntryCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.frmEntryCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.frmEntryCalculator.Controls.Add(this.oprCalculator, 0, 0);
            this.frmEntryCalculator.Controls.Add(this.nlaiA, 0, 1);
            this.frmEntryCalculator.Controls.Add(this.nlaiB, 0, 2);
            this.frmEntryCalculator.Controls.Add(this.btnProses, 1, 3);
            this.frmEntryCalculator.Controls.Add(this.cbOperasi, 1, 0);
            this.frmEntryCalculator.Controls.Add(this.tbNilaiA, 1, 1);
            this.frmEntryCalculator.Controls.Add(this.tbNilaiB, 1, 2);
            this.frmEntryCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmEntryCalculator.Location = new System.Drawing.Point(0, 0);
            this.frmEntryCalculator.Name = "frmEntryCalculator";
            this.frmEntryCalculator.RowCount = 4;
            this.frmEntryCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19355F));
            this.frmEntryCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19355F));
            this.frmEntryCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19355F));
            this.frmEntryCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.41936F));
            this.frmEntryCalculator.Size = new System.Drawing.Size(282, 176);
            this.frmEntryCalculator.TabIndex = 0;
            // 
            // oprCalculator
            // 
            this.oprCalculator.AutoSize = true;
            this.oprCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oprCalculator.Location = new System.Drawing.Point(3, 0);
            this.oprCalculator.Name = "oprCalculator";
            this.oprCalculator.Size = new System.Drawing.Size(50, 42);
            this.oprCalculator.TabIndex = 0;
            this.oprCalculator.Text = "Operasi";
            // 
            // nlaiA
            // 
            this.nlaiA.AutoSize = true;
            this.nlaiA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nlaiA.Location = new System.Drawing.Point(3, 42);
            this.nlaiA.Name = "nlaiA";
            this.nlaiA.Size = new System.Drawing.Size(50, 42);
            this.nlaiA.TabIndex = 1;
            this.nlaiA.Text = "Nilai A";
            // 
            // nlaiB
            // 
            this.nlaiB.AutoSize = true;
            this.nlaiB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nlaiB.Location = new System.Drawing.Point(3, 84);
            this.nlaiB.Name = "nlaiB";
            this.nlaiB.Size = new System.Drawing.Size(50, 42);
            this.nlaiB.TabIndex = 2;
            this.nlaiB.Text = "Nilai B";
            // 
            // btnProses
            // 
            this.btnProses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProses.Location = new System.Drawing.Point(59, 129);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(220, 44);
            this.btnProses.TabIndex = 3;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // cbOperasi
            // 
            this.cbOperasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOperasi.FormattingEnabled = true;
            this.cbOperasi.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cbOperasi.Location = new System.Drawing.Point(59, 3);
            this.cbOperasi.Name = "cbOperasi";
            this.cbOperasi.Size = new System.Drawing.Size(220, 21);
            this.cbOperasi.TabIndex = 4;
            this.cbOperasi.Text = "Pilih Operasi";
            this.cbOperasi.SelectedIndexChanged += new System.EventHandler(this.cbOperasi_SelectedIndexChanged);
            // 
            // tbNilaiA
            // 
            this.tbNilaiA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNilaiA.Location = new System.Drawing.Point(59, 45);
            this.tbNilaiA.Name = "tbNilaiA";
            this.tbNilaiA.Size = new System.Drawing.Size(220, 20);
            this.tbNilaiA.TabIndex = 5;
            this.tbNilaiA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNilaiA_KeyPress);
            // 
            // tbNilaiB
            // 
            this.tbNilaiB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNilaiB.Location = new System.Drawing.Point(59, 87);
            this.tbNilaiB.Name = "tbNilaiB";
            this.tbNilaiB.Size = new System.Drawing.Size(220, 20);
            this.tbNilaiB.TabIndex = 6;
            this.tbNilaiB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNilaiB_KeyPress);
            // 
            // EntryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 176);
            this.Controls.Add(this.frmEntryCalculator);
            this.Name = "EntryCalculator";
            this.Text = "EntryCalculator";
            this.frmEntryCalculator.ResumeLayout(false);
            this.frmEntryCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel frmEntryCalculator;
        private System.Windows.Forms.Label oprCalculator;
        private System.Windows.Forms.Label nlaiA;
        private System.Windows.Forms.Label nlaiB;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.ComboBox cbOperasi;
        private System.Windows.Forms.TextBox tbNilaiA;
        private System.Windows.Forms.TextBox tbNilaiB;
    }
}