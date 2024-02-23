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

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private HMAC myMAC;

        public Form1()
        {
            InitializeComponent();
        }

        public MACHandler(string name)
        {
            if (name.CompareTo("SHA1") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA1();
            }
            if (name.CompareTo("MD5") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACMD5();
            }
            if (name.CompareTo("RIPEMD") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACRIPEMD160();
            }
            if (name.CompareTo("SHA256") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA256();
            }
            if (name.CompareTo("SHA384") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA384();
            }
            if (name.CompareTo("SHA512") == 0)
            {
                myMAC = new System.Security.Cryptography.HMACSHA512();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBoxMAC.Text);
            byte[] mac = mh.ComputeMAC(myConverter.StringToByteArray(textBoxPlain.Text), myConverter.StringToByteArray(textBoxKey.Text));
            textBoxMAC.Text = myConverter.ByteArrayToString(mac);
            textBoxMACHEX.Text = myConverter.ByteArrayToHexString(mac);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MACHandler mh = new MACHandler(comboBoxMAC.Text);
            if(mh.CheckAuthenticity(myConverter.StringToByteArray(textBoxPlain.Text),myConverter.HexStringToByteArray(textBoxMACHEX.Text), myConverter.StringToByteArray(textBoxKey.Text)) == true)
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
