using System;

namespace waltonstine.demo.csharpthreadsync
{
    class Program
    {
        static void LaunchAndCheck(bool wait)
        {
            ThreadWrapper tw = new ThreadWrapper();
            tw.StartThread();

            if (wait)
            {
                tw.WaitForReady();
            }

            if (!tw.InitIsDone)
            {
                Console.WriteLine("{0} wait, main thread accessed worker thread before it was ready.", 
                    (wait) ? "WITH" : "withOUT");
            }
            else
            {
                Console.WriteLine("{0} wait, no problem with accessing thread before appropriate.",
                    (wait) ? "WITH" : "withOUT");
            }

            tw.JoinThread();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Demo of use of ManualResetEvent to synchronize with threads");

            LaunchAndCheck(false);

            LaunchAndCheck(true);

            Console.WriteLine("Done.");
        }
    }
}
