namespace RVCS01
{
    partial class FrmCurso
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
            this.BtnListar = new System.Windows.Forms.Button();
            this.lsbCursos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(70, 57);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 44);
            this.BtnListar.TabIndex = 0;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // lsbCursos
            // 
            this.lsbCursos.FormattingEnabled = true;
            this.lsbCursos.Location = new System.Drawing.Point(151, 57);
            this.lsbCursos.Name = "lsbCursos";
            this.lsbCursos.Size = new System.Drawing.Size(474, 186);
            this.lsbCursos.TabIndex = 1;
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbCursos);
            this.Controls.Add(this.BtnListar);
            this.Name = "FrmCurso";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.ListBox lsbCursos;
    }
}

