Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)                              //Проверка на пятизначность
{
    if (number / 10000 == number % 10)                             //Проверка первого и последнего разрядов
    {
        if ((number / 1000) % 10 == (number / 10) % 10)            //Проверка второго и четвертого разрядов
        {
            Console.Write("А вот и палиндром!");
        }
    }
    else Console.Write("Введенное число не является палиндромом");
}
else Console.Write("Введенное число не пятизначное");