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

            //act
            int ValuveBefore = catalog.Count;
            catalog.Add(pi1);
            catalog.Add(pi2);
            int ValueAfter = catalog.Count;
            //assert

            Assert.AreEqual(ValuveBefore+2, ValueAfter);

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

            Assert.AreEqual(ValuveBefore-1, ValueAfter);

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

            Assert.AreEqual(pi1 ,catalog.Search(1));
            Assert.AreEqual(pi2, catalog.Search(2));
            
        }
        [TestMethod]
        public void TestSMostExpensiveItem()
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

            Assert.AreEqual(pi2.Price, catalog.MostExpensiveMenuItem().Price);



        }
    }
}