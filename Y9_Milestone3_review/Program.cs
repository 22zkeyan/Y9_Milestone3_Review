namespace Y9_Milestone3_review
{
    internal class Program
    {
        static void EssayMark()
        {
            int e1 = 2; // Example marks for essays
            int e2 = 3;
            int e3 = 4;
            int totalMark = e1 + e2 + e3; // Calculate total mark from essays
            Console.WriteLine("Enter the number of essays handed in late"); 
            int late = Convert.ToInt32(Console.ReadLine()); // Prompt user for number of late essays
            if (late == 1) // If one essay is late, deduct 10 marks
            {
                totalMark -= 10;
            } 
            else if (late > 1) // If more than one essay is late, half the total mark
            {
                totalMark /= 2;
            }
            if (totalMark < 0) // Ensure total mark does not go below zero
            {
                totalMark = 0;
            }
            Console.WriteLine($"Total mark: {totalMark}"); // Output the final total mark, with the cool concatenation thing Benyamin showed me
        }
        static void PasswordChecker()
        {
            string[] usernames = { "Yusuf5", "Mary80" }; // stores the valid usernames and passwords in string arrays
            string[] passwords = { "33kk", "af5r" };
            int userInputPos = 0; // stores the position of the username input in the usernames array
            int passInputPos = 0; // stores the position of the password input in the passwords array
            do //repeats 1 or more times.
            {
                Console.WriteLine("Enter the username and password (on separate lines):");
                string usernameInput = Console.ReadLine()!; // Read username input from the user
                string passwordInput = Console.ReadLine()!; // Read password input from the user
                userInputPos = Array.IndexOf(usernames, usernameInput); // Find the index of the username input in the usernames array
                passInputPos = Array.IndexOf(passwords, passwordInput); // Find the index of the password input in the passwords array
                if (userInputPos != passInputPos)  // check if the username/password pair entered is not valid
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
