using HabitTracker;

HabitService service = new HabitService();

bool running = true;

while (running)
{
    Console.WriteLine("===== Habit Tracker =====");
    Console.WriteLine("1. Add Habit");
    Console.WriteLine("2. View Habits");
    Console.WriteLine("3. Complete Habit");
    Console.WriteLine("4. Delete Habit");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    Console.WriteLine();

    if (choice == "1")
    {
        service.AddHabit();
    }
    else if (choice == "2")
    {
        ShowHabits();
    }
    else if (choice == "3")
    {
        ShowHabits();

        Console.Write("Enter habit number to mark as done: ");

        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        bool success = service.MarkHabitAsDone(index);

        if (success)
        {
            Console.WriteLine("Habit marked as done!");
        }
        else
        {
            Console.WriteLine("Invalid habit number.");
        }
    }
    else if (choice == "4")
    {
        ShowHabits();

        Console.Write("Enter habit number to delete: ");

        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        bool success = service.DeleteHabit(index);

        if (success)
        {
            Console.WriteLine("Habit deleted!");
        }
        else
        {
            Console.WriteLine("Invalid habit number.");
        }
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

void ShowHabits()
{
    var habits = service.GetHabits();

    if (habits.Count == 0)
    {
        Console.WriteLine("No habits found.");
        return;
    }

    Console.WriteLine("Your Habits:");

    for (int i = 0; i < habits.Count; i++)
    {
        var habit = habits[i];

        string status = habit.IsDone ? "Done" : "Not Done";

        Console.WriteLine($"{i + 1}. {habit.Name} - {status}");
    }
