using System;

namespace vectori_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[100];
            int n;
            int egale = 0;
            n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                nums[i] = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            { for (int j = i + 1; j <= n; j++)
                {
                    if (nums[i] == nums[j]) egale++;
                }

            }
            Console.WriteLine(egale);

        }
    }
}
