namespace Lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_algorithm = new System.Windows.Forms.ComboBox();
            this.button_generate_key = new System.Windows.Forms.Button();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.textBox_IV = new System.Windows.Forms.TextBox();
            this.label_key = new System.Windows.Forms.Label();
            this.label_IV = new System.Windows.Forms.Label();
            this.textBoxPlain = new System.Windows.Forms.TextBox();
            this.textBoxPlainHex = new System.Windows.Forms.TextBox();
            this.label_ASCII = new System.Windows.Forms.Label();
            this.label_HEX = new System.Windows.Forms.Label();
            this.label_plain_text = new System.Windows.Forms.Label();
            this.label_cipher_text = new System.Windows.Forms.Label();
            this.label_IV_2 = new System.Windows.Forms.Label();
            this.label_ASCII_2 = new System.Windows.Forms.Label();
            this.textBoxCipherHex = new System.Windows.Forms.TextBox();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.button_encrypt_time = new System.Windows.Forms.Button();
            this.button_decrypt_time = new System.Windows.Forms.Button();
            this.label_time_encrypt = new System.Windows.Forms.Label();
            this.label_time_decrypt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_algorithm
            // 
            this.comboBox_algorithm.FormattingEnabled = true;
            this.comboBox_algorithm.Items.AddRange(new object[] {
            "DES",
            "3DES",
            "Rijndael"});
            this.comboBox_algorithm.Location = new System.Drawing.Point(33, 29);
            this.comboBox_algorithm.Name = "comboBox_algorithm";
            this.comboBox_algorithm.Size = new System.Drawing.Size(142, 24);
            this.comboBox_algorithm.TabIndex = 0;
            this.comboBox_algorithm.Text = "DES";
            // 
            // button_generate_key
            // 
            this.button_generate_key.Location = new System.Drawing.Point(33, 70);
            this.button_generate_key.Name = "button_generate_key";
            this.button_generate_key.Size = new System.Drawing.Size(155, 36);
            this.button_generate_key.TabIndex = 1;
            this.button_generate_key.Text = "Generate Key and IV";
            this.button_generate_key.UseVisualStyleBackColor = true;
            this.button_generate_key.Click += new System.EventHandler(this.button_generate_key_Click);
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(379, 31);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.ReadOnly = true;
            this.textBox_key.Size = new System.Drawing.Size(285, 22);
            this.textBox_key.TabIndex = 2;
            // 
            // textBox_IV
            // 
            this.textBox_IV.Location = new System.Drawing.Point(379, 77);
            this.textBox_IV.Name = "textBox_IV";
            this.textBox_IV.ReadOnly = true;
            this.textBox_IV.Size = new System.Drawing.Size(285, 22);
            this.textBox_IV.TabIndex = 3;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(376, 12);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(30, 16);
            this.label_key.TabIndex = 4;
            this.label_key.Text = "Key";
            // 
            // label_IV
            // 
            this.label_IV.AutoSize = true;
            this.label_IV.Location = new System.Drawing.Point(376, 58);
            this.label_IV.Name = "label_IV";
            this.label_IV.Size = new System.Drawing.Size(19, 16);
            this.label_IV.TabIndex = 5;
            this.label_IV.Text = "IV";
            // 
            // textBoxPlain
            // 
            this.textBoxPlain.Location = new System.Drawing.Point(379, 152);
            this.textBoxPlain.Name = "textBoxPlain";
            this.textBoxPlain.Size = new System.Drawing.Size(285, 22);
            this.textBoxPlain.TabIndex = 6;
            // 
            // textBoxPlainHex
            // 
            this.textBoxPlainHex.Location = new System.Drawing.Point(379, 195);
            this.textBoxPlainHex.Name = "textBoxPlainHex";
            this.textBoxPlainHex.ReadOnly = true;
            this.textBoxPlainHex.Size = new System.Drawing.Size(285, 22);
            this.textBoxPlainHex.TabIndex = 7;
            // 
            // label_ASCII
            // 
            this.label_ASCII.AutoSize = true;
            this.label_ASCII.Location = new System.Drawing.Point(329, 155);
            this.label_ASCII.Name = "label_ASCII";
            this.label_ASCII.Size = new System.Drawing.Size(40, 16);
            this.label_ASCII.TabIndex = 8;
            this.label_ASCII.Text = "ASCII";
            // 
            // label_HEX
            // 
            this.label_HEX.AutoSize = true;
            this.label_HEX.Location = new System.Drawing.Point(329, 198);
            this.label_HEX.Name = "label_HEX";
            this.label_HEX.Size = new System.Drawing.Size(34, 16);
            this.label_HEX.TabIndex = 9;
            this.label_HEX.Text = "HEX";
            // 
            // label_plain_text
            // 
            this.label_plain_text.AutoSize = true;
            this.label_plain_text.Location = new System.Drawing.Point(376, 133);
            this.label_plain_text.Name = "label_plain_text";
            this.label_plain_text.Size = new System.Drawing.Size(66, 16);
            this.label_plain_text.TabIndex = 10;
            this.label_plain_text.Text = "Plain Text";
            // 
            // label_cipher_text
            // 
            this.label_cipher_text.AutoSize = true;
            this.label_cipher_text.Location = new System.Drawing.Point(376, 247);
            this.label_cipher_text.Name = "label_cipher_text";
            this.label_cipher_text.Size = new System.Drawing.Size(75, 16);
            this.label_cipher_text.TabIndex = 15;
            this.label_cipher_text.Text = "Cipher Text";
            // 
            // label_IV_2
            // 
            this.label_IV_2.AutoSize = true;
            this.label_IV_2.Location = new System.Drawing.Point(329, 312);
            this.label_IV_2.Name = "label_IV_2";
            this.label_IV_2.Size = new System.Drawing.Size(34, 16);
            this.label_IV_2.TabIndex = 14;
            this.label_IV_2.Text = "HEX";
            // 
            // label_ASCII_2
            // 
            this.label_ASCII_2.AutoSize = true;
            this.label_ASCII_2.Location = new System.Drawing.Point(329, 269);
            this.label_ASCII_2.Name = "label_ASCII_2";
            this.label_ASCII_2.Size = new System.Drawing.Size(40, 16);
            this.label_ASCII_2.TabIndex = 13;
            this.label_ASCII_2.Text = "ASCII";
            // 
            // textBoxCipherHex
            // 
            this.textBoxCipherHex.Location = new System.Drawing.Point(379, 309);
            this.textBoxCipherHex.Name = "textBoxCipherHex";
            this.textBoxCipherHex.ReadOnly = true;
            this.textBoxCipherHex.Size = new System.Drawing.Size(285, 22);
            this.textBoxCipherHex.TabIndex = 12;
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(379, 266);
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.ReadOnly = true;
            this.textBoxCipher.Size = new System.Drawing.Size(285, 22);
            this.textBoxCipher.TabIndex = 11;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(33, 152);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(142, 36);
            this.button_encrypt.TabIndex = 16;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(33, 266);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(142, 36);
            this.button_decrypt.TabIndex = 17;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // button_encrypt_time
            // 
            this.button_encrypt_time.Location = new System.Drawing.Point(33, 361);
            this.button_encrypt_time.Name = "button_encrypt_time";
            this.button_encrypt_time.Size = new System.Drawing.Size(142, 36);
            this.button_encrypt_time.TabIndex = 18;
            this.button_encrypt_time.Text = "Get Encrypt Time";
            this.button_encrypt_time.UseVisualStyleBackColor = true;
            this.button_encrypt_time.Click += new System.EventHandler(this.button_encrypt_time_Click);
            // 
            // button_decrypt_time
            // 
            this.button_decrypt_time.Location = new System.Drawing.Point(33, 418);
            this.button_decrypt_time.Name = "button_decrypt_time";
            this.button_decrypt_time.Size = new System.Drawing.Size(142, 36);
            this.button_decrypt_time.TabIndex = 19;
            this.button_decrypt_time.Text = "Get Decrypt Time";
            this.button_decrypt_time.UseVisualStyleBackColor = true;
            // 
            // label_time_encrypt
            // 
            this.label_time_encrypt.AutoSize = true;
            this.label_time_encrypt.Location = new System.Drawing.Point(376, 371);
            this.label_time_encrypt.Name = "label_time_encrypt";
            this.label_time_encrypt.Size = new System.Drawing.Size(181, 16);
            this.label_time_encrypt.TabIndex = 20;
            this.label_time_encrypt.Text = "Time/message at encryption:";
            // 
            // label_time_decrypt
            // 
            this.label_time_decrypt.AutoSize = true;
            this.label_time_decrypt.Location = new System.Drawing.Point(376, 428);
            this.label_time_decrypt.Name = "label_time_decrypt";
            this.label_time_decrypt.Size = new System.Drawing.Size(182, 16);
            this.label_time_decrypt.TabIndex = 22;
            this.label_time_decrypt.Text = "Time/message at decryption:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label_time_decrypt);
            this.Controls.Add(this.label_time_encrypt);
            this.Controls.Add(this.button_decrypt_time);
            this.Controls.Add(this.button_encrypt_time);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.label_cipher_text);
            this.Controls.Add(this.label_IV_2);
            this.Controls.Add(this.label_ASCII_2);
            this.Controls.Add(this.textBoxCipherHex);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.label_plain_text);
            this.Controls.Add(this.label_HEX);
            this.Controls.Add(this.label_ASCII);
            this.Controls.Add(this.textBoxPlainHex);
            this.Controls.Add(this.textBoxPlain);
            this.Controls.Add(this.label_IV);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.textBox_IV);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.button_generate_key);
            this.Controls.Add(this.comboBox_algorithm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_algorithm;
        private System.Windows.Forms.Button button_generate_key;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.TextBox textBox_IV;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_IV;
        private System.Windows.Forms.TextBox textBoxPlain;
        private System.Windows.Forms.TextBox textBoxPlainHex;
        private System.Windows.Forms.Label label_ASCII;
        private System.Windows.Forms.Label label_HEX;
        private System.Windows.Forms.Label label_plain_text;
        private System.Windows.Forms.Label label_cipher_text;
        private System.Windows.Forms.Label label_IV_2;
        private System.Windows.Forms.Label label_ASCII_2;
        private System.Windows.Forms.TextBox textBoxCipherHex;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Button button_encrypt_time;
        private System.Windows.Forms.Button button_decrypt_time;
        private System.Windows.Forms.Label label_time_encrypt;
        private System.Windows.Forms.Label label_time_decrypt;
    }
}

