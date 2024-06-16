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
    public partial class CaesarForm : Form
    {
        private readonly Caesar caesar;
        public CaesarForm()
        {
            InitializeComponent();
            caesar = new Caesar();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string PlainText = txtPlainText.Text.ToString();
            string KeyStr = txtKey.Text.ToString();

            if (Validate(KeyStr))
            {
                int Key = Convert.ToInt32(KeyStr);
                string Result = caesar.Encrypt(PlainText, Key);
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
                int Key = Convert.ToInt32(KeyStr);
                string Result = caesar.Descrypt(PlainText, Key);
                txtResult.Text = Result;
            }
            else
            {
                MessageBox.Show("Invalid input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool Validate(string Key)
        {
            int number;     
            bool IsNumeric = int.TryParse(Key, out number);
            if(IsNumeric)
            {
                int KeyNumber = Convert.ToInt32(Key);
                return !(KeyNumber < 0);
            }
            else
            {
                return false;
            }
        }
    }
}
