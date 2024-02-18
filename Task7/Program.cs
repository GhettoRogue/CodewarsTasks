var nums = new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

PrintEvenNumbers(nums);

return;

int[] GetEvenNumbers(int[] numbers)
{
    return numbers.Where(n => n % 2 == 0).ToArray();
}

void PrintEvenNumbers(int[] numbers)
{
    foreach (var even in GetEvenNumbers(numbers))
    {
        Console.WriteLine(even);
    }
}