Console.WriteLine("1-300的質數如下:");

for (int i = 2; i < 300; i++)
{
    bool isPrime = true;
    for (global::System.Int32 j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write(i + " ");
    }
}