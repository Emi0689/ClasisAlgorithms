using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public partial class Delegate
    {
        public delegate string DelegadoCopado(string algo);

        public static void RunV2()
        {
            DelegadoCopado delegadoCopado = FuncionParaDelegado;
            var result = HacerAlgo(delegadoCopado);
            Console.WriteLine(result);
        }

        public static string HacerAlgo(DelegadoCopado mainDelegate)
        {
            return mainDelegate("Mostra esto en Mayuscula");
        }

        public static string FuncionParaDelegado(string stringToUpper)
        {
            return stringToUpper.ToUpper();
        }
    }
}
