Console.WriteLine("Welcome to the Secret Elevator!");
Console.WriteLine("Please enter the secret code to access the elevator:");
int secretCode = Convert.ToInt32(Console.ReadLine());
if (secretCode == 135)
{
    Console.WriteLine("Welcome to First Floor!");

}
else if (secretCode == 246)
{
    Console.WriteLine("Welcome to Second Floor!");
}
else if (secretCode == 357)
{
    Console.WriteLine("Welcome to Third Floor!");
}
else if (secretCode == 999)
{
    Console.WriteLine("Welcome to Fourth Floor!");
}
else if (secretCode == 579)
{
    Console.WriteLine("Welcome to Fifth Floor!");
}
else
{
    Console.WriteLine("Access denied! Incorrect secret code.");
}