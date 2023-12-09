using GildedRoseKata;

namespace Strategies
{
	public class BackstageStrategy: DefaultStrategy
	{
		public BackstageStrategy(Item item): base(item)
		{}

        protected override int GetQuality()
        {
            if (item.SellIn < 0)
            {
                return 0;
            }
            if (item.SellIn <= 5)
            {
                return item.Quality + 3;
            }
            if (item.SellIn <= 10)
            {
                return item.Quality + 2;
            }

            return item.Quality + 1;
        }
    }
}

