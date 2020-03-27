using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem2;
            int a, b, c, d;
            int result;
            String[] nums = Console.ReadLine().Split();
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
            c = int.Parse(nums[2]);
            d = int.Parse(nums[3]);
            if (a == b & b == c & c == d){
                result = a*b*c*d;
            } else if (a >= b && b >= c && c >= d) {
                result = Math.Min(Math.Min(a,b),Math.Min(c,d));
            } else {
                Console.WriteLine("Числа расположены не по возрастанию");
            }
        }
    }
}
