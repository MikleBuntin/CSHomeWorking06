//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Будем решать систему уравнений методом Крамера.
// Приведём уравнения к виду:
// k * x + b * y = c:
// - k1 * x + y = b1;
// - k2 * x + y = b2;
// составляем матрицу коэффициентов: 
// - k1, 1, b1
// - k2, 1, b2


Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int DeltaMatrix(int[,] matrix)
{
    return matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
}

void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
      for(int j = 0; j < matr.GetLength(1); j++)
        {
          Console.Write($" |{matr[i, j]}| ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 2];
matrix[0, 0] = - k1;
matrix[0, 1] = 1;
matrix[1, 0] = - k2;
matrix[1, 1] = 1;



double delta0 = DeltaMatrix(matrix);

PrintArray(matrix);
Console.WriteLine($"d0 = " + delta0);

matrix[0, 0] = b1;
matrix[1, 0] = b2;

double delta1 = DeltaMatrix(matrix);
PrintArray(matrix);
Console.WriteLine($"d1 = " + delta1);

matrix[0, 0] = - k1;
matrix[1, 0] = - k2;
matrix[0, 1] = b1;
matrix[1, 1] = b2;

double delta2 = DeltaMatrix(matrix);
PrintArray(matrix);
Console.WriteLine($"d2 = " + delta2);

double x = delta1 / delta0;
double y = delta2 / delta0;

Console.WriteLine($"x = " + x);
Console.WriteLine($"y = " + y);