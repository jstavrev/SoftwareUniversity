import java.util.Scanner;

public class P02InchesToCm {

    public static void main (String[] args) {
        Scanner scanner = new Scanner(System.in);
        double inch = Double.parseDouble(scanner.nextLine());
        double cm = inch * 2.54;
        System.out.printf("cm = %f", cm);
    }
}
