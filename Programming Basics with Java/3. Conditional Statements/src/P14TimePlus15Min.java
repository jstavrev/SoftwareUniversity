import java.util.Scanner;

public class P14TimePlus15Min {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int hour = Integer.parseInt(read.nextLine());
        int minutes = Integer.parseInt(read.nextLine());

        if (minutes + 15 >= 60) {
            hour++;
            minutes -= 45;
        }
        else {
            minutes += 15;
        }
        if (hour == 24) {
            hour = 0;
        }

        System.out.printf("%d:%02d", hour, minutes);
    }
}
