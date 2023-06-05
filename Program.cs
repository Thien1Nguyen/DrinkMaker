// See https://aka.ms/new-console-template for more information
Soda coke = new Soda(false, "Coke", "black");
Coffee duMont = new Coffee("dark", "Columbian");
Wine iDontDrink = new Wine("France", 1990);



List<Drink> AllBeveragest = new List<Drink>();

AllBeveragest.Add(coke);
AllBeveragest.Add(duMont);
AllBeveragest.Add(iDontDrink);


AllBeveragest.ForEach(drink => drink.ShowDrink());

// Soda coffeeSoda = new Coffee("dark", "Columbian");

/*
since class is a type in C# we can't really state that an item that has the Type Soda
and then have a Coffee constructor;
*/