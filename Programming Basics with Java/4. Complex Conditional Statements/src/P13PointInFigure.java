import java.util.Scanner;

public class P13PointInFigure {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        int h = Integer.parseInt(read.nextLine());
        int x = Integer.parseInt(read.nextLine());
        int y = Integer.parseInt(read.nextLine());

        boolean insideCheckerBottomFig = (x > 0 && x < 3 * h) && (y > 0 && y < h);
        boolean insideCheckerTopFig = (x > h && x < 2 * h) && (y > h && y < 4 * h);
        boolean sharedWallChecker = y == h && (x > h && x < 2 * h);
        boolean borderCheckerBottomFig = ((y == 0 || y == h) && (x >= 0 && x <= 3 * h)) || ((x == 0 || x == 3 * h) && (y >= 0 && y <= h));
        boolean borderCheckerTopFig = (y == 4 * h && (x >= h && x <= 2 * h)) || ((x == h || x == 2 * h) && (y >= h && y <= 4 * h));

        if (insideCheckerBottomFig || insideCheckerTopFig || sharedWallChecker) {
            System.out.println("inside");
        } else if (borderCheckerBottomFig || borderCheckerTopFig) {
            System.out.println("border");
        } else {
            System.out.println("outside");
        }
    }
}
