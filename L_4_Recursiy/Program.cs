double Factorial (double n)     //Метод нахождение факториала    1! =1   0! = 1
{
if (n == 1) return 1;    //Если 1 возврашаем  1
else 
return n * Factorial(n-1);  //Если не 1 делаем по формуле
}
for (double i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");  
}