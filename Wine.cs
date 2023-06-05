public class Wine : Drink
{
    string Origin;
    int Year;
    public Wine(string origin, int year, bool fizz = false) : base("Wine", "Wine red", 40.0, fizz, 400)
    {   
        Origin = origin;
        Year = year;
    }
    public override void ShowDrink(){
        base.ShowDrink();
        Console.WriteLine($"[Origin: {Origin}], Year: {Year}");
        Console.WriteLine();
    }
}