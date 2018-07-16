import java.util.Scanner;

public class P08OddEvenSum {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());
        int evenSum = 0;
        int oddSum = 0;
        for (int i = 0; i < n; i ++) {
            int num = Integer.parseInt(read.nextLine());
            if (i % 2 == 0) {
                evenSum += num;
            } else {
                oddSum += num;
            }
        }
        if (evenSum == oddSum) {
            System.out.printf("Yes Sum = %d", evenSum);
        } else {
            System.out.printf("No Diff = %d ", Math.abs(evenSum-oddSum));
        }
    }
}
