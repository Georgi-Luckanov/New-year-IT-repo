Console.WriteLine("Enter a hour: ");
int hour = int.Parse(Console.ReadLine());
if (hour >= 6 && hour <= 10)
{
    Console.WriteLine("Good morning");
}
else if (hour >= 11 && hour <= 18)
{
    Console.WriteLine("Good afternoon");
}
else if (hour >= 19 && hour <= 22)
{
    Console.WriteLine("Good evening");
}
else if(hour >= 23 && hour <= 24)
{
    Console.WriteLine("Good night");
}
else if (hour >= 1  && hour <= 5)
{
    Console.WriteLine("Was is a good party");
}
else
{
    Console.WriteLine("Not a valid hour");
}
//tva ne e code review na random zadacha
//tova si e istinska zadacha 
string username = "TtestUser";
string password = "testPassword123";
Console.WriteLine("Please input credentials");
string inputUsername = Console.ReadLine();
string inputPassword = Console.ReadLine();
if (password == inputUsername)
{
    if (password == inputPassword)
    {
        Console.WriteLine("Login successfull");
    }
    else
    {
        Console.WriteLine("Wrong password");
    }
}
else
{
    Console.WriteLine("User does NOT exist");
}
