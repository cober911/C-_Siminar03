/* Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу квадратов чисел от 1 до 
N.  
 апример: 
5 -> 1, 4, 9, 16, 25.  
2 -> 1,4 */

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string LineNum(int numN, int p)
{
    string outLine = "1";
    for (int i = 2; i <= numN; i++)
    {
        outLine = outLine + "\t" + Math.Pow(i, p);
    }
    return outLine;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int numN = ReadData("Введите число N: ");
string lineTop = LineNum(numN, 1);
string lineDown = LineNum(numN, 2);
PrintData("", lineTop);
PrintData("", lineDown);