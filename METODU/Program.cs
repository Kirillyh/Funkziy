int [] array = new int [10];  //создали массив в котором 10 элементов
//     имя              аргумент
void FillArray (int []collection)  // Метод для заполнения массива
{
int Length = collection.Length;  //Получить длину массива
int index = 0;
while (index < Length)
collection[index] = new Random().Next(1, 10);
//  К аргументу положить рандомное число из диапозона (1б 10)
index++;

}
void PrintArray(int[]collection)  // Метод который печатает массив (метод ничего не возврашает в нем не используеться return)
{
    int count = collection.Length;// /Получить длину массива
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(collection[position]);
        position++;
    }
}

FillArray(array);
PrintArray(array);

//  Метод ищет позицию в массиве

int Indexof (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index]==find)
        {
        position=index;
        }
        index++;
    }
    return position;
}
int pos =Indexof(array, 4);
Console.WriteLine(pos);


