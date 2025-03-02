namespace Diploma_Project.Views
{
    partial class Market
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
            this.itemHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.filterMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puzzleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roguelikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adventuretoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.survivaltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platformertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.filterMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemHolder
            // 
            this.itemHolder.Location = new System.Drawing.Point(278, 0);
            this.itemHolder.Name = "itemHolder";
            this.itemHolder.Size = new System.Drawing.Size(636, 426);
            this.itemHolder.TabIndex = 0;
            this.itemHolder.Tag = "CustomControl";
            this.itemHolder.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // filterMenuStrip
            // 
            this.filterMenuStrip.AutoSize = false;
            this.filterMenuStrip.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.filterMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.filterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.puzzleToolStripMenuItem1,
            this.roguelikeToolStripMenuItem,
            this.adventuretoolStripMenuItem,
            this.survivaltoolStripMenuItem,
            this.simulationtoolStripMenuItem,
            this.platformertoolStripMenuItem,
            this.multiplayerToolStripMenuItem});
            this.filterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.filterMenuStrip.Name = "filterMenuStrip";
            this.filterMenuStrip.Padding = new System.Windows.Forms.Padding(2, 20, 0, 2);
            this.filterMenuStrip.Size = new System.Drawing.Size(152, 426);
            this.filterMenuStrip.Stretch = false;
            this.filterMenuStrip.TabIndex = 1;
            this.filterMenuStrip.Text = "Екшън";
            this.filterMenuStrip.Visible = false;
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.actionToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.actionToolStripMenuItem.Text = "Екшън";
            this.actionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actionToolStripMenuItem.Click += new System.EventHandler(this.actionToolStripMenuItem_Click);
            // 
            // puzzleToolStripMenuItem1
            // 
            this.puzzleToolStripMenuItem1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.puzzleToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puzzleToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.puzzleToolStripMenuItem1.Name = "puzzleToolStripMenuItem1";
            this.puzzleToolStripMenuItem1.Size = new System.Drawing.Size(149, 27);
            this.puzzleToolStripMenuItem1.Text = "Пъзел";
            this.puzzleToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.puzzleToolStripMenuItem1.Click += new System.EventHandler(this.puzzleToolStripMenuItem1_Click);
            // 
            // roguelikeToolStripMenuItem
            // 
            this.roguelikeToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.roguelikeToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roguelikeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roguelikeToolStripMenuItem.Name = "roguelikeToolStripMenuItem";
            this.roguelikeToolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.roguelikeToolStripMenuItem.Text = "Роуглайк ";
            this.roguelikeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roguelikeToolStripMenuItem.Click += new System.EventHandler(this.roguelikeToolStripMenuItem_Click);
            // 
            // adventuretoolStripMenuItem
            // 
            this.adventuretoolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.adventuretoolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adventuretoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adventuretoolStripMenuItem.Name = "adventuretoolStripMenuItem";
            this.adventuretoolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.adventuretoolStripMenuItem.Text = "Приключение  ";
            this.adventuretoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adventuretoolStripMenuItem.Click += new System.EventHandler(this.adventuretoolStripMenuItem_Click);
            // 
            // survivaltoolStripMenuItem
            // 
            this.survivaltoolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.survivaltoolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.survivaltoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.survivaltoolStripMenuItem.Name = "survivaltoolStripMenuItem";
            this.survivaltoolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.survivaltoolStripMenuItem.Text = "Оцеляване";
            this.survivaltoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.survivaltoolStripMenuItem.Click += new System.EventHandler(this.survivaltoolStripMenuItem_Click);
            // 
            // simulationtoolStripMenuItem
            // 
            this.simulationtoolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.simulationtoolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simulationtoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simulationtoolStripMenuItem.Name = "simulationtoolStripMenuItem";
            this.simulationtoolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.simulationtoolStripMenuItem.Text = "Симулация";
            this.simulationtoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simulationtoolStripMenuItem.Click += new System.EventHandler(this.simulationtoolStripMenuItem_Click);
            // 
            // platformertoolStripMenuItem
            // 
            this.platformertoolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.platformertoolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.platformertoolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.platformertoolStripMenuItem.Name = "platformertoolStripMenuItem";
            this.platformertoolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.platformertoolStripMenuItem.Text = "Платформър";
            this.platformertoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.platformertoolStripMenuItem.Click += new System.EventHandler(this.platformertoolStripMenuItem_Click);
            // 
            // multiplayerToolStripMenuItem
            // 
            this.multiplayerToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.multiplayerToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplayerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplayerToolStripMenuItem.Name = "multiplayerToolStripMenuItem";
            this.multiplayerToolStripMenuItem.Size = new System.Drawing.Size(149, 27);
            this.multiplayerToolStripMenuItem.Text = "Мултиплейър";
            this.multiplayerToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.multiplayerToolStripMenuItem.Click += new System.EventHandler(this.multiplayerToolStripMenuItem_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.checkBox.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox.Location = new System.Drawing.Point(6, 401);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(128, 22);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Покажи Всички";
            this.checkBox.UseVisualStyleBackColor = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.itemHolder);
            this.Controls.Add(this.filterMenuStrip);
            this.Name = "Market";
            this.Size = new System.Drawing.Size(930, 426);
            this.Tag = "CustomControl";
            this.Load += new System.EventHandler(this.Market_Load);
            this.filterMenuStrip.ResumeLayout(false);
            this.filterMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemHolder;
        private System.Windows.Forms.MenuStrip filterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puzzleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roguelikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adventuretoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem survivaltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platformertoolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
