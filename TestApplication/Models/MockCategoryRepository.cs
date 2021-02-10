using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategory()
        {
            return new List<Category>()
            {
                new Category{CategoryId=1,CategoryName="Action",Description="Action & Adventure", },
                new Category{CategoryId=2,CategoryName="Horror",Description="Horror , Suspense , Fear"},
                new Category{CategoryId=3,CategoryName="Science Fiction",Description="Futuristic and Technologic"},
                new Category{CategoryId=4,CategoryName="Fantasy",Description="Magic and Wonder"},
                new Category{CategoryId=5,CategoryName="Romance",Description="Love Story"},
                new Category{CategoryId=6,CategoryName="Comedy",Description="Laugh feel good humor"}
            };
        }

        public Category GetCategoryById(int idCategory)
        {
            return GetAllCategory().FirstOrDefault(c => c.CategoryId == idCategory);
        }
    }
}
