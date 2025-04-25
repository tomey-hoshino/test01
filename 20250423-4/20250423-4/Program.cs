SampleCls sc = new();
sc.Show();

interface ISample
{
    void Show();
}

class SampleCls : ISample
{
    public void Show()
    {
        Console.WriteLine("Hello, World!");
    }
}