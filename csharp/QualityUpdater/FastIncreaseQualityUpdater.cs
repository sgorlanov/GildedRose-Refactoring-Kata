namespace csharp
{
    /// <summary>
    /// increases in Quality as its SellIn value approaches;
    /// Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
    /// Quality drops to 0 after the concert
    /// </summary>
    public class FastIncreaseQualityUpdater : IQualityUpdater
    {
        public void Update(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }

            if (item.SellIn <= 10 && item.Quality < 50)
            {
                item.Quality++;
            }

            if (item.SellIn <= 5 && item.Quality < 50)
            {
                item.Quality++;
            }

            if (item.SellIn <= 0)
                item.Quality = 0;
            item.SellIn--;
        }
    }
}