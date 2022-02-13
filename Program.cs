using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Shifts: ");
            int shift = Convert.ToInt32(Console.ReadLine());
            int saving;


            if (salary < 0)
            {
                Console.WriteLine("Salary too small");
            }
            if (salary > 8000)
            {
                Console.WriteLine("Salary too large");
            }
            if (shift < 0)
            {
                Console.WriteLine("Shift too small");
            }
            else
            {
                saving = (int)(salary - ((30 / 100.00) * salary) - ((20 / 100) * salary) + ((2 / 100) * salary * shift));
                Console.WriteLine(saving);
            }

            Console.ReadLine();
        }
    }
}
