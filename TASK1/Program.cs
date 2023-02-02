/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

bool CheckNumber(int b)
{
    if (b ==0)
    {
        System.Console.WriteLine("Любое число в нулевой степени равно единице");
        return false;
    }
    return true;
}
long MyPow(int a, int b)
{
    int degree = 1;
    long result = a;
    while (degree < Math.Abs(b))
    {
        result *= a;
        degree++;
    }
    return result;
}

int a = GetValue("введите первое число:");
int b = GetValue("введите второе число:");

if (CheckNumber(b))
{
    long result = MyPow(a, b);
    System.Console.WriteLine($"{a} ^ {b} = {result}");
}