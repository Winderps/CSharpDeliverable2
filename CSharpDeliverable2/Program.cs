using System;

namespace CSharpDeliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            string input = "";
            int checksum = 0;

            Console.Write("What is your message? ");
            input = Console.ReadLine().ToUpper();

            foreach (char c in input)
            {
                message += (c - 64).ToString() + "-";
                checksum += c;
            }
            message = message.Remove(message.Length - 1);

            Console.WriteLine($"New encoded message: {message}.");
            Console.WriteLine($"Message checksum: {checksum}.");
        }
    }
}
