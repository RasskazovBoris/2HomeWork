Console.Write("Insert the number of week: ");
int input = int.Parse(Console.ReadLine());

if (input < 1 || input > 7)
{
    Console.WriteLine ("There is no such day of the week!");
}
else 
{
    if (input == 6 || input == 7)
    {
        Console.WriteLine("Day off!");
    }
    else
    {
        Console.WriteLine("Working day!");
    }
}