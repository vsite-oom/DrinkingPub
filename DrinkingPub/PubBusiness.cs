namespace Vsite.Oom.DrinkingPub
{
    internal class PubBusiness
    {
        static void Main(string[] args)
        {
            // Cjenik artikala
            Pricelist pricelist = new Pricelist("Kod veselog brace");
            // Stavka ima naziv i cijenu
            pricelist.AddItem("Uštrcak, 0.5 l", 1.23);
            pricelist.AddItem("Coca Cola, 0.33 l", 1.5);
            pricelist.AddItem("Ledeni čaj, 0.25 l", 1.75);
            pricelist.AddItem("Vinjak Cezar, 0.02 l", 2.23);
            pricelist.getMenu();
            pricelist.AddItem("Vinjak Cezar, 0.02 l", 2.20);
            pricelist.getMenu();
            pricelist.RemoveItem("Vinjak Cezar, 0.02 l");
            pricelist.getMenu();
            pricelist.RemoveItem("Vinjak Cezar, 0.02 l");
            pricelist.AddItem("Vinjak Cezar, 0.02 l", 2.23);
            pricelist.getMenu();
            //Dodane funkcionalnosti: stavke se mogu izbrisati, ako stavka već postoji promijeniti će cijenu te ispis cijelog menija



            // Svaki stol ima svoj broj i ime konobara koji ga poslužuje
            Table table1 = new Table(1, "Andrej");
            Table table2 = new Table(2, "Zoran");

            // UKreira se narudžba...
            Order order1 = new Order();
            // ... i u nju se dodaju napitci i količina
            order1.AddItem("Coca Cola, 0.33 l", 3);
            order1.AddItem("Uštrcak, 0.5 l", 1);
            order1.getOrder();
            order1.AddItem("Uštrcak, 0.5 l", 4);
            order1.getOrder();
            order1.RemoveItem("Uštrcak, 0.5 l", 5);
            order1.RemoveItem("Coca Cola, 0.33 l", 1);
            order1.getOrder();
            order1.AddItem("Uštrcak, 0.5 l", 4);
            order1.getOrder();
            //Dodane funkcionalnosti: Nadodavanje već postojeće stavke u narudžbu, storniranje stavke te ispis cijele narudžbe


            // Zaprima se narudžba za određeni stol
            table1.TakeOrder(order1);

            Order order2 = new Order();
            order2.AddItem("Vinjak Cezar, 0.02 l", 5);
            table1.TakeOrder(order2);
            table1.getOrder();
            Order order3 = new Order();
            order3.AddItem("Coca Cola, 0.33 l", 1);
            table1.TakeOrder(order3);
            table1.getOrder();


            // Na kraju se izračuna ukupni iznos računa za stol
            double bill1 = table1.TotalToPay(pricelist);
            Console.WriteLine($"Račun za table1: {bill1}");
            double bill2 = table2.TotalToPay(pricelist);
            Console.WriteLine($"Račun za table2: {bill2}");
        }
    }
}
