using H1_Vamos_a_la_Playa;

// Demonstration using both a pre-defined and a randomly generated beach.

int[,] spots = new int[6, 9]
{
    { 1, 1, 1, 1, 0, 1, 1, 1, 1 },
    { 1, 1, 0, 0, 0, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1, 1, 0, 0, 1 },
    { 1, 0, 0, 1, 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 0, 1, 1, 1, 1 },
    { 1, 1, 0, 0, 0, 1, 0, 0, 0 }
};

BeachManager bm = new BeachManager(new Beach(spots)); // Create a new beach manager, managing the beach from the example that I've manually input into spots.

BeachManager randomlyGeneratedBeachManager = new BeachManager();

Console.WriteLine(bm.AvailableChairs());
Console.WriteLine("Randomly generated beach before reservations: ");
Console.WriteLine(randomlyGeneratedBeachManager.Beach.ToString());
Console.WriteLine("Number of available chairs: ");
Console.WriteLine(randomlyGeneratedBeachManager.AvailableChairs());
Console.WriteLine("Randomly generated beach after reservations: ");
Console.WriteLine(randomlyGeneratedBeachManager.Beach.ToString());
Console.ReadKey();