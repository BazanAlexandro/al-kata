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
			if (item.SellIn >= 0)
			{
				item.Quality -= 1;
			}
			else
			{
				item.Quality -= 2;
			}
		}

		protected virtual int GetQuality()
		{
			return 0;
		}

		public virtual void UpdateSellIn()
		{
			item.SellIn -= 1;
		}
	}
}
