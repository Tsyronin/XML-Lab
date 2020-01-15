using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;


namespace Lab3
{
    public class DOM : IStrategy
    {
        public List<Food> Search(Food food)
        {
            List<Food> result = new List<Food>();
            XmlDocument info = new XmlDocument();
            info.Load(@"C:\Users\MainUser\source\repos\Lab3\Lab3\Menu.xml");
            XmlNode element = info.DocumentElement;
            foreach (XmlNode node in element.ChildNodes)
            {
                string Dish = "", Cuisine = "", Course = "", Weight = "", Description = "", Price = "";
                foreach (XmlAttribute someatrib in node.Attributes)
                {
                    if (someatrib.Name.Equals("Dish") && (someatrib.Value.Equals(food.Dish) || food.Dish.Equals(String.Empty)))
                        Dish = someatrib.Value;
                    if (someatrib.Name.Equals("Cuisine") && (someatrib.Value.Equals(food.Cuisine) || food.Cuisine.Equals(String.Empty)))
                        Cuisine = someatrib.Value;
                    if (someatrib.Name.Equals("Course") && (someatrib.Value.Equals(food.Course) || food.Course.Equals(String.Empty)))
                        Course = someatrib.Value;
                    if (someatrib.Name.Equals("Weight") && (food.Weight.Equals(String.Empty) || WeightRange(someatrib.Value, food.Weight)))
                        Weight = someatrib.Value;
                    if (someatrib.Name.Equals("Description") && (someatrib.Value.Equals(food.Description) || food.Description.Equals(String.Empty)))
                        Description = someatrib.Value;
                    if (someatrib.Name.Equals("Price") && (food.Price.Equals(String.Empty) || PriceRange(someatrib.Value, food.Price)))
                        Price = someatrib.Value;
                }
                if (Dish != "" && Cuisine != "" && Course != "" && Weight != "" && Description != "" && Price != "")
                {
                    Food myfood = new Food();
                    myfood.Dish = Dish;
                    myfood.Cuisine = Cuisine;
                    myfood.Course = Course;
                    myfood.Weight = Weight;
                    myfood.Description = Description;
                    myfood.Price = Price;

                    result.Add(myfood);
                }
            }
            return result;
        }
        public bool WeightRange(string value, string weight)
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
        public bool PriceRange(string value, string price)
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
