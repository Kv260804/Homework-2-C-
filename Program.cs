// Напишите прорамму, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число, обозначающее день недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 5)
{
    Console.WriteLine("Нет");
}
if (a > 5 && a <=7)
{
    Console.WriteLine("Да");
}