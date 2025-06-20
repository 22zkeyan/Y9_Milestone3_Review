namespace Y9_Milestone3_review
{
    internal class Program
    {
        static void EssayMark()
        {
            int e1 = 2;
            int e2 = 3;
            int e3 = 4;
            int totalMark = e1 + e2 + e3;
            Console.WriteLine("Enter the number of essays handed in late");
            int late = Convert.ToInt32(Console.ReadLine());
            if (late == 1)
            {
                totalMark -= 10;
            } else if (late > 1)
            {
                totalMark /= 2;
            }
            if (totalMark < 0)
            {
                totalMark = 0;
            }
            Console.WriteLine($"Total mark: {totalMark}");
        }
        static void PasswordChecker()
        {
            string[] usernames = { "Yusuf5", "Mary80" };
            string[] passwords = { "33kk", "af5r" };
            int userInputPos = 0;
            int passInputPos = 0;
            do
            {
                Console.WriteLine("Enter the username and password (on separate lines):");
                string usernameInput = Console.ReadLine()!;
                string passwordInput = Console.ReadLine()!;
                userInputPos = Array.IndexOf(usernames, usernameInput);
                passInputPos = Array.IndexOf(passwords, passwordInput);
                if (userInputPos != passInputPos)
                {
                    Console.WriteLine("Access denied");
                } else
                {
                    Console.WriteLine("Access granted");
                }
            } while (userInputPos != passInputPos);
        }
        static void Main(string[] args)
        {
            PasswordChecker();
        }
    }
}
