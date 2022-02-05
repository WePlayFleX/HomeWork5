using System;
using cs = System.Console;
using cv = System.Convert;

namespace HomeWork5
{
    class HomeWork5
    {
        public static void Main(string[] args)
        {
            int i, j;
            cs.WriteLine("Enter the number of elements in the array: ");
            string s = cs.ReadLine();
            int num = cv.ToInt32(s);
            int[] a = new int[num + 1];

            cs.WriteLine("Choose the option to enter data into the array: \n0 - Random\n1 - Keyboard input");
            s = cs.ReadLine();
            int k = cv.ToInt32(s);

            if (k == 0)
            {
                Random rand = new Random(); 
                for (i = 0; i < num; i++)
                {
                    a[i] = rand.Next(-10, 10);
                }
            }
            else
            {
                cs.Write("Enter an array: ");
                for (i = 0; i < num; i++)
                {
                    s = cs.ReadLine();
                    a[i] = cv.ToInt32(s);
                }
            }
           
            
            cs.WriteLine("\nOutputting the original array: ");
            for (i = 0; i < num; i++)
            {
                cs.Write("{0} ", a[i]);
            }
            cs.WriteLine("\n");

            int Summ = 0;
            cs.WriteLine("Outputting positive array elements: ");
   
            for (i = 0; i < num; i++)
            {
                if (a[i] >= 0)
                {
                    cs.Write("{0} ", a[i]);
                    Summ += a[i];
                }
            }
            cs.WriteLine("\n\nSum of positive array elements: " + Summ + "\n");
           
            int max = 0;
            int min = 9999;
            int iMax = 0;
            int iMin = 0;

            for (i = 0; i < num; i++)
            {
                if (Math.Abs(a[i]) > max)
                {
                    max = Math.Abs(a[i]);
                    iMax = i;
                }

                if (Math.Abs(a[i]) < min)
                {
                    min = Math.Abs(a[i]);
                    iMin = i;
                }
            }

            double Prod = 0;
            if ((iMin + 1 == iMax) || (iMax + 1 == iMin))
            {
                Prod = 1;
            }
            else
            {
                Prod = 1;
                if (iMin < iMax)
                { 
                    for (i = iMin + 1; i < iMax; i++)
                    {
                        Prod *= a[i];
                    }
                }
                else
                {   
                    for (i = iMax + 1; i < iMin; i++)
                    {
                        Prod *= a[i];
                    }
                }
            }
            cs.WriteLine("Minimum element modulo: " + min);
            cs.WriteLine("Maximum element modulo: " + max);
            cs.WriteLine("Minimum element index: " + iMin);
            cs.WriteLine("Maximum element index: " + iMax);
            cs.WriteLine("Product of array elements located between the maximum modulo and minimum modulo elements: " + Prod);
           
            int x;
            
            cs.WriteLine("\nSorted array output: ");
            for (i = 0; i <= num; i++)
            {
                for (j = 0; j <= num - 1; j++)
                {
                    if (a[j + 1] > a[j]) 
                    {
                        x = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = x;
                    }
                }
            }

            for (i = 0; i <= num; i++)
            {
                cs.WriteLine("Array[" + i + "] = " + a[i]);
            }

            cs.ReadKey();
        }
    }
}