public class P04TriangleOfStars {

        public static void main (String[] args) {

            for (int i = 1; i <= 10; i++) {
                String asteriks = new String(new char[i]).replace("\0", "*");
                System.out.println(asteriks);
            }
        }
}
