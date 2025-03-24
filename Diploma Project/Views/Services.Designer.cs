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
            this.btnSend1 = new System.Windows.Forms.Button();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.checkBoxClear1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.checkBoxClear2 = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxClear3 = new System.Windows.Forms.CheckBox();
            this.txtBoxNeeds = new System.Windows.Forms.TextBox();
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ordersTableAdapter = new Diploma_Project.DatabaseDataSetTableAdapters.OrdersTableAdapter();
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
            this.dateTimePicker.Location = new System.Drawing.Point(6, 36);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Controls.Add(this.btnSend1);
            this.groupBox1.Controls.Add(this.labelPrice1);
            this.groupBox1.Controls.Add(this.checkBoxClear1);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(168, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запази дата за консултация";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSend1
            // 
            this.btnSend1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSend1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSend1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend1.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSend1.Location = new System.Drawing.Point(241, 63);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(97, 28);
            this.btnSend1.TabIndex = 22;
            this.btnSend1.Text = "Заяви";
            this.btnSend1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend1.UseVisualStyleBackColor = false;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Location = new System.Drawing.Point(299, 15);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(40, 23);
            this.labelPrice1.TabIndex = 2;
            this.labelPrice1.Text = "10€";
            // 
            // checkBoxClear1
            // 
            this.checkBoxClear1.AutoSize = true;
            this.checkBoxClear1.Location = new System.Drawing.Point(6, 67);
            this.checkBoxClear1.Name = "checkBoxClear1";
            this.checkBoxClear1.Size = new System.Drawing.Size(99, 27);
            this.checkBoxClear1.TabIndex = 1;
            this.checkBoxClear1.Text = "Изчисти";
            this.checkBoxClear1.UseVisualStyleBackColor = true;
            this.checkBoxClear1.CheckedChanged += new System.EventHandler(this.checkBoxClear1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox2.Controls.Add(this.btnSend2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBoxType);
            this.groupBox2.Controls.Add(this.checkBoxClear2);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(168, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 273);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Желания за начало на игра";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSend2
            // 
            this.btnSend2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSend2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSend2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend2.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSend2.Location = new System.Drawing.Point(241, 236);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(97, 28);
            this.btnSend2.TabIndex = 23;
            this.btnSend2.Text = "Заяви";
            this.btnSend2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend2.UseVisualStyleBackColor = false;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "50€";
            // 
            // cBoxType
            // 
            this.cBoxType.DisplayMember = "Вид игра";
            this.cBoxType.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.ItemHeight = 20;
            this.cBoxType.Items.AddRange(new object[] {
            "Екшън",
            "Оцеляване",
            "Пъзел",
            "Приключение",
            "Роуглайк",
            "Мултиплейър",
            "Платформър",
            "Симулация"});
            this.cBoxType.Location = new System.Drawing.Point(14, 225);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(164, 28);
            this.cBoxType.TabIndex = 19;
            this.cBoxType.Text = "Вид игра";
            this.cBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // checkBoxClear2
            // 
            this.checkBoxClear2.AutoSize = true;
            this.checkBoxClear2.Location = new System.Drawing.Point(241, 211);
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
            this.txtDescription.Size = new System.Drawing.Size(271, 180);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "Попълни желанията си";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // btnSend3
            // 
            this.btnSend3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSend3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSend3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSend3.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSend3.Location = new System.Drawing.Point(283, 306);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(97, 28);
            this.btnSend3.TabIndex = 18;
            this.btnSend3.Text = "Заяви";
            this.btnSend3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend3.UseVisualStyleBackColor = false;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBoxClear3);
            this.groupBox3.Controls.Add(this.btnSend3);
            this.groupBox3.Controls.Add(this.txtBoxNeeds);
            this.groupBox3.Controls.Add(this.txtBoxInfo);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(519, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 343);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Промотиране";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Желана дата за финал";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.MediumPurple;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.MediumSlateBlue;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 299);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "250€";
            // 
            // checkBoxClear3
            // 
            this.checkBoxClear3.AutoSize = true;
            this.checkBoxClear3.Location = new System.Drawing.Point(283, 273);
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
            this.txtBoxNeeds.Location = new System.Drawing.Point(17, 143);
            this.txtBoxNeeds.Multiline = true;
            this.txtBoxNeeds.Name = "txtBoxNeeds";
            this.txtBoxNeeds.Size = new System.Drawing.Size(305, 106);
            this.txtBoxNeeds.TabIndex = 21;
            this.txtBoxNeeds.Text = "Напиши ни твоите изисквания";
            this.txtBoxNeeds.Enter += new System.EventHandler(this.txtBoxNeeds_Enter);
            this.txtBoxNeeds.Leave += new System.EventHandler(this.txtBoxNeeds_Leave);
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxInfo.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxInfo.Location = new System.Drawing.Point(17, 27);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.Size = new System.Drawing.Size(305, 110);
            this.txtBoxInfo.TabIndex = 2;
            this.txtBoxInfo.Text = "Напиши ни защо да работим с теб";
            this.txtBoxInfo.Enter += new System.EventHandler(this.txtBoxInfo_Enter);
            this.txtBoxInfo.Leave += new System.EventHandler(this.txtBoxInfo_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
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
        private System.Windows.Forms.Button btnSend3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.CheckBox checkBoxClear3;
        private System.Windows.Forms.TextBox txtBoxNeeds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}
