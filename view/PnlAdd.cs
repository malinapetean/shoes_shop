using shoes_shop.controller;
using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlAdd:Panel
    {
        private Label newShoe;
        private Label brand;
        private Label type;
        private Label size;
        private Label price;
        private Label id;
        private Label description;
        private TextBox txtBrand;
        private TextBox txtType;
        private TextBox txtPrice;
        private TextBox txtSize;
        private TextBox txtId;
        private TextBox txtDescription;
        private Button add;
        private Button cancel;
        private Shoes shoe;
        private ControllerShoes shoes;
        private List<Shoes> listShoes;

        private FrmHome form;

        public PnlAdd(FrmHome form)
        {
            this.form = form;
            shoes = new ControllerShoes();
            listShoes = new List<Shoes>();
            
           

            this.Width = 773;
            this.Height = 490;
            this.Location = new System.Drawing.Point(200, 80);
            this.BackColor = Color.Azure;
            this.Name = "PnlAdd";

            
            this.shoe = new Shoes();
            this.shoe.Id = shoes.nextId();

            newShoe = new Label();
            newShoe.Location = new System.Drawing.Point(12, 14);
            newShoe.Width = 252;
            newShoe.Height = 50;
            newShoe.Text = "Add new shoe";
            Font font = new Font("Segoe Print", 18);
            newShoe.BackColor = Color.LightBlue;
            newShoe.Font = font;
            this.Controls.Add(newShoe);

            id = new Label();
            id.Location = new System.Drawing.Point(42, 65);
            id.Width = 50;
            id.Height = 40;
            id.Text = "Id";
            Font labels = new Font("Segoe Print", 14);
            id.Font = labels;
            this.Controls.Add(id);

            txtId = new TextBox();
            txtId.Location = new System.Drawing.Point(42, 108);
            txtId.Width = 84;
            txtId.Height = 27;
            this.Controls.Add(txtId);
            txtId.Text = shoes.nextId().ToString();
            txtId.Enabled = false;

            brand = new Label();
            brand.Location = new System.Drawing.Point(42, 211);
            brand.Width = 100; 
            brand.Height = 36;
            brand.Text = "Brand";
            brand.Font = labels;
            this.Controls.Add(brand);

            txtBrand = new TextBox();
            txtBrand.Location = new System.Drawing.Point(42, 250);
            txtBrand.Width = 189;
            txtBrand.Height = 27;
            this.Controls.Add(txtBrand);
            txtBrand.TextChanged += new EventHandler(detail_TextChange);


            type = new Label();
            type.Location = new System.Drawing.Point(42, 138);
            type.Width = 90; 
            type.Height = 40;
            type.Text = "Type";
            type.Font = labels;
            this.Controls.Add(type);

            txtType = new TextBox();
            txtType.Location = new System.Drawing.Point(42, 181);
            txtType.Width = 189;
            txtType.Height = 27;
            this.Controls.Add(txtType);
            txtType.TextChanged += new EventHandler(detail_TextChange);


            size = new Label();
            size.Location = new System.Drawing.Point(42, 280);
            size.Width = 70; 
            size.Height = 36;
            size.Text = "Size";
            size.Font = labels;
            this.Controls.Add(size);

            txtSize = new TextBox();
            txtSize.Location = new System.Drawing.Point(42, 319);
            txtSize.Width = 84;
            txtSize.Height = 27;
            this.Controls.Add(txtSize);
            txtSize.TextChanged += new EventHandler(detail_TextChange);


            price = new Label();
            price.Location = new System.Drawing.Point(42, 349);
            price.Width = 90;
            price.Height = 40;
            price.Text = "Price";
            price.Font = labels;
            this.Controls.Add(price);

            txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(42, 390);
            txtPrice.Width = 105;
            txtPrice.Height = 27;
            this.Controls.Add(txtPrice);
            txtPrice.TextChanged += new EventHandler(detail_TextChange);


            description = new Label();
            description.Location = new System.Drawing.Point(350, 65);
            description.Width = 180;
            description.Height = 40;
            description.Text = "Description";
            description.Font = labels;
            this.Controls.Add(description);

            txtDescription = new TextBox();
            txtDescription.Location = new System.Drawing.Point(350, 108);
            txtDescription.Width = 406;
            txtDescription.Height = 238;
            this.Controls.Add(txtDescription);
            txtDescription.TextChanged += new EventHandler(detail_TextChange);

            add = new Button();
            add.Location = new System.Drawing.Point(535, 392);
            add.Width = 95;
            add.Height = 30;
            add.Text = "Add shoes";
            add.BackColor = Color.LightGray;
            this.Controls.Add(add);
            this.add.Click += new EventHandler(add_Click);

            cancel = new Button();
            cancel.Location = new Point(662, 392);
            cancel.Width = 95;
            cancel.Height = 30;
            cancel.Text = "Cancel";
            cancel.BackColor = Color.LightGray;
            this.Controls.Add(cancel);
            this.cancel.Click += new EventHandler(cancel_Click);
        }
        private void add_Click(object sender, EventArgs e)
        {


            if (!(txtBrand.Text.Equals("") || txtType.Text.Equals("") || txtSize.Text.Equals("") || txtDescription.Text.Equals("")  || txtPrice.Text.Equals("")))
            {

                this.shoe.Brand = txtBrand.Text;
                this.shoe.Type = txtType.Text;
                this.shoe.Price = int.Parse(txtPrice.Text);
                this.shoe.Size = int.Parse(txtSize.Text);
                this.shoe.Description = txtDescription.Text;

                this.shoes.addShoes(shoe);
                this.shoes.save();
                this.shoes.load();
                this.form.Controls.Add(new PnlMain(this.shoes.find(),form));
                this.form.Controls.Remove(this);


            }
            else
            {
                MessageBox.Show(errors());
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
            this.form.erasePanel("PnlAdd");
            this.form.Controls.Add(new PnlMain(shoes.find(),form));

        }
        public String errors()
        {
            String txt = "";

            if(shoe.Type.Equals(""))
            {
                txt += "Trebuie introdus tipul! ";
            }
            if (shoe.Brand.Equals(""))
            {
                txt += "Trebuie introdus brandul! ";
            }
            if (shoe.Size==0)
            {
                txt += "Trebuie introdusa marimea! ";
            }
            if (shoe.Price==0)
            {
                txt += "Trebuie introdus pretul! ";
            }
            if (shoe.Description.Equals(""))
            {
                txt += "Trebuie introdusa descrierea! ";
            }
            return txt;
        }

        private void detail_TextChange(object sender, EventArgs e)
        {
            if(!txtBrand.Text.Equals(""))
            {
                this.shoe.Brand = txtBrand.Text;
            }
            if (!txtType.Text.Equals(""))
            {
                this.shoe.Type = txtType.Text;
            }
            if (!txtSize.Text.Equals(""))
            {
                try
                {
                    this.shoe.Size = int.Parse(txtSize.Text);
                }
                catch(Exception ex1)
                {
                    MessageBox.Show("marime incorecta");
                }
            }
            if (!txtPrice.Text.Equals(""))
            {
                try
                {
                    this.shoe.Price = int.Parse(txtPrice.Text);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("pret invalid");
                }
            }
            if (!txtDescription.Text.Equals(""))
            {
                this.shoe.Description = txtDescription.Text;
            }


        }

    }
}
