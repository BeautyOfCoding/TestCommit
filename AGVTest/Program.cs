using System;
using System.Threading.Tasks;

namespace AGVTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task.Run(() => 
            {
                Console.WriteLine("this is the first thread");
            });

        }
    }
}
