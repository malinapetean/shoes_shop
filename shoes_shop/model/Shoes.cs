using System;
using System.Collections.Generic;
using System.Text;

namespace shoes_shop.model
{
    public class Shoes
    {
        private int id;
        private string type = "";
        private string brand = "";
        private int size;
        private int price;
        private string description = "";
        private string picture = "";

        public Shoes (string text)
        {
            this.id = int.Parse(text.Split(",")[0]);
            this.type = text.Split(",")[1];
            this.brand = text.Split(",")[2];
            this.size= int.Parse(text.Split(",")[3]);
            this.price = int.Parse(text.Split(",")[4]);
            this.description = text.Split(",")[5];
            this.picture = text.Split(",")[6];

        }
        public Shoes(int id, string type,string brand, int size, int price,string description,string picture)
        {
            this.id = id;
            this.type = type;
            this.brand = brand;
            this.size =size;
            this.price = price;
            this.description =description;
            this.picture = picture;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Type
        {
            get => this.type;
            set => this.type = value;
        }
        public string Brand
        {
            get => this.brand;
            set => this.brand = value;
        }
        public int Size
        {
            get => this.size;
            set => this.size = value;
        }
        public int Price
        {
            get => this.price;
            set => this.price = value;
        }
        public string Description
        {
            get => this.description;
            set => this.description = value;
        }
        public string Picture
        {
            get => this.picture;
            set => this.picture = value;
        }
        public string display()
        {
            string text = "";
            text += "The id is: " + this.id + "\n";
            text += "The type is: " + this.type + "\n";
            text += "The brand is: " + this.brand + "\n";
            text += "The size is: " + this.size + "\n";
            text += "The price is: " + this.price + "\n";
            text += "The description is: " + this.description + "\n";
            text += "The picture is: " + this.picture + "\n";
            return text;
        }

        public String tosave()
        {
            String txt = "";
            txt += this.id + "," + this.type + "," + this.brand + "," + this.size + "," + this.price + "," + this.description+","+this.picture;
            return txt;
        }
        public Shoes()
        {

        }
    }
}
