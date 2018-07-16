import java.util.Scanner;

public class P06SquareOfStars {
    public static void main (String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        int spaces = n - 2;
        String asteriks = new String(new char[n]).replace("\0", "*");
        String space = new String(new char[spaces]).replace("\0", " ");
        System.out.println(asteriks);
        for (int i = 0; i < n - 2; i++)
        {
            System.out.println("*" + space + "*");
        }
        System.out.println(asteriks);
    }
}
