import java.util.Scanner;

public class P05MaxNumber {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());
        int max = -99999999;
        for (int i = 0; i < n; i++) {
            int num = Integer.parseInt(read.nextLine());
            if (num > max) {
                max = num;
            }
        }
        System.out.println(max);
    }
}
