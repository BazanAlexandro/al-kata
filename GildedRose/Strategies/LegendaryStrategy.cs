using GildedRoseKata;

namespace Strategies
{
	public class LegendaryStrategy: DefaultStrategy
	{
        public LegendaryStrategy(Item item) : base(item)
        { }

        protected override int GetQualityDiff()
        {
            // quality item does not change
            return 0;
        }

        public override void UpdateSellIn() {
            // SellIn does not change
        }
    }
}
