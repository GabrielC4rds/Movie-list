namespace Lista_Exercicio_filmes_
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxNota = new System.Windows.Forms.TextBox();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.cbnGenero = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(139, 97);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(139, 145);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 17);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(139, 197);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(42, 17);
            this.lblNota.TabIndex = 2;
            this.lblNota.Text = "Nota:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(320, 97);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 17);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(205, 97);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(100, 22);
            this.tbxNome.TabIndex = 4;
            // 
            // tbxNota
            // 
            this.tbxNota.Location = new System.Drawing.Point(205, 194);
            this.tbxNota.Name = "tbxNota";
            this.tbxNota.Size = new System.Drawing.Size(100, 22);
            this.tbxNota.TabIndex = 6;
            // 
            // tbxAno
            // 
            this.tbxAno.Location = new System.Drawing.Point(363, 97);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(100, 22);
            this.tbxAno.TabIndex = 7;
            // 
            // cbnGenero
            // 
            this.cbnGenero.FormattingEnabled = true;
            this.cbnGenero.Location = new System.Drawing.Point(205, 142);
            this.cbnGenero.Name = "cbnGenero";
            this.cbnGenero.Size = new System.Drawing.Size(121, 24);
            this.cbnGenero.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(388, 157);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(83, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(388, 199);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(83, 23);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbnGenero);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.tbxNota);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxNota;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.ComboBox cbnGenero;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVer;
    }
}

