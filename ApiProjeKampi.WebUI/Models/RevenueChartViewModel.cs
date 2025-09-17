namespace ApiProjeKampi.WebUI.Models
{
    public class RevenueChartViewModel
    {
        public List<string> Labels { get; set; } = new();
        public List<int> Income { get; set; } = new();
        public List<int> Expense { get; set; } = new();

        // İstersen ileride rezervasyonlardan hesaplanacak ek veriler için
        public int TotalReservations { get; set; }
        public int ApprovedReservations { get; set; }
        public int CanceledReservations { get; set; }
    }
}

/*
public List<string> Labels { get; set; } = new();
public List<int> Income { get; set; } = new();
public List<int> Expense { get; set; } = new();

// Alt kutucuk verileri
public decimal WeeklyEarnings { get; set; }
public decimal MonthlyEarnings { get; set; }
public decimal YearlyEarnings { get; set; }

public int TotalCustomers { get; set; }
public decimal TotalIncome { get; set; }
public int ProjectCompleted { get; set; }
public decimal TotalExpense { get; set; }
public int NewCustomers { get; set; }

*/