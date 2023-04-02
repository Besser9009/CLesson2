Console.Clear();
System.Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
System.Console.Write("Введите число от 1 до 7, которые обозначают дни недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6){
    System.Console.WriteLine("Выходной день - Суббота");
}
else if (day == 7){
    System.Console.WriteLine("Выходной день - Воскресенье");
}
else if (day <6 && day > 0){
    System.Console.WriteLine("Введённый день не является выходным");
}
else{
    System.Console.WriteLine("Введено неверное число...");
}