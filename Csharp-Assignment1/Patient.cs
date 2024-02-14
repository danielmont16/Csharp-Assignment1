
namespace Csharp_Assignment1
{
    public class Patient
    {
        //instance variables
        private String FirstName;
        private String LastName;
        private double Weight;
        private double Height;

        //creating properties
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Weight1 { get => Weight; set => Weight = value; }
        public double Height1 { get => Height; set => Height = value; }

        //creating custom constructor
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        //creatin the method to calculate BMI
        public double CalculateBMI()
        {
            double heightInMeters = Height / 100;

            return Math.Round(Weight / Math.Pow(heightInMeters, 2), 2);

        }//end of CalculateBMI

        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            string bloodPressureCategory;

            if (systolic < 120 && diastolic < 80)
            {
                bloodPressureCategory = "Normal";

            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            {
                bloodPressureCategory = "Elevated";

            }
            else if (systolic >= 130 && systolic <= 139 || diastolic >= 80 && diastolic <= 89)
            {
                bloodPressureCategory = "High Blood Pressure (Hypertension Stage1)";
            }
            else if (systolic >= 140 && systolic < 180 || diastolic >= 90 && diastolic < 120)
            {
                bloodPressureCategory = "High Blood Pressure (Hypertension Stage2)";
            }
            else if (systolic >= 180 && diastolic >= 120 || systolic >= 180 || diastolic >= 120)
            {
                bloodPressureCategory = "Hypertensive Crisis (consult your doctor inmediately)";
            }
            else
            {
                bloodPressureCategory = "value out of the range, please consult your doctor";
            }

            return bloodPressureCategory;
        }//end of calculateBloodPressure


        //creating method to print results
        public void PatientResults(int systolic, int diastolic)
        {
            double BMIindex = CalculateBMI();
            string BMIstatus;

            if (BMIindex >= 25)
            {
                BMIstatus = "Overweight";
            }
            else if (BMIindex >= 18.5 && BMIindex <= 24.9)
            {
                BMIstatus = "Normal";
            }
            else
            {
                BMIstatus = "Underweight";
            }

            Console.WriteLine($"Full Name: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Height: {Height} CM");
            Console.WriteLine($"Blood Pressure: {CalculateBloodPressure(systolic, diastolic)}");
            Console.WriteLine($"BMI: {BMIindex}");
            Console.WriteLine($"BMI Status: {BMIstatus}");
        }//end of PatientResults printing method


    }//class

}//namespace


