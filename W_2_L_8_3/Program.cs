using System.Diagnostics.CodeAnalysis;

namespace W_2_L_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a= 1;

            int b= 0;


            Console.WriteLine("Ciąg Fibonachiego");

            for (int i = 0; i < 20; i++) 
            { 
                Console.WriteLine(b);
                b += a;
                a = b - a;
            }

        }
    }
}
