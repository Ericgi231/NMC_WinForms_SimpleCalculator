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
            this.butt_Reset = new System.Windows.Forms.Button();
            this.butt_Help = new System.Windows.Forms.Button();
            this.butt_Close = new System.Windows.Forms.Button();
            this.pan_Item1 = new System.Windows.Forms.Panel();
            this.pan_Item2 = new System.Windows.Forms.Panel();
            this.lbl_Quantity2 = new System.Windows.Forms.Label();
            this.tb_Quantity2 = new System.Windows.Forms.TextBox();
            this.lbl_Cost2 = new System.Windows.Forms.Label();
            this.tb_Cost2 = new System.Windows.Forms.TextBox();
            this.nud_Discount2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Discount2 = new System.Windows.Forms.Label();
            this.pan_Item3 = new System.Windows.Forms.Panel();
            this.lbl_Quantity3 = new System.Windows.Forms.Label();
            this.tb_Quantity3 = new System.Windows.Forms.TextBox();
            this.lbl_Cost3 = new System.Windows.Forms.Label();
            this.tb_Cost3 = new System.Windows.Forms.TextBox();
            this.nud_Discount3 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Discount3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Roomates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Purchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount1)).BeginInit();
            this.pan_Item1.SuspendLayout();
            this.pan_Item2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount2)).BeginInit();
            this.pan_Item3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount3)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Cost1
            // 
            this.tb_Cost1.Location = new System.Drawing.Point(117, 17);
            this.tb_Cost1.Name = "tb_Cost1";
            this.tb_Cost1.Size = new System.Drawing.Size(83, 20);
            this.tb_Cost1.TabIndex = 1;
            // 
            // lbl_Cost1
            // 
            this.lbl_Cost1.AutoSize = true;
            this.lbl_Cost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost1.Location = new System.Drawing.Point(114, 0);
            this.lbl_Cost1.Name = "lbl_Cost1";
            this.lbl_Cost1.Size = new System.Drawing.Size(86, 17);
            this.lbl_Cost1.TabIndex = 2;
            this.lbl_Cost1.Text = "Cost of Item:";
            // 
            // lbl_Quantity1
            // 
            this.lbl_Quantity1.AutoSize = true;
            this.lbl_Quantity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity1.Location = new System.Drawing.Point(-3, 0);
            this.lbl_Quantity1.Name = "lbl_Quantity1";
            this.lbl_Quantity1.Size = new System.Drawing.Size(111, 17);
            this.lbl_Quantity1.TabIndex = 3;
            this.lbl_Quantity1.Text = "Quantity of Item:";
            // 
            // tb_Quantity1
            // 
            this.tb_Quantity1.Location = new System.Drawing.Point(0, 17);
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
            this.pictureBox1.Image = global::WinForms_SimpleCalculator.Properties.Resources.kitchen;
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
            this.rb_Three.CheckedChanged += new System.EventHandler(this.rb_Three_CheckedChanged);
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
            this.rb_Two.CheckedChanged += new System.EventHandler(this.rb_Two_CheckedChanged);
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
            this.rb_One.CheckedChanged += new System.EventHandler(this.rb_One_CheckedChanged);
            // 
            // lbl_Discount1
            // 
            this.lbl_Discount1.AutoSize = true;
            this.lbl_Discount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount1.Location = new System.Drawing.Point(206, 0);
            this.lbl_Discount1.Name = "lbl_Discount1";
            this.lbl_Discount1.Size = new System.Drawing.Size(120, 17);
            this.lbl_Discount1.TabIndex = 15;
            this.lbl_Discount1.Text = "Discount Percent:";
            // 
            // nud_Discount1
            // 
            this.nud_Discount1.Location = new System.Drawing.Point(209, 17);
            this.nud_Discount1.Name = "nud_Discount1";
            this.nud_Discount1.Size = new System.Drawing.Size(114, 20);
            this.nud_Discount1.TabIndex = 17;
            // 
            // butt_Reset
            // 
            this.butt_Reset.Location = new System.Drawing.Point(341, 241);
            this.butt_Reset.Name = "butt_Reset";
            this.butt_Reset.Size = new System.Drawing.Size(83, 34);
            this.butt_Reset.TabIndex = 30;
            this.butt_Reset.Text = "Reset";
            this.butt_Reset.UseVisualStyleBackColor = true;
            this.butt_Reset.Click += new System.EventHandler(this.butt_Reset_Click);
            // 
            // butt_Help
            // 
            this.butt_Help.Location = new System.Drawing.Point(433, 241);
            this.butt_Help.Name = "butt_Help";
            this.butt_Help.Size = new System.Drawing.Size(54, 34);
            this.butt_Help.TabIndex = 31;
            this.butt_Help.Text = "Help";
            this.butt_Help.UseVisualStyleBackColor = true;
            this.butt_Help.Click += new System.EventHandler(this.butt_Help_Click);
            // 
            // butt_Close
            // 
            this.butt_Close.Location = new System.Drawing.Point(493, 241);
            this.butt_Close.Name = "butt_Close";
            this.butt_Close.Size = new System.Drawing.Size(54, 34);
            this.butt_Close.TabIndex = 32;
            this.butt_Close.Text = "Close";
            this.butt_Close.UseVisualStyleBackColor = true;
            this.butt_Close.Click += new System.EventHandler(this.butt_Close_Click);
            // 
            // pan_Item1
            // 
            this.pan_Item1.Controls.Add(this.lbl_Quantity1);
            this.pan_Item1.Controls.Add(this.tb_Quantity1);
            this.pan_Item1.Controls.Add(this.lbl_Cost1);
            this.pan_Item1.Controls.Add(this.tb_Cost1);
            this.pan_Item1.Controls.Add(this.nud_Discount1);
            this.pan_Item1.Controls.Add(this.lbl_Discount1);
            this.pan_Item1.Location = new System.Drawing.Point(224, 100);
            this.pan_Item1.Name = "pan_Item1";
            this.pan_Item1.Size = new System.Drawing.Size(323, 37);
            this.pan_Item1.TabIndex = 33;
            // 
            // pan_Item2
            // 
            this.pan_Item2.Controls.Add(this.lbl_Quantity2);
            this.pan_Item2.Controls.Add(this.tb_Quantity2);
            this.pan_Item2.Controls.Add(this.lbl_Cost2);
            this.pan_Item2.Controls.Add(this.tb_Cost2);
            this.pan_Item2.Controls.Add(this.nud_Discount2);
            this.pan_Item2.Controls.Add(this.lbl_Discount2);
            this.pan_Item2.Location = new System.Drawing.Point(224, 143);
            this.pan_Item2.Name = "pan_Item2";
            this.pan_Item2.Size = new System.Drawing.Size(323, 37);
            this.pan_Item2.TabIndex = 34;
            this.pan_Item2.Visible = false;
            // 
            // lbl_Quantity2
            // 
            this.lbl_Quantity2.AutoSize = true;
            this.lbl_Quantity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity2.Location = new System.Drawing.Point(-3, 0);
            this.lbl_Quantity2.Name = "lbl_Quantity2";
            this.lbl_Quantity2.Size = new System.Drawing.Size(111, 17);
            this.lbl_Quantity2.TabIndex = 3;
            this.lbl_Quantity2.Text = "Quantity of Item:";
            // 
            // tb_Quantity2
            // 
            this.tb_Quantity2.Location = new System.Drawing.Point(0, 17);
            this.tb_Quantity2.Name = "tb_Quantity2";
            this.tb_Quantity2.Size = new System.Drawing.Size(108, 20);
            this.tb_Quantity2.TabIndex = 0;
            // 
            // lbl_Cost2
            // 
            this.lbl_Cost2.AutoSize = true;
            this.lbl_Cost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost2.Location = new System.Drawing.Point(114, 0);
            this.lbl_Cost2.Name = "lbl_Cost2";
            this.lbl_Cost2.Size = new System.Drawing.Size(86, 17);
            this.lbl_Cost2.TabIndex = 2;
            this.lbl_Cost2.Text = "Cost of Item:";
            // 
            // tb_Cost2
            // 
            this.tb_Cost2.Location = new System.Drawing.Point(117, 17);
            this.tb_Cost2.Name = "tb_Cost2";
            this.tb_Cost2.Size = new System.Drawing.Size(83, 20);
            this.tb_Cost2.TabIndex = 1;
            // 
            // nud_Discount2
            // 
            this.nud_Discount2.Location = new System.Drawing.Point(209, 17);
            this.nud_Discount2.Name = "nud_Discount2";
            this.nud_Discount2.Size = new System.Drawing.Size(114, 20);
            this.nud_Discount2.TabIndex = 17;
            // 
            // lbl_Discount2
            // 
            this.lbl_Discount2.AutoSize = true;
            this.lbl_Discount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount2.Location = new System.Drawing.Point(206, 0);
            this.lbl_Discount2.Name = "lbl_Discount2";
            this.lbl_Discount2.Size = new System.Drawing.Size(120, 17);
            this.lbl_Discount2.TabIndex = 15;
            this.lbl_Discount2.Text = "Discount Percent:";
            // 
            // pan_Item3
            // 
            this.pan_Item3.Controls.Add(this.lbl_Quantity3);
            this.pan_Item3.Controls.Add(this.tb_Quantity3);
            this.pan_Item3.Controls.Add(this.lbl_Cost3);
            this.pan_Item3.Controls.Add(this.tb_Cost3);
            this.pan_Item3.Controls.Add(this.nud_Discount3);
            this.pan_Item3.Controls.Add(this.lbl_Discount3);
            this.pan_Item3.Location = new System.Drawing.Point(224, 186);
            this.pan_Item3.Name = "pan_Item3";
            this.pan_Item3.Size = new System.Drawing.Size(323, 37);
            this.pan_Item3.TabIndex = 34;
            this.pan_Item3.Visible = false;
            // 
            // lbl_Quantity3
            // 
            this.lbl_Quantity3.AutoSize = true;
            this.lbl_Quantity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity3.Location = new System.Drawing.Point(-3, 0);
            this.lbl_Quantity3.Name = "lbl_Quantity3";
            this.lbl_Quantity3.Size = new System.Drawing.Size(111, 17);
            this.lbl_Quantity3.TabIndex = 3;
            this.lbl_Quantity3.Text = "Quantity of Item:";
            // 
            // tb_Quantity3
            // 
            this.tb_Quantity3.Location = new System.Drawing.Point(0, 17);
            this.tb_Quantity3.Name = "tb_Quantity3";
            this.tb_Quantity3.Size = new System.Drawing.Size(108, 20);
            this.tb_Quantity3.TabIndex = 0;
            // 
            // lbl_Cost3
            // 
            this.lbl_Cost3.AutoSize = true;
            this.lbl_Cost3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost3.Location = new System.Drawing.Point(114, 0);
            this.lbl_Cost3.Name = "lbl_Cost3";
            this.lbl_Cost3.Size = new System.Drawing.Size(86, 17);
            this.lbl_Cost3.TabIndex = 2;
            this.lbl_Cost3.Text = "Cost of Item:";
            // 
            // tb_Cost3
            // 
            this.tb_Cost3.Location = new System.Drawing.Point(117, 17);
            this.tb_Cost3.Name = "tb_Cost3";
            this.tb_Cost3.Size = new System.Drawing.Size(83, 20);
            this.tb_Cost3.TabIndex = 1;
            // 
            // nud_Discount3
            // 
            this.nud_Discount3.Location = new System.Drawing.Point(209, 17);
            this.nud_Discount3.Name = "nud_Discount3";
            this.nud_Discount3.Size = new System.Drawing.Size(114, 20);
            this.nud_Discount3.TabIndex = 17;
            // 
            // lbl_Discount3
            // 
            this.lbl_Discount3.AutoSize = true;
            this.lbl_Discount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount3.Location = new System.Drawing.Point(206, 0);
            this.lbl_Discount3.Name = "lbl_Discount3";
            this.lbl_Discount3.Size = new System.Drawing.Size(120, 17);
            this.lbl_Discount3.TabIndex = 15;
            this.lbl_Discount3.Text = "Discount Percent:";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 287);
            this.Controls.Add(this.pan_Item3);
            this.Controls.Add(this.pan_Item2);
            this.Controls.Add(this.pan_Item1);
            this.Controls.Add(this.butt_Close);
            this.Controls.Add(this.butt_Help);
            this.Controls.Add(this.butt_Reset);
            this.Controls.Add(this.gb_Purchases);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nud_Roomates);
            this.Controls.Add(this.lbl_Roomates);
            this.Controls.Add(this.butt_Calculate);
            this.Controls.Add(this.lbl_Title);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Roomates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Purchases.ResumeLayout(false);
            this.gb_Purchases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount1)).EndInit();
            this.pan_Item1.ResumeLayout(false);
            this.pan_Item1.PerformLayout();
            this.pan_Item2.ResumeLayout(false);
            this.pan_Item2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount2)).EndInit();
            this.pan_Item3.ResumeLayout(false);
            this.pan_Item3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Discount3)).EndInit();
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
        private System.Windows.Forms.Button butt_Reset;
        private System.Windows.Forms.Button butt_Help;
        private System.Windows.Forms.Button butt_Close;
        private System.Windows.Forms.Panel pan_Item1;
        private System.Windows.Forms.Panel pan_Item2;
        private System.Windows.Forms.Label lbl_Quantity2;
        private System.Windows.Forms.TextBox tb_Quantity2;
        private System.Windows.Forms.Label lbl_Cost2;
        private System.Windows.Forms.TextBox tb_Cost2;
        private System.Windows.Forms.NumericUpDown nud_Discount2;
        private System.Windows.Forms.Label lbl_Discount2;
        private System.Windows.Forms.Panel pan_Item3;
        private System.Windows.Forms.Label lbl_Quantity3;
        private System.Windows.Forms.TextBox tb_Quantity3;
        private System.Windows.Forms.Label lbl_Cost3;
        private System.Windows.Forms.TextBox tb_Cost3;
        private System.Windows.Forms.NumericUpDown nud_Discount3;
        private System.Windows.Forms.Label lbl_Discount3;
    }
}

