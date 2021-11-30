using OpenClosedPrinciple.Accounts;
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            AccountOrdinary accountOrdinary = new AccountOrdinary("Обычный", 5000, 10);
            AccountSalary accountSalary = new AccountSalary("Зарплатный", 10000, 20);

            // До подсчета.
            Console.WriteLine($"Тип счета: {accountOrdinary.Type}, баланс = {accountOrdinary.Balance.ToString()}, процент = {accountOrdinary.Interest.ToString()}");
            Console.WriteLine($"Тип счета: {accountSalary.Type}, баланс = {accountSalary.Balance.ToString()}, процент = {accountSalary.Interest.ToString()}");

            Calculator.CalculateInterest(accountOrdinary);
            Calculator.CalculateInterest(accountSalary);

            // После подсчета.
            Console.WriteLine($"Тип счета: {accountOrdinary.Type}, баланс = {accountOrdinary.Balance.ToString()}, процент = {accountOrdinary.Interest.ToString()}");
            Console.WriteLine($"Тип счета: {accountSalary.Type}, баланс = {accountSalary.Balance.ToString()}, процент = {accountSalary.Interest.ToString()}");
        }
    }
}
