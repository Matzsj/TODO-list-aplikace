namespace TODO
{
    internal class Program
    {
        private static List<string> ukoly = new List<string>();

        private static bool ukoncit = false;
        private static string ukol = null;
        private static void Main(string[] args)
        {
            Console.WriteLine("Vitej v TODO aplikaci");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("");
            while (ukoncit == false)
            {

                Console.Write("Co je vas ukol: ");
                string ukol = Console.ReadLine();
                if (ukol != "show" && ukol != "end" && ukol != "clear" && ukol != "help" && !ukol.StartsWith("delete "))
                {
                    ukoly.Add(ukol);
                }


                if (ukol == "show")
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Vase ukoly jsou: ");
                    foreach (string task in ukoly)
                    {
                        Console.WriteLine("- " + task);
                    }
                    Console.WriteLine("---------------------");
                    Console.WriteLine("");
                }
                
                if (ukol == "end")
                {
                    ukoncit = true;
                }


                if (ukol == "clear")
                {
                    ukoly.Clear();
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Vsechny ukoly byly smazany.");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("");
                }

                if (ukol == "help")
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("show - ukaze vsechny ukoly v listu");
                    Console.WriteLine("end - ukonci aplikaci");
                    Console.WriteLine("clear - vymaze vsechny ukoly v listu");
                    Console.WriteLine("---------------------");
                    Console.WriteLine("");
                }

                if (ukol != null && ukol.StartsWith("delete "))
                {
                    string smazani = ukol.Substring(7);

                    if (ukoly.Remove(smazani))
                    {
                        Console.WriteLine("---------------------");
                        Console.WriteLine($"Ukol '{smazani}' byl smazan.");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("");


                    }
                }
            }

        }
    }
}
