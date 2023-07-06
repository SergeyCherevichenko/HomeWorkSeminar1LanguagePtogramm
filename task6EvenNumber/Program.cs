Console.WriteLine("Введите ваше число: ");
int numberuser = Convert.ToInt32(Console.ReadLine());
if (numberuser % 2 == 0)
{
    Console.WriteLine("ваше число: " + numberuser + " - четное");
}
else 
{
    Console.WriteLine("Ваше число: " + numberuser + " - не четное");
}
