namespace Diploma_Project.Views
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(78, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Заглавие";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.ForeColor = System.Drawing.Color.LightCyan;
            this.btnBuy.Location = new System.Drawing.Point(79, 270);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(84, 30);
            this.btnBuy.TabIndex = 18;
            this.btnBuy.Text = "Купи\r\n";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(22, 191);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(201, 76);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer dui elit, sceler" +
    "isque ac auctor in, maximus nec nisi.\r\n";
            // 
            // pBoxIcon
            // 
            this.pBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxIcon.Image = global::Diploma_Project.Properties.Resources.Background_Main_Page;
            this.pBoxIcon.Location = new System.Drawing.Point(25, 33);
            this.pBoxIcon.Name = "pBoxIcon";
            this.pBoxIcon.Size = new System.Drawing.Size(198, 148);
            this.pBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxIcon.TabIndex = 0;
            this.pBoxIcon.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(179, 13);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "label1";
            // 
            // GameProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pBoxIcon);
            this.Name = "GameProduct";
            this.Size = new System.Drawing.Size(236, 314);
            this.Load += new System.EventHandler(this.GameProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
    }
}
