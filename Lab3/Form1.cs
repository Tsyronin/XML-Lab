using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Lab3
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
            DishBox.Enabled = false;
            CuisineBox.Enabled = false;
            CourseBox.Enabled = false;
            WeightBox.Enabled = false;
            DescriptionBox.Enabled = false;
            PriceBox.Enabled = false;
        }

        public void AllFood()
        {
            XmlDocument info = new XmlDocument();
            info.Load("../../Menu.xml");
            XmlElement element = info.DocumentElement;
            XmlNodeList list = element.SelectNodes("Food");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNode n = list.Item(i);
                AddItem(n);
            }

            WeightBox.Items.Add("<300");
            WeightBox.Items.Add(">300");
            PriceBox.Items.Add("<50");
            PriceBox.Items.Add(">50");
        }

        public void AddItem(XmlNode n)
        {
            if (!DishBox.Items.Contains(n.SelectSingleNode("@Dish").Value))
                DishBox.Items.Add(n.SelectSingleNode("@Dish").Value);
            if (!CourseBox.Items.Contains(n.SelectSingleNode("@Course").Value))
                CourseBox.Items.Add(n.SelectSingleNode("@Course").Value);
            if (!CuisineBox.Items.Contains(n.SelectSingleNode("@Cuisine").Value))
                CuisineBox.Items.Add(n.SelectSingleNode("@Cuisine").Value);
            if (!DescriptionBox.Items.Contains(n.SelectSingleNode("@Description").Value))
                DescriptionBox.Items.Add(n.SelectSingleNode("@Description").Value);
        }

        private void DishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DishCheckBox.Checked == false)
            {
                DishBox.Enabled = false;
            }
            else { DishBox.Enabled = true; }
        }

        private void CuisineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CuisineCheckBox.Checked == false)
            {
                CuisineBox.Enabled = false;
            }
            else { CuisineBox.Enabled = true; }
        }

        private void CourseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CourseCheckBox.Checked == false)
            {
                CourseBox.Enabled = false;
            }
            else { CourseBox.Enabled = true; }
        }

        private void WeightCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WeightCheckBox.Checked == false)
            {
                WeightBox.Enabled = false;
            }
            else { WeightBox.Enabled = true; }
        }

        private void DescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DescriptionCheckBox.Checked == false)
            {
                DescriptionBox.Enabled = false;
            }
            else { DescriptionBox.Enabled = true; }
        }

        private void PriceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PriceCheckBox.Checked == false)
            {
                PriceBox.Enabled = false;
            }
            else { PriceBox.Enabled = true; }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the table?", "Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
                OutputTable.Clear();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchFood();
        }

        public void SearchFood()
        {
            OutputTable.Text = "";
            Food food = new Food();
            food.Dish = "";
            food.Cuisine = "";
            food.Course = "";
            food.Weight = "";
            food.Description = "";
            food.Price = "";

            try {
                if (DishCheckBox.Checked && DishBox.Text != "")
                    food.Dish = DishBox.SelectedItem.ToString();
                if (CuisineCheckBox.Checked && CuisineBox.Text != "")
                    food.Cuisine = CuisineBox.SelectedItem.ToString();
                if (CourseCheckBox.Checked && CourseBox.Text != "")
                    food.Course = CourseBox.SelectedItem.ToString();
                if (WeightCheckBox.Checked && WeightBox.Text != "")
                    food.Weight = WeightBox.SelectedItem.ToString();
                if (DescriptionCheckBox.Checked && DescriptionBox.Text != "")
                    food.Description = DescriptionBox.SelectedItem.ToString();
                if (PriceCheckBox.Checked && PriceBox.Text != "")
                    food.Price = PriceBox.SelectedItem.ToString();
            }
            catch
            {
                food.Dish = "Error"; 
                food.Cuisine = "Error";
                food.Course = "Error";
                food.Weight = "Error";
                food.Description = "Error";
                food.Price = "Error";
            }
            IStrategy strategy = new DOM();
            if (!DOM.Checked && !SAX.Checked && !LINQ.Checked)
            {
                MessageBox.Show("Please select strategy");
                return;
            }
            if (DOM.Checked)
                strategy = new DOM();
            if (SAX.Checked)
                strategy = new SAX();
            if (LINQ.Checked)
                strategy = new LINQ();

            List<Food> foods = strategy.Search(food);

            int i = 0;
            foreach (Food f in foods)
            {
                OutputTable.Text += ++i + ")\n";
                OutputTable.Text += "Dish: " + f.Dish + "\n";
                OutputTable.Text += "Cuisine: " + f.Cuisine + "\n";
                OutputTable.Text += "Course: " + f.Course + "\n";
                OutputTable.Text += "Weight: " + f.Weight + "\n";
                OutputTable.Text += "Description: " + f.Description + "\n";
                OutputTable.Text += "Price: " + f.Price + "\n\n\n";
            }
            }

        private void MenuWindow_Load(object sender, EventArgs e)
        {
            AllFood();
        }

        private void MenuWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tsyronin Pavlo K-25 \n" +
                "Interactive Menu", "Information");
        }

        private void ToHTML_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(@"C:\Users\MainUser\source\repos\Lab3\Lab3\XSLTrasform.xsl");
            string xmlFile = @"C:\Users\MainUser\source\repos\Lab3\Lab3\Menu.xml";
            string htmlFile = @"C:\Users\MainUser\source\repos\Lab3\Lab3\XSLTrasform.html";
            xsl.Transform(xmlFile, htmlFile);
            MessageBox.Show("File Transformed. Please wait...");
            System.Diagnostics.Process.Start(@"C:\Users\MainUser\source\repos\Lab3\Lab3\XSLTrasform.html");
        }
    }
}











/*
var res = (from food in doc.Descendants("food") where food.Attribute("Price").Value >= 30 select new {
 price = (string)food.Attribute("Price"),
 ....
    }).ToList();

    foreach (Food f in res)
            {
                OutputTable.Text += ++i + ")\n";
                OutputTable.Text += "Dish: " + f.Dish + "\n";
                OutputTable.Text += "Cuisine: " + f.Cuisine + "\n";
                OutputTable.Text += "Course: " + f.Course + "\n";
                OutputTable.Text += "Weight: " + f.Weight + "\n";
                OutputTable.Text += "Description: " + f.Description + "\n";
                OutputTable.Text += "Price: " + f.Price + "\n\n\n";
            }
 */
