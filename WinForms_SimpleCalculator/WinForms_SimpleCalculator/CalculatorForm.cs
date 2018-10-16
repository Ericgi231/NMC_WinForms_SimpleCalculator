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

        private void butt_Calculate_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            bool pass = true;
            lbl_Cost1.ForeColor = Color.Black;
            lbl_Quantity1.ForeColor = Color.Black;

            //num1
            if (!int.TryParse(tb_Cost1.Text, out num1))
            {
                lbl_Cost1.ForeColor = Color.Red;
                tb_Cost1.Focus();
                pass = false;
            }

            //num2
            if (!int.TryParse(tb_Quantity1.Text, out num2))
            {
                lbl_Quantity1.ForeColor = Color.Red;
                tb_Quantity1.Focus();
                pass = false;
            }

            num3 = (int)nud_Roomates.Value;

            if (pass)
            {
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
    }
}
