int value = new Random().Next(0,10000);
Console.WriteLine(value);
int indexValue = 2;

int digit = value.ToString()[indexValue] - '0';
if(digit <= 9)
{
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("третьей цифры нет");
}