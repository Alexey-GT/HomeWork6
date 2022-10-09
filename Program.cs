/* //Пользователь вводит с клавиатуры число M, потом вводит M чисел через ENTER.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Введите числа через Enter: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
for (int i=0; i<array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine()!);
}
Console.Write($"Количество положительных элементов массива: {FuncPositiveCount(array)}");


int FuncPositiveCount(int[] array)
{
    int counter = 0;
    for (int i=0; i<array.Length; i++)
    {
       if(array[i] > 0)
       counter++;
    }
    return counter;
} */


/* //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем. 
Console.Clear();
Console.WriteLine("Введите коэффициенты b1, k1, b2, k2 через пробел: ");
string input = Console.ReadLine()!;
double[,] array = ParseToArray(input);
double[] crossPoint = FuncCrossPoint(array);
Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");

double[] FuncCrossPoint(double[,] array)
{
    double[] point = new double[2];
    point[0] = -(array[0,0] - array[1,0]) / (array[0,1] - array[1,1]);
    point[1] = array[0,1] * point[0] + array[0,0];
    return point;
}

double[,] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    double[,] result = new double[stringArray.Length/2, stringArray.Length/2];
    for (int i=0; i<stringArray.Length/2; i++)
    {
        for (int j=0; j<stringArray.Length/2; j++)
        {
            result[i,j] = double.Parse(stringArray[i*(stringArray.Length/2)+j]);
 
        }             
    }
    return result;
} */