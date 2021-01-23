
namespace SH1Base64Crypto
{
    partial class frm_sha1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sha1));
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.tbx_input = new System.Windows.Forms.TextBox();
            this.tbx_output = new System.Windows.Forms.TextBox();
            this.btn_crypto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(155, 9);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(38, 15);
            this.lbl_input.TabIndex = 0;
            this.lbl_input.Text = "Input:";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(145, 60);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(48, 15);
            this.lbl_output.TabIndex = 1;
            this.lbl_output.Text = "Output:";
            // 
            // tbx_input
            // 
            this.tbx_input.Location = new System.Drawing.Point(12, 27);
            this.tbx_input.Name = "tbx_input";
            this.tbx_input.Size = new System.Drawing.Size(332, 23);
            this.tbx_input.TabIndex = 2;
            // 
            // tbx_output
            // 
            this.tbx_output.Location = new System.Drawing.Point(12, 78);
            this.tbx_output.Multiline = true;
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.Size = new System.Drawing.Size(332, 117);
            this.tbx_output.TabIndex = 3;
            // 
            // btn_crypto
            // 
            this.btn_crypto.Location = new System.Drawing.Point(228, 210);
            this.btn_crypto.Name = "btn_crypto";
            this.btn_crypto.Size = new System.Drawing.Size(116, 33);
            this.btn_crypto.TabIndex = 4;
            this.btn_crypto.Text = "Cryptography";
            this.btn_crypto.UseVisualStyleBackColor = true;
            this.btn_crypto.Click += new System.EventHandler(this.btn_crypto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_sha1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_crypto);
            this.Controls.Add(this.tbx_output);
            this.Controls.Add(this.tbx_input);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_sha1";
            this.Text = "SHA1 + Base64 Crypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.TextBox tbx_input;
        private System.Windows.Forms.TextBox tbx_output;
        private System.Windows.Forms.Button btn_crypto;
        private System.Windows.Forms.Button button1;
    }
}

