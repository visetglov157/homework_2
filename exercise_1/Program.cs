Console.Clear();
Console.Write("Введи трёхзначное число: ");
int num= Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(num);
Console.WriteLine("вторая цифра числа - "+stringNumber[1]);