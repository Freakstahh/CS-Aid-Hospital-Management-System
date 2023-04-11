using System;
using NUnit.Framework;
using CS_Aid_Hospital_Management_System;

namespace InventoryTests
{
    [TestFixture]
    public class InventoryTests
    {
        [Test]
        public void TestAddItem()
        {
            //Arrange
            Inventory inventory = new Inventory("Test Inventory");
            Item item = new Item("Test Item", 1);

            //Act
            inventory.addItem(item);

            //Assert
            Assert.Contains(item, inventory.Items);
        }

        [Test]
        public void TestObjectCounter()
        {
            //Arrange
            Item item = new Item("Test Item", 10);
            Inventory inventory = new Inventory("Test Inventory");
            inventory.addItem(item);

            //Act
            int count = inventory.objectCounter(item);

            //Assert
            Assert.AreEqual(count, 10);
        }

        [Test]
        public void TestAddCount()
        {
            //Arrange
            Item item = new Item("Test Item", 10);
            Inventory inventory = new Inventory("Test Inventory");
            inventory.addItem(item);

            //Act
            inventory.addCount(item, 5);

            //Assert
            Assert.AreEqual(item.Count, 15);
        }

        [Test]
        public void TestRemoveCount()
        {
            //Arrange
            Item item = new Item("Test Item", 10);
            Inventory inventory = new Inventory("Test Inventory");
            inventory.addItem(item);

            //Act
            inventory.removeCount(item, 5);

            //Assert
            Assert.AreEqual(item.Count, 5);
        }

        [Test]
        public void TestRemoveItem()
        {
            //Arrange
            Item item = new Item("Test Item", 10);
            Inventory inventory = new Inventory("Test Inventory");
            inventory.addItem(item);

            //Act
            inventory.removeItem(item);

            //Assert
            Assert.IsFalse(inventory.Items.Contains(item));
        }

        [Test]
        public void TestCleanInventory()
        {
            //Arrange
            Item item1 = new Item("Test Item 1", 0);
            Item item2 = new Item("Test Item 2", 10);
            Inventory inventory = new Inventory("Test Inventory");
            inventory.addItem(item1);
            inventory.addItem(item2);

            //Act
            inventory.cleanInventory();

            //Assert
            Assert.IsFalse(inventory.Items.Contains(item1));
            Assert.IsTrue(inventory.Items.Contains(item2));
        }
    }
}
