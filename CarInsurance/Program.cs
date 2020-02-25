using System;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nHave you even had a DUI? (true or false): ");
            bool duis = Convert.ToBoolean(Console.ReadLine());

            Console.Write("\nHow many speeding tickets do you have?: ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nAre you qualified?: " + (age > 15 && !duis && tickets <= 3));

            Console.Read();
        }
    }
}
