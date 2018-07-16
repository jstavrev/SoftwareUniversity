import java.util.Scanner;

public class P09PassowordGuess {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String password = read.nextLine();

        if (password.equals("s3cr3t!P@ssw0rd")) {
            System.out.println("Welcome");
        }
        else {
            System.out.println("Wrong password!");
        }
    }
}
