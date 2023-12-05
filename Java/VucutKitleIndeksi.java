import java.util.Scanner;

public class VucutKitleIndeksi {

    public static void main(String[] args){
        Scanner inputs = new Scanner(System.in);

        double height, weight;
        System.out.print("Enter your height: ");
        height = inputs.nextDouble();
        System.out.print("Enter your weight: ");
        weight = inputs.nextDouble();

        double bmi = weight / height * height;
        System.out.print("Your Body Mass Index : " + bmi);

    }
}
