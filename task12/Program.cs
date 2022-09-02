// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Clear();
Console.WriteLine("Привет пользователь, введи первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Отлично, продолжай, введи второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int chast = num1 % num2;

if (num1 > num2)
{
    if (kako == 0)
    {
        Console.WriteLine($"{num1} кратно {num2}");
    }
    else
    {
        Console.WriteLine($"{num1} не кратно {num2}, остаток = {kako}");
    }
}
else
{
    Console.WriteLine("Введите другие числа");
}
