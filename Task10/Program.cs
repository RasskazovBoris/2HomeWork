Console.Write ("Insert the number: ");
int number = int.Parse(Console.ReadLine());

if (System.Math.Abs(number).ToString().Length != 3)
{
    Console.WriteLine("Please, insert 3-digit number!");
}
else 
{int number2 = System.Math.Abs((number/10) % 10);
Console.WriteLine(number2);
}