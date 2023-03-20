string[] predmetyPrvak = { 
    "alp",
    "hw",
    "aj",
    "čj", "d", "m", "ikt", "os", "f", "tv", "opř", "zel" };

Console.WriteLine("Vyber ročník 1 - 4");
string vyberUzivatele = Console.ReadLine();

switch(vyberUzivatele)
{
    case "1":
        foreach(var item in predmetyPrvak)
    {
        Console.WriteLine(item);
     }
    break;
    default: 
        Console.WriteLine("Coming soon");
    break;
}
