import java.util.Scanner;

public class P01PersonalTitles {

    public static void main(String[] args) {
	Scanner read = new Scanner(System.in);
	double age = Double.parseDouble(read.nextLine());
	String gender = read.nextLine();

	if (gender.equals("m")) {
		if (age >= 16) {
			System.out.println("Mr.");
		}
		else {
			System.out.println("Master");
		}
	} else {
		if (age >= 16) {
			System.out.println("Ms.");
		}
		else {
			System.out.println("Miss");
		}
	}
    }
}
