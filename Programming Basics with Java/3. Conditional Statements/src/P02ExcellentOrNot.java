import java.util.Scanner;

public class P02ExcellentOrNot{

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        double grade = Double.parseDouble(read.nextLine());

        if (grade >= 5.5) {
            System.out.println("Excellent!");
        }
        else {
            System.out.println("Not excellent.");
        }
    }
}
