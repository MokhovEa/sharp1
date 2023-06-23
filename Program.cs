Console.Clear();            //Очистка экрана
Console.WriteLine("Введите первое число => "); // вывод приглашения для пользователя
string number1 = Console.ReadLine(); //Ввод пользователя
Console.WriteLine("Введите второе число => "); //преобразует значение в целое число
string number2 = Console.ReadLine(); //Ввод пользователя
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
if (num1 > num2)
{
    Console.WriteLine($"Число {number1} большее, числа {number2}");
}
else {
    Console.WriteLine($"Число {number2} большее, числа {number1}");
}