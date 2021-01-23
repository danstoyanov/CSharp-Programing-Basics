using System;

namespace _06_Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());


            for (int tabsCheck = 1; tabsCheck <= tabs; tabsCheck++)
            {
                string webTitle = Console.ReadLine();

                if (webTitle == "Facebook")
                {
                    salary -= 150;
                }

                if (webTitle == "Instagram")
                {
                    salary -= 100;
                }

                if (webTitle == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }

            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
