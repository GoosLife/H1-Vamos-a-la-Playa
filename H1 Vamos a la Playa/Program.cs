int emptySpots = 0;

int[,] spots = new int[6, 9]
{
    { 1, 1, 1, 1, 0, 1, 1, 1, 1 },
    { 1, 1, 0, 0, 0, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 1, 1, 0, 0, 1 },
    { 1, 0, 0, 1, 1, 1, 1, 1, 1 },
    { 1, 1, 1, 1, 0, 1, 1, 1, 1 },
    { 1, 1, 0, 0, 0, 1, 0, 0, 0 }
};

for (int i = 0; i < 6; i++)
{
    for (int j = 1; j < 7; j++)
    {
        if (spots[i, j - 1] == 0 && spots[i, j + 1] == 0)
        {
            emptySpots++;
            spots[i, j] = 1;
        }
    }
}

Console.WriteLine(emptySpots);
Console.ReadKey();