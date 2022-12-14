void PrintArray(int[,]matrix)                            //CОздаем метод из прошлой задачи который выводит таблицу цифр
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
void FillArray(int[,]matrix)                       //CОздаем метод который будет заполнять наш массив
{
     for (int i = 0; i < matrix.GetLength(0); i++) 
     {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix [i,j]= new Random().Next(1,10); // Заполняем массив рандомными числами
        }
     }
}
int[,] matrix = new int[3, 4];    // Задаем двумерный массив

PrintArray(matrix);              // ВЫводим в консоль метод PrintArray
FillArray(matrix);                // 
Console.WriteLine();              // Делаем пробел
PrintArray(matrix);              //   Выводим заполненый рандомными числами метод