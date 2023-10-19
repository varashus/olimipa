namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sportolok = new List<Helsinki>();
            using StreamReader sr = new StreamReader(
                path: @"..\..\..\src\helsinki.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while (!sr.EndOfStream)
            {
                sportolok.Add(new Helsinki(sr.ReadLine()));   
            }
            Console.WriteLine(sportolok.Count());
            
            int arany = 0;
            int ezust = 0;
            int bronz = 0;
            foreach (var x in sportolok)
            {
                if (x.helyezes == 1)
                {
                    arany++;    
                }
                if (x.helyezes == 2)
                {
                    ezust++;
                }
                if (x.helyezes == 3)
                {
                    bronz++;
                }
            }
            Console.WriteLine($"arany: {arany}");
            Console.WriteLine($"ezüst: {ezust}");
            Console.WriteLine($"bronz: {bronz}");
            Console.WriteLine($"összesen: {arany+ezust+bronz}");



            Console.ReadKey();
        }
    }
}