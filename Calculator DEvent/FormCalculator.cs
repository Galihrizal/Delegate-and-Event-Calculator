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
    public partial class FrmCalculator : Form
    {
        // constructor
        public FrmCalculator()
        {
            InitializeComponent();
            //InisialisasiListView();
        }

        // method event handler untuk merespon event OnCreate,
        // ketika di panggil dari form entry calculator
        private void Entry_OnCreate(int index, double nilaiA, double nilaiB)
        {
            var calculator = new EntryCalculator();

            switch (index)
            {
                case 0:
                    lsbHasil.Items.Add(string.Format("Hasil Penambahan {0} + {1} = {2}", nilaiA, nilaiB, calculator.Penambahan(nilaiA, nilaiB)));
                    break;
                case 1:
                    lsbHasil.Items.Add(string.Format("Hasil Pengurangan {0} - {1} = {2}", nilaiA, nilaiB, calculator.Pengurangan(nilaiA, nilaiB)));
                    break;
                case 2:
                    lsbHasil.Items.Add(string.Format("Hasil Perkalian {0} * {1} = {2}", nilaiA, nilaiB, calculator.Perkalian(nilaiA, nilaiB)));
                    break;
                case 3:
                    lsbHasil.Items.Add(string.Format("Hasil Pembagian {0} / {1} = {2}", nilaiA, nilaiB, calculator.Pembagian(nilaiA, nilaiB)));
                    break;
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            // objek form entry data calculator
            EntryCalculator entry = new EntryCalculator();

            // mendaftarkan method event handler utk merespon event OnCreate (subscribe)
            entry.OnCreate += Entry_OnCreate;

            // tampilkan form entry calculator
            entry.ShowDialog();
        }
    }
}
