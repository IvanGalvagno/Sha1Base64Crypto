using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SH1Base64Crypto
{
    public partial class frm_sha1 : Form
    {
        public frm_sha1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbx_input.Text = "";
            tbx_output.Clear();
        }

        private void btn_crypto_Click(object sender, EventArgs e)
        {
            if (tbx_input.Text.Trim() != "")  
            {
                using (SHA1 sha1 = SHA1.Create())
                {

                    byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(tbx_input.Text.Trim()));
                    var sb = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("X2"));
                    }
                    tbx_output.Text = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(sb.ToString().Trim()));
                }
            }
        }
    }
}
