namespace KujunditePindalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kujundi tüüp (ring, ristkülik või kolmnurk):");
            string kujundiTyyp = Console.ReadLine();
            double pindala = 0;

            switch (kujundiTyyp)
            {
                case "ring":
                    Console.WriteLine("Sisesta ringi raadius:");
                    double raadius = double.Parse(Console.ReadLine());
                    pindala = Math.PI * Math.Pow(raadius, 2);
                    Console.WriteLine("Ringi pindala on " + pindala);
                    break;
                case "ristkülik":
                    Console.WriteLine("Sisesta ristküliku laius:");
                    double laius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta ristküliku kõrgus:");
                    double korgus = double.Parse(Console.ReadLine());
                    pindala = laius * korgus;
                    Console.WriteLine("Ristküliku pindala on " + pindala);
                    break;
                case "kolmnurk":
                    Console.WriteLine("Sisesta kolmnurga alus:");
                    double alus = double.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta kolmnurga kõrgus:");
                    double korgus2 = double.Parse(Console.ReadLine());
                    pindala = 0.5 * alus * korgus2;
                    Console.WriteLine("Kolmnurga pindala on " + pindala);
                    break;
                default:
                    Console.WriteLine("Vale kujundi tüüp!");
                    break;
            }
        }
    }
}