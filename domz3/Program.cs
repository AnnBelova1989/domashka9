using System.Diagnostics;

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1));
}
int num1 = InputNum("введите число m: ");
int num2 = InputNum("введите число n: ");

int funcAck = Ack(num1, num2);
System.Console.WriteLine(funcAck);
