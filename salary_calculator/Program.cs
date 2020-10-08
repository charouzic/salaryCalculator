using System;

namespace salary_calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dixa personal salary calculator");

            SalaryCalculator salary = new SalaryCalculator();

            Console.Write("Please provide hours worked for DAY charge: ");
            int dayHours = int.Parse(Console.ReadLine());

            Console.Write("Please provide hours worked for EVENING charge:  ");
            int eveningHours = int.Parse(Console.ReadLine());

            Console.Write("Please provide hours worked for NIGHT charge: ");
            int nightHours = int.Parse(Console.ReadLine());

            int estimatedSalary = salary.salaryCount(dayHours, eveningHours, nightHours);
            Console.WriteLine($"Your total brutto salary: {estimatedSalary}");

            Console.WriteLine($"Your estimade salary after tax: {salary.estimateSalaryTaxed(estimatedSalary)}");

        }
    }


    public class SalaryCalculator
    {
        public int dayPay = 150;
        public int eveningPay = 170;
        public int nightPay = 190;

        public int salaryCount(int dayH, int eveningH, int nightH)
        {
            int dayilyPay = dayPay * dayH;
            int eveninglyPay = eveningPay * eveningH;
            int nightlyPay = nightPay * nightH;
            int sumPay = dayilyPay + eveninglyPay + nightlyPay;
            double taxed = sumPay;
            return sumPay;
        }

        public double estimateSalaryTaxed(int salaryAmount)
        {
            double pennsionsalaryAmount = salaryAmount*0.98;
            // 4500 is tax free money
            double afterTaxFree = pennsionsalaryAmount - 4500;
            double taxed = afterTaxFree * 0.64;
            // 250 for lunch 
            double taxedCompletely = taxed + 4500 - 250;
            return taxedCompletely;
        }
            
    }
    
        
    
}
