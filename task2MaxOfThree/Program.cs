Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(max > numberB && max > numberC)
{
    Console.WriteLine("Ваше максимальное число из трех введеных: " + max);
}
else if(max > numberB && max < numberC)
{
    max = numberC;
    Console.WriteLine("Ваше максимальное число из трех введеных: " + max);
}
else if(max < numberB && numberB > numberC)
{
    max = numberB;
    Console.WriteLine("Ваше максимадьно число из трех введеных: " + max);
}
else
{
    Console.WriteLine("Ваши числа равны: " + numberA + " = " + numberB + " = " + numberC );
}
