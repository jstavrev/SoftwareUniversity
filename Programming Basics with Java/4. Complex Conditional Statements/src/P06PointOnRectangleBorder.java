import java.util.Scanner;

public class P06PointOnRectangleBorder {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        double x1 = Double.parseDouble(read.nextLine());
        double y1 = Double.parseDouble(read.nextLine());
        double x2 = Double.parseDouble(read.nextLine());
        double y2 = Double.parseDouble(read.nextLine());
        double x = Double.parseDouble(read.nextLine());
        double y = Double.parseDouble(read.nextLine());

        boolean checkX = (x == x1 || x == x2) && (y >= y1 && y <= y2);
        boolean checkY = (y == y1 || y == y2) && (x >= x1 && x <= x2);

        if (checkX || checkY) {
            System.out.println("Border");
        } else {
            System.out.println("Inside / Outside");
        }
    }
}
