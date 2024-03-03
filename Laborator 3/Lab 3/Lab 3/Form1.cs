using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using System.Security.Cryptography;
using System.IO;
using System.Reflection.Emit;
using System.Security.Policy;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        ConversionHandler myConverter = new ConversionHandler();
        private HMAC myMAC;

        public Form1()
        {
            InitializeComponent();

            RandomNumberGenerator rnd = RandomNumberGenerator.Create();
            byte[] key = new byte[16];
            rnd.GetBytes(key);
            byte[] input = new byte[20];
            rnd.GetBytes(input);
            HMACSHA256 hmac = new HMACSHA256(key);
            SHA256Managed hash = new SHA256Managed();
            CryptoStream cs_hmac = new CryptoStream(Stream.Null, hmac, CryptoStreamMode.Write);
            CryptoStream cs_hash = new CryptoStream(Stream.Null, hash, CryptoStreamMode.Write);
            cs_hmac.Write(input, 0, input.Length);
            cs_hmac.Close();
            cs_hash.Write(input, 0, input.Length);
            cs_hash.Close();

            textBoxKey.Text = myConverter.ByteArrayToString(key);
        }

        public void MACHandler(string name)
        {
            if (name.CompareTo("SHA1") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA1();
            }
            else if (name.CompareTo("MD5") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACMD5();
            }
            else if (name.CompareTo("RIPEMD") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACRIPEMD160();
            }
            else if (name.CompareTo("SHA256") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA256();
            }
            else if (name.CompareTo("SHA384") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA384();
            }
            else if (name.CompareTo("SHA512") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA512();
            }
        }

        public bool CheckAuthenticity(byte[] mes, byte[] mac, byte[] key)
        {
            myMAC.Key = key;
            if (CompareByteArrays(myMAC.ComputeHash(mes), mac, myMAC.HashSize / 8) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int MACByteLength()
        {
            return myMAC.HashSize / 8;
        }

        private bool CompareByteArrays(byte[] a, byte[] b, int len)
        {
            for (int i = 0; i < len; i++)
                if (a[i] != b[i]) return false;
            return true;
        }

        public byte[] ComputeMAC(byte[] mes, byte[] key)
        {
            myMAC.Key = key;
            return myMAC.ComputeHash(mes);
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            MACHandler(comboBoxMAC.Text);
            byte[] mac = ComputeMAC(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.StringToByteArray(textBoxKey.Text));
            textBoxMAC.Text = myConverter.ByteArrayToString(mac);
            textBoxMACHEX.Text = myConverter.ByteArrayToHexString(mac);
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            MACHandler(comboBoxMAC.Text);
            if (CheckAuthenticity(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.HexStringToByteArray(textBoxMACHEX.Text), myConverter.StringToByteArray(textBoxKey.Text)) == true)
            {
                System.Windows.Forms.MessageBox.Show("MAC OK !!!");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("MAC NOT OK !!!");
            }
        }
    }
}
