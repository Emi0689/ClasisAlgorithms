using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class ParallelAndFiles
    {
        public void parallelMethod()
        {
            string filename = "result.txt";
            var fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            Parallel.For(1, 100, new ParallelOptions { MaxDegreeOfParallelism = 10 }, //MaxDegreeOfParallelism marca cuantos hilos queres dentro de ese for, el resto es un for normal
            (i) =>
            {
                WriteFile(filename, i, fs); //escribo 100 veces asincronicamente el archivo
            });
        }
        public void WriteFile(string filename, int i, FileStream fs)
        {
            lock (fs) //bloquea el recurso para que escriban hilos de a uno
            { 
                byte[] bContent = new UTF8Encoding(true).GetBytes(i.ToString() + Environment.NewLine); //Environment.NewLine le hace un salto de linewa
                fs.Write(bContent, 0, bContent.Length);
                fs.Flush();
            }
        }

        /*
         * si usamos:
         *  using (var fs = new FileStream(filename, FileMode.Append, FileAccess.Write))
            {
            }
         *  Va a explotar porque el using reserva para una pequeña cantidad de hilos
         */

    }
}
