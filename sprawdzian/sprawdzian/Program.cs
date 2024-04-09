class sprawdzian
{
    static void Main(String[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Szukanie napisów: ");
        Tab();

    }
    static void Tab()
    {
        string[] tab = {"napis", "hello" };
        Console.Write("Jakiego słowa szukasz?: ");
        string sz = Console.ReadLine();
        bool tak = false;
        for (int i = 0; i < tab.Length; i++)
        {
            if (sz == tab[i])
            {
                Console.Write(tab[i] + " jest w tablicy");
                tak = true;
            }
        }
    }
}
