using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the increase: " + salaryBudget);

            Increase(salaryBudget, percent);
        }

        static void Increase(int salaryBudget, int percent)
        {
            salaryBudget += (int)(salaryBudget * (percent / 100.0));
            Console.WriteLine("After the increase: " + salaryBudget);
        }
    }
}