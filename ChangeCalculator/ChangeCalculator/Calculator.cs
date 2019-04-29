using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    public class Calculator
    {
        double amount = 0.0;
        public Calculator(double input)
        {
            amount = input; 
        }
       
        public void changeCalculator()
        {
            //handle dollar bills
            int fiveDollarBillCount = 0;
            int tenDollarBillCount = 0;
            int twentyDollarCount = 0;
            int fiftyDollarBillCount = 0;
            int oneHundredBillCount = 0;

            double dollarAmount = Math.Truncate(amount);
            oneHundredBillCount = (int)(dollarAmount / 100);
            int currentDollarAmount = (int)(dollarAmount % 100);

            if (currentDollarAmount > 0)
            {
                fiftyDollarBillCount = (int)(currentDollarAmount / 50);
                currentDollarAmount = (int)(currentDollarAmount % 50);

                if (currentDollarAmount > 0)
                {
                   
                      twentyDollarCount = (int)(currentDollarAmount / 20);
                      currentDollarAmount = (int)(currentDollarAmount % 20);
                       
                      if(currentDollarAmount>0)
                      {
                            tenDollarBillCount = (int)(currentDollarAmount / 10);
                            currentDollarAmount = (int)(currentDollarAmount % 10);

                            if (currentDollarAmount > 0)
                            {
                                fiveDollarBillCount = (int)(currentDollarAmount / 5);
                                currentDollarAmount = (int)(currentDollarAmount % 5);
                            }
                      }

                 }
                    
                Console.WriteLine("(" + oneHundredBillCount + ") 100 dollar bills (" + fiftyDollarBillCount + ") 50 dollar bills (" + twentyDollarCount+ " ) 20 dollar bills " + "( "+ tenDollarBillCount + ") 10 dollar bills (" + fiveDollarBillCount + ") 5 dollar bills (" + currentDollarAmount + ") 1 dollar bills ");

            }

            //handle decimal parts of amount
            double current = Math.Round(amount - dollarAmount, 2) * 100.00; 
            int quarter = 25;
            int dime = 10;
            int nickle = 5;

            int quarterCount = (int)(current / quarter);
            int dimeCount = 0;
            int nickleCount = 0;

            current = current % quarter;
            if (current > 0)
            {
                dimeCount = (int)(current / dime);
                current = current % dime;
                if (current > 0)
                {
                    nickleCount = (int)(current / nickle);
                    current = current % nickle;  
                }
                
            }
            
            Console.WriteLine(quarterCount + " Quarters " + dimeCount + " Dimes " + nickleCount + " nickles " + current + " cents.");
        }
    }
}
