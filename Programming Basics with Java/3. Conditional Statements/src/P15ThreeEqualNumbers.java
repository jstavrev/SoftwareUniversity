import java.util.Scanner;

public class P15ThreeEqualNumbers {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int a = Integer.parseInt(read.nextLine());
        int b = Integer.parseInt(read.nextLine());
        int c = Integer.parseInt(read.nextLine());

        if (a == b && b == c) {
            System.out.println("yes");
        }
        else {
            System.out.println("no");
        }
    }
}
