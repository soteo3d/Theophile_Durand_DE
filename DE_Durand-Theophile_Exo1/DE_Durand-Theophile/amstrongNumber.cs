using System;

namespace DE_Durand_Theophile
{
    partial class Program
    {
        public class amstrongNumber
        {

            static void Main(string[] args)
            {


                Console.WriteLine("Amstrong number between 100 and 999 ");

                for (int i = 100; i < 999; i++)
                {
                    int n, r, sum = 0, temp;
                    n = i;
                    temp = i;
                    while (n > 0)
                    {
                        r = n % 10;
                        sum = sum + (r * r * r);
                        n = n / 10;
                    }
                    if (temp == sum)
                        Console.WriteLine(i);
                    else
                    {
                        Console.Write("");
                    }

                }
            }
        
          

        }
    }
}
