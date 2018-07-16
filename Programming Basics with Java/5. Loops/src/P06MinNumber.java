import java.util.Scanner;

public class P06MinNumber {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());
        int min = 99999999;
        for (int i = 0; i < n; i++) {
            int num = Integer.parseInt(read.nextLine());
            if (num < min) {
                min = num;
            }
        }
        System.out.println(min);
    }
}
