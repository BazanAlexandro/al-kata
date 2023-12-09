using GildedRoseKata;

namespace Strategies
{
	public class AgingStrategy: DefaultStrategy
	{
		public AgingStrategy(Item item): base(item)
		{}

        protected override int GetQuality()
        {
            return item.Quality += 1;
        }
    }
}

