Judgment obj1 = new Judgment(100);

bool return1 = obj1.overloadMethods(50);
Console.WriteLine(return1); // Output: True

bool return2 = obj1.overloadMethod(150.55); // Corrected method name
Console.WriteLine(return2); // Output: True

class Judgment
{
    int _num;

    public Judgment(int num) { this._num = num; }
    public bool overloadMethods(int val)
    { return _num >= val; }

    public bool overloadMethod(double val) // Corrected method name
    { return _num >= val; }
}
