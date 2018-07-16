import java.util.Scanner;

public class P11EqualWords {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String firstWord = read.nextLine().toLowerCase();
        String secondWord = read.nextLine().toLowerCase();

        if (firstWord.equals(secondWord)) {
            System.out.println("yes");
        }
        else {
            System.out.println("no");
        }
    }
}
