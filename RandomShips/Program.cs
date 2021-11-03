namespace RandomShips
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Select  min tier ship: ");
            string Tier;
            int minTier;
            bool a;
            InputMinTier(out Tier, out minTier, out a);

            Console.WriteLine("Select  max tier ship: ");

            int maxTier = InputMaxTier(ref Tier, minTier, ref a);


            var random = new Random();
            var randomShips = random.Next(minTier, maxTier);

            GetWriteNations();

            var nations = "";
            nations = Console.ReadLine();

            nations = Getnations(nations);

            GetWriteType();

            var ship = "";
            ship = Console.ReadLine();
            ship = GetType(ship, nations);

            Console.WriteLine($"Play with {randomShips} tier {nations} {ship}.");

        }

        private static void GetWriteType()
        {
            Console.WriteLine("select type of ships.");
            Console.WriteLine("1 -> Destroyer");
            Console.WriteLine("2 -> Cruiser");
            Console.WriteLine("3 -> Batle ship");
            Console.WriteLine("4 -> Cw");
            Console.WriteLine("5 -> Random");
        }

        private static void GetWriteNations()
        {
            Console.WriteLine("select nation.");
            Console.WriteLine("1 -> Russia");
            Console.WriteLine("2 -> Usa");
            Console.WriteLine("3 -> Japan");
            Console.WriteLine("4 -> China");
            Console.WriteLine("5 -> Eu");
            Console.WriteLine("6 -> German");
            Console.WriteLine("7 -> Random");
        }

        private static string GetType(string ship, string nations)
        {
            if (ship == "5")
            {
                var randomType = new Random();
                var type = randomType.Next(1, 4);
                if (nations == "China")
                {
                    ship = "Destroyer";
                }
                else
                {
                    if (type == 1)
                    {
                        ship = "Destroyer";
                    }
                    else if (type == 2)
                    {
                        ship = "Cruiser";
                    }
                    else if (type == 3)
                    {
                        ship = "Batle Ship";
                    }
                    else if (type == 4)
                    {
                        ship = "CW";
                    }

                }
            }
            else
            {
                if (nations == "China")
                {
                    ship = "Destroyer";
                }
                else
                {
                    if (ship == "1")
                    {
                        ship = "Destroyer";
                    }
                    if (ship == "2")
                    {
                        ship = "Cruiser";
                    }
                    if (ship == "3")
                    {
                        ship = "Batle ship";
                    }
                    if (ship == "4")
                    {
                        ship = "Cw";
                    }

                }
            }

            return ship;
        }

        private static string Getnations(string nations)
        {
            if (nations == "7")
            {

                var randomNation = new Random();
                var n = randomNation.Next(1, 6);
                if (n == 1)
                {
                    nations = "Russia";
                }
                else if (n == 2)
                {
                    nations = "Usa";
                }
                else if (n == 3)
                {
                    nations = "Japan";
                }
                else if (n == 4)
                {
                    nations = "China";
                }
                else if (n == 5)
                {
                    nations = "Eu";
                }
                else if (n == 6)
                {
                    nations = "German";
                }
            }
            else
            {
                if (nations == "1")
                {
                    nations = "Russia";
                }
                if (nations == "2")
                {
                    nations = "Usa";
                }
                if (nations == "3")
                {
                    nations = "Japan";
                }
                if (nations == "4")
                {
                    nations = "China";
                }
                if (nations == "5")
                {
                    nations = "Eu";
                }
                if (nations == "6")
                {
                    nations = "German";
                }
            }

            return nations;
        }

        private static int InputMaxTier(ref string Tier, int minTier, ref bool a)
        {
            var Tier1 = Console.ReadLine();
            int maxTier;
            if (Tier1 == "")
            {
                maxTier = 10;

            }
            else
            {
                bool b = int.TryParse(Tier1, out maxTier);

                while (maxTier <= minTier || maxTier > 10 || b == false)
                {

                    Console.WriteLine("Select number of 1-10!");
                    Console.WriteLine("Select маx tier: ");
                    Tier = Console.ReadLine();
                    a = int.TryParse(Tier, out maxTier);
                }

            }

            return maxTier;
        }

        private static void InputMinTier(out string Tier, out int minTier, out bool a)
        {
            Tier = Console.ReadLine();
            a = int.TryParse(Tier, out minTier);

            while (minTier <= 0 || minTier > 10 || a == false)
            {

                Console.WriteLine("Select number of 1-10!");
                Console.WriteLine("Select  min tier: ");
                Tier = Console.ReadLine();
                a = int.TryParse(Tier, out minTier);
            }
        }
    }
}

  