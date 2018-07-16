import java.util.Scanner;

public class P08TradeComissions {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String town = read.nextLine().toLowerCase();
        double sales = Double.parseDouble(read.nextLine());
        double comissions = 0.0;
        boolean townCheck = town.equals("sofia") || town.equals("varna") || town.equals("plovdiv");
        boolean errorFree = true;
        if (townCheck && sales >= 0) {
            switch (town) {
                case "sofia":
                    if (sales >= 0 && sales <= 500) {
                        comissions = sales * 0.05;
                    } else if (sales > 500 && sales <= 1000) {
                        comissions = sales * 0.07;
                    } else if (sales > 1000 && sales <= 10000) {
                        comissions = sales * 0.08;
                    } else if (sales > 10000) {
                        comissions = sales * 0.12;
                    }
                        break;
                case "varna":
                    if (sales >= 0 && sales <= 500) {
                        comissions = sales * 0.045;
                    } else if (sales > 500 && sales <= 1000) {
                        comissions = sales * 0.075;
                    } else if (sales > 1000 && sales <= 10000) {
                        comissions = sales * 0.1;
                    } else if (sales > 10000) {
                        comissions = sales * 0.13;
                    }
                        break;
                case "plovdiv":
                    if (sales >= 0 && sales <= 500) {
                        comissions = sales * 0.055;
                    } else if (sales > 500 && sales <= 1000) {
                        comissions = sales * 0.08;
                    } else if (sales > 1000 && sales <= 10000) {
                        comissions = sales * 0.12;
                    } else if (sales > 10000) {
                        comissions = sales * 0.145;
                    }
                        break;
            }
        } else {
            System.out.println("error");
            errorFree = false;
        }
        if (errorFree) {
            System.out.printf("%.2f", comissions);
        }
    }
}
