using BackgroundWorkingWithMVC.Application.Helpers;
using BackgroundWorkingWithMVC.Application.Models;
using System.Collections.Generic;

namespace BackgroundWorkingWithMVC.Application.Caching
{
    public class CategoriesCachingHelper : ICachingHelper<CategoryViewModel>
    {
        public DefaultCacheProvider DefaultCacheProvider { get; private set; }

        public CategoryFakeDataHelper CategoryFakeDataHelper { get; private set; }

        public CategoriesCachingHelper(DefaultCacheProvider defaultCacheProvider, CategoryFakeDataHelper categoryFakeDataHelper)
        {
            DefaultCacheProvider = defaultCacheProvider;
            CategoryFakeDataHelper = categoryFakeDataHelper;
        }

        public List<CategoryViewModel> GetDataFromCache()
        {
            var isSet = DefaultCacheProvider.IsSet(CacheKey);

            if (!isSet)
            {
                DefaultCacheProvider.Set(CacheKey, CategoryFakeDataHelper.GetData(), 1);
            }

            return (List<CategoryViewModel>)DefaultCacheProvider.Get(CacheKey);
        }



        public void SetData(List<CategoryViewModel> data, int time)
        {
            DefaultCacheProvider.Set(CacheKey, data, time);
        }

        public string CacheKey
        {
            get
            {
                return "_categories";
            }
        }
    }
}