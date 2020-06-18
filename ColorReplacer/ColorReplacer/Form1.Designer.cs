namespace ColorReplacer
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ColorDisplay2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alp1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.blue1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.green1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.red1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorDisplay = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisplay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ColorDisplay2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.alp1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.blue1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.green1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.red1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 256);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ความคลาดเคลื่อน";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 20);
            this.button4.TabIndex = 26;
            this.button4.Text = "PickColor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Color to find";
            // 
            // ColorDisplay2
            // 
            this.ColorDisplay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorDisplay2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorDisplay2.Location = new System.Drawing.Point(2, 151);
            this.ColorDisplay2.Name = "ColorDisplay2";
            this.ColorDisplay2.Size = new System.Drawing.Size(136, 49);
            this.ColorDisplay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColorDisplay2.TabIndex = 24;
            this.ColorDisplay2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "HotReplace";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Replace";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Replace);
            // 
            // alp1
            // 
            this.alp1.Location = new System.Drawing.Point(62, 101);
            this.alp1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alp1.Name = "alp1";
            this.alp1.Size = new System.Drawing.Size(41, 20);
            this.alp1.TabIndex = 10;
            this.alp1.ValueChanged += new System.EventHandler(this.OnMumericchange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ALPHA ± ";
            // 
            // blue1
            // 
            this.blue1.Location = new System.Drawing.Point(62, 72);
            this.blue1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(41, 20);
            this.blue1.TabIndex = 7;
            this.blue1.ValueChanged += new System.EventHandler(this.OnMumericchange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BLUE      ±";
            // 
            // green1
            // 
            this.green1.Location = new System.Drawing.Point(62, 46);
            this.green1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.green1.Name = "green1";
            this.green1.Size = new System.Drawing.Size(41, 20);
            this.green1.TabIndex = 4;
            this.green1.ValueChanged += new System.EventHandler(this.OnMumericchange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GREEN   ±";
            // 
            // red1
            // 
            this.red1.Location = new System.Drawing.Point(62, 17);
            this.red1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(41, 20);
            this.red1.TabIndex = 1;
            this.red1.ValueChanged += new System.EventHandler(this.OnMumericchange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RED        ±";
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorDisplay.Location = new System.Drawing.Point(10, 292);
            this.ColorDisplay.Name = "ColorDisplay";
            this.ColorDisplay.Size = new System.Drawing.Size(136, 49);
            this.ColorDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ColorDisplay.TabIndex = 12;
            this.ColorDisplay.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(152, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 363);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Previews";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OnSave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OpenForFile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnOpen);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "replace with";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(79, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 20);
            this.button5.TabIndex = 23;
            this.button5.Text = "PickColor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 379);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ColorDisplay);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorDisplay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown alp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown blue1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown green1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown red1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ColorDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ColorDisplay2;
    }
}

