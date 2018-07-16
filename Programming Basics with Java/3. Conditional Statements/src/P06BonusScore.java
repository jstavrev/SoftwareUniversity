import java.util.Scanner;

public class P06BonusScore {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());
        double bonusScore = 0;

        if (n <= 100) {
            bonusScore += 5;
        }
        else if (n > 100 && n <= 1000) {
            bonusScore += n * 0.2;
        }
        else if (n > 1000) {
            bonusScore += n * 0.1;
        }

        if (n % 2 == 0) {
            bonusScore += 1;
        }
        if (n % 10 == 5) {
            bonusScore += 2;
        }

        System.out.println(bonusScore);
        System.out.println(bonusScore + n);
    }
}
