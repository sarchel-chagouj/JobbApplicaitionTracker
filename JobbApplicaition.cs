using System;

namespace JobbApplicaitionTracker
{
    public enum Status
    {
        Applied,
        Interview,
        Offer,
        Rejected
    }

    public class JobApplication
    {
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public Status Status { get; set; }

        public DateTime ApplicationDate { get; set; }
        public DateTime? ResponseDate { get; set; }

        public int SalaryExpectation { get; set; }

        public int GetDaysSinceApplied()
        {
            return (DateTime.Now - ApplicationDate).Days;
        }

        public void GetSummary()
        {
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Position: " + PositionTitle);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Days Since Applied: " + GetDaysSinceApplied());
            Console.WriteLine("Response Date: " + ResponseDate?.ToShortDateString());
            Console.WriteLine("Salary Expectation: " + SalaryExpectation + " kr");
        }
    }
}
