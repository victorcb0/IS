package lab;

import java.math.BigInteger;

public class Ex1 {

	public static void main(String[] args) {
		
		BigInteger n = new BigInteger("837210799");
		BigInteger e = new BigInteger("7");
		BigInteger d = new BigInteger("478341751");
		
		BigInteger[] k;
		k = (e.multiply(d).subtract(new BigInteger("1"))).divideAndRemainder(n);
		if (k[1].compareTo(n.divide(new BigInteger("2"))) > 0) 
			k[0] = k[0].add(new BigInteger("1"));
		
		BigInteger S = new BigInteger("4").multiply(n.add(new BigInteger("1"))).add(new BigInteger("1")).subtract(e.multiply(d)).divide(k[0]);
		BigInteger delta = S.pow(2).subtract(new BigInteger("4").multiply(n));
		BigInteger p = S.add(delta.sqrt()).divide(new BigInteger("2"));
		BigInteger q = S.subtract(delta.sqrt()).divide(new BigInteger("2"));
		
		System.out.println(p + " " + q);

	}

}
