using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.Oom.DrinkingPub.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void ConstructorCreatesTableWithNumberAndNameOfWaiterProvided()
        {
            Table table1 = new Table(1, "Andrej");
        }

        [TestMethod]
        public void TableTakes1Order()
        {
            // Cjenik artikala
            Pricelist pricelist = new Pricelist("Kod veselog brace");
            // Stavka ima naziv i cijenu
            pricelist.AddItem("Uštrcak, 0.5 l", 1.23);
            pricelist.AddItem("Coca Cola, 0.33 l", 1.5);
            pricelist.AddItem("Ledeni čaj, 0.25 l", 1.75);
            pricelist.AddItem("Vinjak Cezar, 0.02 l", 2.23);

            // Svaki stol ima svoj broj i ime konobara koji ga poslužuje
            Table table1 = new Table(1, "Andrej");
            Table table2 = new Table(2, "Zoran");

            // UKreira se narudžba...
            Order order1 = new Order();
            // ... i u nju se dodaju napitci i količina
            order1.AddItem("Coca Cola, 0.33 l", 3);
            order1.AddItem("Uštrcak, 0.5 l", 1);

            // Zaprima se narudžba za određeni stol
            table1.TakeOrder(order1);

            Assert.AreEqual(1, table1.Orders.Count);
        }

        [TestMethod]
        public void TableTakes2Orders()
        {
            Pricelist pricelist = new Pricelist("Kod veselog brace");

            pricelist.AddItem("Uštrcak, 0.5 l", 1.23);
            pricelist.AddItem("Coca Cola, 0.33 l", 1.5);
            pricelist.AddItem("Ledeni čaj, 0.25 l", 1.75);
            pricelist.AddItem("Vinjak Cezar, 0.02 l", 2.23);

            Table table1 = new Table(1, "Andrej");
            Table table2 = new Table(2, "Zoran");

            // UKreira se narudžba...
            Order order1 = new Order();
            // ... i u nju se dodaju napitci i količina
            order1.AddItem("Coca Cola, 0.33 l", 3);
            order1.AddItem("Uštrcak, 0.5 l", 1);

            // Zaprima se narudžba za određeni stol
            table1.TakeOrder(order1);

            Order order2 = new Order();
            order2.AddItem("Vinjak Cezar, 0.02 l", 5);
            table1.TakeOrder(order2);

            Assert.AreEqual(2, table1.Orders.Count);
        }

        [TestMethod]
        public void TableCalculatesTotalToPay()
        {
            // Cjenik artikala
            Pricelist pricelist = new Pricelist("Kod veselog brace");
            // Stavka ima naziv i cijenu
            pricelist.AddItem("Uštrcak, 0.5 l", 1.23);
            pricelist.AddItem("Coca Cola, 0.33 l", 1.5);
            pricelist.AddItem("Ledeni čaj, 0.25 l", 1.75);
            pricelist.AddItem("Vinjak Cezar, 0.02 l", 2.23);

            // Svaki stol ima svoj broj i ime konobara koji ga poslužuje
            Table table1 = new Table(1, "Andrej");
            Table table2 = new Table(2, "Zoran");

            // UKreira se narudžba...
            Order order1 = new Order();
            // ... i u nju se dodaju napitci i količina
            order1.AddItem("Coca Cola, 0.33 l", 3);
            order1.AddItem("Uštrcak, 0.5 l", 1);

            // Zaprima se narudžba za određeni stol
            table1.TakeOrder(order1);

            Order order2 = new Order();
            order2.AddItem("Vinjak Cezar, 0.02 l", 5);
            table1.TakeOrder(order2);

            //Na kraju se izračuna ukupni iznos računa za stol
            double bill1 = table1.TotalToPay(pricelist);
            Console.WriteLine($"Račun za table1: {bill1}");
            double bill2 = table2.TotalToPay(pricelist);
            Console.WriteLine($"Račun za table2: {bill2}");

            Assert.AreEqual(16.88, Math.Round(bill1, 2));
            Assert.AreEqual(0, bill2);
        }
    }
}