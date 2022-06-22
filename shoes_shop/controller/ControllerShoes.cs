using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace shoes_shop.controller
{
    public class ControllerShoes
    {
        private List<Shoes> shoes;
        private Shoes shoe;

        public ControllerShoes()
        {
            shoe = new Shoes();
            shoes = new List<Shoes>();
            this.load();
        }
        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\Ica\source\repos\shoes_shop\shoes_shop\souces\shoes.txt");
            string text = "";
            while ((text = read.ReadLine()) != null)
            {
                this.shoes.Add(new Shoes(text));
            }
            read.Close();

        }
        public void display()
        {
            foreach(Shoes s in shoes)
            {
                Console.WriteLine(s.display());
            }
        }

    }
}
