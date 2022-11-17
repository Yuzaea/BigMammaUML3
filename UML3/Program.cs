using BigMammaUML3;






IMenuCatalog catalog;
catalog = new MenuCatalog();

//Pizza pi1 = new Pizza(1, "poop", "poopy", 25, MenuType.Pizza, true, true, true);
//Pizza pi2 = new Pizza(2, "poopasa", "poopasdy", 255, MenuType.Pizza, false, false, false);
//Pizza pi3 = new Pizza(3, "poopasa", "poopasdy", 25232325, MenuType.Pizza, false, false, false);
////act
//catalog.Add(pi2);
//catalog.Add(pi1);
//catalog.Add(pi3);

////List<IMenuItem> veganItems=catalog.FindAllVegan(MenuType.Pizza);
////foreach (IMenuItem veganItem in veganItems)
////{
////    Console.WriteLine(veganItem.PrintInfo);
////}

////Console.WriteLine(pi2);

////Console.WriteLine(pi1);


Beverage b1 = new Beverage(4, "poop", "poopy", 25232, MenuType.Beverage, true, true, true);
Beverage b2 = new Beverage(5, "poopasa", "poopasdy", 2, MenuType.Beverage, false, false, false);
Beverage b3 = new Beverage(6, "poopasasa", "poopasdawy", 705364565, MenuType.Beverage, false, false, false);

//act
catalog.Add(b1);
catalog.Add(b2);
catalog.Add(b3);




//catalog.PrintBeveragesMenu();

Beverage b2new = new Beverage(5, "poopasa", "poopasdy super", 2, MenuType.Beverage, false, true, false);
catalog.Update(5, b2new);

//catalog.PrintBeveragesMenu();
b2new.PrintInfo();
b2.PrintInfo();
Console.WriteLine(b2.PrintInfo());
Console.WriteLine(b2new.PrintInfo());