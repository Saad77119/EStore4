using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Shared
{
    public enum MainCategory
    {
        MensFashion,
        WomensFashion,
        Electronics
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public MainCategory  MainCategory { get; set; }

        public string subCategory { get; set; }

        public int ShopID { get; set; }
        
        public Product(int id, string name, string description,decimal Price, MainCategory mainCategory,string subcategory,int ShopID)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = Price;
            this.MainCategory = mainCategory;
            this.subCategory = subCategory;
            this.ShopID = ShopID;
        }
    }
}
