using AdvantShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvantShop.Data
{
    public class DBObjects
    {

        private static Dictionary<string, Category> category;

        public static void Initial(AppDBContent content)
        {
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Products.Any())
            {
                //content.AddRange(
                //    new Product
                //    {
                //        Img = "/img/forBd/sport/velik.png",
                //        Desc = "Коричневый велосипед",
                //        Stars = 3,
                //        Availiable = false,
                //        Hit = false,
                //        Novelty = false,
                //        Price = 16000,
                //        Category = Categories["Спортивные товары"]
                //    },
                //    new Product
                //    {
                //        Img = "/img/forBd/garden/velik-red.png",
                //        Desc = "Бело-красный велосипед",
                //        Stars = 5,
                //        Availiable = true,
                //        Hit = false,
                //        Novelty = true,
                //        Price = 24000,
                //        Category = Categories["Спортивные товары"]
                //    },
                //    new Product
                //    {
                //        Img = "/img/forBd/garden/myach.png",
                //        Desc = "Футбольный мяч Adidas",
                //        Stars = 5,
                //        Availiable = false,
                //        Hit = true,
                //        Novelty = false,
                //        Price = 900,
                //        Category = Categories["Спортивные товары"]
                //    },
                //    new Product
                //    {
                //        Img = "/img/forBd/cosmetic/radio.png",
                //        Desc = "Радиоприемник Рассвет",
                //        Stars = 2,
                //        Availiable = true,
                //        Hit = false,
                //        Novelty = true,
                //        Price = 450,
                //        Category = Categories["Бытовая техника"]
                //    },
                //    new Product
                //    {
                //        Img = "/img/forBd/tech/micro.png",
                //        Desc = "Микроволновка Hayer",
                //        Stars = 4,
                //        Availiable = false,
                //        Hit = false,
                //        Novelty = false,
                //        Price = 6900,
                //        Category = Categories["Бытовая техника"]
                //    }
                //);
            }
            //content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    //var list = new Category[]
                    //{
                    //    new Category{ Name="Одежда", isFavourite=true},
                    //    new Category{ Name="Мебель", isFavourite=true},
                    //    new Category{ Name="Бытовая техника", isFavourite=true},
                    //    new Category{ Name="Спортивные товары", isFavourite=true},
                    //    new Category{ Name="Косметика", isFavourite=true},
                    //    new Category{ Name="Садовая техника", isFavourite=true},
                    //    new Category{ Name="Сантехника", isFavourite=false},
                    //    new Category{ Name="Строительные материалы", isFavourite=false},
                    //    new Category{ Name="Автотехника", isFavourite=false},
                    //    new Category{ Name="Еда", isFavourite=false},
                    //    new Category{ Name="Разработка сайтов", isFavourite=false},
                    //};
                    //category = new Dictionary<string, Category>();
                    //foreach (Category el in list)
                    //{
                    //    category.Add(el.Name, el);
                    //}
                }
                return category;
            }
        }
    }
}
