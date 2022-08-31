Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine($"{num1} - большее число");
}
else if(num1 == num2){
    Console.WriteLine("Они равны");
}
else{
    Console.WriteLine($"{num2} - большее число");
}
