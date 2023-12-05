import java.util.Scanner;

public class NotOrtalamasi {

    public static void main(String[] args){
        int turkce, matematik, fizik, kimya, tarih, muzik;
        Scanner input1 = new Scanner(System.in);

        System.out.println("Turkce notunu giriniz: ");
        turkce = input1.nextInt();

        System.out.println("Matematik notunu giriniz: ");
        matematik = input1.nextInt();

        System.out.println("Fizik notunu giriniz: ");
        fizik = input1.nextInt();

        System.out.println("Kimya notunu giriniz: ");
        kimya = input1.nextInt();

        System.out.println("Tarih notunu giriniz: ");
        tarih = input1.nextInt();

        System.out.println("Muzik notunu giriniz: ");
        muzik = input1.nextInt();

        double not = ((double) matematik + tarih + muzik + fizik + kimya +turkce) / 6;

        System.out.println("Not Ortamalamaniz: " + not);

    }
}
