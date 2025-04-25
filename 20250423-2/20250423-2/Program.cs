Country obj1 = new();
obj1.Registry("秀和太郎");

obj1.Show1();

Country obj2 = new();
obj2.Registry("秀和次郎", "日本");

obj2.Show2();

class Customer
{
    public string? Name { get; set; }

    public void Registry(string name)
    {
        Name = "君の名は" + name;
    }

    public void Show1()
    {
        Console.WriteLine(Name);
    }
}

class Country : Customer
{
    public string? CountryName { get; set; }
    public void Registry(string name, string countryName)
    {
        Name = "君の名は" + name;
        CountryName = "君の国籍は" + countryName;
    }
    public void Show2()
    {
        Console.WriteLine(Name);
        Console.WriteLine(CountryName);
    }
}