namespace csharp
{
    /// <summary>
    /// actually increases in Quality the older it gets
    /// </summary>
    public class IncreaseQualityUpdater : IQualityUpdater
    {
        public void Update(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
            item.SellIn--;
        }
    }
}