import java.util.Scanner;

public class P05InvalidNumber {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());

        if (n == 0 || (n >= 100 && n <= 200)) {

        } else {
            System.out.println("invalid");
        }

    }
}
