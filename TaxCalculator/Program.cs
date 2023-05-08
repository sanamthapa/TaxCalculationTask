
////Console.WriteLine("Hello, World!");
////TaxCalculator obj = new TaxCalculator();
////decimal totalTax = obj.CalculateAdditionalIncomeTax(400, 1500);
////Console.WriteLine($"totalTax= {totalTax:F2}");



//namespace TaxCalculation.TaxCalculator;

//class Program
//{
//    static void Main(string[] args)
//    {
//        decimal baseIncome = 400;
//        decimal additionalIncome = 1500;

//        var taxCalculator = new TaxCalculator();
//        decimal totalTax = taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);

//        Console.WriteLine($"Total Tax: {totalTax:F2}");
//    }
//}

using System;
using TaxCalculation.TaxCalculator;

namespace TaxCalculation.TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the tax calculator!");

            Console.Write("Enter your base income: ");
            decimal baseIncome = decimal.Parse(Console.ReadLine());

            Console.Write("Enter your additional income: ");
            decimal additionalIncome = decimal.Parse(Console.ReadLine());

           
            decimal totalTax = CalculateTotalTax(baseIncome, additionalIncome);

            Console.WriteLine($"Your total tax is: {totalTax:F2}");
        }

        static decimal CalculateTotalTax(decimal baseIncome, decimal additionalIncome)
        {
            var taxCalculator = new TaxCalculator();

            decimal totalTax = taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);

            return totalTax;
        }
    }
}

