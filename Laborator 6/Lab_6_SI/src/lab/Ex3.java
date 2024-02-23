package lab;

import java.math.BigInteger;

public class Ex3 {

	public static void main(String[] args) {
		
		BigInteger n = new BigInteger("5076313634899413540120536350051034312987619378778911504647420938544"
				+ "7465177110314901155284204273194792744073890582538974985571109131603"
				+ "02801741874277608327");
		BigInteger e = new BigInteger("3");
		BigInteger d = new BigInteger("3384209089932942360080357566700689541991746252519274336431613959029"
				+ "8310118072592266557861250508877279212747197519861041620378008076415"
				+ "22348207376583379547");
		
		BigInteger[] k;
		k = (e.multiply(d).subtract(new BigInteger("1"))).divideAndRemainder(n);
		if (k[1].compareTo(n.divide(new BigInteger("2"))) > 0) 
			k[0] = k[0].add(new BigInteger("1"));
		
		BigInteger S = k[0].multiply(n.add(new BigInteger("1"))).add(new BigInteger("1")).subtract(e.multiply(d)).divide(k[0]);
		BigInteger delta = S.pow(2).subtract(new BigInteger("4").multiply(n));
		BigInteger p = S.add(delta.sqrt()).divide(new BigInteger("2"));
		BigInteger q = S.subtract(delta.sqrt()).divide(new BigInteger("2"));
		
		System.out.println(p + "\n" + q);

	}

}
