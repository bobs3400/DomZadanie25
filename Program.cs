int GetStepen(int a, int b)
{
    int result = 1;
    for (int i= 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;  
}
Console.WriteLine("Введите число А и В");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Число А в степени В равно {GetStepen(a, b)}");