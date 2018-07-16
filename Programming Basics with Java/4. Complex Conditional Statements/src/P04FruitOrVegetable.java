import java.util.Scanner;

public class P04FruitOrVegetable {

    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        String product = read.nextLine().toLowerCase();

        boolean fruit = product.equals("banana") || product.equals("apple") || product.equals("kiwi") || product.equals("cherry") || product.equals("lemon") || product.equals("grapes");
        boolean vegetable = product.equals("tomato") || product.equals("cucumber") || product.equals("pepper") || product.equals("carrot");

        if (fruit) {
            System.out.println("fruit");
        } else if (vegetable) {
            System.out.println("vegetable");
        } else {
            System.out.println("unknown");
        }
    }
}
