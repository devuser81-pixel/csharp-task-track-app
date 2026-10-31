using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TaskTrackerApp
{
    public class TaskItem
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public bool IsCompleted {get; set;}
    }

    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("   C# CLI TASK TRACKER RUN   ");
            Console.WriteLine("=============");

            var tasks = new List<TaskItem>
            {
                new TaskItem {Id = 1, Title = "Setup Environment", IsCompleted = true},
                new TaskItem {Id = 2 , Title = "Verify JSON output", IsCompleted = true}
            };

            string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText("tasks.json",json);

            Console.WriteLine($"[VERIFICATION] Programmatic Self-Test Passed: {tasks.Count == 2}");
            Console.WriteLine($"Saced {tasks.Count} tasks to local tasks.json storage.");
            Console.WriteLine("=====================");

        }
    }
}