using shoes_shop.controller;
using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlUpdate:Panel
    {
        private Label updateShoe;
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
        private Button update;
        private Button cancel;
        private Button delete;

        private Shoes shoe;
        private ControllerShoes shoes;
        private List<Shoes> listShoes;

        private FrmHome form;

        public PnlUpdate(FrmHome form, Shoes shoe)
        {
            this.form = form;
            shoes = new ControllerShoes();
            listShoes = new List<Shoes>();

            this.Width = 773;
            this.Height = 490;
            this.Location = new System.Drawing.Point(200, 80);
            this.BackColor = Color.Azure;
            this.Name = "PnlUpdate";

            this.shoe = shoe; ;

            Font font = new Font("Segoe Print", 18);
            Font labels = new Font("Segoe Print", 14);

            updateShoe = new Label();
            updateShoe.Location = new System.Drawing.Point(12, 14);
            updateShoe.Width = 220;
            updateShoe.Height = 50;
            updateShoe.Text = "Update shoe";
            updateShoe.BackColor = Color.LightBlue;
            updateShoe.Font = font;
            this.Controls.Add(updateShoe);

            id = new Label();
            id.Location = new System.Drawing.Point(42, 65);
            id.Width = 50;
            id.Height = 40;
            id.Text = "Id";
            id.Font = labels;
            this.Controls.Add(id);

            txtId = new TextBox();
            txtId.Location = new System.Drawing.Point(42, 108);
            txtId.Width = 84;
            txtId.Height = 27;
            this.Controls.Add(txtId);
            txtId.Text = shoe.Id.ToString();
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
            txtBrand.Text = shoe.Brand;
            this.Controls.Add(txtBrand);
            txtBrand.TextChanged += new EventHandler(update_TextChanged);

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
            txtType.Text = shoe.Type;
            this.Controls.Add(txtType);
            txtType.TextChanged += new EventHandler(update_TextChanged);

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
            txtSize.Text = shoe.Size.ToString();
            txtSize.TextChanged += new EventHandler(update_TextChanged);

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
            txtPrice.Text = shoe.Price.ToString();
            this.Controls.Add(txtPrice);
            txtPrice.TextChanged += new EventHandler(update_TextChanged);

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
            txtDescription.Text = shoe.Description;
            txtDescription.TextChanged += new EventHandler(update_TextChanged);


            update = new Button();
            update.Location = new System.Drawing.Point(585, 375);
            update.Width = 131;
            update.Height = 44;
            update.Text = "Update shoe";
            update.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            update.FlatStyle = new FlatStyle();
            update.BackColor = Color.LightBlue;
            this.Controls.Add(update);
            this.update.Click += new EventHandler(update_Click);

            cancel = new Button();
            cancel.Location = new Point(468, 375);
            cancel.Width = 94;
            cancel.Height = 44;
            cancel.Text = "Cancel";
            cancel.BackColor = Color.LightGray;
            this.Controls.Add(cancel);
            this.cancel.Click += new EventHandler(cancel_Click);

            delete = new Button();
            delete.Location = new Point(468, 425);
            delete.Width =248;
            delete.Height =29;
            delete.Text = "Delete";
            delete.BackColor = Color.LightGray;
            this.Controls.Add(delete);
            delete.Click += new EventHandler(delete_Click);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!(txtBrand.Text.Equals("") || txtType.Text.Equals("") || txtSize.Text.Equals("") || txtPrice.Text.Equals("") || txtDescription.Text.Equals("")))
            {
                this.shoes.updateShoes(this.shoe);
                this.shoes.save();
                this.shoes.load();
                this.form.Controls.Add(new PnlMain(this.shoes.find(), form));
                this.form.Controls.Remove(this);

            }
            else
                MessageBox.Show(checkErrors());
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.form.Controls.Add(new PnlMain(this.shoes.find(), form));
            this.form.Controls.Remove(this);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            this.shoes.delete(this.shoe);
            this.shoes.save();
            this.shoes.load();
            this.form.Controls.Add(new PnlMain(this.shoes.find(), form));
            this.form.Controls.Remove(this);

        }
        private void update_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.shoe.Brand = txtBrand.Text;
                this.shoe.Type = txtType.Text;
                this.shoe.Description = txtDescription.Text;
                this.shoe.Size = int.Parse(txtSize.Text);
                this.shoe.Price= int.Parse(txtPrice.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("valoare invalida");

            }
        }
        private String checkErrors()
        {
            String text = "";
            if (txtBrand.Text.Equals(""))
                text += "Add brand! ";
            if (txtType.Text.Equals(""))
                text += "Add type! ";
            if (txtSize.Text.Equals(""))
                text += "Add size! ";
            if (txtPrice.Text.Equals(""))
                text += "Add price! ";
            if (txtDescription.Text.Equals(""))
                text += "Add description! ";
            return text;
        }
    }
}
