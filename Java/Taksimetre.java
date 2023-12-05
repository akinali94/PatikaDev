import java.util.Scanner;
public class Taksimetre {

    public static void main(String[] args){
        Scanner kmInput = new Scanner(System.in);

        int baslangıc = 10;

        System.out.print("KM giriniz: ");

        double km = kmInput.nextDouble();

        double ucret = baslangıc + km * 2.20;

        ucret = (ucret < 20) ? 20 : ucret;

        System.out.println("Ücret: " + ucret);


    }
}
