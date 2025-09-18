namespace Homework_10.Task_2;

public interface FinanceOperations
{
    double CalculateLoanPercent(int month, double AmountPerMonth);
    bool CheckUserHistory();
}