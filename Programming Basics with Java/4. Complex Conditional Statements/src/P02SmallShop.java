import java.util.Scanner;

public class P02SmallShop {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String product = read.nextLine().toLowerCase();
        String town = read.nextLine().toLowerCase();
        double amount = Double.parseDouble(read.nextLine());
        double bill = 0.0;
        switch (town) {
            case "sofia":
                switch (product) {
                    case "coffee": bill = amount * 0.5; break;
                    case "water": bill = amount * 0.8; break;
                    case "beer": bill = amount * 1.2; break;
                    case "sweets": bill = amount * 1.45; break;
                    case "peanuts": bill = amount * 1.6; break;

                }
                break;
            case "plovdiv":
                switch (product) {
                    case "coffee": bill = amount * 0.4; break;
                    case "water": bill = amount * 0.7; break;
                    case "beer": bill = amount * 1.15; break;
                    case "sweets": bill = amount * 1.30; break;
                    case "peanuts": bill = amount * 1.5; break;

                }
                break;
            case "varna":
                switch (product) {
                    case "coffee": bill = amount * 0.45; break;
                    case "water": bill = amount * 0.7; break;
                    case "beer": bill = amount * 1.1; break;
                    case "sweets": bill = amount * 1.35; break;
                    case "peanuts": bill = amount * 1.55; break;

                }
                break;
        }
        System.out.println(bill);

    }
}
