using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMDPrototypes
{
    class Ans33846838
    {
        public Ans33846838()
        {

        }
        private static void OldThreadStuff()
        {

            for (var i = 0; i <= 200; i++)
            {
                Thread.Sleep(2);
                Thread t = new Thread((() => Test(i)));
                t.IsBackground = true;
                t.Start();

            }
        }
        private static void NewThreadStuff()
        {
            //long startSet = System.Diagnostics.Process.GetCurrentProcess().WorkingSet64;
            //List<long> endSet = new List<long>();
            //for (var i = 0; i <= 20000; i++)
            //{
            //    Action Act = new Action(() => Test(i));

            //    Task Tsk = new Task(Act);
            //    Tsk.Start();
            //    endSet.Add(System.Diagnostics.Process.GetCurrentProcess().WorkingSet64);
            //    int worker;
            //    int ioCompletion;
            //    ThreadPool.GetMaxThreads(out worker, out ioCompletion);
            //    Console.WriteLine(worker);
            //    Console.WriteLine(ioCompletion);
            //}
            //Console.WriteLine(startSet.ToString("###,###,###,###,###,###.####"));
            //Console.WriteLine(endSet.Average().ToString("###,###,###,###,###,###.####"));
        }
        public static void Test(int index)
        {
            Thread.Sleep(2);
            Console.WriteLine("Done with: " + index);
        }
        public bool Execute(String[] args)
        {
            bool retValue = false;
            NewThreadStuff();
            int worker;
            int ioCompletion;
            ThreadPool.GetMaxThreads(out worker, out ioCompletion);
            Console.WriteLine(worker);
            Console.ReadLine();

            OldThreadStuff();
            ThreadPool.GetMaxThreads(out worker, out ioCompletion);
            Console.WriteLine(worker);

            GC.Collect();
            return retValue;
        }
    }
}
