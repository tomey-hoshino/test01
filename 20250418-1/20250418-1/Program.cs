// See https://aka.ms/new-console-template for more information
Func<string, string> selector = UpperCase;

string[] words = { "orange", "apple", "grape", "pineapple" };

foreach(string word in words) Console.WriteLine(selector(word));

static string UpperCase(string word)
{
    return word.ToUpper();
}

Action<string> select = Disp;
select("Hello World");

static void Disp(string s)
{
    Console.WriteLine(s);
}

Action<string>del=s=>Disp2(s);
del("Hello World");

static void Disp2(string s)
{
    Console.WriteLine(s);
}

Action<string> del3 = s =>
{
    Console.WriteLine(s);
};
del3("Hello World");