Console.WriteLine("\n1.聯合 信用卡");
Console.WriteLine("\n2.JCB 信用卡");
Console.WriteLine("\n3.VISA 信用卡");
Console.WriteLine("\n4.MASTER 信用卡");
int input;
Console.Write("\n請輸入欲使用的信用卡種類:");
input = int.Parse(Console.ReadLine());

switch (input)
{
    case 03:
        Console.WriteLine("\n您是持 聯合 信用卡付費");
        break;
    case 35:
        Console.WriteLine("\n您是持 JCB 信用卡付費");
        break;
    case 45:
        Console.WriteLine("\n您是持 VISA 信用卡付費");
        break;
    case 54:
        Console.WriteLine("\n您是持 MASTER 信用卡付費");
        break;
}