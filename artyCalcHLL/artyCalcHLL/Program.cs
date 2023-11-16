using System;

namespace ArtyCalcHLL
{

    class Program
    {

        static Boolean inRange(double aLat, double aLong, double bLat, double bLong) {

            return true;
        }

        static void Main(string[] args)
        {
            string mapName = "";
            while ((mapName != "carentan") && (mapName != "purple heart lane"))
            {
                Console.WriteLine("What is the name of the map?");
                mapName = Console.ReadLine().ToLower();
                Console.WriteLine();
            }

            string onGermanSide = "";
            while ((onGermanSide != "yes") && (onGermanSide != "no"))
            {
                Console.WriteLine("Are you on the German side? (type 'Yes' or 'No')");
                onGermanSide = Console.ReadLine().ToLower();
                Console.WriteLine();
            }

            //For Carentan Map
            if (mapName == "carentan")
            {
                if (onGermanSide == "no") //On an Allied Faction
                {
                    double startLat = 0;
                    double startLong = 0;

                    Console.WriteLine("Your artillery's coordinates are:\n");
                    Console.WriteLine("Latitude = " + startLat);
                    Console.WriteLine("Longitude = " + startLong + "\n\n");

                    double targetLat;
                    double targetLong;

                    while (true)
                    {
                        Console.WriteLine("Enter the target's latitudinal coordinate:");
                        targetLat = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the target's longitudinal coordinate:");
                        targetLong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                    }

                }


                else //On Germany
                {
                    double startLat = 0;
                    double startLong = 0;

                    Console.WriteLine("Your artillery's coordinates are:\n");
                    Console.WriteLine("Latitude = " + startLat);
                    Console.WriteLine("Longitude = " + startLong + "\n\n");

                    double targetLat;
                    double targetLong;

                    while (true)
                    {
                        Console.WriteLine("Enter the target's latitudinal coordinate:");
                        targetLat = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the target's longitudinal coordinate:");
                        targetLong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                    }

                }
            }

            //For Purple Heart Lane
            if (mapName == "purple heart lane")
            {
                if (onGermanSide == "no") //On an Allied Faction
                {
                    double startLat = 0;
                    double startLong = 0;

                    Console.WriteLine("Your artillery's coordinates are:\n");
                    Console.WriteLine("Latitude = " + startLat);
                    Console.WriteLine("Longitude = " + startLong + "\n\n");

                    double targetLat;
                    double targetLong;

                    while (true)
                    {
                        Console.WriteLine("Enter the target's latitudinal coordinate:");
                        targetLat = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the target's longitudinal coordinate:");
                        targetLong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                    }

                }


                else //On Germany
                {
                    double startLat = 0;
                    double startLong = 0;

                    Console.WriteLine("Your artillery's coordinates are:\n");
                    Console.WriteLine("Latitude = " + startLat);
                    Console.WriteLine("Longitude = " + startLong + "\n\n");

                    double targetLat;
                    double targetLong;

                    while (true)
                    {
                        Console.WriteLine("Enter the target's latitudinal coordinate:");
                        targetLat = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the target's longitudinal coordinate:");
                        targetLong = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                    }

                }

            }

        }

    }

}