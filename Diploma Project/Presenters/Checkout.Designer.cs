namespace Diploma_Project.Presenters
{
    partial class Checkout
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
            this.listBoxCheckOut = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkBoxClear1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxCheckOut
            // 
            this.listBoxCheckOut.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.listBoxCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCheckOut.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxCheckOut.FormattingEnabled = true;
            this.listBoxCheckOut.ItemHeight = 23;
            this.listBoxCheckOut.Location = new System.Drawing.Point(27, 69);
            this.listBoxCheckOut.Name = "listBoxCheckOut";
            this.listBoxCheckOut.Size = new System.Drawing.Size(328, 276);
            this.listBoxCheckOut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количка";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.ForeColor = System.Drawing.Color.LightCyan;
            this.btnRegister.Location = new System.Drawing.Point(27, 364);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(97, 30);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Покупка";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // checkBoxClear1
            // 
            this.checkBoxClear1.AutoSize = true;
            this.checkBoxClear1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxClear1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxClear1.Location = new System.Drawing.Point(256, 364);
            this.checkBoxClear1.Name = "checkBoxClear1";
            this.checkBoxClear1.Size = new System.Drawing.Size(99, 27);
            this.checkBoxClear1.TabIndex = 19;
            this.checkBoxClear1.Text = "Изчисти";
            this.checkBoxClear1.UseVisualStyleBackColor = true;
            this.checkBoxClear1.CheckedChanged += new System.EventHandler(this.checkBoxClear1_CheckedChanged);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.checkBoxClear1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCheckOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox checkBoxClear1;
    }
}