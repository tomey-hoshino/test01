// See https://aka.ms/new-console-template for more information
int s = 30000000;

S[] ar1= new S[s];

var now1 = DateTime.Now;

for (int i = 0; i < ar1.Length; i++)
{
    ar1[i] = new S(i);
}

Console.WriteLine(DateTime.Now - now1);

C[] ar2= new C[s];

var now2 = DateTime.Now;

for (int i = 0; i < ar2.Length; i++)
{
    ar2[i] = new C(i);
}

Console.WriteLine(DateTime.Now - now2);

struct S
{
    public int num;
    public S(int n) { num = n; }
}
class C
{
    public int num;
    public C(int n) { num = n; }
}