using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker
{
    public class HabitService
    {
        private List<Habit> habits = new()
        {
            new Habit { Name = "Drink Water", IsDone = false },
            new Habit { Name = "Read 10 Pages", IsDone = true },
            new Habit { Name = "Walk 30 Minutes", IsDone = false }
        };


        //Add a new habit
        public void AddHabit()
        {
            Console.Write("Enter habit name: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Habit name cannot be empty.");
                return;
            }

            Habit newHabit = new Habit
            {
                Name = name,
                IsDone = false
            };

            habits.Add(newHabit);

            Console.WriteLine($"Habit '{name}' has been added.");
        }

        //View habits
        public List<Habit> GetHabits()
        {
            return habits;
        }


        //Mark a habit as done
        public void MarkHabitAsDone()
        {
            Console.WriteLine("Mark Habit as Done selected");
        }

        //Delete a habit
        public void DeleteHabit()
        {
            if (habits.Count == 0)
            {
                Console.WriteLine("No habits to delete.");
                return;
            }

            Console.WriteLine("Select a habit to delete:");

            for (int i = 0; i < habits.Count; i++)
            {
                var habit = habits[i];
                string status = habit.IsDone ? "Done" : "Not Done";

                Console.WriteLine($"{i + 1}. {habit.Name} - {status}");
            }

            Console.Write("Enter habit number to delete: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            if (number < 1 || number > habits.Count)
            {
                Console.WriteLine("Habit not found.");
                return;
            }

            Habit habitToDelete = habits[number - 1];
            habits.RemoveAt(number - 1);

            Console.WriteLine($"Habit '{habitToDelete.Name}' has been deleted.");
        }
    }
}
