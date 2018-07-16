import java.util.Scanner;

public class P01SquareArea {

    public static void main(String[] args) {
	Scanner scanner = new Scanner(System.in);
	int a = Integer.parseInt(scanner.nextLine());

	int area = (int)Math.pow(a, 2);

        System.out.println(area);
    }
}
