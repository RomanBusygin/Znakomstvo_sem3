Console.Clear();
int x1 = Coordinate("X1= ");
int y1 = Coordinate("Y1= ");
int z1 = Coordinate("Z1= ");
int x2 = Coordinate("X2= ");
int y2 = Coordinate("Y2= ");
int z2 = Coordinate("Z2= ");

double distance = Math.Sqrt(Quadro(x1, x2) + Quadro(y1, y2) + Quadro(z1, z2));
Console.Write($"Расстояние между точками равно: {distance}");

int Coordinate(string str)                             //Запись координат
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int coord1, int coord2)                     //Вычисление квадрата отрезка по осям
{
    return (coord2 - coord1) * (coord2 - coord1);
}