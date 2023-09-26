while (true)
{
    Console.Write("Enter your age: ");
    string userInput = Console.ReadLine();
    int age;

    if (int.TryParse(userInput, out age))
    {
        if (age >= 18)
        {
            Console.WriteLine("You can vote!");
        }
        else
        {
            Console.WriteLine("You can't vote!");
        }
    }
    else
    {
        Console.WriteLine(value: "Number given is not received as a real number");
    }
}
