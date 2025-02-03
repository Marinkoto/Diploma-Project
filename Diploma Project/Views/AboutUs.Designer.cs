namespace Diploma_Project.Views
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.infoPBox = new System.Windows.Forms.PictureBox();
            this.logoPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(481, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 59);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "За нас";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Location = new System.Drawing.Point(300, 72);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(561, 409);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoPBox
            // 
            this.infoPBox.BackgroundImage = global::Diploma_Project.Properties.Resources.Logo__2_;
            this.infoPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPBox.Image = global::Diploma_Project.Properties.Resources.About_us_Photo;
            this.infoPBox.Location = new System.Drawing.Point(16, 214);
            this.infoPBox.Name = "infoPBox";
            this.infoPBox.Size = new System.Drawing.Size(200, 200);
            this.infoPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPBox.TabIndex = 3;
            this.infoPBox.TabStop = false;
            // 
            // logoPBox
            // 
            this.logoPBox.BackgroundImage = global::Diploma_Project.Properties.Resources.Logo__2_;
            this.logoPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoPBox.Image = global::Diploma_Project.Properties.Resources.Logo__2_;
            this.logoPBox.Location = new System.Drawing.Point(16, 9);
            this.logoPBox.Name = "logoPBox";
            this.logoPBox.Size = new System.Drawing.Size(200, 200);
            this.logoPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPBox.TabIndex = 0;
            this.logoPBox.TabStop = false;
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.infoPBox);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.logoPBox);
            this.Name = "AboutUs";
            this.Size = new System.Drawing.Size(930, 426);
            this.Tag = "CustomControl";
            ((System.ComponentModel.ISupportInitialize)(this.infoPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox infoPBox;
    }
}
