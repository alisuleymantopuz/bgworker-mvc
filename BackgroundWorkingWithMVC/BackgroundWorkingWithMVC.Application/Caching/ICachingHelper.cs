using System.Collections.Generic;

namespace BackgroundWorkingWithMVC.Application.Caching
{
    public interface ICachingHelper<T>
    {
        List<T> GetDataFromCache();

        void SetData(List<T> data, int time);

        string CacheKey { get; }
    }
}