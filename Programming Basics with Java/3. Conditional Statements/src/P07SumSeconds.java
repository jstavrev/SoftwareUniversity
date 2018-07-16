import java.util.Scanner;

public class P07SumSeconds {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int firstTime = Integer.parseInt(read.nextLine());
        int secondTime = Integer.parseInt(read.nextLine());
        int thirdTime = Integer.parseInt(read.nextLine());

        int totalTimeSeconds = firstTime + secondTime + thirdTime;
        int parsedToMinutes = totalTimeSeconds / 60;
        int seconds = parsedToMinutes * 60;
        int diff = totalTimeSeconds - seconds;

        System.out.printf("%d:%02d", parsedToMinutes, diff);
    }
}
