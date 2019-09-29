namespace exercicio_02_1
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
            this.gpbPresenca = new System.Windows.Forms.GroupBox();
            this.chklbPresenca = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.txtNrAusentes = new System.Windows.Forms.TextBox();
            this.txtAusentes = new System.Windows.Forms.TextBox();
            this.lblAusentes = new System.Windows.Forms.Label();
            this.lblPresentes = new System.Windows.Forms.Label();
            this.txtPresentes = new System.Windows.Forms.TextBox();
            this.txtNrPresentes = new System.Windows.Forms.TextBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.gpbPresenca.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPresenca
            // 
            this.gpbPresenca.Controls.Add(this.chbTodos);
            this.gpbPresenca.Controls.Add(this.chklbPresenca);
            this.gpbPresenca.Location = new System.Drawing.Point(12, 12);
            this.gpbPresenca.Name = "gpbPresenca";
            this.gpbPresenca.Size = new System.Drawing.Size(213, 139);
            this.gpbPresenca.TabIndex = 1;
            this.gpbPresenca.TabStop = false;
            this.gpbPresenca.Text = "Presenca";
            // 
            // chklbPresenca
            // 
            this.chklbPresenca.FormattingEnabled = true;
            this.chklbPresenca.Items.AddRange(new object[] {
            "Ana",
            "Bruno",
            "Carlos",
            "Denise",
            "Elaine",
            "Fabio"});
            this.chklbPresenca.Location = new System.Drawing.Point(6, 49);
            this.chklbPresenca.Name = "chklbPresenca";
            this.chklbPresenca.Size = new System.Drawing.Size(192, 79);
            this.chklbPresenca.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 157);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(293, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(306, 157);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(303, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.lblPresentes);
            this.gpbResultado.Controls.Add(this.txtPresentes);
            this.gpbResultado.Controls.Add(this.txtNrPresentes);
            this.gpbResultado.Controls.Add(this.lblAusentes);
            this.gpbResultado.Controls.Add(this.txtAusentes);
            this.gpbResultado.Controls.Add(this.txtNrAusentes);
            this.gpbResultado.Location = new System.Drawing.Point(248, 12);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(361, 139);
            this.gpbResultado.TabIndex = 4;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // txtNrAusentes
            // 
            this.txtNrAusentes.Location = new System.Drawing.Point(58, 28);
            this.txtNrAusentes.Name = "txtNrAusentes";
            this.txtNrAusentes.ReadOnly = true;
            this.txtNrAusentes.Size = new System.Drawing.Size(100, 20);
            this.txtNrAusentes.TabIndex = 0;
            // 
            // txtAusentes
            // 
            this.txtAusentes.Location = new System.Drawing.Point(6, 54);
            this.txtAusentes.Multiline = true;
            this.txtAusentes.Name = "txtAusentes";
            this.txtAusentes.ReadOnly = true;
            this.txtAusentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAusentes.Size = new System.Drawing.Size(152, 74);
            this.txtAusentes.TabIndex = 1;
            // 
            // lblAusentes
            // 
            this.lblAusentes.AutoSize = true;
            this.lblAusentes.Location = new System.Drawing.Point(6, 31);
            this.lblAusentes.Name = "lblAusentes";
            this.lblAusentes.Size = new System.Drawing.Size(51, 13);
            this.lblAusentes.TabIndex = 2;
            this.lblAusentes.Text = "Ausentes";
            // 
            // lblPresentes
            // 
            this.lblPresentes.AutoSize = true;
            this.lblPresentes.Location = new System.Drawing.Point(195, 31);
            this.lblPresentes.Name = "lblPresentes";
            this.lblPresentes.Size = new System.Drawing.Size(54, 13);
            this.lblPresentes.TabIndex = 5;
            this.lblPresentes.Text = "Presentes";
            // 
            // txtPresentes
            // 
            this.txtPresentes.Location = new System.Drawing.Point(198, 54);
            this.txtPresentes.Multiline = true;
            this.txtPresentes.Name = "txtPresentes";
            this.txtPresentes.ReadOnly = true;
            this.txtPresentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPresentes.Size = new System.Drawing.Size(157, 74);
            this.txtPresentes.TabIndex = 4;
            // 
            // txtNrPresentes
            // 
            this.txtNrPresentes.Location = new System.Drawing.Point(255, 28);
            this.txtNrPresentes.Name = "txtNrPresentes";
            this.txtNrPresentes.ReadOnly = true;
            this.txtNrPresentes.Size = new System.Drawing.Size(100, 20);
            this.txtNrPresentes.TabIndex = 3;
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Location = new System.Drawing.Point(6, 19);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(92, 17);
            this.chbTodos.TabIndex = 3;
            this.chbTodos.Text = "Marcar Todos";
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 193);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gpbPresenca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbPresenca.ResumeLayout(false);
            this.gpbPresenca.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbPresenca;
        private System.Windows.Forms.CheckedListBox chklbPresenca;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.Label lblPresentes;
        private System.Windows.Forms.TextBox txtPresentes;
        private System.Windows.Forms.TextBox txtNrPresentes;
        private System.Windows.Forms.Label lblAusentes;
        private System.Windows.Forms.TextBox txtAusentes;
        private System.Windows.Forms.TextBox txtNrAusentes;
        private System.Windows.Forms.CheckBox chbTodos;
    }
}

