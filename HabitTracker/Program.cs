bool running = true;

while (running)
{
    Console.WriteLine("===== Habit Tracker =====");
    Console.WriteLine("1. Add Habit");
    Console.WriteLine("2. View Habits");
    Console.WriteLine("3. Mark Habit as Done");
    Console.WriteLine("4. Delete Habit");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("Add Habit selected");
    }
    else if (choice == "2")
    {
        Console.WriteLine("View Habits selected");
    }
    else if (choice == "3")
    {
        Console.WriteLine("Mark Habit as Done selected");
    }
    else if (choice == "4")
    {
        Console.WriteLine("Delete Habit selected");
    }
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye!");
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please choose 1-5.");
    }

    Console.WriteLine();
}