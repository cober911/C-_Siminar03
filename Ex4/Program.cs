/* Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 2D пространстве. 
Например: 
 A (3,6); B (2,1) -> 5,09  
A (7,-5); B (1,-1) -> 7,21 */

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

double FindLen(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

//Запрашиваю кординаты
int x1 = ReadData("Введите координату X первой точки: ");
int y1 = ReadData("Введите координату y второй точки: ");
int x2 = ReadData("Введите координату X третей точки: ");
int y2 = ReadData("Введите координату y четвертой точки: ");
//Вывожу кординаты
double result = FindLen(x1, y1, x2, y2);
result = Math.Round(result, 3); //Сокращаем остаток после запятой до двух цифр.
PrintData("Расстояние между точками: ", result.ToString());