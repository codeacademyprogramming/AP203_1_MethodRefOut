using System;

namespace _090302022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = Sum(45, 10, 7);
            Console.WriteLine(res);

            int wantedChar = FindCharIndex("programming", 'l');

            Console.WriteLine(wantedChar);

            Console.WriteLine(Sqrt(35));
        }

        static int Sum(int num1,int num2,int num3=0)
        {
            int result = num1 + num2 + num3;
            return result;
        }

        static int FindCharIndex(string str,char chr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                    return i;
            }
            return -1;
        }

        static int Sqrt(int num)
        {
            int index = 0;

            while (index*index<=num)
            {
                index++;
            }

            return index - 1;
        }



    }
}
