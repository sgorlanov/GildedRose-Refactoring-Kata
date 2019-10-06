using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private IList<Item> _items;
        private readonly IQualityUpdaterResolver _qualityUpdaterResolver;

        public GildedRose(IList<Item> items, IQualityUpdaterResolver qualityUpdaterResolver)
        {
            _items = items;
            _qualityUpdaterResolver = qualityUpdaterResolver;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var qualityUpdater = _qualityUpdaterResolver.Resolve(item);

                qualityUpdater.Update(item);
            }
        }
    }
}
