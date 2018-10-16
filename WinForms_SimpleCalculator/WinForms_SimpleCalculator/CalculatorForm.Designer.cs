namespace WinForms_SimpleCalculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.tb_Cost1 = new System.Windows.Forms.TextBox();
            this.lbl_Cost1 = new System.Windows.Forms.Label();
            this.lbl_Quantity1 = new System.Windows.Forms.Label();
            this.tb_Quantity1 = new System.Windows.Forms.TextBox();
            this.butt_Calculate = new System.Windows.Forms.Button();
            this.lbl_Roomates = new System.Windows.Forms.Label();
            this.nud_Roomates = new System.Windows.Forms.NumericUpDown();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_Purchases = new System.Windows.Forms.GroupBox();
            this.rb_Three = new System.Windows.Forms.RadioButton();
            this.rb_Two = new System.Windows.Forms.RadioButton();
            this.rb_One = new System.Windows.Forms.RadioButton();
            this.lbl_Discount1 = new System.Windows.Forms.Label();
            this.nud_Discount1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.butt_Reset = new System.Windows.Forms.Button();
            this.butt_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Roomates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Purchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Cost1
            // 
            this.tb_Cost1.Location = new System.Drawing.Point(341, 117);
            this.tb_Cost1.Name = "tb_Cost1";
            this.tb_Cost1.Size = new System.Drawing.Size(83, 20);
            this.tb_Cost1.TabIndex = 1;
            // 
            // lbl_Cost1
            // 
            this.lbl_Cost1.AutoSize = true;
            this.lbl_Cost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost1.Location = new System.Drawing.Point(338, 97);
            this.lbl_Cost1.Name = "lbl_Cost1";
            this.lbl_Cost1.Size = new System.Drawing.Size(86, 17);
            this.lbl_Cost1.TabIndex = 2;
            this.lbl_Cost1.Text = "Cost of Item:";
            // 
            // lbl_Quantity1
            // 
            this.lbl_Quantity1.AutoSize = true;
            this.lbl_Quantity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity1.Location = new System.Drawing.Point(221, 97);
            this.lbl_Quantity1.Name = "lbl_Quantity1";
            this.lbl_Quantity1.Size = new System.Drawing.Size(111, 17);
            this.lbl_Quantity1.TabIndex = 3;
            this.lbl_Quantity1.Text = "Quantity of Item:";
            // 
            // tb_Quantity1
            // 
            this.tb_Quantity1.Location = new System.Drawing.Point(224, 117);
            this.tb_Quantity1.Name = "tb_Quantity1";
            this.tb_Quantity1.Size = new System.Drawing.Size(108, 20);
            this.tb_Quantity1.TabIndex = 0;
            // 
            // butt_Calculate
            // 
            this.butt_Calculate.Location = new System.Drawing.Point(224, 241);
            this.butt_Calculate.Name = "butt_Calculate";
            this.butt_Calculate.Size = new System.Drawing.Size(108, 34);
            this.butt_Calculate.TabIndex = 3;
            this.butt_Calculate.Text = "Calculate";
            this.butt_Calculate.UseVisualStyleBackColor = true;
            this.butt_Calculate.Click += new System.EventHandler(this.butt_Calculate_Click);
            // 
            // lbl_Roomates
            // 
            this.lbl_Roomates.AutoSize = true;
            this.lbl_Roomates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roomates.Location = new System.Drawing.Point(430, 54);
            this.lbl_Roomates.Name = "lbl_Roomates";
            this.lbl_Roomates.Size = new System.Drawing.Size(98, 17);
            this.lbl_Roomates.TabIndex = 8;
            this.lbl_Roomates.Text = "No. Roomates";
            // 
            // nud_Roomates
            // 
            this.nud_Roomates.Location = new System.Drawing.Point(433, 74);
            this.nud_Roomates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Roomates.Name = "nud_Roomates";
            this.nud_Roomates.Size = new System.Drawing.Size(95, 20);
            this.nud_Roomates.TabIndex = 2;
            this.nud_Roomates.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(218, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(295, 31);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Shared Cost Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // gb_Purchases
            // 
            this.gb_Purchases.Controls.Add(this.rb_Three);
            this.gb_Purchases.Controls.Add(this.rb_Two);
            this.gb_Purchases.Controls.Add(this.rb_One);
            this.gb_Purchases.Location = new System.Drawing.Point(224, 44);
            this.gb_Purchases.Name = "gb_Purchases";
            this.gb_Purchases.Size = new System.Drawing.Size(200, 50);
            this.gb_Purchases.TabIndex = 13;
            this.gb_Purchases.TabStop = false;
            this.gb_Purchases.Text = "Total Purchases";
            // 
            // rb_Three
            // 
            this.rb_Three.AutoSize = true;
            this.rb_Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Three.Location = new System.Drawing.Point(124, 20);
            this.rb_Three.Name = "rb_Three";
            this.rb_Three.Size = new System.Drawing.Size(64, 21);
            this.rb_Three.TabIndex = 2;
            this.rb_Three.Text = "Three";
            this.rb_Three.UseVisualStyleBackColor = true;
            // 
            // rb_Two
            // 
            this.rb_Two.AutoSize = true;
            this.rb_Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Two.Location = new System.Drawing.Point(66, 20);
            this.rb_Two.Name = "rb_Two";
            this.rb_Two.Size = new System.Drawing.Size(52, 21);
            this.rb_Two.TabIndex = 1;
            this.rb_Two.Text = "Two";
            this.rb_Two.UseVisualStyleBackColor = true;
            // 
            // rb_One
            // 
            this.rb_One.AutoSize = true;
            this.rb_One.Checked = true;
            this.rb_One.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_One.Location = new System.Drawing.Point(7, 20);
            this.rb_One.Name = "rb_One";
            this.rb_One.Size = new System.Drawing.Size(53, 21);
            this.rb_One.TabIndex = 0;
            this.rb_One.TabStop = true;
            this.rb_One.Text = "One";
            this.rb_One.UseVisualStyleBackColor = true;
            // 
            // lbl_Discount1
            // 
            this.lbl_Discount1.AutoSize = true;
            this.lbl_Discount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount1.Location = new System.Drawing.Point(430, 97);
            this.lbl_Discount1.Name = "lbl_Discount1";
            this.lbl_Discount1.Size = new System.Drawing.Size(120, 17);
            this.lbl_Discount1.TabIndex = 15;
            this.lbl_Discount1.Text = "Discount Percent:";
            // 
            // nud_Discount1
            // 
            this.nud_Discount1.Location = new System.Drawing.Point(433, 117);
            this.nud_Discount1.Name = "nud_Discount1";
            this.nud_Discount1.Size = new System.Drawing.Size(114, 20);
            this.nud_Discount1.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(433, 160);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Discount Percent:";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(224, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantity of Item:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cost of Item:";
            this.label3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(341, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Visible = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(433, 203);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Discount Percent:";
            this.label4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(224, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 20);
            this.textBox3.TabIndex = 24;
            this.textBox3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Quantity of Item:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cost of Item:";
            this.label6.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(341, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 20);
            this.textBox4.TabIndex = 25;
            this.textBox4.Visible = false;
            // 
            // butt_Reset
            // 
            this.butt_Reset.Location = new System.Drawing.Point(341, 241);
            this.butt_Reset.Name = "butt_Reset";
            this.butt_Reset.Size = new System.Drawing.Size(83, 34);
            this.butt_Reset.TabIndex = 30;
            this.butt_Reset.Text = "Reset";
            this.butt_Reset.UseVisualStyleBackColor = true;
            // 
            // butt_Help
            // 
            this.butt_Help.Location = new System.Drawing.Point(452, 242);
            this.butt_Help.Name = "butt_Help";
            this.butt_Help.Size = new System.Drawing.Size(95, 34);
            this.butt_Help.TabIndex = 31;
            this.butt_Help.Text = "Help";
            this.butt_Help.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 287);
            this.Controls.Add(this.butt_Help);
            this.Controls.Add(this.butt_Reset);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nud_Discount1);
            this.Controls.Add(this.lbl_Discount1);
            this.Controls.Add(this.gb_Purchases);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nud_Roomates);
            this.Controls.Add(this.lbl_Roomates);
            this.Controls.Add(this.butt_Calculate);
            this.Controls.Add(this.tb_Quantity1);
            this.Controls.Add(this.lbl_Quantity1);
            this.Controls.Add(this.lbl_Cost1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.tb_Cost1);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Roomates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Purchases.ResumeLayout(false);
            this.gb_Purchases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Cost1;
        private System.Windows.Forms.Label lbl_Cost1;
        private System.Windows.Forms.Label lbl_Quantity1;
        private System.Windows.Forms.TextBox tb_Quantity1;
        private System.Windows.Forms.Button butt_Calculate;
        private System.Windows.Forms.Label lbl_Roomates;
        private System.Windows.Forms.NumericUpDown nud_Roomates;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_Purchases;
        private System.Windows.Forms.RadioButton rb_Two;
        private System.Windows.Forms.RadioButton rb_One;
        private System.Windows.Forms.RadioButton rb_Three;
        private System.Windows.Forms.Label lbl_Discount1;
        private System.Windows.Forms.NumericUpDown nud_Discount1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button butt_Reset;
        private System.Windows.Forms.Button butt_Help;
    }
}

