Console.Write ("Insert the number: ");
int input = int.Parse(Console.ReadLine());

int number = System.Math.Abs(input);
int lengthOfNumber = number.ToString().Length;

if (lengthOfNumber < 3)
{
    Console.WriteLine("There is no third number!");
}
else 
{
    while (lengthOfNumber > 3)
{
        number = number / 10;
        lengthOfNumber = lengthOfNumber - 1;
}
    Console.WriteLine(number % 10);
}