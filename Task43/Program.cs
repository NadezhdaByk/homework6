// Находит точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());
void Point(int B1, int K1, int B2, int K2)
{
    double x1 = B1-B2;
    double x2 = K2-K1;
    double x = x1/x2;
    double y = K1*x + B1;
    Console.WriteLine($"Координаты точки пересечения ({x};{y})");
}
Point(b1,k1,b2,k2);