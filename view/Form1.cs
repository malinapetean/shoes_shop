using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using shoes_shop.model;

namespace view
{
    public partial class Form1 : Form
    { 
        ///Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currebtchildForm;
        private List<Shoes> shoes;
        private List<PnlShoes> pnlShoes;
        public Form1(List<Shoes> shoes)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 45);
            PnlAsside.Controls.Add(leftBorderBtn);
            ///Delete Form bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.pnlShoes = new List<PnlShoes>();
            this.shoes = shoes;
            createCards();
        }
        public void createCards()
        {
            int x = 0, y = 0, ct = 0;
            foreach(Shoes s in shoes)
            {
                ct++;
                PnlShoes pnlsh = new PnlShoes(s, this);
                pnlsh.Location = new Point(x, y);
                this.Controls.Add(pnlsh);
                this.pnlShoes.Add(pnlsh);

                x += 240;
                if(ct%3==0)
                {
                    x = 10;
                    y += 230;
                }
                if(y>this.Height)
                {
                    this.AutoScroll = true;
                }
            }
        }
        private struct RgbColors
        {
            public static Color color3 = Color.FromArgb(255, 153, 204);
            public static Color color4 = Color.FromArgb(204, 153, 255);
            public static Color color1 = Color.FromArgb(153, 255, 204);
            public static Color color2 = Color.FromArgb(255, 255, 153);
            public static Color color5 = Color.FromArgb(255, 153, 153);

        }
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisabledButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(70, 130, 180);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }

        }
        private void DisabledButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.LightBlue;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childform)
        {
            if(currebtchildForm!= null)
            {
                currebtchildForm.Close();
            }
            currebtchildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(childform);
            PnlMain.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color2);
            OpenChildForm(new FrmAddShoes());
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color1);
            OpenChildForm(new FrmSortShoes());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            ActiveButton(sender, RgbColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color5);
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            currebtchildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisabledButton();
            leftBorderBtn.Visible = false;
        }
        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
