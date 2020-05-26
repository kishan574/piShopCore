using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piShopCore.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie{Id=1, Name="Apple Pie", Price = 12.95M, ShortDescription="Lorem ipsum", LongDescription="Lorem ipsum dolor sit amet", ImgThumbnaiUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg"  },
                new Pie{Id=1, Name="Apple Pie", Price = 12.95M, ShortDescription="Lorem ipsum", LongDescription="Lorem ipsum dolor sit amet", ImgThumbnaiUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg"  },
                new Pie{Id=1, Name="Apple Pie", Price = 12.95M, ShortDescription="Lorem ipsum", LongDescription="Lorem ipsum dolor sit amet", ImgThumbnaiUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg"  },
                new Pie{Id=2, Name="Apple Pie", Price = 12.95M, ShortDescription="Lorem ipsum", LongDescription="Lorem ipsum dolor sit amet", ImgThumbnaiUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg"  },
                new Pie{Id=3, Name="Apple Pie", Price = 12.95M, ShortDescription="Lorem ipsum", LongDescription="Lorem ipsum dolor sit amet", ImgThumbnaiUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg" },
                new Pie{Id=4, Name="Apple Pie", Price = 12.95M, ShortDescription="Lorem ipsum", LongDescription="Lorem ipsum dolor sit amet", ImgThumbnaiUrl="https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg" }
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p=>p.Id == pieId);
        }
    }
}
