using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Threads
{
    class ThreadPooling
    {
        const string path = @"text";
        public void executeThreadPool()
        {
            for (int i = 0; i < 50; i++)
            {
                ThreadPool.QueueUserWorkItem(show, i); //crea los hilos necesarios segun el visual o el S.O. para finalizar la terea. Y no tengas que gestionar la cantidad vos.
                                                        // y reutiliza los creados si se desocuparon para no crear nuevos.
            }
            while (ThreadPool.PendingWorkItemCount > 0) ; //esto es para que no finalice si algun hilo queda pendiente de ejecución.
        }

        public void show(object data)
        {
            int i = (int)data;
            using (var sw = new StreamWriter(path + i + ".txt"))
            {
                Console.WriteLine("Hola soy el hilo" + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
