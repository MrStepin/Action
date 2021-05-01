using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    class Program 
    {
        static void Main(string[] args)
        {
            string message = "test";
            Action<string> print;
            print = Print;
            print(message);

            Func<int, int, int> sum;
            sum = Sum;

            Func<int[], double> max;
            max = Max;

            Action<byte[]> send;
            send = SendData;

            Some some;
            some = SomeFunc;

        }
        delegate void Some();

        private static void Print(string message)
        {

        }

        private static int Sum(int a, int b)
        {
            return a;
        }

        private static double Max(int[] array)
        {
            return 5.0;
        }

        private static void SendData(byte[] data)
        {

        }

        private static void SomeFunc()
        {

        }
    }
}
