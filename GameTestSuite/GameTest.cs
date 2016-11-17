using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleGame;
namespace GameTestSuite
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void PlayerCanStartGame()
        {
            Player p1 = new Player();
            Player p2 = new Player(User);

            Game game = new Game();
            Assert.AreEqual("","");
        }


        [TestMethod]
        public void CanCreateItem()
        {
            Item i1 = new Item("Name",);
        }

        [TestMethod]
        public void CanAddItemToInventory()
        {
            Player p = new Player();


        }


        [TestMethod]
        public void CanPurchaseItem()
        {
            Item i1 = new Item("Name",);
        }

        [TestMethod]
        public void PlayerCanBuyCharacterFromShop()
        {
            List<Item> n
            Item i1 = 

            Shop s = new Shop(List<Item>);


            Game game = new Game();

        }

        [TestMethod]
        public void PlayerCanViewCharacter()
        {
            Character c = new Character();

            Assert.AreEqual("","");

        }
    }
}
