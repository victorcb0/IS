package lab;

import java.math.BigInteger;

public class Ex2 {

	public static void main(String[] args) {
		
		BigInteger n1 = new BigInteger("1847699703211741474306835620200164403018549338663410171471785774910651696711"
				+ "1612498593376843054357445856160615445717940522297177325246609606469460712496"
				+ "2372044202226975675668737842756238950876467844093328515749657884341508847552"
				+ "8298186726451339863364931908084671990431874381283363502795470282653297802934"
				+ "9161558118810498449083195450098483937752272570525785919449938700736957556884"
				+ "3693381277961308923039256969525326162082367649031603655137144791393234716956"
				+ "6988069");
		BigInteger n2 = new BigInteger("2519590847565789349402718324004839857142928212620403202777713783604366202070"
				+ "7595556264018525880784406918290641249515082189298559149176184502808489120072"
				+ "8449926873928072877767359714183472702618963750149718246911650776133798590957"
				+ "0009733045974880842840179742910064245869181719511874612151517265463228221686"
				+ "9987549182422433637259085141865462043576798423387184774447920739934236584823"
				+ "8242811981638150106748104516603773060562016196762561338441436038339044149526"
				+ "3443219011465754445417842402092461651572335077870774981712577246796292638635"
				+ "6373289912154831438167899885040445364023527381951378636564391212010397122822"
				+ "120720357");
		BigInteger c1 = new BigInteger("1720824975522517857539467309146518060382842270514896093391979291030656292239"
				+ "7291446654035136859446266905140522147597644944431643498057575862023479413245"
				+ "6638260412096493538625812249998880361757163409597018001190001744747405240965"
				+ "7500820140866171389821089899978493473235156488326073675749875367732149010528"
				+ "9244104109064444335973488450882364503785143338799248614163518428477608940469"
				+ "9678849571206887860878689927075639507531091535187214291140378602914898718344"
				+ "7449947");
		BigInteger c2 = new BigInteger("4561642280956381246774642331705575104523442518306294887033201504008906454855"
				+ "8878555145972657908956759775539747979197737797768926554418702738975251318948"
				+ "7102258520443358104409325508073221395545765319081041834133569912754811011387"
				+ "3635190699932165850542152382657518899992710162713201334532551245793969597202"
				+ "6692191157400036070478620074907493119547542465852819192370184492356694178657"
				+ "6698578327560649299302223024036233077234207232288187628580786589383228234629"
				+ "4300028016342171410187938861009812975635715641457865781951720724292241356964"
				+ "6111551957961184286656146057704287329146644239215935313741848147782402529568"
				+ "44983980");
		BigInteger m = c1.multiply(n2.multiply(n2.modInverse(n1))).add(c2.multiply(n1.multiply(n1.modInverse(n2)))).mod(n1.multiply(n2));
		m = m.sqrt();
		System.out.println(m);
	}

}