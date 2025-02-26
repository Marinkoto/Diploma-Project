namespace Diploma_Project.Presenters
{
    partial class AdminEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEntry));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.пазарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поръчкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.потребителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMarket1 = new Diploma_Project.Views.AdminMarket();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.SlateBlue;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пазарToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.поръчкиToolStripMenuItem,
            this.потребителиToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.Menu.Size = new System.Drawing.Size(762, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // пазарToolStripMenuItem
            // 
            this.пазарToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пазарToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("пазарToolStripMenuItem.Image")));
            this.пазарToolStripMenuItem.Name = "пазарToolStripMenuItem";
            this.пазарToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.пазарToolStripMenuItem.Text = "Пазар";
            this.пазарToolStripMenuItem.Click += new System.EventHandler(this.пазарToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.услугиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("услугиToolStripMenuItem.Image")));
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.услугиToolStripMenuItem.Text = "Заявки";
            // 
            // поръчкиToolStripMenuItem
            // 
            this.поръчкиToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.поръчкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("поръчкиToolStripMenuItem.Image")));
            this.поръчкиToolStripMenuItem.Name = "поръчкиToolStripMenuItem";
            this.поръчкиToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.поръчкиToolStripMenuItem.Text = "Поръчки";
            // 
            // потребителиToolStripMenuItem
            // 
            this.потребителиToolStripMenuItem.Image = global::Diploma_Project.Properties.Resources.Profile_Icon;
            this.потребителиToolStripMenuItem.Name = "потребителиToolStripMenuItem";
            this.потребителиToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.потребителиToolStripMenuItem.Text = "Потребители";
            // 
            // adminMarket1
            // 
            this.adminMarket1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.adminMarket1.Location = new System.Drawing.Point(194, 38);
            this.adminMarket1.Name = "adminMarket1";
            this.adminMarket1.Size = new System.Drawing.Size(388, 426);
            this.adminMarket1.TabIndex = 1;
            // 
            // AdminEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(762, 453);
            this.ControlBox = false;
            this.Controls.Add(this.adminMarket1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(460, 500);
            this.Name = "AdminEntry";
            this.Text = "AdminEntry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminEntry_FormClosed);
            this.Load += new System.EventHandler(this.AdminEntry_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem пазарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поръчкиToolStripMenuItem;
        private Views.AdminMarket adminMarket1;
        private System.Windows.Forms.ToolStripMenuItem потребителиToolStripMenuItem;
    }
}