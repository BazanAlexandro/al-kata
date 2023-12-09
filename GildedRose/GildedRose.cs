using System.Collections.Generic;
using Strategies;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<IStrategy> _strategies;

    public GildedRose(IList<Item> items)
    {
        _strategies = new List<IStrategy>();

        foreach(var item in items)
        {
            IStrategy strategy;
            switch(item.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    strategy = new LegendaryStrategy(item);
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    strategy = new BackstageStrategy(item);
                    break;
                case "Aged Brie":
                    strategy = new AgingStrategy(item);
                    break;
                case "Conjured Mana Cake":
                    strategy = new ConjuredStrategy(item);
                    break;
                default:
                    strategy = new DefaultStrategy(item);
                    break;
            }

            _strategies.Add(strategy);
        }
    }

    public void UpdateQuality()
    {
        foreach (var strategy in _strategies)
        {
            strategy.UpdateQuality();
            strategy.UpdateSellIn();
        }
    }
}