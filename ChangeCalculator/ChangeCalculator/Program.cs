using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the amount of money that you would like to convert into changes:");
            var d =Convert.ToDouble(Console.ReadLine());

            Calculator c = new Calculator(d);
            c.changeCalculator();
            Console.ReadLine();
        }

        
    }

    
    
}
