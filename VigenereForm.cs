using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using encryption_converter.Encryption;

namespace encryption_converter
{
    public partial class VigenereForm : Form
    {
        private readonly Vigenere vigenere;

        public VigenereForm()
        {
            InitializeComponent();
            vigenere = new Vigenere();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string PlainText = txtPlainText.Text.ToString();
            string KeyStr = txtKey.Text.ToString();

            if(Validate(KeyStr))
            {
                string Result = vigenere.Encrypt(PlainText, KeyStr);
                txtResult.Text = Result;
            }
            else
            {
                MessageBox.Show("Invalid input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string PlainText = txtPlainText.Text.ToString();
            string KeyStr = txtKey.Text.ToString();

            if (Validate(KeyStr))
            {
                string Result = vigenere.Descrypt(PlainText, KeyStr);
                txtResult.Text = Result;
            }
            else
            {
                MessageBox.Show("Invalid input", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool Validate(string Key)
        {
            int number;
            return !int.TryParse(Key, out number);
        }
    }
}
