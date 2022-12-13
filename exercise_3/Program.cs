Console.Clear();
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("это выходной день");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("такого дня недели нет");
    }
    else Console.WriteLine("это не выходной день");
}

CheckingTheDayOfTheWeek(dayNumber);
