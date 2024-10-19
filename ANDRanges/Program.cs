

//temp <= 0 - Freezing cold
//temp > 0 AND temp < 10 - Cold
//Temps >= 10 AND temp < 15 - Chilly
//Temps >= 15 AND temp < 20 - Warm
//Temps >= 20 AND temp < 30 - Hot
//Temps >= 30 - SUPER HOT 


Console.WriteLine("Enter the temperature: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("SUPER HOT");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Warm");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly");
}
else if (temp < 10 && temp >= 0)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("FREEZING!");
}