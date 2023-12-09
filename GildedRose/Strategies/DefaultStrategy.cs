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
			var newQuality = GetQuality();

			if (newQuality >= 0 && newQuality <= 50)
			{
				item.Quality = newQuality;
			}
		}

		protected virtual int GetQuality()
		{
            if (item.SellIn >= 0)
            {
                return item.Quality - 1;
            }
            else
            {
                return item.Quality - 2;
            }
        }

		public virtual void UpdateSellIn()
		{
			item.SellIn -= 1;
		}
	}
}
