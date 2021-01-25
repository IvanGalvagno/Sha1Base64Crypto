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
            string src = tbx_input.Text.Trim();
            if (tbx_input.Text.Trim() != "")  
            {
                using (SHA1 sha1 = SHA1.Create())
                {
                    tbx_output.Text = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(src)));
                }
            }
        }
    }
}
