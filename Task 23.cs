Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= number)
{
    int cube = count * count * count;
    count++;
    Console.Write($"{cube} ");
}