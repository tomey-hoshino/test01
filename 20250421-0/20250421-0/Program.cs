Member obj1 = new();
obj1.Registry("Gerry Lopez", "米国");
Member obj2 = new();

obj2.Registry("秀和太郎");

class Member
{
    public void Registry(string name, string country)
    {
        Console.WriteLine("名前は" + name + "：国籍は" + country);
    }

    public void Registry(string name)
    {
        Console.WriteLine("名前は"+name+"：国籍は日本");
    }
}