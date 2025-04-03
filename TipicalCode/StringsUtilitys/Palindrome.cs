namespace StringsUtilitys
{
    public class Palindrome
    {
        static private bool PalindromeV1(string text)
        {
            for (int i = 0; i < (text.Length / 2); i++)
            {
                if (text[i] != text[text.Length - i])
                    return false;
            }
            return true;
        }

        static private string Duplicados(string texto)
        {
            string duplicados = string.Empty;
            for (int i = 0; i < texto.Length; i++)
            {
                for (int j = 0; j < texto.Length; j++)
                {
                    if (texto[i] == texto[j] && i != j)
                    {
                        if (!duplicados.Contains(texto[i]))
                            duplicados.Concat(texto[i].ToString() + ", ");
                        break;
                    }
                }
            }
            duplicados = duplicados.Substring(0, duplicados.Length - 3);
            return duplicados;
        }
    }
}
