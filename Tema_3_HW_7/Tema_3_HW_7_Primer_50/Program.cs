/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/


int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 0)
{
break;
}
else
{
Console.WriteLine("Ввели не корректное число. Повторите ввод.");
}
}

return result;
}



int[,] InitMatrix(int rows, int columns)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
matrix[i,j] = rnd.Next(-99, 100);
}
}

return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}

Console.WriteLine();
}
}

int countOfRows = GetNumber("Введите кол-во строк:");

int countOfColumns = GetNumber("Введите кол-во столбцов:");

int[,] matrix = InitMatrix(countOfRows, countOfColumns);

Console.WriteLine();

PrintMatrix(matrix);

Console.WriteLine();
int n = GetNumber("Введите номер строки искомого элемента");
int m = GetNumber("Введите номер столбца искомого элемента");

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {matrix[n-1,m-1]}");
}

