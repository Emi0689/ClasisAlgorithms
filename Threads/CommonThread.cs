using System;
using System.Threading;

namespace Threads
{
    public class CommonThread
    {
        public void threadTest1()
        { 
            //Lo que sea 1
        }

        public void threadTest2()
        {
            //Lo que sea 2
        }

        public void threadPosta()
        {
            Thread ejecutar1 = new Thread(new ThreadStart(threadTest1));
            Thread ejecutar2 = new Thread(new ThreadStart(threadTest2));

            ejecutar1.Start();
            ejecutar2.Start();
        }
    }
}
