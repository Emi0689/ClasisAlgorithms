namespace StringsUtilitys
{
    public static class Prefix
    {

        public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length)
        {
            var wordsFinds = (from word in words
                              where (word.Length > 2)
                              select word.Substring(0, length).Distinct());
            return (IEnumerable<string>)wordsFinds;
        }



        static public void printString(int[] elementos)
        {
            Console.WriteLine("La lista de Elementos ordenada es: \n\r");
            for (int i = 0; i < elementos.Length - 1; i++)
            {
                Console.Write(elementos[i] + ", ");
            }
            Console.Write(elementos[^1]);
        }
    }
}
