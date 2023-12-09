using GildedRoseKata;

namespace Strategies
{
	public class DefaultStrategy
	{
		protected Item item;

		public DefaultStrategy(Item item)
		{
			this.item = item;
		}

		public void UpdateQuality()
		{

		}

		protected virtual int GetQuality()
		{
			return 0;
		}

		public virtual void UpdateSellIn()
		{}
	}
}

