// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

ActionDelegate(Disp, "Hello World!");

static void Disp(string message)
{
    Console.WriteLine(message);
}

static void ActionDelegate(Action<string> call, string message)
{
    call(message);
}