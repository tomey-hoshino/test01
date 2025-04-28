Console.WriteLine("プログラムを開始します。");

ThreadPool.QueueUserWorkItem(new WaitCallback(MethodTest));
Console.WriteLine("何かキーを押すとすぐに終了します。");

Console.ReadLine();

static void MethodTest(object? obj)
{
    Thread.Sleep(5000);
    Console.WriteLine("別スレッドの処理が完了しました");
}