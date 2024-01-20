internal class Program
{
    private static void Main(string[] args)
    {
        string[] pets = new string[] {"cat", "dog", "parrot", "guinea pig"};
        foreach (string pet in pets)
        {
            Console.WriteLine(pet);
            if (pet == "dog")// 
            {
                Console.WriteLine("End program because found pet 'dog'.");
                break;
            }
        }
    }
}