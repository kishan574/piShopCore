using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace piShopCore.Models
{
    public class DbInit
    {
        public static void Seed(AppDbContext Context)
        {
            if (!Context.Pies.Any())
            {
                Context.AddRange
                    (
                new Pie { Name = "Apple Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg" },
                new Pie { Name = "Blueberry Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://cdn-ap-ec.yottaa.net/55b635db0b5344273c002031/d1fd69005c1501336a81123dfe2baf36.yottaa.net/v~4b.480/6655-3-large.jpg?yocs=2u_&yoloc=ap" },
                new Pie { Name = "Cheese cake", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/5/27/0/IGSP01_25282_s4x3.jpg.rend.hgtvcom.826.620.suffix/1485531666198.jpeg" },
                new Pie { Name = "Cherry Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRgI1unfM3AIdseLkW17wFT1JaVkzhoOzm3aEA2lJxhYVxx5E3uqg" },
                new Pie { Name = "Peach Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://assets.epicurious.com/photos/57d70ef7de27564257b657c7/master/pass/peach-pie.jpg" },
                new Pie { Name = "Strawberry Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPhf6Zsp8HhvbdxSUQpXkAHT0JnGSoZHeiw7ZuGnEestIXMaA2" },
                new Pie { Name = "Cranberry Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://mt-backend-familycircle-environment-contentbucket-1qlli1qnqqj9z.s3.amazonaws.com/s3fs-public/styles/398x398/public/2018-09/apple-cranberry-lattice-pie-1074724d.jpg" },
                new Pie { Name = "Pumpkin Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-image.myrecipes.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Fmedium_2x%2Fpublic%2Fimage%2Frecipes%2Fck%2F11%2Fginger-pumpkin-pie-ck-x.jpg%3Fitok%3DSnPfaIF7&w=1000&c=sc&poi=face&q=70" },
                new Pie { Name = "Maple Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://cook.fnr.sndimg.com/content/dam/images/cook/fullset/2016/4/14/0/CCFAM106H_Salted-Maple-Pie_s4x3.jpg.rend.hgtvcom.616.462.suffix/1460671646956.jpeg" },
                new Pie { Name = "Strawberry icecream Pie", Price = 12.95M, ShortDescription = "Lorem ipsum", LongDescription = "Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet.", ImgThumbnaiUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTh-7D-GV9M6sSgnRAv89aZkq0Ifl3KUPuTnxmRyHNUGbWaBaIZ"  }

                    );
                Context.SaveChanges();
                 }
        }
    }
}
