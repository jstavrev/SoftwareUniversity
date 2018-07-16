import java.util.Scanner;

public class P03EvenOrOdd {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int n = Integer.parseInt(read.nextLine());

        if (n % 2 == 0) {
            System.out.println("even");
        }
        else {
            System.out.println("odd");
        }
    }
}
