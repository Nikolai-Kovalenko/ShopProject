using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Reository
{
    public class CategotyRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategotyRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategoris => appDBContent.Category;
    }
}
