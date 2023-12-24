using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generation
{
    internal class Random_Number_Generation
    {
        private long seed { get; set; }
        private long multiplier { get; set; }
        private long increment { get; set; }
        private long modulus { get; set; }
        private int number_of_Iterations { get; set; }
 
        public Random_Number_Generation(long multiplier, long increment, long modulus, long seed , int number_of_Iterations)
        {
            this.multiplier = multiplier;
            this.increment = increment;
            this.modulus = modulus;
            this.seed = seed;
            this.number_of_Iterations = number_of_Iterations;
        }

        public long[] GeneratedRandomNumbers()
        {

            long[] randomNumbers = new long[number_of_Iterations];
            long current = seed;

            for (int i = 0; i < number_of_Iterations ; i++)
            {
                current = (multiplier * current + increment) % modulus;
                randomNumbers[i] = current ;

            }

            return randomNumbers;
        }
        // Floyd's cycle-finding algorithm
        public long CalculateCycleLength()
        {
            long current = seed;
            long cycleLength = 0;
            long initialSeed = seed;
            bool isPowerof2 = isPowerOf2();
            long k = modulus - 1; 
            if (isPowerof2 && increment != 0 && multiplier == 4*k + 1 
                && RelativelyPrime(increment , modulus))
            {
                cycleLength = modulus;
            
            }
            else if (isPowerof2 && increment == 0 && seed %2 !=0  
                && (multiplier == 8* k + 5  || multiplier == 8 * k + 3))
            {
                cycleLength = modulus / 4;
                
            }
            else if (chkprime(modulus) && increment == 0 && isDivisable(k) )
            {
                cycleLength = modulus - 1;
         
            }
            else
            {
                do
                {
                    current = (multiplier * current + increment) % modulus;
                    cycleLength++;
                } while (current != initialSeed);
            }

            return cycleLength;
        }

        private bool isPowerOf2()
        {
            double log  = Math.Log(modulus,2);

            return log == Math.Floor(log) && modulus > 0 ;
        }
        private bool chkprime(long num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        private bool isDivisable(long k)
        {
 
            return (Math.Pow((double)multiplier, (double)k)-1) % modulus == 0;
        }
        private bool RelativelyPrime(long number1, long number2)
        {
            while (number2 != 0)
            {
                long temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }
            return number1 == 1;
        }
    }
}
