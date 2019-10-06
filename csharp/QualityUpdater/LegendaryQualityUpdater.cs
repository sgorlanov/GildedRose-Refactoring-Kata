namespace csharp
{
    /// <summary>
    /// never has to be sold or decreases in Quality
    /// </summary>
    public class LegendaryQualityUpdater : IQualityUpdater
    {
        public void Update(Item item)
        {
            if (item.Quality != 80)
            {
                item.Quality = 80;
            }
        }
    }
}