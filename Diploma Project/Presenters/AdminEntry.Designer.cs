namespace Diploma_Project.Presenters
{
    partial class AdminEntry
    {
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem пазарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поръчкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem потребителиToolStripMenuItem;
        private Views.AdminMarket adminMarket;
        private Views.AdminQueue adminQueue;
        private Views.AdminRegistry adminRegistry;
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
            this.adminQueue = new Diploma_Project.Views.AdminQueue();
            this.adminMarket = new Diploma_Project.Views.AdminMarket();
            this.adminRegistry = new Diploma_Project.Views.AdminRegistry();
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
            this.Menu.Size = new System.Drawing.Size(735, 24);
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
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
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
            this.потребителиToolStripMenuItem.Click += new System.EventHandler(this.потребителиToolStripMenuItem_Click);
            // 
            // adminQueue
            // 
            this.adminQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.adminQueue.Location = new System.Drawing.Point(0, 27);
            this.adminQueue.Name = "adminQueue";
            this.adminQueue.Size = new System.Drawing.Size(753, 483);
            this.adminQueue.TabIndex = 2;
            this.adminQueue.Visible = false;
            this.adminQueue.Load += new System.EventHandler(this.adminQueue_Load);
            // 
            // adminMarket
            // 
            this.adminMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.adminMarket.Location = new System.Drawing.Point(188, 32);
            this.adminMarket.Name = "adminMarket";
            this.adminMarket.Size = new System.Drawing.Size(388, 426);
            this.adminMarket.TabIndex = 1;
            this.adminMarket.Visible = false;
            // 
            // adminRegistry
            // 
            this.adminRegistry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.adminRegistry.Location = new System.Drawing.Point(25, 32);
            this.adminRegistry.Name = "adminRegistry";
            this.adminRegistry.Size = new System.Drawing.Size(686, 483);
            this.adminRegistry.TabIndex = 3;
            // 
            // AdminEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(735, 543);
            this.Controls.Add(this.adminQueue);
            this.Controls.Add(this.adminMarket);
            this.Controls.Add(this.adminRegistry);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
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
    }
}