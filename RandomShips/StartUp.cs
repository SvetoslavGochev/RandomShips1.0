namespace RandomShips
{
    using System;
    using static ShipsExtensionss;

    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select min tier ship: ");

            InputMinTier( out string Tier, out int minTier, out bool parseShip);

            Console.WriteLine("Select max tier ship: ");

            int maxTier = InputMaxTier(ref Tier, minTier, ref parseShip);

            var random = new Random();
            var randomShips = random.Next(minTier, maxTier);

            GetWriteNations();

            var nations = Console.ReadLine();
            nations = GetNations(nations);

            GetWriteType();

            var ship = Console.ReadLine();
            ship = GetTypeShip(ship, nations);

            Console.WriteLine($"Play with {randomShips} tier {nations} {ship}.");
        }


    }
}

