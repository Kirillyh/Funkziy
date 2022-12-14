int Factorial (int n)     //Метод нахождение факториала    1! =1   0! = 1
{
if (n == 1) return 1;    //Если 1 возврашаем  1
else 
return n * Factorial(n-1);  //Если не 1 делаем по формуле
}
Console.WriteLine(Factorial(3));  //1*2*3=6