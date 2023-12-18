namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Garage garage = new Garage();
            int id;
            string brand, model, valg;
            bool createLoop = true;
            string menu = """
                ------------------------------
                O. Opret biler
                D. Fjern en bil
                U. Udskriv alle dine biler
                F. Find bil med ID
                X. Afslut
                ------------------------------
                """;
            do
            {
                Console.WriteLine(menu);
                var key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.O:
                        do
                        {
                            Console.Clear();
                            if (cars.Count() == 0)
                            {
                                id = 1;
                            }
                            else
                            {
                                id = cars.Count() + 1;
                            }
                            Console.Write("Indtast et bil mærke: ");
                            brand = Console.ReadLine();
                            Console.Write($"Indtast {brand}'s model: ");
                            model = Console.ReadLine();
                            Console.Clear();
                            cars.Add(garage.TilføjBil(brand, model, id));
                            Console.Write("Vil du tilføje endnu en bil? (ja/nej): ");
                            valg = Console.ReadLine();
                            if (valg.ToLower() == "nej" || valg.ToLower() == "n")
                            {
                                createLoop = false;
                            }
                        } while (createLoop == true);
                        break;
                    case ConsoleKey.D:
                        Console.Write("Indtast et bil ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(garage.SletBil(id, cars));
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine("Biler du ejer:");
                        Console.WriteLine(garage.UdlæsBil(cars));
                        break;
                    case ConsoleKey.F:
                        Console.Write("Indtast et bil ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine(garage.FindBil(id, cars));
                        break;
                    case ConsoleKey.X:
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nTryk på en hvilken som helst tast for at fortsætte");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
