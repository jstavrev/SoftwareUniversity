import java.util.Scanner;

public class P11Cinema {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String ticketType = read.nextLine();
        int r = Integer.parseInt(read.nextLine());
        int c = Integer.parseInt(read.nextLine());
        int totalSeats = r * c;
        double roomPrice = 0.0;

        switch (ticketType) {
            case "Premiere": roomPrice = totalSeats * 12; break;
            case "Normal": roomPrice = totalSeats * 7.5; break;
            case "Discount": roomPrice = totalSeats * 5; break;
        }
        System.out.printf("%2f leva", roomPrice);
    }
}
