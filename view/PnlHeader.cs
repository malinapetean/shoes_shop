using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlHeader : Panel
    {
        private Label labelNameShop;


        public PnlHeader()
        {
            labelNameShop = new Label();
            labelNameShop.AutoSize = true;
            labelNameShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            labelNameShop.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelNameShop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelNameShop.Location = new System.Drawing.Point(200, 9);
            labelNameShop.Name = "labelNameShop";
            labelNameShop.Size = new System.Drawing.Size(373, 59);
            labelNameShop.TabIndex = 0;
            labelNameShop.Text = "Sneaker Shop";


            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.labelNameShop);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "PnlHeader";
            this.Size = new System.Drawing.Size(773, 80);
            this.TabIndex = 4;
            //this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.SuspendLayout();

        }

        ///Drag Form
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}
    }
}
