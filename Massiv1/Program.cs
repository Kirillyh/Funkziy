﻿// МАССИВ

// int[] array = {3,2,5,1,6,7,3,8,};  Тип данных [] имя = {3,2,5,1,6,7,3,8,9};

int[] array = {3,2,5,1,6,7,3,8,9};

array [0] = 18;     // Присвоили индексу [0] число 12

int Max(int arg1, int arg2, int arg3 )  //Функция или метод находит максимальное число
{
    int result =arg1 ;
    if (arg2>result)result=arg2;
    if (arg3 > result)result=arg3;
    return result;
}
int max = Max(
Max (array[0],array[1],array[2]),
Max (array[3], array[4],array[5]),
Max (array[6],array[7],array[8])
);
Console.WriteLine(max);