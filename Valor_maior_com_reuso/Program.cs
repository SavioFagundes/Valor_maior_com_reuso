namespace Valor_maior_com_reuso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printservice = new PrintService<string>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printservice.AddValue(x);
            }
            int a = (int)printservice.First();
            int b = a + 2;  

            printservice.Print();
            Console.WriteLine();
            Console.WriteLine("Firt: " + printservice.First());
        }
    }
}