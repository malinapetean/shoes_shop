using shoes_shop.controller;
using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using System.Windows.Forms;

namespace view
{
    class PnlShoeCard:Panel
    {
        private Shoes shoe;
        private PictureBox picture;
        private Label brand;
        private TextBox description;
        private ControllerShoes control;
       
        private FrmHome form;

        public PnlShoeCard(Shoes shoe,FrmHome form)
        {
            this.shoe = shoe;
            this.Name = "shoeCard";
            this.form = form;
            this.Height = 220;
            this.Width = 215;
            this.BackColor = Color.SteelBlue;
            control = new ControllerShoes();

            picture = new PictureBox();
            picture.Location = new Point(18, 20);
            picture.Height = 185;
            picture.Width = 120;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Size = new Size(185, 120);
            picture.Image = Image.FromFile(Application.StartupPath + @"/imagini/" + this.shoe.Picture+".jpg");
            this.Controls.Add(picture);

            brand = new Label();
            brand.Location = new Point(85, 145);
            brand.Height = 25;
            brand.Width = 100;
            brand.Text = shoe.Brand;
            brand.ForeColor = Color.Black;
            this.Controls.Add(brand);

            description = new TextBox();
            description.Location = new Point(30, 170);
            description.Height = 40;
            description.Width = 155;
            description.Multiline = true;
            description.Enabled = false;
            description.Text = shoe.Description;
            this.Controls.Add(description);

            this.picture.Click += new EventHandler(shoe_Click);
        }

        private void shoe_Click(object sender, EventArgs e)
        {
            this.form.erasePanel ("PnlMain");
            this.form.Controls.Add(new PnlUpdate(form,control.getShoeByID(shoe.Id)));
        }
    }
}
