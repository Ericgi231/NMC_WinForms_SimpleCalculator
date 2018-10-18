using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        public void ResetLabelColors()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is Label)
                        (control as Label).ForeColor = Color.Black;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void butt_Calculate_Click(object sender, EventArgs e)
        {
            int item1Cost, item1Quantity, item2Cost, item2Quantity, item3Cost, item3Quantity;
            int item1Total = 0, item2Total = 0, item3Total = 0;
            int grandTotal, grandTotalPerPerson;
            bool pass = true;

            ResetLabelColors();

            //item one calcs
            if (!int.TryParse(tb_Cost1.Text, out item1Cost))
            {
                lbl_Cost1.ForeColor = Color.Red;
                tb_Cost1.Focus();
                pass = false;
            }
            if (!int.TryParse(tb_Quantity1.Text, out item1Quantity))
            {
                lbl_Quantity1.ForeColor = Color.Red;
                tb_Quantity1.Focus();
                pass = false;
            }

            item1Total = item1Cost * item1Quantity;

            if (rb_Two.Checked || rb_Three.Checked)
            {
                //item two calcs
                if (!int.TryParse(tb_Cost2.Text, out item2Cost))
                {
                    lbl_Cost2.ForeColor = Color.Red;
                    tb_Cost2.Focus();
                    pass = false;
                }
                if (!int.TryParse(tb_Quantity2.Text, out item2Quantity))
                {
                    lbl_Quantity2.ForeColor = Color.Red;
                    tb_Quantity2.Focus();
                    pass = false;
                }

                item2Total = item2Cost * item2Quantity;
            }

            if (rb_Three.Checked)
            {
                //item three calcs
                if (!int.TryParse(tb_Cost3.Text, out item3Cost))
                {
                    lbl_Cost3.ForeColor = Color.Red;
                    tb_Cost3.Focus();
                    pass = false;
                }
                if (!int.TryParse(tb_Quantity3.Text, out item3Quantity))
                {
                    lbl_Quantity3.ForeColor = Color.Red;
                    tb_Quantity3.Focus();
                    pass = false;
                }

                item3Total = item3Cost * item3Quantity;
            }

            if (pass)
            {
                //Final Math
                grandTotal = item1Total + item2Total + item3Total;

                //print to solution window
                FormCollection fc = Application.OpenForms;
                foreach (Form f in fc)
                {
                    if (f.GetType() == typeof(SolutionForm))
                    {
                        f.Close();
                        break;
                    }
                }

                SolutionForm sf = new SolutionForm();
                string total = "$" + (num1 * num2).ToString();
                string totalPer = "$" + ((num1 * num2) / num3).ToString();
                sf.SetTotals(total, totalPer);
                sf.Show();
            }
        }

        private void butt_Reset_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void butt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void rb_One_CheckedChanged(object sender, EventArgs e)
        {
            pan_Item1.Visible = true;
            pan_Item2.Visible = false;
            pan_Item3.Visible = false;
        }

        private void rb_Two_CheckedChanged(object sender, EventArgs e)
        {
            pan_Item1.Visible = true;
            pan_Item2.Visible = true;
            pan_Item3.Visible = false;
        }

        private void rb_Three_CheckedChanged(object sender, EventArgs e)
        {
            pan_Item1.Visible = true;
            pan_Item2.Visible = true;
            pan_Item3.Visible = true;
        }
    }
}
