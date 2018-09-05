using System;
using System.Diagnostics;
using System.Threading;

namespace Shikiro.LearnThrift.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWorldTest.Run(1);
            UserTest.Run(1);
            for (int i = 0; i < 10; i++)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                //HelloWorldTest.Run(100);
                UserTest.Run(100);

                Console.WriteLine(stopwatch.ElapsedMilliseconds);
            }

            var mres = new ManualResetEventSlim();
            mres.Wait();
        }
    }
}
