import java.util.Scanner;
import java.lang.Math;

public class Hipotenüs {
    public static void main(String[] args){
        Scanner input1 = new Scanner(System.in);
        int a, b;

        System.out.println("Birinci kenar: " );
        a = input1.nextInt();

        System.out.println("Ikinci kenar: " );
        b = input1.nextInt();

        double hipo = Math.sqrt(a *a + b * b);

        System.out.print("Hipotenüs: " + hipo);

    }
}
