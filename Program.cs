//Задание 1

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

//Задание 2

Console.Clear();
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}

//Задание 3

Console.Clear();       
Console.WriteLine("Введите число => "); 
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
if ((num1 % 2) == 0)
        {
            Console.WriteLine($"число {num1} четное");
        }
        else
        {
            Console.WriteLine($"число {num1} нечетное");
        }

// Задание 4

Console.Clear();
 int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }