using BackgroundWorkingWithMVC.Application.Models;
using System;
using System.Collections.Generic;

namespace BackgroundWorkingWithMVC.Application.Helpers
{
    public class CategoryFakeDataHelper
    {
        public static Random Random { get; private set; }

        public CategoryFakeDataHelper()
        {
            Random = new Random();
        }

        public List<CategoryViewModel> GetData()
        {
            var categories = new List<CategoryViewModel>();

            int count = Random.Next(1, 20);

            for (int i = 0; i < count; i++)
            {
                var c = new CategoryViewModel();
                c.Id = i;
                c.Name = Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
                categories.Add(c);
            }

            return categories;
        }
    }
}