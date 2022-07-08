
namespace view
{
    partial class FrmMkLayoutAgain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlAsside = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlAsside.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAsside
            // 
            this.PnlAsside.BackColor = System.Drawing.Color.LightBlue;
            this.PnlAsside.Controls.Add(this.comboBox1);
            this.PnlAsside.Controls.Add(this.iconButton1);
            this.PnlAsside.Controls.Add(this.panel1);
            this.PnlAsside.Location = new System.Drawing.Point(0, 0);
            this.PnlAsside.Name = "PnlAsside";
            this.PnlAsside.Size = new System.Drawing.Size(200, 570);
            this.PnlAsside.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-3, 483);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "d";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 420);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 45);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Original list";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 45);
            this.panel1.TabIndex = 0;
            // 
            // FrmMkLayoutAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 564);
            this.Controls.Add(this.PnlAsside);
            this.Name = "FrmMkLayoutAgain";
            this.Text = "FrmMkLayoutAgain";
            this.PnlAsside.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAsside;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}