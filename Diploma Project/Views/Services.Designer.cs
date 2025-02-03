namespace Diploma_Project.Views
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxClear1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkBoxClear2 = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxClear3 = new System.Windows.Forms.CheckBox();
            this.txtBoxNeeds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.MediumPurple;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(6, 26);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.checkBoxClear1);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(168, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запази дата за консултация";
            // 
            // checkBoxClear1
            // 
            this.checkBoxClear1.AutoSize = true;
            this.checkBoxClear1.Location = new System.Drawing.Point(212, 26);
            this.checkBoxClear1.Name = "checkBoxClear1";
            this.checkBoxClear1.Size = new System.Drawing.Size(99, 27);
            this.checkBoxClear1.TabIndex = 1;
            this.checkBoxClear1.Text = "Изчисти";
            this.checkBoxClear1.UseVisualStyleBackColor = true;
            this.checkBoxClear1.CheckedChanged += new System.EventHandler(this.checkBoxClear1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Indigo;
            this.groupBox2.Controls.Add(this.cBoxType);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.checkBoxClear2);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(168, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 273);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Желания за начало на игра";
            // 
            // cBoxType
            // 
            this.cBoxType.DisplayMember = "Вид игра";
            this.cBoxType.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.ItemHeight = 20;
            this.cBoxType.Items.AddRange(new object[] {
            "3D",
            "2D",
            "RPG"});
            this.cBoxType.Location = new System.Drawing.Point(114, 232);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(121, 28);
            this.cBoxType.TabIndex = 19;
            this.cBoxType.Text = "Вид игра";
            this.cBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSend.Location = new System.Drawing.Point(14, 232);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 28);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Изпрати";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // checkBoxClear2
            // 
            this.checkBoxClear2.AutoSize = true;
            this.checkBoxClear2.Location = new System.Drawing.Point(240, 233);
            this.checkBoxClear2.Name = "checkBoxClear2";
            this.checkBoxClear2.Size = new System.Drawing.Size(99, 27);
            this.checkBoxClear2.TabIndex = 2;
            this.checkBoxClear2.Text = "Изчисти";
            this.checkBoxClear2.UseVisualStyleBackColor = true;
            this.checkBoxClear2.CheckedChanged += new System.EventHandler(this.checkBoxClear2_CheckedChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.Location = new System.Drawing.Point(14, 26);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(289, 197);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Попълни желанията си";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Indigo;
            this.groupBox3.Controls.Add(this.checkBoxClear3);
            this.groupBox3.Controls.Add(this.txtBoxNeeds);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnImport);
            this.groupBox3.Controls.Add(this.txtBoxInfo);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(519, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 345);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Промотиране";
            // 
            // checkBoxClear3
            // 
            this.checkBoxClear3.AutoSize = true;
            this.checkBoxClear3.Location = new System.Drawing.Point(20, 310);
            this.checkBoxClear3.Name = "checkBoxClear3";
            this.checkBoxClear3.Size = new System.Drawing.Size(99, 27);
            this.checkBoxClear3.TabIndex = 2;
            this.checkBoxClear3.Text = "Изчисти";
            this.checkBoxClear3.UseVisualStyleBackColor = true;
            this.checkBoxClear3.CheckedChanged += new System.EventHandler(this.checkBoxClear3_CheckedChanged);
            // 
            // txtBoxNeeds
            // 
            this.txtBoxNeeds.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxNeeds.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxNeeds.Location = new System.Drawing.Point(17, 228);
            this.txtBoxNeeds.Multiline = true;
            this.txtBoxNeeds.Name = "txtBoxNeeds";
            this.txtBoxNeeds.Size = new System.Drawing.Size(354, 76);
            this.txtBoxNeeds.TabIndex = 21;
            this.txtBoxNeeds.Text = "Напиши ни твоите изисквания";
            this.txtBoxNeeds.Enter += new System.EventHandler(this.txtBoxNeeds_Enter);
            this.txtBoxNeeds.Leave += new System.EventHandler(this.txtBoxNeeds_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 75);
            this.label2.TabIndex = 20;
            this.label2.Text = "Вмъкни ни кратки клипове или снимки на играта ти които да използваме.";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImport.ForeColor = System.Drawing.Color.LightCyan;
            this.btnImport.Location = new System.Drawing.Point(17, 183);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(97, 30);
            this.btnImport.TabIndex = 19;
            this.btnImport.Text = "Вмъкни";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxInfo.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxInfo.Location = new System.Drawing.Point(17, 26);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.Size = new System.Drawing.Size(354, 76);
            this.txtBoxInfo.TabIndex = 2;
            this.txtBoxInfo.Text = "Напиши ни защо да работим с теб";
            this.txtBoxInfo.Enter += new System.EventHandler(this.txtBoxInfo_Enter);
            this.txtBoxInfo.Leave += new System.EventHandler(this.txtBoxInfo_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Services";
            this.Size = new System.Drawing.Size(930, 426);
            this.Tag = "CustomControl";
            this.Load += new System.EventHandler(this.Services_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxClear1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox checkBoxClear2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.CheckBox checkBoxClear3;
        private System.Windows.Forms.TextBox txtBoxNeeds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cBoxType;
    }
}
