import java.util.Scanner;

public class Manav {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int armut, elma, domates, muz, patlican;
        double armutFiyat = 2.14;
        double elmaFiyat = 3.67;
        double domatesFiyat = 1.11;
        double muzFiyat = 0.95;
        double patlicanFiyat = 5.00;

        System.out.print("Armut kaç kilo alındı: ");
        armut = input.nextInt();

        System.out.print("Elma kaç kilo alındı: ");
        elma = input.nextInt();

        System.out.print("Domates kaç kilo alındı: ");
        domates = input.nextInt();

        System.out.print("Muz kaç kilo alındı: ");
        muz = input.nextInt();

        System.out.print("Patlıcan kaç kilo alındı: ");
        patlican = input.nextInt();

        double total = armut*armutFiyat + elma*elmaFiyat + muz*muzFiyat + domates*domatesFiyat + patlican*patlicanFiyat;
        System.out.println("Toplam Fiyat: " + total);


    }
}
