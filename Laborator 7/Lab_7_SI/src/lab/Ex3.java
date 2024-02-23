package lab;

//import java.security.Key;
//import java.security.KeyPair;
//import java.security.KeyPairGenerator;
//import java.security.Security;
import java.security.spec.InvalidKeySpecException;
import java.security.SecureRandom;
//import javax.crypto.Cipher;
//import java.security.InvalidKeyException;
import java.security.NoSuchAlgorithmException;
//import javax.crypto.BadPaddingException;
//import javax.crypto.IllegalBlockSizeException;
//import javax.crypto.NoSuchPaddingException;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
//import javax.crypto.ShortBufferException;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;
import javax.xml.bind.DatatypeConverter;

public class Ex3 {

	public static void main(String[] args) throws NoSuchAlgorithmException, InvalidKeySpecException {

		// declare secure PRNG
		SecureRandom myPRNG = new SecureRandom();
		char[] password = "short_password".toCharArray();
		byte[] salt = new byte[16];
		int iteration_count = 10000;
		int key_size = 128;
		// set salt values to random
		myPRNG.nextBytes(salt);
		// initialize key factory for HMAC-SHA1 derivation
		SecretKeyFactory keyFactory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1");
		// set key specification
		PBEKeySpec pbekSpec = new PBEKeySpec(password, salt, iteration_count, key_size);
		// generate the key
		SecretKey myAESPBKey = new SecretKeySpec(keyFactory.generateSecret(pbekSpec).getEncoded(), "AES");
		// print the key
		System.out.println("AES key: " + DatatypeConverter.printHexBinary(myAESPBKey.getEncoded()));
		
	}

}
