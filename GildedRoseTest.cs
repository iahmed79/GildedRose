using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using GuildedRoseCsharp;

namespace GildedRose
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void RunTheRunner()
        {
            var items = new List<Item>
            {
                new Item { Name = "Butter", SellIn = 10, Quality = 40 },
                new Item { Name = "Aged Brie", SellIn = 25, Quality = 10 },
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 25, Quality = 40 },
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 40 },
            };

            var result = GuildedRoseRunner.RunWithInput(items);
            File.WriteAllText(@"H:\GildedRoseOutput.txt", result);

            Assert.AreEqual(GildedRoseOutput.AllItemsOutput, result);
        }
    }
}