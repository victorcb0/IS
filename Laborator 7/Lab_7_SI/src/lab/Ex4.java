package lab;

//import java.security.Key;
//import java.security.KeyPair;
//import java.security.KeyPairGenerator;
//import java.security.Security;
import java.security.spec.InvalidKeySpecException;
import java.security.SecureRandom;
import java.security.InvalidAlgorithmParameterException;
import java.security.InvalidKeyException;
import javax.crypto.Cipher;
import java.security.NoSuchAlgorithmException;
import javax.crypto.BadPaddingException;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.ShortBufferException;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;
import javax.xml.bind.DatatypeConverter;

public class Ex4 {
	
	public static void main(String[] args) throws NoSuchAlgorithmException, InvalidKeySpecException, NoSuchPaddingException, InvalidKeyException, InvalidAlgorithmParameterException, ShortBufferException, IllegalBlockSizeException, BadPaddingException {
		
		SecureRandom myPRNG = new SecureRandom();
		char[] password = "short_password".toCharArray();
		byte[] salt = new byte[16];
		int iteration_count = 10000;
		int key_size = 128;
		myPRNG.nextBytes(salt);
		SecretKeyFactory keyFactory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1");
		PBEKeySpec pbekSpec = new PBEKeySpec(password, salt, iteration_count, key_size);
		SecretKey myAESPBKey = new SecretKeySpec(keyFactory.generateSecret(pbekSpec).getEncoded(), "AES");
		System.out.println("AES key: " + DatatypeConverter.printHexBinary(myAESPBKey.getEncoded()));
		
		byte[] plaintext = new byte[16];
		byte[] keyBytes1 = new byte[16];
		byte[] ivBytes1 = new byte[16];
		byte[] ciphertext1 = new byte[16];
		plaintext = hexStringToByteArray(DatatypeConverter.printHexBinary(myAESPBKey.getEncoded()));
		myPRNG.nextBytes(keyBytes1);
		myPRNG.nextBytes(ivBytes1);
		SecretKeySpec myKey1 = new SecretKeySpec(keyBytes1, "AES");
		IvParameterSpec myIV1 = new IvParameterSpec(ivBytes1);
		Cipher myAES1 = Cipher.getInstance("AES/CBC/NoPadding");
		myAES1.init(Cipher.ENCRYPT_MODE, myKey1, myIV1);
		int cLength1 = myAES1.update(plaintext, 0, plaintext.length, ciphertext1, 0);
		cLength1 += myAES1.doFinal(ciphertext1, cLength1);
		System.out.println("ciphertext1: " + DatatypeConverter.printHexBinary(ciphertext1));
		
		byte[] keyBytes2 = new byte[16];
		byte[] ivBytes2 = new byte[16];
		byte[] ciphertext2 = new byte[16];
		myPRNG.nextBytes(keyBytes2);
		myPRNG.nextBytes(ivBytes2);
		SecretKeySpec myKey2 = new SecretKeySpec(keyBytes2, "AES");
		IvParameterSpec myIV2 = new IvParameterSpec(ivBytes2);
		Cipher myAES2 = Cipher.getInstance("AES/OFB/NoPadding");
		myAES2.init(Cipher.ENCRYPT_MODE, myKey2, myIV2);
		int cLength2 = myAES2.update(ciphertext1, 0, ciphertext1.length, ciphertext2, 0);
		cLength2 += myAES2.doFinal(ciphertext2, cLength2);
		System.out.println("ciphertext2: " + DatatypeConverter.printHexBinary(ciphertext2));
		
		byte[] keyBytes3 = new byte[16];
		byte[] ivBytes3 = new byte[16];
		byte[] ciphertext3 = new byte[16];
		myPRNG.nextBytes(keyBytes3);
		myPRNG.nextBytes(ivBytes3);
		SecretKeySpec myKey3 = new SecretKeySpec(keyBytes3, "AES");
		IvParameterSpec myIV3 = new IvParameterSpec(ivBytes3);
		Cipher myAES3 = Cipher.getInstance("AES/CFB/NoPadding");
		myAES3.init(Cipher.ENCRYPT_MODE, myKey3, myIV3);
		int cLength3 = myAES3.update(ciphertext2, 0, ciphertext2.length, ciphertext3, 0);
		cLength3 += myAES3.doFinal(ciphertext3, cLength3);
		System.out.println("ciphertext3: " + DatatypeConverter.printHexBinary(ciphertext3));
		
		myAES3.init(Cipher.DECRYPT_MODE, myKey3, myIV3);
		byte[] dec_plaintext3 = new byte[16];
		cLength3 = myAES3.update(ciphertext3, 0, ciphertext3.length, dec_plaintext3, 0);
		cLength3 += myAES3.doFinal(dec_plaintext3, cLength3);
		System.out.println("\ndecrypted3: " + DatatypeConverter.printHexBinary(dec_plaintext3));
		
		myAES2.init(Cipher.DECRYPT_MODE, myKey2, myIV2);
		byte[] dec_plaintext2 = new byte[16];
		cLength2 = myAES2.update(dec_plaintext3, 0, dec_plaintext3.length, dec_plaintext2, 0);
		cLength2 += myAES2.doFinal(dec_plaintext2, cLength2);
		System.out.println("decrypted2: " + DatatypeConverter.printHexBinary(dec_plaintext2));
		
		myAES1.init(Cipher.DECRYPT_MODE, myKey1, myIV1);
		byte[] dec_plaintext1 = new byte[16];
		cLength1 = myAES1.update(dec_plaintext2, 0, dec_plaintext2.length, dec_plaintext1, 0);
		cLength1 += myAES1.doFinal(dec_plaintext1, cLength1);
		System.out.println("decrypted1: " + DatatypeConverter.printHexBinary(dec_plaintext1));
	}

	public static byte[] hexStringToByteArray(String s) {
	    int len = s.length();
	    byte[] data = new byte[len / 2];
	    for (int i = 0; i < len; i += 2) {
	        data[i / 2] = (byte) ((Character.digit(s.charAt(i), 16) << 4) + Character.digit(s.charAt(i+1), 16));
	    }
	    return data;
	}

}
