namespace csharp
{
    /// <summary>
    /// items degrade in Quality twice as fast as normal items
    /// </summary>
    public class FastDegradeQualityUpdater : IQualityUpdater
    {
        public void Update(Item item)
        {
            if (item.Quality >= 2)
            {
                item.Quality -= 2;
            }

            if (item.SellIn <= 0)
            {
                if (item.Quality >= 2)
                {
                    item.Quality -= 2;
                }
            }
            item.SellIn--;
        }
    }
}