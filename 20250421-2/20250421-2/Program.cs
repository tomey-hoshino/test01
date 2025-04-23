DataSet ds1 = new("配列の値", new int[] { 10, 20, 30, 40, 50 });

Console.Write(ds1.Str + "= {");

foreach(var m in ds1.Num)
{
    Console.Write(m + " ");
}
Console.WriteLine("}");

class DataSet
{ 
    private string _str;
    private int[] _num;

    public DataSet(string str, int[] num)
    {
        _str = str;
        _num = num;
    }

    public string Str
    {
        get=>_str;
        set => _str = value;
    }

    public int[] Num
    {
        get => _num;
        set => _num = value;
    }
}