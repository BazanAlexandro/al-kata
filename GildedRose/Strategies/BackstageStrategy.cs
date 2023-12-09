using GildedRoseKata;

namespace Strategies
{
	public class BackstageStrategy: DefaultStrategy
	{
		public BackstageStrategy(Item item): base(item)
		{}

        protected override int GetQualityDiff()
        {
            if (item.SellIn <= 0)
            {
                return -item.Quality;
            }
            if (item.SellIn <= 5)
            {
                return 3;
            }
            if (item.SellIn <= 10)
            {
                return 2;
            }

            return 1;
        }
    }
}

