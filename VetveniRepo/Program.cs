string[] predmetyPrvak = { 
    "alp",
    "hw",
    "aj",
    "čj", "d", "m", "ikt", "os", "f", "tv", "opř", "zel" };

string[] predmetyDruhak = {
    "čj",
    "aj",
    "d",
    "zsv",
    "m",
    "tv", "f", "hw", "opř", "ikt", "os", "zw", "as", "..." };

string[] predmetyTretak = {
    "čj",
    "aj",
    "zsv",
    "f",
    "m", "tv", "e", "pg", "hw", "..."};

string[] predmetyCtvrtak = {
    "čj", 
    "aj",
    "m",
    "tv",
    "vr",
    "dp",
    "..."};

Console.WriteLine("Vyber ročník 1 - 4");
string vyberUzivatele = Console.ReadLine();
string zamereni = Console.ReadLine();
switch(vyberUzivatele)
{
    case "1":
        foreach(var item in predmetyPrvak)
    {
        Console.WriteLine(item);
    }
    break;

    case "2":
        foreach(var item in predmetyDruhak)
        {
            Console.WriteLine(item);
        }
        break;
    
    case "3":
        Console.WriteLine("napiš zaměření");
        if (zamereni == "HWPOS")
        {
            Console.WriteLine("shw");
            Console.WriteLine("sps");
            Console.WriteLine("iv");
            Console.WriteLine("ass");
        }
        else
        {
            Console.WriteLine("opg");
            Console.WriteLine("mv");
            Console.WriteLine("gs");
            Console.WriteLine("wapp");
        }
        foreach (var item in predmetyTretak)
        {
            Console.WriteLine(item);
        }
        break;

    case "4":
        Console.WriteLine("napiš zaměření");
        if(zamereni == "HWPOS")
        {
            Console.WriteLine("shw");
            Console.WriteLine("sps");
            Console.WriteLine("iv");
            Console.WriteLine("asy");
        }
        else
        {
            Console.WriteLine("opg");
            Console.WriteLine("mv");
            Console.WriteLine("gs");
            Console.WriteLine("wapp");
        }
        foreach (var item in predmetyCtvrtak)
        {
            Console.WriteLine(item);
        }
        break;

    default:
        Console.WriteLine("chyba");
    break;
}
