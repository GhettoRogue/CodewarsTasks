Console.WriteLine($"Number of digit is: {Digits(03456)}");
Console.WriteLine($"Number of digit is: {Digits(34567)}");
Console.WriteLine($"Number of digit is: {Digits(345678)}");

return;

static int Digits(ulong n)
{
    var myStr = Convert.ToString(n);
    return  myStr.Length;
    
    /*var count = 0;
    while (n != 0)
    {
        n /= 10;
        count++;
    }
    return count;*/
}