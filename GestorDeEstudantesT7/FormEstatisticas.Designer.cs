namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTotalDeEstudantes = new System.Windows.Forms.Panel();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelTotalDeEstudantes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelTotalDeEstudantes.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalDeEstudantes
            // 
            this.panelTotalDeEstudantes.BackColor = System.Drawing.Color.Blue;
            this.panelTotalDeEstudantes.Controls.Add(this.labelTotalDeEstudantes);
            this.panelTotalDeEstudantes.Location = new System.Drawing.Point(12, 12);
            this.panelTotalDeEstudantes.Name = "panelTotalDeEstudantes";
            this.panelTotalDeEstudantes.Size = new System.Drawing.Size(776, 196);
            this.panelTotalDeEstudantes.TabIndex = 0;
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.Yellow;
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(386, 214);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(402, 224);
            this.panelMeninas.TabIndex = 1;
            this.panelMeninas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.Red;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Controls.Add(this.label2);
            this.panelMeninos.Location = new System.Drawing.Point(12, 214);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(368, 224);
            this.panelMeninos.TabIndex = 1;
            // 
            // labelTotalDeEstudantes
            // 
            this.labelTotalDeEstudantes.AutoSize = true;
            this.labelTotalDeEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeEstudantes.Location = new System.Drawing.Point(166, 72);
            this.labelTotalDeEstudantes.Name = "labelTotalDeEstudantes";
            this.labelTotalDeEstudantes.Size = new System.Drawing.Size(390, 39);
            this.labelTotalDeEstudantes.TabIndex = 0;
            this.labelTotalDeEstudantes.Text = "Total de estudantes: 999";
            this.labelTotalDeEstudantes.Click += new System.EventHandler(this.labelTotalDeEstudantes_Click);
            this.labelTotalDeEstudantes.MouseEnter += new System.EventHandler(this.labelTotalDeEstudantes_MouseEnter);
            this.labelTotalDeEstudantes.MouseLeave += new System.EventHandler(this.labelTotalDeEstudantes_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meninos: 50%";
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(78, 91);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(185, 31);
            this.labelMeninos.TabIndex = 2;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.MouseEnter += new System.EventHandler(this.labelMeninos_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.labelMeninos_MouseLeave);
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(114, 91);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(185, 31);
            this.labelMeninas.TabIndex = 2;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.MouseEnter += new System.EventHandler(this.labelMeninas_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.labelMeninas_MouseLeave);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelTotalDeEstudantes);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelTotalDeEstudantes.ResumeLayout(false);
            this.panelTotalDeEstudantes.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalDeEstudantes;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Label labelTotalDeEstudantes;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Label label2;
    }
}