namespace Homework_7;

class Program
{
    static void Main()
    {
        /*#region Task 1

        Console.WriteLine("Enter Radius For Circle:");
        var radius = int.Parse(Console.ReadLine()!);

        if (radius > 0)
        {
            var bigArea = Math.Pow(2 * radius, 2);
            var smallArea = Math.Pow(2 * radius, 2) / 2;
            
            Console.WriteLine($"Difference between big and small areas is {bigArea - smallArea}");
        }
        else Console.WriteLine("Radius must be positive");
            
        #endregion*/

        /*#region Task 2

        Console.WriteLine("Enter Length Of Sequence:");
        var length = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Enter Sequence:");
        var sequence = new List<string>();

        for (int i = 0; i < length; i++)
        {
            sequence.Add(Console.ReadLine()!);
        }

        var allSame = sequence.Distinct().Count() == 1;

        Console.WriteLine(allSame ? "Yes" : "No");

        #endregion*/
        
        /*#region Task 3

        var win = 3;
        
        Console.WriteLine("Enter Match results");
        Console.Write("Win:");
        var won = int.Parse(Console.ReadLine()!);
        
        Console.Write("Draw:");
        var drawn = int.Parse(Console.ReadLine()!);
        
        Console.Write("Lose:");
        var lost = int.Parse(Console.ReadLine()!);
        
        var sum = won * win + drawn;
        Console.WriteLine($"Sum of points is {sum}");

        #endregion*/
        
        /*
        #region Task 4
        
        Console.WriteLine("Enter hours worked in a week:");
        var salaryInWeek = 0;
        var salaryPerHour = 10;
        var overTimeSalary = 5;
        

        for (var i = 0; i < 7; i++)
        {
            switch (i)
            {
                case 0:
                {
                    Console.Write("Monday:");
                    var monday = int.Parse(Console.ReadLine()!);
                    
                    if (monday > 8) salaryInWeek += salaryPerHour + (monday - 8) * overTimeSalary;
                    else salaryInWeek += monday * salaryPerHour;
                    
                    break;
                }
                case 1:
                {
                    Console.Write("Tuesday:");
                    var tuesday = int.Parse(Console.ReadLine()!);
                    
                    if (tuesday > 8) salaryInWeek += salaryPerHour + (tuesday - 8) * overTimeSalary;
                    else salaryInWeek += tuesday * salaryPerHour;
                    
                    break;
                }
                case 2:
                {
                    Console.Write("Wednesday:");
                    var wednesday = int.Parse(Console.ReadLine()!);
                    
                    if (wednesday > 8) salaryInWeek += salaryPerHour + (wednesday - 8) * overTimeSalary;
                    else salaryInWeek += wednesday * salaryPerHour;
                    
                    break;
                }
                case 3:
                {
                    Console.Write("Thursday:");
                    var thursday = int.Parse(Console.ReadLine()!);
                    
                    if (thursday > 8) salaryInWeek += salaryPerHour + (thursday - 8) * overTimeSalary;
                    else salaryInWeek += thursday * salaryPerHour;
                    
                    break;
                }
                case 4:
                {
                    Console.Write("Friday:");
                    var friday = int.Parse(Console.ReadLine()!);
                    
                    if (friday > 8) salaryInWeek += salaryPerHour + (friday - 8) * overTimeSalary;
                    else salaryInWeek += friday * salaryPerHour;
                    
                    break;
                }
                case 5:
                {
                    Console.Write("Saturday:");
                    var saturday = int.Parse(Console.ReadLine()!);
                    
                    salaryInWeek += 2 * saturday * salaryPerHour;
                    
                    break;
                }
                case 6:
                {
                    Console.Write("Sunday:");
                    var sunday = int.Parse(Console.ReadLine()!);
                    
                    salaryInWeek += 2 * sunday * salaryPerHour;
                    
                    break;
                }
            }
        }
        
        Console.WriteLine($"Salary in week {salaryInWeek}");
        
        #endregion
    */
        
        /*#region Task 5
        
        int[] workoutHours = [1, 5, 6, 10, 11, 12];
        
        var satisfying = new List<int>();
        
        for (var i = 1; i < workoutHours.Length; i++)
        {
            if (workoutHours[i] - workoutHours[i - 1] == 1)
            {
                satisfying.Add(workoutHours[i - 1]);
                satisfying.Add(workoutHours[i]);
            }
        }
        
        Console.WriteLine($"Progress: {satisfying.Distinct().Count()}");
        
        #endregion*/

        #region Task 6

        string[] words = ["Hello", "World", "Programming", "communication"];
        Console.WriteLine("Enter lenght of words to print:");
        var length = int.Parse(Console.ReadLine()!);
        
        words
            .Where(x => x.Length == length)
            .ToList()
            .ForEach(Console.WriteLine);
        
        #endregion
    }
}