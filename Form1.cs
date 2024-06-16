using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryption_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCaesar_Click(object sender, EventArgs e)
        {
            CaesarForm form = new CaesarForm();
            form.Show();
        }

        private void BtnVigenere_Click(object sender, EventArgs e)
        {
            VigenereForm form = new VigenereForm();
            form.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
