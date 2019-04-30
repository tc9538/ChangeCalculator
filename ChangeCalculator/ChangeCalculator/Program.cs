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
            //var d = Convert.ToDouble(Console.ReadLine());
            double d=0.00;
            Boolean result = Double.TryParse(Console.ReadLine(), out d);

            while (d!=-1)
            {
                if (d < 0 || d == 0)
                {
                    Console.WriteLine("Enter an amount larger than 0 or does not contain alphabetical characters:");
                    //d = Convert.ToDouble(Console.ReadLine());
                    Boolean resultA = Double.TryParse(Console.ReadLine(), out d);
                    
                }
                else
                {
                    
                    Console.WriteLine("*************************************************************************************");
                    Console.WriteLine("Enter another amount of money to convert into changes or enter -1 to end the program");
                    Boolean resultB = Double.TryParse(Console.ReadLine(), out d);
            
                }

                if(d !=0 && d>0)
                {
                    Calculator c = new Calculator(d);
                    c.changeCalculator();
                }

              

            }


        }

        
    }
}
