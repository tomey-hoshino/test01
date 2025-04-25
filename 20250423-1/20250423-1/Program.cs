C obj = new();

class A 
{
    public A() : base()
    {
        Console.WriteLine("Aクラスのコンストラクターです");
    }
}

class B : A
{
    public B() : base()
    {
        Console.WriteLine("Bクラスのコンストラクターです");
    }
}

class C : B
{
    public C() : base()
    {
        Console.WriteLine("Cクラスのコンストラクターです");
    }
}