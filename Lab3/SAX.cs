using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab3
{
    public class SAX : IStrategy
    {
        public List<Food> Search(Food food)
        {
            List<Food> AllResult = new List<Food>();
            var XmlReader = new XmlTextReader(@"C:\Users\MainUser\source\repos\Lab3\Lab3\Menu.xml");

            while (XmlReader.Read())
            {
                if (XmlReader.HasAttributes)
                {
                    while (XmlReader.MoveToNextAttribute())
                    {
                        string Dish = "", Cuisine = "", Course = "", Weight = "", Description = "", Price = "";

                        if (XmlReader.Name.Equals("Dish") && (XmlReader.Value.Equals(food.Dish) || food.Dish.Equals(String.Empty)))
                        {
                            Dish = XmlReader.Value;
                            XmlReader.MoveToNextAttribute();

                            if (XmlReader.Name.Equals("Cuisine") && (XmlReader.Value.Equals(food.Cuisine) || food.Cuisine.Equals(String.Empty)))
                            {
                                Cuisine = XmlReader.Value;
                                XmlReader.MoveToNextAttribute();

                                if (XmlReader.Name.Equals("Course") && (XmlReader.Value.Equals(food.Course) || food.Course.Equals(String.Empty)))
                                {
                                    Course = XmlReader.Value;
                                    XmlReader.MoveToNextAttribute();

                                    if (XmlReader.Name.Equals("Weight") && (food.Weight.Equals(String.Empty) || WeightRange(XmlReader.Value, food.Weight)))
                                    {
                                        Weight = XmlReader.Value;
                                        XmlReader.MoveToNextAttribute();

                                        if (XmlReader.Name.Equals("Description") && (XmlReader.Value.Equals(food.Description) || food.Description.Equals(String.Empty)))
                                        {
                                            Description = XmlReader.Value;
                                            XmlReader.MoveToNextAttribute();

                                            if (XmlReader.Name.Equals("Price") && (food.Price.Equals(String.Empty) || PriceRange(XmlReader.Value, food.Price)))
                                                Price = XmlReader.Value;
                                        }
                                    }
                                }
                            }
                        }

                        if (Dish != "" && Cuisine != "" && Course != "" && Weight != "" && Description != "" && Price != "")
                        {
                            Food food1 = new Food();
                            food1.Dish = Dish;
                            food1.Cuisine = Cuisine;
                            food1.Course = Course;
                            food1.Weight = Weight;
                            food1.Description = Description;
                            food1.Price = Price;

                            AllResult.Add(food1);
                        }
                    }



                }
            }
            XmlReader.Close();
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
