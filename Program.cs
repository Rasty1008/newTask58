/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using static System.Console;
Clear();
WriteLine("Введите число строк 1-й матрицы: ");
int n = int.Parse(ReadLine()!);
WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int m = int.Parse(ReadLine()!);
WriteLine("Введите число столбцов 2-й матрицы: ");
int c = int.Parse(ReadLine()!);
int randomNumbers = int.Parse(ReadLine()!);

int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
WriteLine("Первая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, c];
GetArray(secomdMartrix);
WriteLine("Вторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,c];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteLine("Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}



void GetArray(int[,] inArray) {
  for (int i = 0; i < inArray.GetLength(0); i++) {
    for (int j = 0; j < inArray.GetLength(1); j++) {
      inArray[i, j] = new Random().Next(randomNumbers);
    }
  }
}

void WriteArray (int[,] inArray) {
  for (int i = 0; i < inArray.GetLength(0); i++) {
    for (int j = 0; j < inArray.GetLength(1); j++) {
      Write(inArray[i,j] + " ");
    }
    WriteLine();
  }
}