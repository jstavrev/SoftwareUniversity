import java.util.Scanner;

public class P07LeftAndRightSum {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());
        int leftTotal = 0;
        int rightTotal = 0;

        for (int i = 0; i < n; i++) {
            int leftNum = Integer.parseInt(read.nextLine());
            leftTotal += leftNum;
        }
        for (int i = 0; i < n; i++) {
            int rightNum = Integer.parseInt(read.nextLine());
            rightTotal += rightNum;
        }
        if (leftTotal == rightTotal) {
            System.out.printf("Yes sum = %d", leftTotal);
        } else {
            System.out.printf("No, diff = %d", Math.abs(leftTotal-rightTotal));
        }
    }
}
