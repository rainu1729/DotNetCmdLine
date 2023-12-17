// Read input from the console.
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

// Display the input on the console screen.
Console.WriteLine("Hello, " + name + "!");

// Wait for the user to press the Enter key before continuing.
Console.ReadLine();

// Display a list of numbered options with some descriptive text. Once selected display the selected option.

Console.WriteLine("1. Option 1");
Console.WriteLine("2. Option 2");
Console.WriteLine("3. Option 3");

Console.WriteLine("Please select an option:");

int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("You selected Option 1.");
        break;
    case 2:
        Console.WriteLine("You selected Option 2.");
        break;
    case 3:
        Console.WriteLine("You selected Option 3.");
        break;
    default:
        Console.WriteLine("Invalid option.");
        break;
}

// Wait for the user to press the Enter key before closing the console window.
Console.ReadLine();

