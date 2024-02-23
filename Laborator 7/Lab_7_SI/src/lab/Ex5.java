package lab;

import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;
import java.security.spec.InvalidKeySpecException;
import java.time.Duration;
import java.time.Instant;

import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;
//import javax.xml.bind.DatatypeConverter;

public class Ex5 {

	public static void main(String[] args) throws NoSuchAlgorithmException, InvalidKeySpecException {
				
		char[] password = "short_password".toCharArray();
		byte[] salt = new byte[16];
		int iteration_count = 10000;
		int key_size = 128;
		
		Instant start = Instant.now();
		SecureRandom myPRNG = new SecureRandom();
		myPRNG.nextBytes(salt);
		SecretKeyFactory keyFactory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1");
		PBEKeySpec pbekSpec = new PBEKeySpec(password, salt, iteration_count, key_size);
		SecretKey myAESPBKey = new SecretKeySpec(keyFactory.generateSecret(pbekSpec).getEncoded(), "AES");  
		Instant end = Instant.now();
		
		Duration timeElapsed = Duration.between(start, end); 
		System.out.println(timeElapsed.toMillis() + " ms");

	}

}
