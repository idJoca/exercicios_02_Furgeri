namespace exercicio02_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotalInicial = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gpbPagamento = new System.Windows.Forms.GroupBox();
            this.rdbVista = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.gpbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalInicial
            // 
            this.txtTotalInicial.Location = new System.Drawing.Point(95, 5);
            this.txtTotalInicial.Name = "txtTotalInicial";
            this.txtTotalInicial.Size = new System.Drawing.Size(113, 20);
            this.txtTotalInicial.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(5, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total da compra";
            // 
            // gpbPagamento
            // 
            this.gpbPagamento.Controls.Add(this.lblDesconto);
            this.gpbPagamento.Controls.Add(this.numDesconto);
            this.gpbPagamento.Controls.Add(this.rdbCredito);
            this.gpbPagamento.Controls.Add(this.rdbDebito);
            this.gpbPagamento.Controls.Add(this.rdbVista);
            this.gpbPagamento.Location = new System.Drawing.Point(8, 31);
            this.gpbPagamento.Name = "gpbPagamento";
            this.gpbPagamento.Size = new System.Drawing.Size(200, 92);
            this.gpbPagamento.TabIndex = 2;
            this.gpbPagamento.TabStop = false;
            this.gpbPagamento.Text = "Forma de Pagamento";
            // 
            // rdbVista
            // 
            this.rdbVista.AutoSize = true;
            this.rdbVista.Location = new System.Drawing.Point(7, 20);
            this.rdbVista.Name = "rdbVista";
            this.rdbVista.Size = new System.Drawing.Size(103, 17);
            this.rdbVista.TabIndex = 0;
            this.rdbVista.TabStop = true;
            this.rdbVista.Text = "Á vista (dinheiro)";
            this.rdbVista.UseVisualStyleBackColor = true;
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Location = new System.Drawing.Point(7, 43);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(56, 17);
            this.rdbDebito.TabIndex = 1;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(7, 66);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(58, 17);
            this.rdbCredito.TabIndex = 2;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // numDesconto
            // 
            this.numDesconto.Location = new System.Drawing.Point(120, 40);
            this.numDesconto.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(74, 20);
            this.numDesconto.TabIndex = 3;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(117, 22);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(77, 13);
            this.lblDesconto.TabIndex = 4;
            this.lblDesconto.Text = "% de desconto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(8, 129);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(109, 129);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(5, 161);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(71, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor a Pagar";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Location = new System.Drawing.Point(82, 158);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(127, 20);
            this.txtTotalFinal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbPagamento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalInicial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbPagamento.ResumeLayout(false);
            this.gpbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalInicial;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gpbPagamento;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.RadioButton rdbVista;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtTotalFinal;
    }
}

