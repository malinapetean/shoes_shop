using FontAwesome.Sharp;
using shoes_shop.controller;
using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    public partial class FrmHome : Form
    {
       
        private ControllerShoes shoes;
        private IconButton btnsort;
        private IconButton btnsort2;
        private IconButton btnadd;
        private IconButton btnType;
        private IconButton btnBrand;
        private IconButton btnSize;
        private IconButton btnOriginalList;
        private ComboBox comboboxType;
        private ComboBox comboboxBrand;
        public FrmHome()
        {
            InitializeComponent();
            this.shoes = new ControllerShoes();

            this.btnadd = new IconButton();
            this.btnadd.Click += new EventHandler(addShoes_Click);

            this.btnsort = new IconButton();
            this.btnsort.Click += new EventHandler(sort_Click);

            this.btnsort2 = new IconButton();
            this.btnsort2.Click += new EventHandler(sort2_Click);

            this.btnType = new IconButton();
            this.btnType.Click += new EventHandler(type_Click);

            this.btnBrand = new IconButton();
            this.btnBrand.Click += new EventHandler(brand_Click);

             this.btnSize = new IconButton();
            this.btnSize.Click += new EventHandler(size_Click);

            this.btnOriginalList = new IconButton();
            this.btnOriginalList.Click += new EventHandler(originalList_Click);

            this.comboboxType = new ComboBox();
            this.comboboxType.SelectedIndexChanged += new EventHandler(combobox_SelectedIndexChanged);

            this.comboboxBrand = new ComboBox();
            this.comboboxBrand.SelectedIndexChanged += new EventHandler(comboboxBrand_SelectedIndexChanged);

            ///Delete Form bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.Controls.Add(new PnlMain(shoes.find(),this));
            this.Controls.Add(new PnlAsside(btnsort, btnsort2,btnadd,btnType,btnBrand,btnSize,btnOriginalList,comboboxType,comboboxBrand, this));
            this.Controls.Add(new PnlHeader());
            this.SuspendLayout();
            this.ResumeLayout(false);
        }


        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
        private void sort_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            List<Shoes> sortedshoes = shoes.sortShoesbyBrand();
            this.Controls.Add(new PnlMain(sortedshoes,this));

        }
        private void sort2_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            List<Shoes> sortedshoes = shoes.sortShoesByPrice();

            this.Controls.Add(new PnlMain(sortedshoes, this));

        }

        private void addShoes_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd")) 
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            this.Controls.Add(new PnlAdd(this));
        }
        private void type_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            List<Shoes> shoesType = shoes.listshoesType("Slapi");
            this.Controls.Add(new PnlMain(shoesType, this));
        }
        private void brand_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            List<Shoes> shoesBrand = shoes.listshoesBrand("Adidas");
            this.Controls.Add(new PnlMain(shoesBrand, this));
        }
        private void size_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            List<Shoes> shoesSize = shoes.listshoesSize(42);
            this.Controls.Add(new PnlMain(shoesSize, this));

        }

        private void originalList_Click(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            this.Controls.Add(new PnlMain(shoes.find(), this));
        }
        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            this.Controls.Add(new PnlMain(shoes.listshoesType(this.comboboxType.Text), this));

        }

        private void comboboxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchPanel("PnlMain"))
                erasePanel("PnlMain");
            if (searchPanel("PnlAdd"))
                erasePanel("PnlAdd");
            if (searchPanel("PnlUpdate"))
                erasePanel("PnlUpdate");
            shoes.load();
            this.Controls.Add(new PnlMain(shoes.listshoesBrand(this.comboboxBrand.Text), this));
        }
        public void erasePanel(String name)
        {
            Control cautat = null;

            foreach (Control aux in this.Controls)
            {
                if (aux.Name.Equals(name))
                {
                    cautat = aux;
                }
            }

            if (cautat != null)
                this.Controls.Remove(cautat);
        }

        public bool searchPanel(String panel)
        {
            Control p = null;
            foreach(Control control in this.Controls)
            {
                if(control.Name.Equals(panel))
                {
                    p = control;
                    return true;
                }
            }
            return false;
        }
    }
}
