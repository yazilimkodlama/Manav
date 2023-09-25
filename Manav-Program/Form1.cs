using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Add(txtMeyve.Text);
            txtMeyve.Text = "";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Clear();
        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Remove(lstSepet.SelectedItem);
            //listbox seçili elemanı listeden kaldırır.
        }
    }
}
