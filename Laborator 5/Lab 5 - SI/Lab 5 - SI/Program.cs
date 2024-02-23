using System;
using System.Security.Cryptography;

namespace Lab_5___SI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversionHandler ch = new ConversionHandler();

            //Criptarea unei chei AES cu RSA
            //RSACryptoServiceProvider myRSA = new RSACryptoServiceProvider(2048);
            //AesManaged myAES = new AesManaged();
            //byte[] RSAciphertext;
            //byte[] plaintext;
            //myAES.GenerateKey();
            //RSAciphertext = myRSA.Encrypt(myAES.Key, true);
            //plaintext = myRSA.Decrypt(RSAciphertext, true);
            //Console.WriteLine(ch.ByteArrayToHexString(myAES.Key) + "\n");
            //Console.WriteLine(ch.ByteArrayToHexString(RSAciphertext) + "\n");
            //Console.WriteLine(ch.ByteArrayToHexString(plaintext));

            //Semnarea si verificarea cu RSA
            //RSACryptoServiceProvider myRSA = new RSACryptoServiceProvider(2048);
            //SHA256Managed myHash = new SHA256Managed();
            //string some_text = "this is an important message";
            //byte[] signature;
            //signature = myRSA.SignData(System.Text.Encoding.ASCII.GetBytes(some_text), myHash);
            //bool verified;
            //verified = myRSA.VerifyData(System.Text.Encoding.ASCII.GetBytes(some_text), myHash, signature);
            //Console.WriteLine(ch.ByteArrayToHexString(signature) + "\n");
            //Console.WriteLine(verified? "Valid" : "Nevalid");

            //Afisarea sub forma de XML a parametrilor
            //RSACryptoServiceProvider myRSA = new RSACryptoServiceProvider(2048);
            //Console.WriteLine(myRSA.ToXmlString(true));

            //Calcularea timpului RSA: generare, criptare, decriptare, semnare, verificare
            //RSACryptoServiceProvider myrsa = new RSACryptoServiceProvider(1600);
            //System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            //int size;
            //int count = 100;
            //swatch.Start();
            //for(int i=0; i<count; i++)
            //{
            //    myrsa = new RSACryptoServiceProvider(1024);
            //    size = myrsa.KeySize;
            //}
            //swatch.Stop();
            //Console.WriteLine("Generation time at 1024 bit ... " + (swatch.ElapsedTicks / (10*count)).ToString() + " ms");
            //byte[] plain = new byte[20];
            //byte[] ciphertext = myrsa.Encrypt(plain, true);

            //swatch.Reset();
            //swatch.Start();
            //for(int i=0; i<count; i++)
            //{
            //    ciphertext = myrsa.Encrypt(plain, true);
            //}
            //swatch.Stop();
            //Console.WriteLine("Encryption time at 1024 bit ... " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");

            //swatch.Reset();
            //swatch.Start();
            //for (int i=0; i<count; i++)
            //{
            //    plain = myrsa.Decrypt(ciphertext, true);
            //}
            //swatch.Stop();
            //Console.WriteLine("Decryption time at 1024 bit ... " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");

            //swatch.Reset();
            //swatch.Start();
            //SHA256Managed myHash = new SHA256Managed();
            //byte[] signature;
            //signature = myrsa.SignData(System.Text.Encoding.ASCII.GetBytes(ch.ByteArrayToString(plain)), myHash);
            //for (int i = 0; i < count; i++)
            //{
            //    signature = myrsa.SignData(System.Text.Encoding.ASCII.GetBytes(ch.ByteArrayToString(plain)), myHash);
            //}
            //swatch.Stop();
            //Console.WriteLine("Signing time at 1024 bit ... " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");

            //swatch.Reset();
            //swatch.Start();
            //bool verified;
            //for (int i = 0; i < count; i++)
            //{
            //    verified = myrsa.VerifyData(System.Text.Encoding.ASCII.GetBytes(ch.ByteArrayToString(plain)), myHash, signature);
            //}
            //swatch.Stop();
            //Console.WriteLine("Verification time at 1024 bit ... " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");




            //Semnarea si verificare cu DSA
            //DSACryptoServiceProvider myDSA = new DSACryptoServiceProvider(512);
            //string some_text = "this is an important message";
            //byte[] signature;
            //signature = myDSA.SignData(System.Text.Encoding.ASCII.GetBytes(some_text));
            //bool verified;
            //verified = myDSA.VerifyData(System.Text.Encoding.ASCII.GetBytes(some_text), signature);
            //Console.WriteLine(ch.ByteArrayToHexString(signature) + "\n");
            //Console.WriteLine(verified ? "Valid" : "Nevalid");

            //Afisarea sub forma de XML a parametrilor
            //DSACryptoServiceProvider myDSA = new DSACryptoServiceProvider(512);
            //Console.WriteLine(myDSA.ToXmlString(true));

            //Calcularea timpului DSA: generare, criptare, decriptare, semnare, verificare
            //DSACryptoServiceProvider mydsa = new DSACryptoServiceProvider(512);
            //System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            //int size;
            //int count = 100;
            //swatch.Start();
            //for (int i = 0; i < count; i++)
            //{
            //    mydsa = new DSACryptoServiceProvider(512);
            //    size = mydsa.KeySize;
            //}
            //swatch.Stop();
            //Console.WriteLine("Generation time at 512 bit ... " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");
            //byte[] plain = new byte[20];

            //swatch.Reset();
            //swatch.Start();
            //byte[] signature;
            //signature = mydsa.SignData(System.Text.Encoding.ASCII.GetBytes(ch.ByteArrayToString(plain)));
            //for (int i = 0; i < count; i++)
            //{
            //    signature = mydsa.SignData(System.Text.Encoding.ASCII.GetBytes(ch.ByteArrayToString(plain)));
            //}
            //swatch.Stop();
            //Console.WriteLine("Signing time at 512 bit ... " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");

            //swatch.Reset();
            //swatch.Start();
            //bool verified;
            //for (int i = 0; i < count; i++)
            //{
            //    verified = mydsa.VerifyData(System.Text.Encoding.ASCII.GetBytes(ch.ByteArrayToString(plain)), signature);
            //}
            //swatch.Stop();
            //Console.WriteLine("Verification time at 512 bit ... " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");

        }
    }
}