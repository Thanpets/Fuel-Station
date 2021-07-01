using FuelStationProgram.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProgram.Impl
{
    public class Ledger : Entity
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public const decimal RentinCost = 5000;

        public void Calculate(List<Transaction> transactions, List<Employee> employees, List<Items> items, List<TransactionLine> transactionLines) {
            Income = CalculateIncome(transactions);
            Expenses = CalculateExpenses(employees, items, transactions, transactionLines);
            Total = Income - Expenses;
        }

        public decimal CalculateIncome(List<Transaction> transactions) {
            decimal transactionsIncome = 0;
            foreach (Transaction t in transactions) {
                if (t.Date.Date>DateFrom && t.Date.Date<DateTo) {
                    transactionsIncome += t.TotalValue;
                }
            }
            return transactionsIncome;
        }

        public decimal CalculateExpenses(List<Employee> employees, List<Items> items, List<Transaction> transactions, List<TransactionLine> transactionLines) {
            decimal salaryExpenses = 0;
            foreach (Employee e in employees) {
                DateTime dateA = DateFrom;
                DateTime dateB = DateTo;
                if (e.DateStart > DateTo || e.DateEnd < DateFrom) {
                    continue;
                }
                if (e.DateStart > DateFrom)
                    dateA = e.DateStart;
                if (e.DateEnd < DateTo)
                    dateB = e.DateEnd;
                
                double workMonths = (dateB - dateA).Days / 30.0;
                salaryExpenses += e.Salary * (decimal)workMonths;
            }

            decimal itemCostExpenses = 0;
            foreach (Transaction t in transactions) {
                if (t.Date.Date > DateFrom && t.Date.Date < DateTo) {
                    List<TransactionLine> currentLines = transactionLines.FindAll(x => x.TransactionID == t.ID);
                    foreach(TransactionLine l in currentLines) {
                        decimal currentCost = items.Find(x => x.ID == l.ItemID).Cost;
                        itemCostExpenses += currentCost * l.Quantity;
                    }
                }
            }

            int monthsTotal = (int) Math.Ceiling((DateTo - DateFrom).Days / 30.00);
            decimal rent = monthsTotal * RentinCost;
            return salaryExpenses+itemCostExpenses+rent;
        }



    }
}
