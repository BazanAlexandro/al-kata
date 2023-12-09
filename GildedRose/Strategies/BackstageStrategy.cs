using GildedRoseKata;

namespace Strategies
{
	public class BackstageStrategy: DefaultStrategy
	{
		public BackstageStrategy(Item item): base(item)
		{}

        protected override int GetQuality()
        {
            return 0;
        }
    }
}

