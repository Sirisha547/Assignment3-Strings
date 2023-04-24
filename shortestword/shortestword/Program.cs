namespace shortestword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the strings : ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            string shortest = words[0];
            for(int i =0; i<words.Length; i++)
            {
                if (words[i].Length < shortest.Length)
                {
                    shortest = words[i];
                }
            }
            Console.WriteLine($"The shortest word in the list is {shortest}");
        }
    }
}