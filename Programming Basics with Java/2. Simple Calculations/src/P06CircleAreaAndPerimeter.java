import java.util.Scanner;

public class P06CircleAreaAndPerimeter {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double r = Double.parseDouble(scanner.nextLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        System.out.printf("Area = %f%n", area);
        System.out.printf("Perimeter = %f", perimeter);
    }
}
