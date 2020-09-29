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
            double d;
            Boolean result = Double.TryParse(Console.ReadLine(), out d);

            while (d>=0)
            {
                
                //Check to see the input is valid or not
                if (d == 0)
                {
                    Console.WriteLine("*************************************************************************************");
                    Console.WriteLine("Enter an amount larger than 0 or does not contain alphabetical characters:");
                    //d = Convert.ToDouble(Console.ReadLine());
                    result = Double.TryParse(Console.ReadLine(), out d);
                    
                }
                else if(d>0)
                {
                    Calculator c1 = new Calculator(d);
                    c1.changeCalculator();
                    Console.WriteLine("*************************************************************************************");
                    Console.WriteLine("Enter another amount of money to convert into changes or enter -1 to end the program");
                    result = Double.TryParse(Console.ReadLine(), out d);
                }
                
            }


        }

        
    }
}
