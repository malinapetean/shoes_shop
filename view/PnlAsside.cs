using FontAwesome.Sharp;
using shoes_shop.controller;
using shoes_shop.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    class PnlAsside:Panel
    {

        private IconButton btnAdd;
        private IconButton btnSort;
        private IconButton btnSort2;
        private IconButton btnType;
        private IconButton btnBrand;
        private IconButton btnSize;
        private IconButton btnOriginalList;
        private ControllerShoes control;

        private PictureBox pictureLogo;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Panel pnlLogo;

        private FrmHome form;

        public PnlAsside(IconButton sortByBrand, IconButton sortByPrice,IconButton add, IconButton type,IconButton brand, IconButton size, IconButton mainList, FrmHome form)
        {
            this.Location = new Point(0, 0);
            this.Name = "PnlAsside";
            this.Size = new Size(200, 570);
            this.BackColor = System.Drawing.Color.LightBlue;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 45);
            this.Controls.Add(leftBorderBtn);
            control = new ControllerShoes();
            this.form = form;

            pnlLogo = new Panel();
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "PnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 150);
            this.pnlLogo.TabIndex = 0;
            this.Controls.Add(pnlLogo);

            pictureLogo = new PictureBox();
            this.pictureLogo.BackColor = System.Drawing.Color.LightBlue;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Image = global::view.Properties.Resources.shoes_clipart_clipart_images_clipartwork_15;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(200, 150);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            this.pnlLogo.Controls.Add(this.pictureLogo);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();

            this.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.SuspendLayout();
            this.pnlLogo.SuspendLayout();

            btnAdd = add;
            this.btnAdd.Location = new System.Drawing.Point(0, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add new shoes";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 35;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.btnAdd);

            btnSort = sortByBrand;
            btnSort.FlatAppearance.BorderSize = 0;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSort.ForeColor = Color.Black;
            btnSort.IconChar = IconChar.SortAlphaDown;
            btnSort.IconColor = SystemColors.ActiveCaptionText;
            btnSort.IconFont = IconFont.Auto;
            btnSort.IconSize = 35;
            btnSort.ImageAlign = ContentAlignment.MiddleLeft;
            btnSort.Location = new Point(0, 150);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(200, 45);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort by brand";
            btnSort.TextAlign = ContentAlignment.MiddleLeft;
            btnSort.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += new EventHandler(this.btnSort_Click);
            btnSort.BackColor =Color.LightBlue;
            this.Controls.Add(this.btnSort);

            btnSort2 = sortByPrice;
            btnSort2.FlatAppearance.BorderSize = 0;
            btnSort2.FlatStyle = FlatStyle.Flat;
            btnSort2.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSort2.ForeColor = Color.Black;
            btnSort2.IconChar = IconChar.SortNumericDown;
            btnSort2.IconColor = SystemColors.ActiveCaptionText;
            btnSort2.IconFont = IconFont.Auto;
            btnSort2.IconSize = 35;
            btnSort2.ImageAlign = ContentAlignment.MiddleLeft;
            btnSort2.Location = new Point(0, 195);
            btnSort2.Name = "btnSort2";
            btnSort2.Size = new Size(200, 45);
            btnSort2.TabIndex = 1;
            btnSort2.Text = "Sort by price";
            btnSort2.TextAlign = ContentAlignment.MiddleLeft;
            btnSort2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSort2.UseVisualStyleBackColor = false;
            btnSort2.Click += new EventHandler(this.btnType_Click);
            btnSort2.BackColor = Color.LightBlue;
            this.Controls.Add(this.btnSort2);

            btnType = type;
            btnType.FlatAppearance.BorderSize = 0;
            btnType.FlatStyle = FlatStyle.Flat;
            btnType.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnType.ForeColor = Color.Black;
            btnType.IconChar = IconChar.ShoePrints;
            btnType.IconColor = SystemColors.ActiveCaptionText;
            btnType.IconFont = IconFont.Auto;
            btnType.IconSize = 35;
            btnType.ImageAlign = ContentAlignment.MiddleLeft;
            btnType.Location = new Point(0,285);
            btnType.Name = "btntypeSlapi";
            btnType.Size = new Size(200, 45);
            btnType.TabIndex = 1;
            btnType.Text = "Slapi";
            btnType.TextAlign = ContentAlignment.MiddleLeft;
            btnType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnType.UseVisualStyleBackColor = false;
            btnType.Click += new EventHandler(this.btnType_Click);
            btnType.BackColor = Color.LightBlue;
            this.Controls.Add(this.btnType);

            btnBrand = brand;
            btnBrand.FlatAppearance.BorderSize = 0;
            btnBrand.FlatStyle = FlatStyle.Flat;
            btnBrand.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBrand.ForeColor = Color.Black;
            btnBrand.IconChar = IconChar.Running;
            btnBrand.IconColor = SystemColors.ActiveCaptionText;
            btnBrand.IconFont = IconFont.Auto;
            btnBrand.IconSize = 35;
            btnBrand.ImageAlign = ContentAlignment.MiddleLeft;
            btnBrand.Location = new Point(0, 330);
            btnBrand.Name = "btnbrand";
            btnBrand.Size = new Size(200, 45);
            btnBrand.TabIndex = 1;
            btnBrand.Text = "Adidas shoes";
            btnBrand.TextAlign = ContentAlignment.MiddleLeft;
            btnBrand.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBrand.UseVisualStyleBackColor = false;
            btnBrand.Click += new EventHandler(this.btnBrand_Click);
            btnBrand.BackColor = Color.LightBlue;
            this.Controls.Add(this.btnBrand);

            btnSize = size;
            btnSize.FlatAppearance.BorderSize = 0;
            btnSize.FlatStyle = FlatStyle.Flat;
            btnSize.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSize.ForeColor = Color.Black;
            btnSize.IconChar = IconChar.Ruler;
            btnSize.IconColor = SystemColors.ActiveCaptionText;
            btnSize.IconFont = IconFont.Auto;
            btnSize.IconSize = 35;
            btnSize.ImageAlign = ContentAlignment.MiddleLeft;
            btnSize.Location = new Point(0, 375);
            btnSize.Name = "btnsize";
            btnSize.Size = new Size(200, 45);
            btnSize.TabIndex = 1;
            btnSize.Text = "Show size 42";
            btnSize.TextAlign = ContentAlignment.MiddleLeft;
            btnSize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSize.UseVisualStyleBackColor = false;
            btnSize.Click += new EventHandler(this.btnSize_Click);
            btnSize.BackColor = Color.LightBlue;
            this.Controls.Add(this.btnSize);

            btnOriginalList = mainList;
            btnOriginalList.FlatAppearance.BorderSize = 0;
            btnOriginalList.FlatStyle = FlatStyle.Flat;
            btnOriginalList.Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOriginalList.ForeColor = Color.Black;
            btnOriginalList.IconChar = IconChar.List;
            btnOriginalList.IconColor = SystemColors.ActiveCaptionText;
            btnOriginalList.IconFont = IconFont.Auto;
            btnOriginalList.IconSize = 35;
            btnOriginalList.ImageAlign = ContentAlignment.MiddleLeft;
            btnOriginalList.Location = new Point(0, 420);
            btnOriginalList.Name = "btnList";
            btnOriginalList.Size = new Size(200, 45);
            btnOriginalList.TabIndex = 1;
            btnOriginalList.Text = "Original list";
            btnOriginalList.TextAlign = ContentAlignment.MiddleLeft;
            btnOriginalList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOriginalList.UseVisualStyleBackColor = false;
            btnOriginalList.Click += new EventHandler(this.btnOriginalList_Click);
            btnOriginalList.BackColor = Color.LightBlue;
            this.Controls.Add(this.btnOriginalList);
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color2);
            
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color1);
            
        }
        private void btnSort2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color3);

        }
        private void btnType_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color4);

        }
        private void btnBrand_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color5);

        }
        private void btnSize_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color1);

        }

        private void btnOriginalList_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgbColors.color2);

        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            ///currebtchildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisabledButton();
            leftBorderBtn.Visible = false;
        }
        

    }
}
