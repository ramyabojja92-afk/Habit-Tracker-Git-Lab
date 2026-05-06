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
            Console.WriteLine("Add Habit selected");
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
            Console.WriteLine("Delete Habit selected");
        }
    }
}
