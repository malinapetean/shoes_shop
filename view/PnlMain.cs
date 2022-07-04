using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlMain:Panel
    {
        private List<Shoes> shoes;
        private List<PnlShoeCard> pnlShoes;
        private PnlUpdate updatepanel;
        private FrmHome form;

        public PnlMain(List<Shoes> shoes,FrmHome form)
        {
            this.pnlShoes = new List<PnlShoeCard>();

            this.Parent = form;
            this.shoes = shoes;
            this.Width = 773;
            this.Height = 490;
            this.Location = new Point(200, 80);
            this.BackColor = Color.Azure;
            this.form = form;
            this.Name = "PnlMain";
            createCards();

        }
        public void createCards()
        {
            int x = 10, y = 10, ct = 0;
            foreach (Shoes s in shoes)
            {
                ct++;
                PnlShoeCard pnlsh = new PnlShoeCard(s, form);
                pnlsh.Location = new Point(x, y);
                this.Controls.Add(pnlsh);
                this.pnlShoes.Add(pnlsh);

                x += 240;
                if (ct % 3 == 0)
                {
                    x = 10;
                    y += 230;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }
        }
       
    }
}
