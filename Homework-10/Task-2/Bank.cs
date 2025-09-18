namespace Homework_10.Task_2;

public class Bank : FinanceOperations
{
    public double CalculateLoanPercent(int month, double AmountPerMonth)
    {
        return month * (int)AmountPerMonth * 1.05;
    }

    public bool CheckUserHistory()
    {
        var random = new Random();
        return random.Next(2) == 1;
    }
}