//Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

Console.WriteLine("Задайте размер двумерного массива m х n");
Console.Write("Введите m = ");
int m=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n=Convert.ToInt32(Console.ReadLine());
int [,] matrix=new int [m,n];

Console.WriteLine("Созданный массив");
for (int i = 0; i <m; i++){
    for (int j= 0; j < n; j++){
        matrix[i,j]= new Random().Next(-10,10);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
Console.Write("Введите i = ");
int i1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j = ");
int j1=Convert.ToInt32(Console.ReadLine());

if (i1>n && j1>m)
{Console.WriteLine("Элементов с такими индексами нет в массиве "); }

for (int i = 0; i <m; i++)
{
    for (int j= 0; j < n; j++){
        if (i1==i && j1==j){
           Console.Write($"{matrix[i,j]} "); }
    }
}
