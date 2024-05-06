namespace GestorDeEstudantes
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(135, 67);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(91, 92);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(87, 222);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 20);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(84, 257);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(56, 20);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            this.labelSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Location = new System.Drawing.Point(184, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox2.Location = new System.Drawing.Point(184, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.ForeColor = System.Drawing.Color.Green;
            this.buttonLogin.Location = new System.Drawing.Point(40, 354);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 50);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelar.Location = new System.Drawing.Point(213, 354);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 50);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "ACESSO";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.pictureBoxUser);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
    }
}

