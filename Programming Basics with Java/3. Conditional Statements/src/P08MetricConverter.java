import java.util.Scanner;

public class P08MetricConverter {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        double distance = Double.parseDouble(read.nextLine());
        String from = read.nextLine();
        String to = read.nextLine();

        double meters = 0;
        switch (from) {
            case "m": meters = distance;
                break;
            case "mm": meters = distance / 1000;
                break;
            case "cm": meters = distance / 100;
                break;
            case "mi":  meters = distance / 0.000621371192;
                break;
            case "in": meters = distance / 39.3700787;
                break;
            case "km": meters = distance * 1000;
                break;
            case "ft": meters = distance / 3.2808399;
                break;
            case "yd": meters = distance / 1.0936133;
        }
        switch (to) {
            case "m":
                System.out.println(meters);
                break;
            case "mm": meters *= 1000;
                System.out.printf("%.8f", meters);
                break;
            case "cm": meters *= 100;
                System.out.println(meters);
                break;
            case "mi":  meters *= 0.000621371192;
                System.out.println(meters);
                break;
            case "in": meters *= 39.3700787;
                System.out.println(meters);
                break;
            case "km": meters /= 1000;
                System.out.println(meters);
                break;
            case "ft": meters *= 3.2808399;
                System.out.println(meters);
                break;
            case "yd": meters *= 1.0936133;
                System.out.println(meters);
                break;
        }
    }
}
