import java.util.Scanner;

public class P01ExcellentResult {

    public static void main(String[] args) {
	Scanner read = new Scanner(System.in);
	double grade = Double.parseDouble(read.nextLine());

	if (grade >= 5.5) {
        System.out.println("Excellent!");
    }
    }
}
