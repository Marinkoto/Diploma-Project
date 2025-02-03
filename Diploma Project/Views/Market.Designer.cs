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
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemHolder
            // 
            this.itemHolder.Location = new System.Drawing.Point(275, 0);
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
            this.dToolStripMenuItem,
            this.dToolStripMenuItem1,
            this.rPGToolStripMenuItem,
            this.fightingToolStripMenuItem});
            this.filterMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.filterMenuStrip.Name = "filterMenuStrip";
            this.filterMenuStrip.Size = new System.Drawing.Size(139, 426);
            this.filterMenuStrip.Stretch = false;
            this.filterMenuStrip.TabIndex = 1;
            this.filterMenuStrip.Text = "menuStrip1";
            this.filterMenuStrip.Visible = false;
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(132, 27);
            this.dToolStripMenuItem.Text = "2D";
            this.dToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dToolStripMenuItem1
            // 
            this.dToolStripMenuItem1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dToolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            this.dToolStripMenuItem1.Size = new System.Drawing.Size(132, 27);
            this.dToolStripMenuItem1.Text = "3D";
            this.dToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rPGToolStripMenuItem
            // 
            this.rPGToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rPGToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rPGToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rPGToolStripMenuItem.Name = "rPGToolStripMenuItem";
            this.rPGToolStripMenuItem.Size = new System.Drawing.Size(132, 27);
            this.rPGToolStripMenuItem.Text = "RPG";
            this.rPGToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fightingToolStripMenuItem
            // 
            this.fightingToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.fightingToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fightingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fightingToolStripMenuItem.Name = "fightingToolStripMenuItem";
            this.fightingToolStripMenuItem.Size = new System.Drawing.Size(132, 27);
            this.fightingToolStripMenuItem.Text = "Puzzle";
            this.fightingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.itemHolder);
            this.Controls.Add(this.filterMenuStrip);
            this.Name = "Market";
            this.Size = new System.Drawing.Size(930, 426);
            this.Tag = "CustomControl";
            this.Load += new System.EventHandler(this.Market_Load);
            this.filterMenuStrip.ResumeLayout(false);
            this.filterMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemHolder;
        private System.Windows.Forms.MenuStrip filterMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fightingToolStripMenuItem;
    }
}
