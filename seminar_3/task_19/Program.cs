Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int reverse_number = 0;
int copy_number = number;

while (copy_number > 0)
{    
    int end_numeric = copy_number % 10;
    copy_number = copy_number / 10;
    reverse_number = reverse_number * 10 + end_numeric;
}

if(number == reverse_number) {
    Console.WriteLine("Число является палиндромом");
}else{
    Console.WriteLine("Число не является палиндромом");
}