namespace Homework6;

class Program
{
    static void Main()
    {
        #region Task 1

         Console.WriteLine("Enter size of array: ");
         var n = int.Parse(Console.ReadLine()!);
         var numbers = new int[n];

         for (var i = 0; i < n; i++)
         {
             numbers[i] = int.Parse(Console.ReadLine()!);
         }

         var oddNumbers = new int[n];
         var oddNumbersCount = 0;

         var evenNumbers = new int[n];
         var evenNumbersCount = 0;

         foreach (var number in numbers)
         {
             if (number % 2 == 0)
             {
                 evenNumbers[evenNumbersCount++] = number;
             }
             else
             {
                 oddNumbers[oddNumbersCount++] = number;
             }
         }

         Console.Write("Odd numbers: ");
         foreach (var oddNumber in oddNumbers)
         {
             if (oddNumber != 0) Console.Write($"{oddNumber} ");
         }
         
         Console.WriteLine();
         Console.Write("Even numbers: ");
         foreach (var evenNumber in evenNumbers)
         {
             if (evenNumber != 0) Console.Write($"{evenNumber} ");
         }
        
        #endregion

        #region Task 2

        Dictionary<string, int> contactsDictionary = new Dictionary<string, int>();
        Console.WriteLine("Enter Operation Type For Contacts: 1 - Add, 2 - Delete, 3 - Edit Contact, 4 - Get Contact, 0 - Exit:");
        var operation = int.Parse(Console.ReadLine()!);

        while (operation != 0)
        {
            switch (operation)
            {
                case 1:
                {
                    Console.WriteLine("Enter Contact Name And Phone Number:");
                    contactsDictionary.Add(Console.ReadLine()!, int.Parse(Console.ReadLine()!));
                    operation = 5;
                    
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Enter Contact Name To Delete:");
                    contactsDictionary.Remove(Console.ReadLine()!);
                    operation = 5;
                    
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Enter Name Of Contact To Edit:");
                    var key = Console.ReadLine()!;
                    
                    Console.WriteLine("Enter New Phone Number:");
                    var value = int.Parse(Console.ReadLine()!);
                    
                    contactsDictionary[key] = value;
                    
                    operation = 5;
                    
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Enter Name Of Contact To Get:");
                    var key = Console.ReadLine()!;
                    
                    Console.WriteLine("Phone Number:");
                    Console.WriteLine(contactsDictionary[key]);
                    
                    operation = 5;
                    
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Enter Operation Type For Contacts: 1 - Add, 2 - Delete, 3 - Edit Contact, 4 - Get Contact, 0 - Exit:");
                    operation = int.Parse(Console.ReadLine()!);
                    
                    break;
                }
            }
        }

        #endregion
        
        #region Task 3
        
        Console.WriteLine("Enter size of array: ");
        var n2 = int.Parse(Console.ReadLine()!);
        var numbers2 = new int[n2];

        for (var i = 0; i < n2; i++)
        {
            numbers2[i] = int.Parse(Console.ReadLine()!);
        }

        numbers2
            .GroupBy(x => x)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Key} appears {x.Count()} times in the array. sum is {x.Sum()}"));;
        
        #endregion
        
        #region Task 4
        
        int[] scores = [100, 13, 32, 4, 32, 1, 32, 34];
        
        Console.WriteLine("Enter number of top contestants to get: ");
        var n3 = int.Parse(Console.ReadLine()!);

        scores
            .OrderByDescending(x => x)
            .Take(n3)
            .ToList()
            .ForEach(x => Console.Write($"{x} "));

        #endregion
    }
}