

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter a password:");

    string password = Console.ReadLine();

    if (password == "password")
    {
        Console.WriteLine("login succesful");
        break;

    }
    else
    {
        Console.WriteLine("password is inccorect \"Try again\"!");
    }



}




