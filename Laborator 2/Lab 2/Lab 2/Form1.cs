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
using System.IO;
using System.Security.Policy;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();
        SymmetricAlgorithm mySymmetricAlg;

        public Form1()
        {
            InitializeComponent();
        }

        public void Generate(string cipher)
        {
            switch (cipher)
            {
                case "DES":
                    mySymmetricAlg = DES.Create();
                    break;
                case "3DES":
                    mySymmetricAlg = TripleDES.Create();
                    break;
                case "Rijndael":
                    mySymmetricAlg = Rijndael.Create();
                    break;
            }
            mySymmetricAlg.GenerateIV();
            mySymmetricAlg.GenerateKey();
        }

        public byte[] Encrypt(byte[] mess, byte[] key, byte[] iv)
        {
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(mess, 0, mess.Length);
            cs.Close();
            return ms.ToArray();
        }

        public byte[] Decrypt(byte[] mess, byte[] key, byte[] iv)
        {
            byte[] plaintext = new byte[mess.Length];
            mySymmetricAlg.Key = key;
            mySymmetricAlg.IV = iv;
            MemoryStream ms = new MemoryStream(mess);
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateDecryptor(), CryptoStreamMode.Read);
            cs.Read(plaintext, 0, mess.Length);
            cs.Close();
            return plaintext;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            byte[] ciphertext = Encrypt(myConverter.StringToByteArray(textBoxPlain.Text),
                myConverter.HexStringToByteArray(textBox_key.Text), 
                myConverter.HexStringToByteArray(textBox_IV.Text));
            textBoxCipher.Text = myConverter.ByteArrayToString(ciphertext);
            textBoxCipherHex.Text = myConverter.ByteArrayToHexString(ciphertext);
            textBoxPlainHex.Text = myConverter.ByteArrayToHexString(myConverter.StringToByteArray(textBoxPlain.Text));
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            byte[] plaintext = Decrypt(myConverter.HexStringToByteArray(textBoxCipherHex.Text), 
                myConverter.HexStringToByteArray(textBox_key.Text), 
                myConverter.HexStringToByteArray(textBox_IV.Text));
            textBoxPlain.Text = myConverter.ByteArrayToString(plaintext);
            textBoxPlainHex.Text = myConverter.ByteArrayToHexString(plaintext);
        }

        private void button_generate_key_Click(object sender, EventArgs e)
        {
            Generate(comboBox_algorithm.Text);
            textBox_key.Text = myConverter.ByteArrayToHexString(mySymmetricAlg.Key);
            textBox_IV.Text = myConverter.ByteArrayToHexString(mySymmetricAlg.IV);
        }

        private void button_encrypt_time_Click(object sender, EventArgs e)
        {
            mySymmetricAlg.GenerateIV(); // generates a fresh IV
            mySymmetricAlg.GenerateKey(); // generates a fresh Key
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, mySymmetricAlg.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] mes_block = new byte[8];
            long start_time = DateTime.Now.Ticks;
            int count = 10000000;
            for (int i = 0; i < count; i++)
            {
                cs.Write(mes_block, 0, mes_block.Length);
            }
            cs.Close();
            double operation_time = (DateTime.Now.Ticks - start_time);
            operation_time = operation_time / (10 * count);
            label_time_encrypt.Text = "Time for encryption of a message block: " + operation_time.ToString() + " us";
        }

    }
}
