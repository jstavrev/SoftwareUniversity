import java.util.Scanner;

public class P12CurrencyConverter {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double amount = Double.parseDouble(scanner.nextLine());
        String receivedCurrency = scanner.nextLine();
        String returnedCurrency = scanner.nextLine();
        double bgn = 0.0;

        switch (receivedCurrency) {
            case "USD": bgn = amount * 1.79549;
                break;
            case "EUR": bgn = amount * 1.95583;
                break;
            case "GBP": bgn = amount * 2.53405;
                break;
            case "BGN": bgn = amount;
                break;
        }

        switch (returnedCurrency) {
            case "USD":
                bgn /= 1.79549;
                System.out.printf("%.2f USD", bgn);
                break;
            case "EUR":
                bgn /= 1.95583;
                System.out.printf("%.2f EUR", bgn);
                break;
            case "GBP":
                bgn /= 2.53405;
                System.out.printf("%.2f GBP", bgn);
                break;
            case "BGN":
                System.out.printf("%.2f BGN", bgn);
                break;
        }
    }
}
