package lab;

//import java.security.Key;
//import java.security.KeyPair;
//import java.security.KeyPairGenerator;
//import java.security.Security;
import java.security.SecureRandom;
import javax.crypto.Cipher;
import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
import javax.crypto.BadPaddingException;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.ShortBufferException;
import javax.crypto.spec.SecretKeySpec;
import javax.xml.bind.DatatypeConverter;
//import javax.rmi.CORBA.Util;

public class Ex1 {

	public static void main(String[] args) throws NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException, ShortBufferException, IllegalBlockSizeException, BadPaddingException {
		
		byte[] keyBytes = new byte[16];
		// declare secure PRNG
		SecureRandom myPRNG = new SecureRandom();
		// seed the key
		myPRNG.nextBytes(keyBytes);
		// build the key from random key bytes
		SecretKeySpec myKey = new SecretKeySpec(keyBytes, "AES");
		// instantiate AES object for ECB with no padding
		Cipher myAES = Cipher.getInstance("AES/ECB/NoPadding");
		// initialize AES objecy to encrypt mode
		myAES.init(Cipher.ENCRYPT_MODE, myKey);
		// initialize plaintext
		byte[] plaintext = new byte[16];
		// initialize ciphertext
		byte[] ciphertext = new byte[16];
		// update cipher with the plaintext
		int cLength = myAES.update(plaintext, 0, plaintext.length, ciphertext, 0);
		// process remaining blocks of plaintext
		cLength += myAES.doFinal(ciphertext, cLength);
		// print plaintext and ciphertext
		System.out.println("plaintext: " + DatatypeConverter.printHexBinary(plaintext));
		System.out.println("ciphertext: " + DatatypeConverter.printHexBinary(ciphertext));
		// initialize AES for decryption
		myAES.init(Cipher.DECRYPT_MODE, myKey);
		// initialize a new array of bytes to place the decryption
		byte[] dec_plaintext = new byte[16];
		cLength = myAES.update(ciphertext, 0, ciphertext.length, dec_plaintext, 0);
		// process remaining blocks of ciphertext
		cLength += myAES.doFinal(dec_plaintext, cLength);
		// print the new plaintext (hopefully identical to the initial one)
		System.out.println("decrypted: " + DatatypeConverter.printHexBinary(dec_plaintext));

	}

}
