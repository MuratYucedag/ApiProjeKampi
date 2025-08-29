using ApiProjeKampi.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.ViewComponents.DashboardViewComponents
{
    public class _DashboardMainChartComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var vm = new RevenueChartViewModel
            {
                Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun" },
                Income = new List<int> { 5, 15, 14, 36, 32, 32 },
                Expense = new List<int> { 7, 11, 30, 18, 25, 13 },
                WeeklyEarnings = 675,
                MonthlyEarnings = 1587,
                YearlyEarnings = 45965,
                TotalCustomers = 8257,
                TotalIncome = 9857,
                ProjectCompleted = 28,
                TotalExpense = 6287,
                NewCustomers = 684
            };

            return View(vm);
        }
    }
}
