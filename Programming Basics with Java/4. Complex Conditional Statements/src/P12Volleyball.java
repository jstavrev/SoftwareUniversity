import java.util.Scanner;

public class P12Volleyball {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String yearType = read.nextLine();
        int holidays = Integer.parseInt(read.nextLine());
        int homeTownWeekends = Integer.parseInt(read.nextLine());
        double totalDaysPlayed = 0.0;
        totalDaysPlayed = ((48 - homeTownWeekends) * 0.75) + (0.6666666666666667 * holidays) + homeTownWeekends;
        if (yearType.equals("leap")) {
            totalDaysPlayed += totalDaysPlayed * 0.15;
        }
        System.out.printf("%f", Math.floor(totalDaysPlayed));

    }
}
