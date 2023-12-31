﻿using GildedRoseKata;

namespace Strategies
{
	public class DefaultStrategy: IStrategy
	{
		protected Item item;

		public DefaultStrategy(Item item)
		{
			this.item = item;
		}

		public virtual void UpdateQuality()
		{
			var diff = GetQualityDiff();
			var newQuality = item.Quality + diff;

			if (newQuality >= 50)
			{
				item.Quality = 50;
			}
			else if (newQuality <= 0)
			{
				item.Quality = 0;
			}
			else
			{
				item.Quality = newQuality;
			}
		}

		protected virtual int GetQualityDiff()
		{
            if (item.SellIn > 0)
            {
                return -1;
            }
            else
            {
                return -2;
            }
        }

		public virtual void UpdateSellIn()
		{
			item.SellIn -= 1;
		}
	}
}
