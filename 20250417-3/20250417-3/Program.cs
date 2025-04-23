// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Security.Cryptography;

int a1 = 10, a2 = 10;

int[] ary1 = { 1, 2, 3 };
int[] ary2 = { 1, 2, 3 };

Pro1(a1, ary1);
Console.WriteLine("a1=" + a1);
Console.WriteLine("ary1[0]=" + ary1[0]);

Pro2(ref a2, ref ary2);
Console.WriteLine("a2=" + a2);
Console.WriteLine("ary2[0]=" + ary2[0]);

static void Pro1(int n1, int[] n2)
{
    n1++;
    n2[0]++;
}
static void Pro2(ref int v1, ref int[] v2)
{
    v1++;
    v2[0]++;
}