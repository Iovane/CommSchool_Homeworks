namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        /*int[] numbers = [15, 23, 12, 25, 100];
        var minValue = numbers[0];
        var maxValue = numbers[0];
        
        foreach (var number in numbers)
        {
            minValue = number < minValue ? number : minValue;
            maxValue = number > maxValue ? number : maxValue;
        } 
        
        Console.WriteLine($"Min value: {minValue}");
        Console.WriteLine($"Max value: {maxValue}");*/
        
        Console.WriteLine("Enter a word: ");
        var word = Console.ReadLine();
        
        var count = word!
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
        
        Console.WriteLine("Frequencies:");
        foreach (var item in count)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}