using BigMammaUML3;






IMenuCatalog catalog;
catalog = new MenuCatalog();

Pizza pi1 = new Pizza(1,"poop","poopy",25,MenuType.Pizza,true,true,true);


//SoftDrink s1 = new SoftDrink(3, "øl", "smager af lort", 20, MenuType.Beverage, true, true, "");
Console.WriteLine($"for add{catalog.Count}");
catalog.Add(pi1);
Console.WriteLine($"efter add{catalog.Count}");
Pizza pi2 = new Pizza(2, "poopasa", "poopasdy", 255, MenuType.Pizza, false, false, false);
catalog.Add(pi2);
Console.WriteLine($"efter add{catalog.Count}");

//List<IMenuItem> veganItems=catalog.FindAllVegan(MenuType.Pizza);
//foreach (IMenuItem veganItem in veganItems)
//{
//    Console.WriteLine(veganItem.PrintInfo);
//}

//Console.WriteLine(pi2);

//Console.WriteLine(pi1);


Console.WriteLine(catalog.Search(1).PrintInfo());   
Console.WriteLine(catalog.Search(number: 2));



Console.WriteLine(catalog.MostExpensiveMenuItem().PrintInfo);