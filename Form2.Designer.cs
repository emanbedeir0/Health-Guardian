namespace MedicineReminderApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textMedName = new System.Windows.Forms.TextBox();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxMedicines = new System.Windows.Forms.ListBox();
            this.numDoseAmount = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoseAmount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textMedName
            // 
            this.textMedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMedName.Location = new System.Drawing.Point(393, 20);
            this.textMedName.Name = "textMedName";
            this.textMedName.Size = new System.Drawing.Size(230, 32);
            this.textMedName.TabIndex = 0;
            this.textMedName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numHour
            // 
            this.numHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHour.Location = new System.Drawing.Point(393, 185);
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(230, 32);
            this.numHour.TabIndex = 2;
            // 
            // numQty
            // 
            this.numQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.Location = new System.Drawing.Point(393, 127);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(230, 32);
            this.numQty.TabIndex = 3;
            this.numQty.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numMin
            // 
            this.numMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMin.Location = new System.Drawing.Point(393, 237);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(230, 32);
            this.numMin.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(400, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxMedicines
            // 
            this.listBoxMedicines.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMedicines.FormattingEnabled = true;
            this.listBoxMedicines.ItemHeight = 25;
            this.listBoxMedicines.Location = new System.Drawing.Point(46, 305);
            this.listBoxMedicines.Name = "listBoxMedicines";
            this.listBoxMedicines.Size = new System.Drawing.Size(678, 279);
            this.listBoxMedicines.TabIndex = 7;
            this.toolTip1.SetToolTip(this.listBoxMedicines, "Double click to delet a medicine");
            this.listBoxMedicines.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicines_SelectedIndexChanged);
            // 
            // numDoseAmount
            // 
            this.numDoseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDoseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDoseAmount.Location = new System.Drawing.Point(393, 72);
            this.numDoseAmount.Name = "numDoseAmount";
            this.numDoseAmount.Size = new System.Drawing.Size(230, 32);
            this.numDoseAmount.TabIndex = 8;
            this.numDoseAmount.ValueChanged += new System.EventHandler(this.numDoseAmount_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(325, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 70);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show Weekly Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxMedicines);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.numDoseAmount);
            this.panel1.Controls.Add(this.numHour);
            this.panel1.Controls.Add(this.numQty);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textMedName);
            this.panel1.Location = new System.Drawing.Point(293, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 716);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedecineReminderApp.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(349, 599);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(272, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 38);
            this.label4.TabIndex = 18;
            this.label4.Text = "Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(301, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(180, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(302, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dose";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(90, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Medicine Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedecineReminderApp.Properties.Resources.WhatsApp_Image_2026_04_21_at_10_13_17_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 708);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Medicine Reminder";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoseAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textMedName;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxMedicines;
        private System.Windows.Forms.NumericUpDown numDoseAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}