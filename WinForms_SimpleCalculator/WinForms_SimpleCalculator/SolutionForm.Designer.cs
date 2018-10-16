namespace WinForms_SimpleCalculator
{
    partial class SolutionForm
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
            this.lbl_PerCost = new System.Windows.Forms.Label();
            this.tb_TotalPerPerson = new System.Windows.Forms.TextBox();
            this.lbl_TotalCost = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.butt_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PerCost
            // 
            this.lbl_PerCost.AutoSize = true;
            this.lbl_PerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PerCost.Location = new System.Drawing.Point(176, 12);
            this.lbl_PerCost.Name = "lbl_PerCost";
            this.lbl_PerCost.Size = new System.Drawing.Size(111, 17);
            this.lbl_PerCost.TabIndex = 15;
            this.lbl_PerCost.Text = "Cost Per Person";
            // 
            // tb_TotalPerPerson
            // 
            this.tb_TotalPerPerson.Location = new System.Drawing.Point(179, 32);
            this.tb_TotalPerPerson.Name = "tb_TotalPerPerson";
            this.tb_TotalPerPerson.Size = new System.Drawing.Size(100, 20);
            this.tb_TotalPerPerson.TabIndex = 2;
            // 
            // lbl_TotalCost
            // 
            this.lbl_TotalCost.AutoSize = true;
            this.lbl_TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCost.Location = new System.Drawing.Point(86, 12);
            this.lbl_TotalCost.Name = "lbl_TotalCost";
            this.lbl_TotalCost.Size = new System.Drawing.Size(72, 17);
            this.lbl_TotalCost.TabIndex = 14;
            this.lbl_TotalCost.Text = "Total Cost";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(89, 32);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(81, 20);
            this.tb_Total.TabIndex = 1;
            // 
            // butt_Back
            // 
            this.butt_Back.Location = new System.Drawing.Point(12, 12);
            this.butt_Back.Name = "butt_Back";
            this.butt_Back.Size = new System.Drawing.Size(68, 40);
            this.butt_Back.TabIndex = 0;
            this.butt_Back.Text = "Back";
            this.butt_Back.UseVisualStyleBackColor = true;
            this.butt_Back.Click += new System.EventHandler(this.butt_Back_Click);
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 63);
            this.Controls.Add(this.butt_Back);
            this.Controls.Add(this.lbl_PerCost);
            this.Controls.Add(this.tb_TotalPerPerson);
            this.Controls.Add(this.lbl_TotalCost);
            this.Controls.Add(this.tb_Total);
            this.Name = "SolutionForm";
            this.Text = "Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PerCost;
        private System.Windows.Forms.TextBox tb_TotalPerPerson;
        private System.Windows.Forms.Label lbl_TotalCost;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Button butt_Back;
    }
}