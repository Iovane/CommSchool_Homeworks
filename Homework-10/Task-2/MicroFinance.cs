namespace Homework_10.Task_2;

public class MicroFinance : FinanceOperations
{
    public double CalculateLoanPercent(int month, double AmountPerMonth)
    {
        return month * (int)AmountPerMonth * 1.1 + month * 4;
    }

    public bool CheckUserHistory()
    {
        return true;
    }
}