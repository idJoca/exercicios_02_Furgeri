using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio02_2
{
    public partial class Form1 : Form
    {
        decimal AUMENTO_CREDITO = 0.02M;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.rdbVista.Checked)
            {
                this.txtTotalFinal.Text = (Convert.ToDecimal(this.txtTotalInicial.Text) * (1 - Convert.ToDecimal(this.numDesconto.Value))).ToString();
            } else if (this.rdbCredito.Checked)
            {
                this.txtTotalFinal.Text = (Convert.ToDecimal(this.txtTotalInicial.Text) * (this.AUMENTO_CREDITO + 1)).ToString();
            }
            else
            {
                this.txtTotalFinal.Text = (Convert.ToDecimal(this.txtTotalInicial.Text)).ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtTotalFinal.Clear();
            this.txtTotalInicial.Clear();
            this.rdbCredito.Checked = false;
            this.rdbDebito.Checked = false;
            this.rdbVista.Checked = false;
            this.numDesconto.Value = 0;
        }
    }
}
