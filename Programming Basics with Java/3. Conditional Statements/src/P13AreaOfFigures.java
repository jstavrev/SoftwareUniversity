import java.util.Scanner;

public class P13AreaOfFigures {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String figureType = read.nextLine();

        switch (figureType) {
            case "square":
                double a = Double.parseDouble(read.nextLine());
                System.out.printf("%.3f", a * a);
                break;
            case "rectangle":
                double a1 = Double.parseDouble(read.nextLine());
                double b1 = Double.parseDouble(read.nextLine());
                System.out.printf("%.3f", a1 * b1);
                break;
            case "circle":
                double r = Double.parseDouble(read.nextLine());
                System.out.printf("%.3f", Math.PI * r * r);
                break;
            case "triangle":
                double a2 = Double.parseDouble(read.nextLine());
                double b2 = Double.parseDouble(read.nextLine());
                System.out.printf("%.3f", a2 * b2 / 2);
                break;
        }
    }
}
