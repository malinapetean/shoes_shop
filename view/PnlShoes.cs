using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlShoes:Panel
    {
        private Shoes shoe;
        private PictureBox picture;
        private Label brand;
        private TextBox description;
        private Form1 form;

        public PnlShoes(Shoes shoe, Form1 form)
        {
            this.shoe = shoe;
            this.Width = 221;
            this.Height = 213;
            this.BackColor = Color.SteelBlue;
        }
    }
}
