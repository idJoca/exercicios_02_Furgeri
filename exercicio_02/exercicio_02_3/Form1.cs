using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_02_3
{
    public partial class Form1 : Form
    {
        String[] dataset = { "Ação", "Comédia", "Ficção", "Romance", "Suspense" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String element in this.dataset)
            {
                this.chklbGeneros.Items.Add(element);
                this.chklbGeneroPreferido.Items.Add(element);
            }
        }

        private void chklbGeneroPreferido_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.chklbGeneroPreferido.SelectedIndex;
            int totalCount = this.chklbGeneroPreferido.Items.Count;
            for (int i = 0; i < totalCount - 1; i++)
            {
                if (selectedIndex != i)
                {
                    this.chklbGeneroPreferido.SetItemChecked(i, false);
                }
            }
            this.chkOutroPreferido.Checked = false;
            this.txtPreferido.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.txtResultado.Clear();
            this.txtResultado.AppendText("Genêros Selecionados:" + Environment.NewLine);
            foreach (object item in this.chklbGeneros.CheckedItems)
            {
                this.txtResultado.AppendText(item.ToString() + Environment.NewLine);
            }
            if (this.chkOutroGenero.Checked)
            {
                this.txtResultado.AppendText(this.txtOutroGenero.Text + Environment.NewLine);
            }

            this.txtResultado.AppendText(Environment.NewLine + "Genêro Preferido:" + Environment.NewLine);
            foreach (object item in this.chklbGeneroPreferido.CheckedItems)
            {
                this.txtResultado.AppendText(item.ToString() + Environment.NewLine);
            }
            if (this.chkOutroPreferido.Checked)
            {
                this.txtResultado.AppendText(this.txtPreferido.Text + Environment.NewLine);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            int totalCountGeneros = this.chklbGeneros.Items.Count;
            for (int i = 0; i < totalCountGeneros - 1; i++)
            {
                this.chklbGeneros.SetItemChecked(i, false);
            }

            int totalCountPreferidos = this.chklbGeneroPreferido.Items.Count;
            for (int i = 0; i < totalCountPreferidos - 1; i++)
            {
                this.chklbGeneroPreferido.SetItemChecked(i, false);
            }
            this.chkOutroGenero.Checked = false;
            this.txtOutroGenero.Clear();

            this.chkOutroPreferido.Checked = false;
            this.txtPreferido.Clear();

            this.txtResultado.Clear();
        }

        private void chkOutroPreferido_CheckedChanged(object sender, EventArgs e)
        {
            int totalCount = this.chklbGeneroPreferido.Items.Count;
            for (int i = 0; i < totalCount - 1; i++)
            {
                this.chklbGeneroPreferido.SetItemChecked(i, false);
            }
        }
    }
}
