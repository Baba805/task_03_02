using System;

namespace task1_02_03_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            int[] arr = { 13, 24, 41, 65, 78 };
            int cem = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    cem += arr[i];
                }

            }
            Console.WriteLine(cem);

        }
    }
}
