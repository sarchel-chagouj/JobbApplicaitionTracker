using System;

namespace JobbApplicaitionTracker
{
    internal class Program
    {
        static void Main()
        {
            JobbManager manager = new JobbManager();

            while (true)
            {
                Console.WriteLine("\n--- JOB APPLICATION TRACKER ---");
                Console.WriteLine("1. Add Job");
                Console.WriteLine("2. Show All");
                Console.WriteLine("3. Filter by Status (LINQ)");
                Console.WriteLine("4. Sort by Date (LINQ)");
                Console.WriteLine("5. Show Statistics (LINQ)");
                Console.WriteLine("6. Update Status");
                Console.WriteLine("7. Delete Job");
                Console.WriteLine("8. Exit");

                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddJob();
                        break;

                    case "2":
                        manager.ShowAll();
                        break;

                    case "3":
                        manager.ShowByStatus();
                        break;

                    case "4":
                        manager.SortByDate();
                        break;

                    case "5":
                        manager.ShowStatistics();
                        break;

                    case "6":
                        manager.UpdateStatus();
                        break;

                    case "7":
                        manager.DeleteJob();
                        break;

                    case "8":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
