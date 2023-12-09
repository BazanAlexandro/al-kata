using GildedRoseKata;

namespace Strategies
{
	public class AgingStrategy: DefaultStrategy
	{
		public AgingStrategy(Item item): base(item)
		{}

        protected override int GetQualityDiff()
        {
            return 1;
        }
    }
}

