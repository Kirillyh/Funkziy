// Имеется одномерный массив array из n элементов требуется найти элемент массива равный find


int[] array = {3,2,5,1,6,4,3,8,9};

int n = array.Length;

int find = 9;    // Какой элемент в массиве нужно найти
int index = 0;
while(index<n)
{
    
    if (array[index]==find)
    {
        Console.WriteLine(index);
       // break;   //  Останавливает на первом элементе если два одинаковых числа
    }
    index++;
}