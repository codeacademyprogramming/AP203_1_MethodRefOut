using System;

namespace _2._09032021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;

            string name = "Hikmet";

            ChangeName(ref name);

            Console.WriteLine(name);

            int[] nums = { 1, 2, 3 };

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========");
            SetZero(nums);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            int num;

            Add(out num);

            Console.WriteLine(num);


            int num2 = 40;
            MakeOdd(ref num2);

            Console.WriteLine($"num2: {num2}");
        }

        static void SetZero(int[] nums)
        {
            nums[0] = 0;    
        }

        static void ChangeName(ref string name)
        {
            name+="a";
        }

        static void Add(out int n)
        {
            n = 10;
        }
        
        static void MakeOdd(ref int n)
        {
            if (n % 2 == 0)
                n++;
        }
    }
}
