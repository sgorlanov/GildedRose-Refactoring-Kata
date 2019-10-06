namespace csharp
{
    public interface IQualityUpdater
    {
        /// <summary>
        /// lowers Quality and SellIn values for every item
        /// </summary>
        /// <param name="item"></param>
        void Update(Item item);
    }
}