try
{
    int m = 4,
        n = 4;
    int[,] arr = new int[m, n];
    int[] result = new int[m];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            arr[i, k] = rnd.Next(1, 10);
        }
    }

    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            result[i] += arr[i, k];
        }
    }

    Console.Write("Среднее арифметическое каждого столбца: ");
    foreach (int num in result)
    {
        Console.Write("{0} ", num);
    }
} catch(Exception err)
{
    Console.WriteLine(err);
}