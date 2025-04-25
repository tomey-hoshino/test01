SetNumber obj1 = new(11, 22, 33.405);
Console.WriteLine(obj1.numA + "," + obj1.numB + ",", +obj1.numC);

SetNumber obj2 = new(20);
Console.WriteLine(obj2.numA + "," + obj2.numB + "," + obj2.numC);

SetNumber obj3 = new(11.55);
Console.WriteLine(obj3.numA + "," + obj3.numB + "," + obj3.numC);

class SetNumber
{ 
    public int numA
    { get; set; }

    public int numB
    { get; set; }

    public double numC
    { get; set; }

    public SetNumber(int a, int b, double c)
    {
        numA = a;
        numB = b;
        numC = c;
    }

    public SetNumber(int a)
    {
        numA = a;
        numB = 10;
        numC = 1.234;
    }

    public SetNumber(double c)
    {
        numA = 500;
        numB = 10;
        numC = c;
    }
}