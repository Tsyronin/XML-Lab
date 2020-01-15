using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab3
{
    class LINQ : IStrategy
    {
        public List<Food> Search(Food food)
        {
            List<Food> AllResult = new List<Food>();

            var file = XDocument.Load(@"C:\Users\MainUser\source\repos\Lab3\Lab3\Menu.xml");
            var result = from obj in file.Descendants("Food")
                         where ((obj.Attribute("Dish").Value.Equals(food.Dish) || food.Dish.Equals(String.Empty)) &&
                         (obj.Attribute("Cuisine").Value.Equals(food.Cuisine) || food.Cuisine.Equals(String.Empty)) &&
                         (obj.Attribute("Course").Value.Equals(food.Course) || food.Course.Equals(String.Empty)) &&
                         (food.Weight.Equals(String.Empty) || WeightRange(obj.Attribute("Weight").Value, food.Weight)) &&
                         (obj.Attribute("Description").Value.Equals(food.Description) || food.Description.Equals(String.Empty)) &&
                         (food.Price.Equals(String.Empty) || PriceRange(obj.Attribute("Price").Value, food.Price)))
                         select new
                         {
                             Dish = (string)obj.Attribute("Dish"),
                             Cuisine = (string)obj.Attribute("Cuisine"),
                             Course = (string)obj.Attribute("Course"),
                             Weight = (string)obj.Attribute("Weight"),
                             Description = (string)obj.Attribute("Description"),
                             Price = (string)obj.Attribute("Price")
                         };
            foreach (var f in result)
            {
                Food food1 = new Food();
                food1.Dish = f.Dish;
                food1.Cuisine = f.Cuisine;
                food1.Course = f.Course;
                food1.Weight = f.Weight;
                food1.Description = f.Description;
                food1.Price = f.Price;
                AllResult.Add(food1);
            }
            return AllResult;
        }
        private bool WeightRange(string value, string weight)
        {
            int.TryParse(value, out int val);
            if (weight[0] == '<' && val < 300)
                return true;
            else
            {
                if (weight[0] == '>' && val >= 300)
                    return true;
                else { return false; }
            }
        }
        private bool PriceRange(string value, string price)
        {
            int.TryParse(value, out int val);
            if (price[0] == '<' && val < 50)
                return true;
            else
            {
                if (price[0] == '>' && val >= 50)
                    return true;
                else { return false; }
            }
        }
    }
}
