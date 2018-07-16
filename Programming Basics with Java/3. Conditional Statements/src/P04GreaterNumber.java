import java.util.Scanner;

public class P04GreaterNumber {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int a = Integer.parseInt(read.nextLine());
        int b = Integer.parseInt(read.nextLine());

        int c = Math.max(a, b);
        System.out.println(c);
    }
}
