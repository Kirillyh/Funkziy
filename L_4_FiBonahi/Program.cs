//   f(1) = 1   Задаем числа
//   f(2) = 1
//   f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n==1 || n == 2) return 1;   //Если значение n ==1 или n == 2 то возврашаем 1
    else return Fibonacci(n-1) + Fibonacci(n-2);  // иначе  возврашаем
}
for (int i=1; i<10; i++)  // сколько чифр фибоначи
{
    Console.WriteLine(Fibonacci(i));
}