var items = new List<int>() { -56, -85, 72, -26, -14, 76, -27, 72, 35, -21, -67, 87, 0, 21, 59, 27, -92, 68 };

foreach (var nums in MultipleOfIndex(items))
{
    Console.WriteLine(nums);
}

return;

List<int> MultipleOfIndex(List<int> xs) => xs.Where((t, i) => t % (i + 1) == 0).ToList();