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
            ///Delete Form bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.Controls.Add(new PnlMain(shoes.find(),this));
            this.Controls.Add(new PnlAsside(btnsort, btnsort2,btnadd,this));
            this.Controls.Add(new PnlHeader());
            this.SuspendLayout();
            this.ResumeLayout(false);
        }


        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
        private void sort_Click(object sender, EventArgs e)
        {
            erasePanel("PnlMain");
            shoes.load();
            List<Shoes> sortedshoes = shoes.sortShoesbyBrand();
            this.Controls.Add(new PnlMain(sortedshoes,this));

        }
        private void sort2_Click(object sender, EventArgs e)
        {
            erasePanel("PnlMain");
            shoes.load();
            List<Shoes> sortedshoes = shoes.sortShoesByPrice();
            this.Controls.Add(new PnlMain(sortedshoes, this));

        }

        private void addShoes_Click(object sender, EventArgs e)
        {
            erasePanel("PnlMain");
            this.Controls.Add(new PnlAdd(this));
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
    }
}
