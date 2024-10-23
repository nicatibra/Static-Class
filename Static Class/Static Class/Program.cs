namespace Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n0. Exit program \n1. IsOdd() method \n2. IsEven() \n3. HasDigit() method \n4. CheckPassword() method \n5. Capitalize() method");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your number: ");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entered number is odd: " + number.IsOdd());
                        break;

                    case 2:
                        Console.WriteLine("\nEnter your number: ");
                        int number2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Entered number is even: " + number2.IsEven());
                        break;

                    case 3:
                        Console.WriteLine("\nEnter word: ");
                        string word = Console.ReadLine();
                        Console.WriteLine("Entered word has digit: " + word.HasDigit());
                        break;

                    case 4:
                        Console.WriteLine("\nEnter your password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine("Your password is in correct format: " + password.CheckPassword());
                        break;

                    case 5:
                        Console.WriteLine("\nEnter your word: ");
                        string word2 = Console.ReadLine();
                        Console.WriteLine("Capitalized word: " + word2.Capitalize());
                        break;

                    default:
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
