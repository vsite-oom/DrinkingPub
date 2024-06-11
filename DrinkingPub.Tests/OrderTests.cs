using Vsite.Oom.DrinkingPub;

namespace DrinkingPub.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void CreateOrderWithNameAndQuantityProvided()
        {
            var narudzba = new Order();
            string imeProizvoda = "Šljiva";
            int brojKomada = 2;
            narudzba.AddItem(imeProizvoda, brojKomada);
            Assert.AreEqual(brojKomada, narudzba.Items[imeProizvoda]);
        }
        [TestMethod]
        public void CreateOrderWithoutNameProvided()
        {
            var narudzba = new Order();
            string imeProizvoda = "";
            int brojKomada = 2;
            Assert.ThrowsException<ArgumentException>(() => narudzba.AddItem(imeProizvoda, brojKomada));
        }
        [TestMethod]
        public void CreateOrderWithoutQuantityProvided()
        {
            var narudzba = new Order();
            string imeProizvoda = "Loza";
            int brojKomada = 0;
            Assert.ThrowsException<ArgumentException>(() => narudzba.AddItem(imeProizvoda, brojKomada));

        }
        [TestMethod]
        public void CreateOrderAddItemsAndAddMoreOfSameItems()
        {
            var narudzba = new Order();
            string imeProizvoda = "Šljiva";
            int brojKomada = 2;
            narudzba.AddItem(imeProizvoda, brojKomada);
            int brojDodatnihKomada = 4;
            narudzba.AddItem(imeProizvoda, brojDodatnihKomada);
            Assert.AreEqual(brojKomada + brojDodatnihKomada, narudzba.Items[imeProizvoda]);
        }
    }
}