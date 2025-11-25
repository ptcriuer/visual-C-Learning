string yes ="";
int num;
string symbol="";
string str = "";
do
{
    Console.WriteLine("請輸入欲顯示的符號:");
    symbol = Console.ReadLine();
    Console.WriteLine("請輸入重複地次數:");
    num = int.Parse(Console.ReadLine());
    for (global::System.Int32 i = 1; i <= num; i++)
    {
        str += symbol;
    }
    Console.WriteLine(str);
    str = "";
    Console.WriteLine("是否繼續(按 y or Y 繼續):");
    yes = Console.ReadLine();
    
}
while (yes == "y" || yes =="Y");
