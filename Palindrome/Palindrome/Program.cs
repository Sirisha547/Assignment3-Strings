namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Banglore", "Delhi", "MADAM", "Mumbai" };
            int pc = 0;
            string pwords = "";
            for (int i = 0; i < words.Length; i++)
            {
                string rwords = "";
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    rwords += words[i][j];
                }
                if (words[i] == rwords)
                {
                    pc++;
                    pwords += words[i];
                }
            }
            if (pc > 0)
            {
                Console.WriteLine("the number palindromes in the list " + pc);
                Console.WriteLine(pwords);
            }
            else
            {
                Console.WriteLine("there are no palindromes in the list");
            }
        }
    }
}
