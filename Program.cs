using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW4_Christopher_Cesen
{
    class Program
    {
        static void Main(string[] args)
        {
            int cNumber1;
            int cNumber2;
            int cSum;

            Console.WriteLine("Enter the amount for the first number");
            cNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount for the  second number");
            cNumber2 = int.Parse(Console.ReadLine());

            cSum = cNumber1 + cNumber2;
            Console.WriteLine("The sum of {0} +{1} is {2}", cNumber1, cNumber2, cSum);

            decimal cAmount1;
            decimal cAmount2;
            decimal cAmount3;
            decimal cProduct;

            cAmount1 = 5;
            cAmount2 = 6;
            cAmount3 = 7;
            cProduct = (cAmount1 + cAmount2) * (cAmount3 + 10);

            Console.WriteLine("The sum of {0} +{1} * {2} +10 = {3}", cAmount1, cAmount2, cAmount3, cProduct);






            Console.WriteLine("Hello\tWorld");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine(" \"Hello World\" ");
            Console.WriteLine("Hello \\ World!");
        }
    }
}
