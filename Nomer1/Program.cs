Console.Clear();
System.Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество элементов в заданном вами числе: ");
int n = int.Parse(Console.ReadLine());
double z1 = Math.Pow(10, (n - 3));
int z = Convert.ToInt32(z1);
if (n == 3){
    int num3 = num % 10;
    System.Console.WriteLine(num3);
}
else if (n > 3){
    int num3 = (num / z) % 10;
    System.Console.WriteLine(num3);
}
else{
    System.Console.WriteLine("Третьей цифры нет");
}
