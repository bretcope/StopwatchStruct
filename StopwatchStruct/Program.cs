using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new StopwatchStruct();
            sw.Start();
            var rand = new Random();
            var x = rand.NextDouble();
            for (var i = 0; i < 10000000; i++)
            {
                x = rand.NextDouble();
            }

            Console.WriteLine(x);
            sw.Stop();
            Console.WriteLine(sw.GetElapsedMilliseconds());
        }
    }
}
