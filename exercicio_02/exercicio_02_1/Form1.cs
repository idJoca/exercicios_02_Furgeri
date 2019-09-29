using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_02_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.btnLimpar_Click(sender, e);
            var items = this.chklbPresenca.Items;
            int totalPresentes = 0, totalAusentes = 0;
            foreach (var item in items)
            {
                if (this.chklbPresenca.GetItemChecked(items.IndexOf(item)))
                {
                    this.txtPresentes.AppendText(item.ToString() + Environment.NewLine);
                    totalPresentes++;
                } else
                {
                    this.txtAusentes.AppendText(item.ToString() + Environment.NewLine);
                    totalAusentes++;
                }
            }
            this.txtNrPresentes.Text = totalPresentes.ToString();
            this.txtNrAusentes.Text = totalAusentes.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtAusentes.Clear();
            this.txtPresentes.Clear();

            this.txtNrAusentes.Clear();
            this.txtNrPresentes.Clear();
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.chklbPresenca.Items.Count; i++)
            {
                this.chklbPresenca.SetItemChecked(i, this.chbTodos.Checked);
            }
        }
    }
}
