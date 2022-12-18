﻿//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



Console.Write("Сколько элементов? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] input =new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("введите "+(i+1)+" элемент");
    string part = Convert.ToString(Console.ReadLine());
    input[i]= part;
}

// ввели массив, каждый элемент отдельно, получили начальный массив строк

string[] output=new string[size];
int n =0;
int m =3;

for (int j = 0; j < size; j++)
{
    if(input[j].Length<=m)
    {
       output[n]=input[j];
        n++;
    }
}
Console.WriteLine();

// создали массив вывода, ввели переменные обозначающе место строки в массиве вывода и макс. количество знаков в строке массива,
// при помощи цикла перебрали элементы начального массива и,
// если в строке было меньше или равно чем допустимый макс. кол-ва знаков, то добавляли строку в массив вывода 




void PrintArray(string [] array)
{
for (int i = 0; i< array.Length; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine();
}

// создали метод для вывода через цикл, и вывели конечный массив

PrintArray(output);

