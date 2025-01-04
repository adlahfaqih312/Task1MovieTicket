namespace Task1MovieTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void discountDay(string d, double a)
            {
                if (d == "MONDAY" || d == "TUESDAY" || d == "WEDNESDAY" || d == "THURSDAY")
                {
                    a = a - ((a * 10) / 100);
                    Console.WriteLine($"your ticket price is : {a}");
                }
                else if (d == "FRIDAY" || d == "SATURDAY" || d == "SUNDAY")
                {
                    a = a;
                    Console.WriteLine($"your ticket price is : {a}");
                }
                else
                {
                    Console.WriteLine("You enter a wrong day");
                }
            }
            Console.WriteLine("Please Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            double price;
            Console.WriteLine("Please Enter the day you want : ");
            string day = Console.ReadLine();
            string d = day.ToUpper();
            if (age >= 18 && age < 60)
            {
                price = 12;
                discountDay(d, price);

            }
            else if (age >= 60)
            {
                price = 8;
                discountDay(d, price);
            }
            else
            {
                price = 6;
                discountDay(d, price);
            }


        }
    }
}
