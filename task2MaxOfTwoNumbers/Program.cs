Console.WriteLine("Введите первое число: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberY = Convert.ToInt32(Console.ReadLine());
if(numberX > numberY)
{
    Console.WriteLine("Это число большее из двух вами введеных: " + " max = " + numberX);
    Console.WriteLine("Это число меньшее из двух вами введенных: " + " min = " + numberY);
}
else if(numberY > numberX)
{
    Console.WriteLine("Это число большее из двух вами введенных: " + " max = " +numberY);
    Console.WriteLine("Это число меньшее из двух вами введенных: " + " min = " + numberX);

}
else
{
    Console.WriteLine("Ваши числа равны: " + numberX + " = " + numberY);
}
