using GildedRoseKata;
using Strategies;

namespace GildedRose.Strategies
{
	public class LegendaryStrategy: DefaultStrategy
	{
        public LegendaryStrategy(Item item) : base(item)
        { }

        protected override int GetQuality()
        {
            // quality item does not change
            return item.Quality;
        }

        public override void UpdateSellIn() {
            // SellIn does not change
        }
    }
}
