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
            if (a == b & b == c & c == d){
                result = a*b*c*d;
            } else if (a >= b && b >= c && c >= d) {
                result = Math.Min(Math.Min(a,b),Math.Min(c,d));
            } else {
                Console.WriteLine("Числа расположены не по возрастанию")
            }
        }
    }
}
