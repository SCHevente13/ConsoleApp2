namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pigs> list = FileManager.ReadFile("disznok.csv");
        }
    }
}
