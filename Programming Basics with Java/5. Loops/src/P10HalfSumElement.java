import java.util.Arrays;
import java.util.OptionalInt;
import java.util.Scanner;
import java.util.stream.IntStream;

public class P10HalfSumElement {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());
        int[] arr = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++) {
            int num = Integer.parseInt(read.nextLine());
            arr[i] = num;
            sum += num;
        }
        if (Arrays.asList(arr).contains(sum)) {
            System.out.printf("Yes sum = %d", sum);
        } else {
            System.out.printf("No Diff = %d", sum - Arrays.stream(arr).max());
        }



    }
}
