namespace exercicio_02_3
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
            this.gpbGeneros = new System.Windows.Forms.GroupBox();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
            this.chklbGeneros = new System.Windows.Forms.CheckedListBox();
            this.chkOutroGenero = new System.Windows.Forms.CheckBox();
            this.txtOutroGenero = new System.Windows.Forms.TextBox();
            this.txtPreferido = new System.Windows.Forms.TextBox();
            this.chkOutroPreferido = new System.Windows.Forms.CheckBox();
            this.chklbGeneroPreferido = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gpbGeneros.SuspendLayout();
            this.gpbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbGeneros
            // 
            this.gpbGeneros.Controls.Add(this.txtOutroGenero);
            this.gpbGeneros.Controls.Add(this.chkOutroGenero);
            this.gpbGeneros.Controls.Add(this.chklbGeneros);
            this.gpbGeneros.Location = new System.Drawing.Point(12, 12);
            this.gpbGeneros.Name = "gpbGeneros";
            this.gpbGeneros.Size = new System.Drawing.Size(200, 119);
            this.gpbGeneros.TabIndex = 0;
            this.gpbGeneros.TabStop = false;
            this.gpbGeneros.Text = "Quais genêros de filme você gosta?";
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.chklbGeneroPreferido);
            this.gpbGenero.Controls.Add(this.txtPreferido);
            this.gpbGenero.Controls.Add(this.chkOutroPreferido);
            this.gpbGenero.Location = new System.Drawing.Point(218, 12);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(200, 119);
            this.gpbGenero.TabIndex = 1;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Selecione o seu genêro preferido";
            // 
            // chklbGeneros
            // 
            this.chklbGeneros.FormattingEnabled = true;
            this.chklbGeneros.Location = new System.Drawing.Point(6, 19);
            this.chklbGeneros.Name = "chklbGeneros";
            this.chklbGeneros.Size = new System.Drawing.Size(188, 64);
            this.chklbGeneros.TabIndex = 2;
            // 
            // chkOutroGenero
            // 
            this.chkOutroGenero.AutoSize = true;
            this.chkOutroGenero.Location = new System.Drawing.Point(6, 89);
            this.chkOutroGenero.Name = "chkOutroGenero";
            this.chkOutroGenero.Size = new System.Drawing.Size(52, 17);
            this.chkOutroGenero.TabIndex = 2;
            this.chkOutroGenero.Text = "Outro";
            this.chkOutroGenero.UseVisualStyleBackColor = true;
            // 
            // txtOutroGenero
            // 
            this.txtOutroGenero.Location = new System.Drawing.Point(64, 89);
            this.txtOutroGenero.Name = "txtOutroGenero";
            this.txtOutroGenero.Size = new System.Drawing.Size(130, 20);
            this.txtOutroGenero.TabIndex = 2;
            // 
            // txtPreferido
            // 
            this.txtPreferido.Location = new System.Drawing.Point(64, 89);
            this.txtPreferido.Name = "txtPreferido";
            this.txtPreferido.Size = new System.Drawing.Size(130, 20);
            this.txtPreferido.TabIndex = 3;
            // 
            // chkOutroPreferido
            // 
            this.chkOutroPreferido.AutoSize = true;
            this.chkOutroPreferido.Location = new System.Drawing.Point(6, 89);
            this.chkOutroPreferido.Name = "chkOutroPreferido";
            this.chkOutroPreferido.Size = new System.Drawing.Size(52, 17);
            this.chkOutroPreferido.TabIndex = 4;
            this.chkOutroPreferido.Text = "Outro";
            this.chkOutroPreferido.UseVisualStyleBackColor = true;
            this.chkOutroPreferido.CheckedChanged += new System.EventHandler(this.chkOutroPreferido_CheckedChanged);
            // 
            // chklbGeneroPreferido
            // 
            this.chklbGeneroPreferido.CheckOnClick = true;
            this.chklbGeneroPreferido.FormattingEnabled = true;
            this.chklbGeneroPreferido.Location = new System.Drawing.Point(6, 19);
            this.chklbGeneroPreferido.Name = "chklbGeneroPreferido";
            this.chklbGeneroPreferido.Size = new System.Drawing.Size(188, 64);
            this.chklbGeneroPreferido.TabIndex = 5;
            this.chklbGeneroPreferido.SelectedValueChanged += new System.EventHandler(this.chklbGeneroPreferido_SelectedValueChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 137);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(200, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Itens Selecionados";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(218, 137);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 166);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(406, 146);
            this.txtResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gpbGenero);
            this.Controls.Add(this.gpbGeneros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbGeneros.ResumeLayout(false);
            this.gpbGeneros.PerformLayout();
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGeneros;
        private System.Windows.Forms.CheckedListBox chklbGeneros;
        private System.Windows.Forms.GroupBox gpbGenero;
        private System.Windows.Forms.TextBox txtOutroGenero;
        private System.Windows.Forms.CheckBox chkOutroGenero;
        private System.Windows.Forms.CheckedListBox chklbGeneroPreferido;
        private System.Windows.Forms.TextBox txtPreferido;
        private System.Windows.Forms.CheckBox chkOutroPreferido;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

