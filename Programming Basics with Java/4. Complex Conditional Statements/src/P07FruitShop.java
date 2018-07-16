import java.util.Scanner;

public class P07FruitShop {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String product = read.nextLine().toLowerCase();
        String day = read.nextLine().toLowerCase();
        double amount = Double.parseDouble(read.nextLine());
        double price = 0.0;
        boolean weekend = day.equals("saturday") || day.equals("sunday");
        boolean weekDay = day.equals("monday") || day.equals("tuesday") || day.equals("wednesday") || day.equals("thursday") || day.equals("friday");
        boolean fruit = product.equals("banana") || product.equals("apple") || product.equals("orange") || product.equals("grapefruit") || product.equals("kiwi") || product.equals("pineapple") || product.equals("grapes");
        boolean errorFree = true;
        if (weekDay && fruit) {
            switch (product) {
                case "banana":
                    price = amount * 2.5;
                    break;
                case "apple":
                    price = amount * 1.2;
                    break;
                case "orange":
                    price = amount * 0.85;
                    break;
                case "grapefruit":
                    price = amount * 1.45;
                    break;
                case "kiwi":
                    price = amount * 2.7;
                    break;
                case "pineapple":
                    price = amount * 5.5;
                    break;
                case "grapes":
                    price = amount * 3.85;
                    break;
            }
        } else if (weekend && fruit) {
            switch (product) {
                case "banana":
                    price = amount * 2.7;
                    break;
                case "apple":
                    price = amount * 1.25;
                    break;
                case "orange":
                    price = amount * 0.9;
                    break;
                case "grapefruit":
                    price = amount * 1.6;
                    break;
                case "kiwi":
                    price = amount * 3;
                    break;
                case "pineapple":
                    price = amount * 5.6;
                    break;
                case "grapes":
                    price = amount * 4.20;
                    break;
            }

        } else {
            System.out.println("error");
            errorFree = false;
        }
        if (errorFree) {
            System.out.println(price);
        }
    }
}
