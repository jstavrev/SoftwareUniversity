import java.util.Scanner;

public class P04SumNumbers {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());
        int sum = 0;
        for (int i = 0; i < n; i++) {
            int num = Integer.parseInt(read.nextLine());
            sum += num;
        }
        System.out.println(sum);

    }
}
