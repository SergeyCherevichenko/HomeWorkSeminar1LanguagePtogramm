int EnterNumber()
{
    Console.WriteLine("Введите число: ");
    int numberuser = Convert.ToInt32(Console.ReadLine());
    return numberuser;
} 
int x = EnterNumber();  
    while (x <= 0)
{
    Console.WriteLine("Вы ввели число менее либо равное 0! Попробуйте ввести еще раз!");
    x = EnterNumber();
}

   int i = 1;
   Console.Write("Ваши четные числа  от 0 до " + x + " :   ");
while(i < x + 1 )
{
    if(i % 2 == 0)
    Console.Write(i + " ");
    i++;
    }   






