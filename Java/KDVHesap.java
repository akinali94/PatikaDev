import java.util.Scanner;

public class KDVHesap {
    public static void main(String[] args){
        Scanner input1 = new Scanner(System.in);
        int fiyat;

        System.out.print("Fiyati giriniz: ");
        fiyat = input1.nextInt();

        double kdv = ((double) fiyat) * 18 / 100;
        double fiyatKdv = fiyat + kdv;

        System.out.print("KDV'li Fiyat: " + fiyatKdv + "\n");
        System.out.print("KDV: " + kdv);

    }
}
