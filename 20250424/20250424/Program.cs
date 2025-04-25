TestClass obj1 = new(100);
TestClass obj2 = new(500);
obj1.Show(obj2);

public class TestClass
{
    public int Num { get; set; }

    public TestClass(int num)
    {
        Num = num;
    }

    public void Show(TestClass a)
    {
        Console.WriteLine("呼び出し元のインスタンスのプロパティ値は" + Num);

        Console.WriteLine("引数のインスタンスのプロパティ値は" + a.Num);
    }
}