using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class Tasks
    {
        public void executeTask()
        {
            Task.Run(async () => //esto en realidad solo es porque en main no se puede devolver el 
            {
                Task<bool> Tbool = TaskMethod();
                Console.WriteLine("Hago instrucciones mientras procesa \n\r");
                Console.WriteLine("Sigo haciendo otras cosas \n\r");
                bool boolResult = await Tbool; //aca espera que termine el asincrono

            }).GetAwaiter().GetResult();
        }

        public async Task<bool> TaskMethod()
        {
            HttpClient cliente = new HttpClient();
            var _ = await cliente.GetAsync("https://www.google.com"); //si no le pon
           
            return true;
        }
    }
}
