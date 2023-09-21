int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int num)
{
    if (num == 0) return;
    System.Console.Write(num + ", ");
    PrintNumbers(num - 1);
}
int elements = InputNum("Задайте значение N: ");
PrintNumbers(elements);