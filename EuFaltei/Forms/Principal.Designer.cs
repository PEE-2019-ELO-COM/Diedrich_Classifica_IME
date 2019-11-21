namespace EuFaltei
{
    partial class Principal
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
            this.BtnConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClassificaEng = new System.Windows.Forms.Button();
            this.LabelCR = new System.Windows.Forms.Label();
            this.LabelTurma = new System.Windows.Forms.Label();
            this.labeleng = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.BtnClassificaTurma = new System.Windows.Forms.Button();
            this.BtnNotasAluno = new System.Windows.Forms.Button();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.Panel_Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConfig
            // 
            this.BtnConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfig.Location = new System.Drawing.Point(12, 401);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(182, 23);
            this.BtnConfig.TabIndex = 0;
            this.BtnConfig.Text = "Configuração";
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.BtnClassificaEng);
            this.panel1.Controls.Add(this.LabelCR);
            this.panel1.Controls.Add(this.LabelTurma);
            this.panel1.Controls.Add(this.labeleng);
            this.panel1.Controls.Add(this.LabelNome);
            this.panel1.Controls.Add(this.BtnCarregar);
            this.panel1.Controls.Add(this.TextUser);
            this.panel1.Controls.Add(this.BtnClassificaTurma);
            this.panel1.Controls.Add(this.BtnNotasAluno);
            this.panel1.Controls.Add(this.Label_Nome);
            this.panel1.Controls.Add(this.BtnConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 436);
            this.panel1.TabIndex = 2;
            // 
            // BtnClassificaEng
            // 
            this.BtnClassificaEng.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClassificaEng.Location = new System.Drawing.Point(12, 371);
            this.BtnClassificaEng.Name = "BtnClassificaEng";
            this.BtnClassificaEng.Size = new System.Drawing.Size(182, 23);
            this.BtnClassificaEng.TabIndex = 11;
            this.BtnClassificaEng.Text = "Classifica Engenharia";
            this.BtnClassificaEng.UseVisualStyleBackColor = true;
            this.BtnClassificaEng.Click += new System.EventHandler(this.BtnClassificaEng_Click);
            // 
            // LabelCR
            // 
            this.LabelCR.AutoSize = true;
            this.LabelCR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCR.ForeColor = System.Drawing.Color.White;
            this.LabelCR.Location = new System.Drawing.Point(12, 169);
            this.LabelCR.Name = "LabelCR";
            this.LabelCR.Size = new System.Drawing.Size(41, 21);
            this.LabelCR.TabIndex = 10;
            this.LabelCR.Text = "CR: ";
            // 
            // LabelTurma
            // 
            this.LabelTurma.AutoSize = true;
            this.LabelTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTurma.ForeColor = System.Drawing.Color.White;
            this.LabelTurma.Location = new System.Drawing.Point(12, 148);
            this.LabelTurma.Name = "LabelTurma";
            this.LabelTurma.Size = new System.Drawing.Size(67, 21);
            this.LabelTurma.TabIndex = 9;
            this.LabelTurma.Text = "Turma: ";
            // 
            // labeleng
            // 
            this.labeleng.AutoSize = true;
            this.labeleng.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleng.ForeColor = System.Drawing.Color.White;
            this.labeleng.Location = new System.Drawing.Point(12, 127);
            this.labeleng.Name = "labeleng";
            this.labeleng.Size = new System.Drawing.Size(44, 21);
            this.labeleng.TabIndex = 8;
            this.labeleng.Text = "Eng:";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.ForeColor = System.Drawing.Color.White;
            this.LabelNome.Location = new System.Drawing.Point(12, 106);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(61, 21);
            this.LabelNome.TabIndex = 7;
            this.LabelNome.Text = "Nome:";
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarregar.Location = new System.Drawing.Point(12, 62);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(182, 23);
            this.BtnCarregar.TabIndex = 6;
            this.BtnCarregar.Text = "Carregar Dados";
            this.BtnCarregar.UseVisualStyleBackColor = true;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // TextUser
            // 
            this.TextUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUser.Location = new System.Drawing.Point(12, 33);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(182, 23);
            this.TextUser.TabIndex = 5;
            // 
            // BtnClassificaTurma
            // 
            this.BtnClassificaTurma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClassificaTurma.Location = new System.Drawing.Point(12, 342);
            this.BtnClassificaTurma.Name = "BtnClassificaTurma";
            this.BtnClassificaTurma.Size = new System.Drawing.Size(182, 23);
            this.BtnClassificaTurma.TabIndex = 4;
            this.BtnClassificaTurma.Text = "Classifica Turma";
            this.BtnClassificaTurma.UseVisualStyleBackColor = true;
            this.BtnClassificaTurma.Click += new System.EventHandler(this.BtnClassificaTurma_Click);
            // 
            // BtnNotasAluno
            // 
            this.BtnNotasAluno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotasAluno.Location = new System.Drawing.Point(12, 313);
            this.BtnNotasAluno.Name = "BtnNotasAluno";
            this.BtnNotasAluno.Size = new System.Drawing.Size(182, 23);
            this.BtnNotasAluno.TabIndex = 2;
            this.BtnNotasAluno.Text = "Notas";
            this.BtnNotasAluno.UseVisualStyleBackColor = true;
            this.BtnNotasAluno.Click += new System.EventHandler(this.BtnNotasAluno_Click);
            // 
            // Label_Nome
            // 
            this.Label_Nome.AutoSize = true;
            this.Label_Nome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nome.ForeColor = System.Drawing.Color.White;
            this.Label_Nome.Location = new System.Drawing.Point(75, 9);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(56, 21);
            this.Label_Nome.TabIndex = 1;
            this.Label_Nome.Text = "Aluno";
            // 
            // Panel_Content
            // 
            this.Panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Content.Location = new System.Drawing.Point(200, 0);
            this.Panel_Content.Name = "Panel_Content";
            this.Panel_Content.Size = new System.Drawing.Size(731, 436);
            this.Panel_Content.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 436);
            this.Controls.Add(this.Panel_Content);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.Text = "Classificação IME";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Content;
        private System.Windows.Forms.Button BtnNotasAluno;
        private System.Windows.Forms.Button BtnClassificaTurma;
        private System.Windows.Forms.Label labeleng;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.Label LabelTurma;
        private System.Windows.Forms.Label LabelCR;
        private System.Windows.Forms.Button BtnClassificaEng;
    }
}

