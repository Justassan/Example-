Console.WriteLine("Введите имя!");
string username = Console.ReadLine();

if(username.ToLower() == "king")
{
Console.WriteLine("ДАРОВА, King");
}
else 
{
    Console.Write("q, ");
    Console.WriteLine(username);
}
