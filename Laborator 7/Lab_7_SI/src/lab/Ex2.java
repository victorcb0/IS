package lab;

import java.security.Key;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
//import java.security.Security;
import java.security.SecureRandom;
import javax.crypto.Cipher;
import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
import javax.crypto.BadPaddingException;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
//import javax.crypto.ShortBufferException;
//import javax.crypto.spec.SecretKeySpec;
import javax.xml.bind.DatatypeConverter;

public class Ex2 {

	public static void main(String[] args) throws NoSuchAlgorithmException, NoSuchPaddingException, InvalidKeyException, IllegalBlockSizeException, BadPaddingException {
		
		byte[] keyBytes = new byte[16];
		// declare secure PRNG
		SecureRandom myPRNG = new SecureRandom();
		// seed the key
		myPRNG.nextBytes(keyBytes);
		// get a Cipher instance for RSA with PKCS1 padding
		Cipher myRSA = Cipher.getInstance("RSA/ECB/PKCS1Padding");
		// get an instance for the Key Generator
		KeyPairGenerator myRSAKeyGen = KeyPairGenerator.getInstance("RSA");
		// generate an 1024 bit key
		myRSAKeyGen.initialize(1024, myPRNG);
		KeyPair myRSAKeyPair= myRSAKeyGen.generateKeyPair();
		// store the public and private key individually
		Key pbKey = myRSAKeyPair.getPublic();
		Key pvKey = myRSAKeyPair.getPrivate();
		// initialize plaintext
		byte[] plaintext = new byte[16];
		// initialize ciphertext
		byte[] ciphertext = new byte[16];
		// init cipher for encryption
		myRSA.init(Cipher.ENCRYPT_MODE, pbKey, myPRNG);
		// encrypt, as expected we encrypt a symmetric key with RSA rather than a file or some longer stream which should be encrypted with AES
		ciphertext = myRSA.doFinal(keyBytes);
		// init cipher for decryption
		myRSA.init(Cipher.DECRYPT_MODE, pvKey);
		// decrypt
		plaintext = myRSA.doFinal(ciphertext);
		System.out.println("plaintext: " + DatatypeConverter.printHexBinary(plaintext));
		System.out.println("ciphertext: " + DatatypeConverter.printHexBinary(ciphertext));
		System.out.println("keybytes: " + DatatypeConverter.printHexBinary(keyBytes));
		
	}

}
