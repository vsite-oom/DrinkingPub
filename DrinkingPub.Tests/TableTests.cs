using Vsite.Oom.DrinkingPub;

namespace DrinkingPub.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void CreateTableWithTablenumberAndWaiternameProvided()
        {
            int brojStola = 1;
            string imeKonobara = "Šime";
            var stol = new Table(brojStola, imeKonobara);
            Assert.AreEqual(brojStola, stol.table_number);
            Assert.AreEqual(imeKonobara, stol.waiter_name);
        }
        [TestMethod]
        public void CreateTableWithoutTablenumberProvided()
        {
            int brojStola = 0;
            string imeKonobara = "Šime";
            Assert.ThrowsException<ArgumentException>(() => new Table(brojStola, imeKonobara));
        }
        [TestMethod]
        public void CreateTableWithoutWaiternameProvided()
        {
            int brojStola = 1;
            Assert.ThrowsException<ArgumentException>(() => new Table(brojStola, null!));
        }
        [TestMethod]
        public void TakeOrderIsNullThrowsError()
        {
            int brojStola = 1;
            string imeKonobara = "Šime";
            var stol = new Table(brojStola, imeKonobara);
            Assert.ThrowsException<ArgumentNullException>(() => stol.TakeOrder(null!));
        }
        [TestMethod]
        public void TotalToPayPricelistiIsNullThrowsError()
        {
            int brojStola = 1;
            string imeKonobara = "Šime";
            var stol = new Table(brojStola, imeKonobara);
            Assert.ThrowsException<ArgumentNullException>(() => stol.TotalToPay(null!));
        }
        [TestMethod]
        public void TotalToPayWith1ItemReturnsPrice()
        {
            var cjenik = new Pricelist("Kafana");
            cjenik.AddItem("Brlja", 0.75);
            var stol = new Table(1, "Mirko");
            var narudzba = new Order();
            narudzba.AddItem("Brlja", 1);
            stol.TakeOrder(narudzba);

            Assert.AreEqual(0.75, stol.TotalToPay(cjenik));
        }
        [TestMethod]
        public void TotalToPayWithMultipleItemReturnsPrice()
        {
            var cjenik = new Pricelist("Kafana");
            cjenik.AddItem("Brlja", 0.75);
            cjenik.AddItem("Viski", 2.25);
            cjenik.AddItem("Pivo", 1.10);
            var stol = new Table(1, "Mirko");
            var narudzba = new Order();
            narudzba.AddItem("Brlja", 2);
            narudzba.AddItem("Viski", 1);
            narudzba.AddItem("Brlja", 2);
            narudzba.AddItem("Pivo", 3);
            narudzba.AddItem("Pivo", 3);
            stol.TakeOrder(narudzba);

            Assert.AreEqual(11.85, stol.TotalToPay(cjenik));
        }
    }
}