using System.Collections.Generic;
using Strategies;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly IList<Item> _items;
    private readonly IList<IStrategy> _strategies;

    public GildedRose(IList<Item> items)
    {
        _strategies = new List<IStrategy>();

        foreach(var item in items)
        {
            IStrategy strategy = item.Name switch
            {
                "Sulfuras, Hand of Ragnaros" => new LegendaryStrategy(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstageStrategy(item),
                "Aged Brie" => new AgingStrategy(item),
                "Conjured Mana Cake" => new ConjuredStrategy(item),
                _ => new DefaultStrategy(item),
            };
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