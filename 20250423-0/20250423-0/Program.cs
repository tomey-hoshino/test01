Customer obj1 = new();

Customer obj2 = new("A101", "秀和太郎");

Customer obj3 = new("A102", "山田次郎", 28);

Console.WriteLine(obj1.id + "　" + obj1.name + "　" + obj1.age);

Console.WriteLine(obj2.id + "　" + obj2.name + "　" + obj2.age);

Console.WriteLine(obj3.id + "　" + obj3.name + "　" + obj3.age);

class Customer
{
    public string id;
    public string name;
    public int age;

    public Customer() : this("-", "-", -1)
    { 
    }
    public Customer(string id, string name) : this(id, name, -1)
    {
    }

    public Customer(string id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
}