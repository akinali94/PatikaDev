import java.util.Scanner;
import java.lang.Math;

public class Daire {
    public static void main(String[] args){
        Scanner circleInput = new Scanner(System.in);

        int radius, angle;
        System.out.print("Enter the radius: ");
        radius = circleInput.nextInt();

        System.out.print("Enter the angle: ");
        angle = circleInput.nextInt();

        double area = radius * radius * Math.PI;
        double circ = 2 * radius * Math.PI;
        double areaOfPart = (Math.PI * radius * radius * angle) / 360;

        System.out.println("Area of circle: " + area);
        System.out.println("Circumference of circle: " + circ);
        System.out.println("Area of circle with central angle : " + areaOfPart);






    }
}
