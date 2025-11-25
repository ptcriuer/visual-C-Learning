student a001;
Console.WriteLine();
Console.Write("請輸入第1位學生的資料:\n");
Console.Write($"1. 學號:");
a001.id = Console.ReadLine();
Console.Write($"2. 姓名:");
a001.name = Console.ReadLine();
Console.Write($"3. 分數:");
a001.Score = int.Parse(Console.ReadLine());

student a002;
Console.WriteLine();
Console.Write("請輸入第2位學生的資料:\n");
Console.Write($"1. 學號:");
a002.id = Console.ReadLine();
Console.Write($"2. 姓名:");
a002.name = Console.ReadLine();
Console.Write($"3.分數:");
a002.Score = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("-----------------------------------------");
Console.WriteLine();
Console.WriteLine("輸入資料如下 ....");
Console.WriteLine();
Console.WriteLine($"第 1 位學生資料   學號:{a001.id}    姓名:{a001.name}  成績:{a001.Score}");
Console.WriteLine();
Console.WriteLine($"第 2 位學生資料   學號:{a002.id}    姓名:{a002.name}  成績:{a002.Score}");

struct student
{
    public string id;
    public string name;
    public int Score;
}