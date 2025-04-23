// See https://aka.ms/new-console-template for more information
string[] words = { "The first line of a message", "The second line of a message", };

Func<string, string> upper = s => Upper(s);
Func<string, string> lower = s => Lower(s);

foreach(string word in words)
{
    Console.WriteLine(upper(word));
    Console.WriteLine(lower(word));
}   

static string Upper(string s)
{
    return "Uppercase："+s.ToUpper();
}
static string Lower(string s)
{
    return "Lowercase：" + s.ToLower();
}

Func<string, string> up = s => { return "Uppercase：" + s.ToUpper(); };  
Func<string, string> low = s => { return "Lowercase：" + s.ToLower(); };

foreach (string word in words)
{
    Console.WriteLine(up(word));
    Console.WriteLine(low(word));
}