using GildedRoseKata;

namespace Strategies
{
	public class ConjuredStrategy: DefaultStrategy
	{
		public ConjuredStrategy(Item item): base(item)
		{}

        protected override int GetQualityDiff()
        {
            return base.GetQualityDiff() * 2;
        }
    }
}

