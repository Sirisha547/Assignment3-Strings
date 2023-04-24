namespace wordinlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Banglore", "Chennai", "Delhi", "Mumbai", "Kolkata" };
            Console.WriteLine("Enter a word to check if it is present in the list : ");
            string str = Console.ReadLine();
            bool found = false;
            for ( int i = 0; i < words.Length; i++)
            {
                if (words[i] == str)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"The word {str} is in the list ");
            }
            else
            {
                Console.WriteLine($"The word {str} is not in the list ");
            }
        }
    }
}