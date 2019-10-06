namespace csharp
{
    /// <summary>
    /// Default resolver based on item's name
    /// </summary>
    public class QualityUpdaterResolver : IQualityUpdaterResolver
    {
        public IQualityUpdater Resolve(Item item)
        {
            if (item.Name.Contains("Aged Brie"))
                return new IncreaseQualityUpdater();
            if (item.Name.Contains("Sulfuras"))
                return new LegendaryQualityUpdater();
            if (item.Name.Contains("Backstage passes"))
                return new FastIncreaseQualityUpdater();
            if (item.Name.Contains("Conjured"))
                return new FastDegradeQualityUpdater();

            return new QualityUpdater();
        }
    }
}