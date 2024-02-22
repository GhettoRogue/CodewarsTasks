Console.Clear();
Console.WriteLine(GetDrinkByProfession("programmer"));
Console.WriteLine(GetDrinkByProfession("politician"));
Console.WriteLine(GetDrinkByProfession("bike gang member"));
Console.WriteLine(GetDrinkByProfession("other"));

return;

string GetDrinkByProfession(string p)
{
    return p.ToLower() switch
    {
        "jabroni" => "Patron Tequila",
        "school counselor" => "Anything with Alcohol",
        "programmer" => "Hipster Craft Beer",
        "bike gang member" => "Moonshine",
        "politician" => "Your tax dollars",
        "rapper" => "Cristal",
        _ => "Beer"
    };
}