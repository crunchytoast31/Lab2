int num;
Console.WriteLine("Choose a number between 1-100!");
num = int.Parse(Console.ReadLine());

if (num < 60 && num % 2 != 0)
{
    Console.WriteLine("It is odd and less than 60");
}

if (num < 25 && num % 2 == 0)
{
    Console.WriteLine("the number is even and less than 25");
}
if (num >= 26 && num < 60 && num % 2 == 0)
{
    Console.WriteLine("It is even and greater than 60");
}
if (num > 60 && num % 2 != 0)
{
    Console.WriteLine("The number is odd and greater than 60");
}
else
{ 
    Console.WriteLine("the number is even and greater than 60");

}






