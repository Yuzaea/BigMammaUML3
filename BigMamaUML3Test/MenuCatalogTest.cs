using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigMamaUML3Test;
using BigMammaUML3;

namespace BigMamaUML3Test
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //arrange
            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Pizza pi1 = new Pizza(1, "poop", "poopy", 25, MenuType.Pizza, true, true, true);
            Pizza pi2 = new Pizza(2, "poopasa", "poopasdy", 255, MenuType.Pizza, false, false, false);
            Pizza pi3 = new Pizza(3, "poopasa", "poopasdy", 25232325.00, MenuType.Pizza, false, false, false);
            //act
            int ValuveBefore = catalog.Count;
            catalog.Add(pi2);
            catalog.Add(pi1);
            catalog.Add(pi3);
            int ValueAfter = catalog.Count;
            //assert

            Assert.AreEqual(ValuveBefore + 3, ValueAfter);

        }
        [TestMethod]
        public void TestDelete()
        {
            //arange

            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Pizza pi1 = new Pizza(1, "poop", "poopy", 25, MenuType.Pizza, true, true, true);
            Pizza pi2 = new Pizza(2, "poopasa", "poopasdy", 255, MenuType.Pizza, false, false, false);


            //act
            catalog.Add(pi2);
            catalog.Add(pi1);
            int ValuveBefore = catalog.Count;
            catalog.Delete(1);
            int ValueAfter = catalog.Count;



            //assert

            Assert.AreEqual(ValuveBefore - 1, ValueAfter);

        }
        [TestMethod]
        public void TestSearch()
        {
            //arange
            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Pizza pi1 = new Pizza(1, "poop", "poopy", 25, MenuType.Pizza, true, true, true);
            Pizza pi2 = new Pizza(2, "poopasa", "poopasdy", 255, MenuType.Pizza, false, false, false);



            //act



            catalog.Add(pi2);
            catalog.Add(pi1);


            //assert

            Assert.AreEqual(pi1, catalog.Search(1));
            Assert.AreEqual(pi2, catalog.Search(2));

        }
        [TestMethod]
        public void TestSMostExpensiveItem()
        {
            //arange
            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Pizza pi1 = new Pizza(1, "poop", "poopy", 25232, MenuType.Pizza, true, true, true);
            Pizza pi2 = new Pizza(2, "poopasa", "poopasdy", 2, MenuType.Pizza, false, false, false);
            Pizza pi3 = new Pizza(3, "poopasasa", "poopasdawy", 705364565, MenuType.Pizza, false, false, false);
            //act
            catalog.Add(pi2);
            catalog.Add(pi1);
            catalog.Add(pi3);

            //assert

            Assert.AreEqual(pi3.Price, catalog.MostExpensiveMenuItem().Price);



        }
        [TestMethod]
        public void TestPrintBeveragesMenu()
        {
            //arrange 
            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Beverage pi1 = new Beverage(1, "poop", "poopy", 25232, MenuType.Beverage, true, true, true);
            Beverage pi2 = new Beverage(2, "poopasa", "poopasdy", 2, MenuType.Beverage, false, false, false);
            Beverage pi3 = new Beverage(3, "poopasasa", "poopasdawy", 705364565, MenuType.Beverage, true, false, false);

            //act
            catalog.Add(pi2);
            catalog.Add(pi1);
            catalog.Add(pi3);

            //assert


            //Assert.AreEqual(pi1, catalog.PrintBeveragesMenu(pi1));
            //Assert.AreEqual(pi2, catalog.Search(2));

        }
        [TestMethod]
        public void TestFindAllVegan()
        {

            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Beverage pi1 = new Beverage(1, "poop", "poopy", 25232, MenuType.Beverage, true, true, true);
            Beverage pi2 = new Beverage(2, "poopasa", "poopasdy", 2, MenuType.Beverage, false, false, false);
            Beverage pi3 = new Beverage(3, "poopasasa", "poopasdawy", 705364565, MenuType.Beverage, true, false, false);


            catalog.Add(pi2);
            catalog.Add(pi1);
            catalog.Add(pi3);


            Assert.AreEqual(catalog.FindAllVegan(MenuType.Beverage).Count, 2);


        }

        [TestMethod]
        public void TestFindAllIsOrganic()
        {

            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Beverage pi1 = new Beverage(1, "poop", "poopy", 25232, MenuType.Beverage, true, true, true);
            Beverage pi2 = new Beverage(2, "poopasa", "poopasdy", 2, MenuType.Beverage, false, false, false);
            Beverage pi3 = new Beverage(3, "poopasasa", "poopasdawy", 705364565, MenuType.Beverage, true, true, false);


            catalog.Add(pi2);
            catalog.Add(pi1);
            catalog.Add(pi3);



            Assert.AreEqual(catalog.FindAllOrganic(MenuType.Beverage).Count, 2);
        }
        [TestMethod]
        public void TestUpdate()
        {
            //arange
            IMenuCatalog catalog;
            catalog = new MenuCatalog();

            Pizza pi3 = new Pizza(3, "poopasa", "poopasdy", 2, MenuType.Pizza, false, false, false);
            Pizza pi3new = new Pizza(3, "poopasa", "poopasdy", 50, MenuType.Pizza, false, false, false);

            //act

            catalog.Add(pi3);

            catalog.Update(3, pi3new);

            //assert



            Assert.AreEqual(50, catalog.Search(3).Price);


        }

    }
}
