﻿/* Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных 
координат точек в этой четверти (x и y). */

int ReadLine(string line)
{
    Console.WriteLine(line);
    int number=int.Parse(Console.ReadLine());
    return number;
}

string QuterTest(int quter)
{
    if (quter == 1)
    {
        return "x > 0 && y > 0";
    }
    if (quter ==2)
    {
        return "x > 0 && y < 0";
    }
    if (quter == 3)
    {
        return "x < 0 && y < 0";
    }
    if (quter == 4)
    {
        return "x < 0 && y > 0";
    }
    return "Такой четверти нет";
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

//
int quter= ReadLine("Введите номер четверти: ");
//
string ansfer = QuterTest(quter);
//Вывожу кординаты
PrintData("Дипазон четверти: ", ansfer.ToString());