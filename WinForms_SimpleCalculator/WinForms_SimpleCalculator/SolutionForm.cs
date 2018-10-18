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
    public partial class SolutionForm : Form
    {
        public SolutionForm()
        {
            InitializeComponent();
        }

        public void SetTotals(Totals totals)
        {
            tb_Total.Text = "$" + totals.GrandTotal.ToString();
            tb_TotalPerPerson.Text = "$" + totals.GrandTotalPerPerson.ToString();
        }

        private void butt_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
