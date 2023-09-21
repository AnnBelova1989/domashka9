int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int PrintSumNumbers(int start, int end)
{
    if (start == end) return start++;
    return start + PrintSumNumbers(++start, end);
}
int elements1 = InputNum("Задайте значение M: ");
int elements2 = InputNum("Задайте значение N: ");

int sum = PrintSumNumbers(elements1, elements2);
System.Console.WriteLine(sum);