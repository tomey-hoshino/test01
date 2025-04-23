// See https://aka.ms/new-console-template for more information
string name="";

int age = 0;

GetData(ref name, ref age); 

Console.WriteLine($"Hello {name}, you are {age} years old.");

static void GetData(ref string name, ref int age)
{
    name = "John Doe";
    age = 30;
}
