using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryption_converter.Encryption
{
    class Caesar
    {
        public string Encrypt(string Text, int key)
        {
            string cipher = "";

            foreach(char ch in Text)
            {
                if(ch != 32)
                {
                    int number = ch - 'A';
                    number = (number + key) % 26;
                    cipher += (char)(number + 'A');
                }
                else
                {
                    cipher += ch;
                }
            }
            return cipher;
        }

        public string Descrypt(string Text, int key)
        {
            string decipher = "";

            foreach (char ch in Text)
            {
                if (ch != 32)
                {
                    int number = ch - 'A';
                    number = (number - key + 26) % 26;
                    decipher += (char)(number + 'A');
                }
                else
                {
                    decipher += ch;
                }
            }

            return decipher;
        }

    }
}
