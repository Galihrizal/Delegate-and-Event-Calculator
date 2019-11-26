using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_DEvent
{
    public partial class EntryCalculator : Form
    {
        private double nilaiA, nilaiB;
        private string pilih;

        // deklarasi tipe data untuk event OnCreate
        public delegate void CreateUpdateEventHandler(int index, double NilaiA, double NilaiB);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi field untuk menyimpan status entry data (input baru)
        private bool isNewData = true;

        // Constructor default
        public EntryCalculator()
        {
            InitializeComponent();
        }

        // Constructor untuk inisialisasi data ketika entri data baru
        public EntryCalculator(string title) : this()
        {
            // ganti text/judul form
            this.Text = title;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            nilaiA = Convert.ToDouble(tbNilaiA.Text);
            nilaiB = Convert.ToDouble(tbNilaiB.Text);

            if (isNewData) // data baru
            {
                switch (pilih)
                {
                    case "Penambahan":
                        OnCreate(0, nilaiA, nilaiB);
                        var msg1 = "Data Perhitungan berhasil di input";

                        MessageBox.Show(msg1, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Pengurangan":
                        OnCreate(1, nilaiA, nilaiB);
                        var msg2 = "Data Perhitungan berhasil di input";

                        MessageBox.Show(msg2, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Perkalian":
                        OnCreate(2, nilaiA, nilaiB);
                        var msg3 = "Data Perhitungan berhasil di input";

                        MessageBox.Show(msg3, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Pembagian":
                        OnCreate(3, nilaiA, nilaiB);
                        var msg4 = "Data Perhitungan berhasil di input";

                        MessageBox.Show(msg4, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("Pilih dulu Operasinya kang");
                        var msg5 = "Data Perhitungan tidak di input";

                        MessageBox.Show(msg5, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                       
                // reset form input, utk persiapan input data berikutnya
                tbNilaiA.Clear();
                tbNilaiB.Clear();

                tbNilaiA.Focus();
            }
        }

        private void cbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            pilih = cbOperasi.SelectedItem.ToString();
        }

        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";

            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                // inputan selain angka
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }

                return false;
            }
            else
                return false;
        }

        private void tbNilaiA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void tbNilaiB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        public double Penambahan(double nilaiA, double nilaiB)
        {
            return nilaiA + nilaiB;
        }

        public double Pengurangan(double nilaiA, double nilaiB)
        {
            return nilaiA - nilaiB;
        }

        public double Perkalian(double nilaiA, double nilaiB)
        {
            return nilaiA * nilaiB;
        }

        public double Pembagian(double nilaiA, double nilaiB)
        {
            return nilaiA / nilaiB;
        }
    }
}
