Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0){
    Console.WriteLine($"{num} - чётное число");
}
else{
    Console.WriteLine($"{num} - нечётное число");
}