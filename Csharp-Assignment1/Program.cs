namespace Csharp_Assignment1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        string ageInput = Console.ReadLine()?? "";

        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine() ?? "";

        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine() ?? "";

        Console.WriteLine("Enter your weight in KG:");
        double weight = double.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Enter your height in CM:");
        double height = double.Parse(Console.ReadLine() ?? "");

        Patient patient = new (firstName, lastName, weight, height);

        Console.WriteLine("Enter your systolic blood pressure:");
        int systolic = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Enter your diastolic blood pressure:");
        int diastolic = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine();
        Console.WriteLine("****************************");
        patient.PatientResults(systolic, diastolic);
        Console.WriteLine();
        Console.WriteLine("****************************");
    }
}
    


