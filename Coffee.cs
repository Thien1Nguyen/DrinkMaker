public class Coffee : Drink
{
    string RoastValue;
    string BeanType;
    public Coffee(string roast, string bean) : base("Coffee", "black", 160, false, 200)
    {   
        RoastValue = roast;
        BeanType = bean;
    }

    public override void ShowDrink(){
        base.ShowDrink();
        Console.WriteLine($"[Roast Value: {RoastValue}], Bean Type: {BeanType}");
        Console.WriteLine();
    }
}