using System;

namespace task2_02_03_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.Arraydaki ədədlərin ədədi ortasını hesablayan alqoritm qurun.

            int[] arr = { 12, 25, 88, 71, 90 };
            int cem = 0;
            int say = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                cem += arr[i];
                say++;
            }
            Console.WriteLine(cem / say);
        }
    }
}
