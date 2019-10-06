namespace csharp
{
    public interface IQualityUpdaterResolver
    {
        /// <summary>
        /// obtains <see cref="IQualityUpdater"/> for certain Item
        /// </summary>
        /// <param name="item"></param>
        /// <returns><see cref="IQualityUpdater"/></returns>
        IQualityUpdater Resolve(Item item);
    }
}
