TestClass obj1 = new(400);
TestClass obj2 = new(200);

obj1.Add(obj2);
Console.WriteLine(obj1.Num);

obj1.Subtract(obj2);
Console.WriteLine(obj1.Num);

public class TestClass
{ 
    public int Num { get; set; }

    public TestClass(int num)
    {
        Num = num;
    }

    public void Add(TestClass a)
    {
        Num += a.Num;
    }
    public void Subtract(TestClass a)
    {
        Num -= a.Num;
    }
}