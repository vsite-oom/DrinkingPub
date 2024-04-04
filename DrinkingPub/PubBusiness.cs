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

            // svaki stol ima svoj broj i ime konobara koji ga poslužuje
            Table table1 = new Table(1, "andrej");
            Table table2 = new Table(2, "zoran");

            //// ukreira se narudžba...
            //Order order1 = new Order();
            //// ... i u nju se dodaju napitci i količina
            //order1.additem("coca cola, 0.33 l", 3);
            //order1.additem("uštrcak, 0.5 l", 1);

            ////zaprima se narudžba za određeni stol
            //table1.takeorder(order1);

            //order order2 = new order();
            //order2.additem("vinjak cezar, 0.02 l", 5);
            //table1.takeorder(order2);

            //// Na kraju se izračuna ukupni iznos računa za stol
            //double bill1 = table1.TotalToPay(pricelist);
            //Console.WriteLine($"Račun za table1: {bill1}");
            //double bill2 = table2.TotalToPay(pricelist);
            //Console.WriteLine($"Račun za table2: {bill2}");
        }
    }
}
