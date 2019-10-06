namespace csharp
{
    public class QualityUpdater : IQualityUpdater
    {
        public void Update(Item item) 
        {
            if (item.Quality >= 1)
            {
                item.Quality--;
            }

            if (item.SellIn <= 0)
            {
                if (item.Quality >= 1)
                {
                    item.Quality--;
                }
            }
        }
    }
}
