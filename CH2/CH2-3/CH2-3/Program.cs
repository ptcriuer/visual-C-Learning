Console.WriteLine();
Console.WriteLine($"1. 二進制的進位值:{(int)state.Binary}");
Console.WriteLine();
Console.WriteLine($"2. 八進制的進位值:{(int)state.Octal}");
Console.WriteLine();
Console.WriteLine($"3. 十六進制的進位值:{(int)state.Hex}");
enum state:int
{
    Binary = 2,
    Octal = 8,
    Hex = 16,
};
