using GildedRoseKata;

namespace Strategies
{
	public class LegendaryStrategy: DefaultStrategy
	{
        public LegendaryStrategy(Item item) : base(item)
        { }

        public override void UpdateQuality()
        {
            // Quality does not change
        }

        public override void UpdateSellIn() {
            // SellIn does not change
        }
    }
}
