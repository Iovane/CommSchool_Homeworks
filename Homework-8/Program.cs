using System.Text;

namespace Homework_8;

class Program
{
    static void Main()
    {
        Console.WriteLine(Task1(32, 1024, 4));
        Console.WriteLine(Task1(49, 71, 2));
        Console.WriteLine(Task1(2, 27, 4));
        Console.WriteLine(Task1(2, 5, 1));
        Console.WriteLine(Task1(1, 16, 2));

        Console.WriteLine(Task2("AAAABBBB"));

        Console.WriteLine(Task3("multiplication", "subtraction"));

        Task4([1, 2, 3, 4, 5]);
        Task4(["love", "jackpot", "happy"]);
        Task4([true, false, false, true, false, true]);
        
        Task5(123141);
        
        Console.WriteLine(Task6([1, 2, 3, 4]));
        Console.WriteLine(Task6([1, 2, 3, 4, 1]));

    }

    private static double Task1(int a, int b, int n)
    {
        if (n <= 0) throw new ArgumentOutOfRangeException(nameof(n), "n must be positive");

        var root1 = Math.Ceiling(Math.Pow(a, 1.0 / n));
        var root2 = Math.Floor(Math.Pow(b, 1.0 / n)) + 1;

        return root2 - root1;
    }

    private static int Task2(string text)
    {
        var counts = text
            .GroupBy(x => x)
            .Sum(x => x.Count() / 2);

        return counts;
    }

    private static string Task3(string text1, string text2)
    {
        var len1 = text1.Length;
        var len2 = text2.Length;
        var dp = new int[len1 + 1, len2 + 1];
        var longest = 0;
        var endIndex = 0;

        for (var i = 1; i <= len1; i++)
        {
            for (var j = 1; j <= len2; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                    if (dp[i, j] <= longest) continue;
                    longest = dp[i, j];
                    endIndex = i;
                }
                else
                {
                    dp[i, j] = 0;
                }
            }
        }

        return longest > 0 ? text1.Substring(endIndex - longest, longest) : string.Empty;
    }

    private static void Task4<T>(List<T> list)
    {
        switch (list[0].GetType().Name)
        {
            case "Int32":
            {
                var sum = 0;
                list.ForEach(x => sum += int.Parse(x?.ToString() ?? string.Empty));
                Console.WriteLine(sum);

                break;
            }
            case "String":
            {
                list
                    .ForEach(x => Console.WriteLine(x?.ToString()?.ToUpper()));
                break;
            }
            case "Boolean":
            {
                Console.WriteLine(list[0]);
                Console.WriteLine(list.Last());

                if (list.Count % 2 == 0)
                {
                    Console.Write($"{list[list.Count / 2]}, ");
                    Console.WriteLine(list[list.Count / 2 - 1]);
                }
                else
                {
                    Console.WriteLine(list[list.Count / 2]);
                }

                break;
            }
        }
    }

    private static void Task5(int number)
    {
        if (number < 10)
        {
            Console.Write(number);
            return;
        }

        Task5(number / 10);
        Console.Write(" - " + (number % 10));
    }

    private static bool Task6(int[] nums)
    {
        return nums.GroupBy(x => x).Any(x => x.Count() > 1);
    }
    
}