TestClass[] a = { new(10001, "public"), new(10002, "private"), new(10003, "protected") };

foreach (TestClass tc in a)
{
    Console.WriteLine(tc.Id + "=" + tc.Product);
}

public class  TestClass
{
    public int Id { get; set; }
    public string Product { get; set; }

    public TestClass(int id, string product)
    {
        Id = id;
        Product = product;
    }
}