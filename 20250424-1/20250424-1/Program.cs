TestClass[] a = new TestClass[3];

a[0] = new TestClass("public");
a[1] = new TestClass("private");
a[2] = new TestClass("protected");

foreach (TestClass tc in a)
{
    Console.WriteLine(tc.Modifier);
}

public class TestClass
{
    private string _modifier;

    public string Modifier
    {
        get { return _modifier; }
    }
    public TestClass(string modifier)
    {
        _modifier = modifier;
    }
}