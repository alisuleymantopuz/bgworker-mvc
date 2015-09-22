using BackgroundWorkingWithMVC.Application.Caching;
using BackgroundWorkingWithMVC.Application.Helpers;
using BackgroundWorkingWithMVC.Application.Models;
using System;

namespace BackgroundWorkingWithMVC.Application.BackgroudWorkers.CacheWorkers
{
    public class CategoriesCacheWorker : IWorker<CategoryViewModel>
    {
        public CategoriesCachingHelper CategoriesCachingHelper { get; private set; }

        public CategoryFakeDataHelper CategoryFakeDataHelper { get; private set; }

        public CategoriesCacheWorker(CategoriesCachingHelper categoriesCachingHelper, CategoryFakeDataHelper categoryFakeDataHelper)
        {
            CategoriesCachingHelper = categoriesCachingHelper;
            CategoryFakeDataHelper = categoryFakeDataHelper;
        }

        public void Initialize()
        {

            BackgroundTaskRunner.FireAndForgetTask(() =>
            {
                StartOperation();
            });

        }

        public void StartOperation()
        {
            var data = CategoryFakeDataHelper.GetData();

            CategoriesCachingHelper.SetData(data, 1);

            AddLog("Category list was cached", data.Count);

            CompleteOperation();

            System.Threading.Thread.Sleep(60000);

            Initialize();
        }

        public void CompleteOperation()
        {
            AddLog("Category list caching was completed.");
        }

        public void AddLog(string message = "", int? rowCount = 0)
        {
            Console.WriteLine(string.Format("{0} - {1}", message, rowCount));
        }
    }
}