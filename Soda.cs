public class Soda : Drink
{
    bool Diet;

    public Soda(bool diet, string name, string color) : base(name, color, 35.7, true, 300)
    {   
        Diet = diet;
    }

    public override void ShowDrink(){
        base.ShowDrink();
        Console.WriteLine($"[Diet?: {Diet}]");
        Console.WriteLine();
    }
}