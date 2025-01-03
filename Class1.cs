using System;
using System.Collections.Generic;

namespace Prime_Factors_class 
{
    public class PrimeFactors 
    {
      
        public static List<int> PrimeFactorCalculator(int number)
        {
            List<int> listOfNums = new List<int>();

            
            
           
                    for (; number % 2 == 0; number /= 2)
                    {
                       listOfNums.Add(2);
                    }

                
                    for (int i = 3; i <= Math.Sqrt(number); i+= 2)
                    {
                        while (number % i == 0)
                        {
                            listOfNums.Add(i);

                            //so it will go to the next prime num
                            number /= i;

                        }
                    }
                
                if (number > 2)
                {
                    listOfNums.Add(number);
                }
              
            return listOfNums;
        }
    }
}