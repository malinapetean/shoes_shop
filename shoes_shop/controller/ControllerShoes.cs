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
            shoes.Clear();
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
        public List<Shoes> find()
        {
            return this.shoes;
        }

        public int nextId()
        {
            int nr = shoes.Count;
            return shoes[nr - 1].Id + 1;
        }
        public List<Shoes> sortShoes()
        {
            List<Shoes> alphabet = shoes;
            int sch = 0;
            while (sch == 0)
            {
                sch = 1;
                for (int i = 0; i < alphabet.Count - 1; i++)
                {
                    if (alphabet[i].Brand.CompareTo(alphabet[i + 1].Brand) > 0)
                    {
                        Shoes b = alphabet[i];
                        alphabet[i] = alphabet[i + 1];
                        alphabet[i + 1] = b;
                        sch = 0;
                    }
                }
            }
            return alphabet;
        }

        public bool existence(Shoes s)
        {
            for(int i=0;i<shoes.Count;i++)
            {
                if((shoes[i].Brand.Equals(s.Brand))&&(shoes[i].Type.Equals(s.Type)))
                {
                    return true;
                }
            }
            return false;
        }
        public bool addShoes(Shoes shoe)
        {
            if(existence(shoe)==false)
            {
                this.shoes.Add(shoe);
                return true;
            }
            return false;
        }

        public String toSave()
        {
            String txt = "";
            int nr = shoes.Count;
            int i;
            for( i=0;i<nr-1;i++)
            {
                txt += shoes[i].tosave() + "\n";
            }
            txt += shoes[i].tosave();

            return txt;

        }
        public Shoes getShoeByID(int id)
        {
            foreach(Shoes s in shoes)
            {
                if(s.Id.Equals(id))
                {
                    return s;
                }
            }
            return null;
        }

        public void updateShoes(Shoes shoe)
        {
            foreach(Shoes s in shoes)
            {
                if(s.Id.Equals(shoe.Id))
                {
                    s.Type = shoe.Type;
                    s.Brand = shoe.Brand;
                    s.Description = shoe.Description;
                    s.Price = shoe.Price;
                    s.Size = shoe.Size;
                }
            }
            this.save();
        }
        public void delete(Shoes s)
        {
            for(int i=0;i<shoes.Count;i++)
            {
                if(shoes[i].Id.Equals(s.Id))
                {
                    shoes.RemoveAt(i);
                }
            }
            this.save();
        }
        public void save()
        {
            StreamWriter w = new StreamWriter(@"C:\Users\Ica\source\repos\shoes_shop\shoes_shop\souces\shoes.txt");
            w.Write(this.toSave());
            w.Close();
        }






    }
}
