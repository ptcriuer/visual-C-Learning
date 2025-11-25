int first;
int second;
string op;
int output = 0;
Console.Write("\n1.請輸入第一個運算元:");
first = int.Parse(Console.ReadLine());
Console.Write("\n2.請輸入第二個運算元:");
second = int.Parse(Console.ReadLine());
Console.Write("\n2.請輸入運算子:加(+) 減(-) 乘(*) 除(/):");
op = Console.ReadLine();

if(op == "*")
{
    output = first * second;
}
else if (op == "+")
{
    output = first + second;
}
else if(op == "-")
{
    output = first - second;
}
else if(op == "/")
{
    output = first / second;
}
else
{
    Console.WriteLine("您可能輸入有誤!");
}
Console.WriteLine($"運算結果: {first} {op} {second} = {output}");
