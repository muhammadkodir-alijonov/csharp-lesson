import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Object[] userDetails = getUserDetails();
        System.out.println("Name: " + userDetails[0] + ", Surname: " + userDetails[1] + ", Age: " + userDetails[2]);
    }
    public static int getAge() {
        System.out.println("Enter your age: ");
        Scanner scanner = new Scanner(System.in);
        int age = scanner.nextInt();
        return age;
    }
    public static Object[] getUserDetails() {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter your name: ");
        String name = scanner.nextLine();

        System.out.print("Enter your surname: ");
        String surname = scanner.nextLine();

        System.out.print("Enter your age: ");
        int age = scanner.nextInt();

        Object[] userDetails = new Object[3];
        userDetails[0] = name;
        userDetails[1] = surname;
        userDetails[2] = age;

        return userDetails;
    }
    public static User getUser() {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter your name: ");
        String name = scanner.nextLine();

        System.out.print("Enter your surname: ");
        String surname = scanner.nextLine();

        System.out.print("Enter your age: ");
        int age = scanner.nextInt();

        User u = new User();
        u.name = name;
        u.surname = surname;
        u.age = age;
        return u;
    }
}