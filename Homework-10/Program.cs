using Homework_10.Task_2;

namespace Homework_10;

class Program
{
    static void Main(string[] args)
    {
        #region Task 1

        FileWorker file = new File(128, "txt");

        file.Read();
        file.Write();
        file.Edit();
        file.Delete();

        #endregion


        #region Task 2

        var bank = new Bank();
        var microFinance = new MicroFinance();

        if (bank.CheckUserHistory())
        {
            Console.WriteLine(bank.CalculateLoanPercent(12, 10000));
        }

        if (microFinance.CheckUserHistory())
        {
            Console.WriteLine(microFinance.CalculateLoanPercent(12, 10000));
        }

        #endregion
    }
}