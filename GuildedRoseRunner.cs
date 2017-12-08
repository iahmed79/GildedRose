using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class GuildedRoseRunner
    {
        public static string RunWithInput(IList<Item> items)
        {
            var sb = new StringBuilder();

            sb.AppendLine("OMGHAI!");

            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                sb.AppendLine("-------- day " + i + " --------");
                sb.AppendLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    sb.AppendLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }
                app.UpdateQuality();
            }

            return sb.ToString();
        }
    }
}
