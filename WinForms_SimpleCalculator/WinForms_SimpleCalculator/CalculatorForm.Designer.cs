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
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.lbl_CostOfItem = new System.Windows.Forms.Label();
            this.lbl_QuantityOfItem = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.butt_Calculate = new System.Windows.Forms.Button();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.lbl_NumberOfRoomates = new System.Windows.Forms.Label();
            this.lbl_TotalCost = new System.Windows.Forms.Label();
            this.lbl_PerCost = new System.Windows.Forms.Label();
            this.tb_TotalPerPerson = new System.Windows.Forms.TextBox();
            this.nud_Roomates = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Roomates)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Cost
            // 
            this.tb_Cost.Location = new System.Drawing.Point(15, 72);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(100, 20);
            this.tb_Cost.TabIndex = 1;
            // 
            // lbl_CostOfItem
            // 
            this.lbl_CostOfItem.AutoSize = true;
            this.lbl_CostOfItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CostOfItem.Location = new System.Drawing.Point(12, 52);
            this.lbl_CostOfItem.Name = "lbl_CostOfItem";
            this.lbl_CostOfItem.Size = new System.Drawing.Size(86, 17);
            this.lbl_CostOfItem.TabIndex = 2;
            this.lbl_CostOfItem.Text = "Cost of Item:";
            // 
            // lbl_QuantityOfItem
            // 
            this.lbl_QuantityOfItem.AutoSize = true;
            this.lbl_QuantityOfItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuantityOfItem.Location = new System.Drawing.Point(12, 9);
            this.lbl_QuantityOfItem.Name = "lbl_QuantityOfItem";
            this.lbl_QuantityOfItem.Size = new System.Drawing.Size(111, 17);
            this.lbl_QuantityOfItem.TabIndex = 3;
            this.lbl_QuantityOfItem.Text = "Quantity of Item:";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Location = new System.Drawing.Point(15, 29);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(100, 20);
            this.tb_Quantity.TabIndex = 0;
            // 
            // butt_Calculate
            // 
            this.butt_Calculate.Location = new System.Drawing.Point(173, 26);
            this.butt_Calculate.Name = "butt_Calculate";
            this.butt_Calculate.Size = new System.Drawing.Size(75, 23);
            this.butt_Calculate.TabIndex = 3;
            this.butt_Calculate.Text = "Calculate";
            this.butt_Calculate.UseVisualStyleBackColor = true;
            this.butt_Calculate.Click += new System.EventHandler(this.butt_Calculate_Click);
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(173, 72);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(100, 20);
            this.tb_Total.TabIndex = 4;
            // 
            // lbl_NumberOfRoomates
            // 
            this.lbl_NumberOfRoomates.AutoSize = true;
            this.lbl_NumberOfRoomates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberOfRoomates.Location = new System.Drawing.Point(12, 95);
            this.lbl_NumberOfRoomates.Name = "lbl_NumberOfRoomates";
            this.lbl_NumberOfRoomates.Size = new System.Drawing.Size(142, 17);
            this.lbl_NumberOfRoomates.TabIndex = 8;
            this.lbl_NumberOfRoomates.Text = "Number of Roomates";
            // 
            // lbl_TotalCost
            // 
            this.lbl_TotalCost.AutoSize = true;
            this.lbl_TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCost.Location = new System.Drawing.Point(170, 52);
            this.lbl_TotalCost.Name = "lbl_TotalCost";
            this.lbl_TotalCost.Size = new System.Drawing.Size(72, 17);
            this.lbl_TotalCost.TabIndex = 9;
            this.lbl_TotalCost.Text = "Total Cost";
            // 
            // lbl_PerCost
            // 
            this.lbl_PerCost.AutoSize = true;
            this.lbl_PerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PerCost.Location = new System.Drawing.Point(170, 95);
            this.lbl_PerCost.Name = "lbl_PerCost";
            this.lbl_PerCost.Size = new System.Drawing.Size(111, 17);
            this.lbl_PerCost.TabIndex = 11;
            this.lbl_PerCost.Text = "Cost Per Person";
            // 
            // tb_TotalPerPerson
            // 
            this.tb_TotalPerPerson.Location = new System.Drawing.Point(173, 115);
            this.tb_TotalPerPerson.Name = "tb_TotalPerPerson";
            this.tb_TotalPerPerson.Size = new System.Drawing.Size(100, 20);
            this.tb_TotalPerPerson.TabIndex = 5;
            // 
            // nud_Roomates
            // 
            this.nud_Roomates.Location = new System.Drawing.Point(15, 116);
            this.nud_Roomates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Roomates.Name = "nud_Roomates";
            this.nud_Roomates.Size = new System.Drawing.Size(120, 20);
            this.nud_Roomates.TabIndex = 2;
            this.nud_Roomates.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 149);
            this.Controls.Add(this.nud_Roomates);
            this.Controls.Add(this.lbl_PerCost);
            this.Controls.Add(this.tb_TotalPerPerson);
            this.Controls.Add(this.lbl_TotalCost);
            this.Controls.Add(this.lbl_NumberOfRoomates);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.butt_Calculate);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.lbl_QuantityOfItem);
            this.Controls.Add(this.lbl_CostOfItem);
            this.Controls.Add(this.tb_Cost);
            this.Name = "CalculatorForm";
            this.Text = "Roomate Supply Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Roomates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.Label lbl_CostOfItem;
        private System.Windows.Forms.Label lbl_QuantityOfItem;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Button butt_Calculate;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label lbl_NumberOfRoomates;
        private System.Windows.Forms.Label lbl_TotalCost;
        private System.Windows.Forms.Label lbl_PerCost;
        private System.Windows.Forms.TextBox tb_TotalPerPerson;
        private System.Windows.Forms.NumericUpDown nud_Roomates;
    }
}

