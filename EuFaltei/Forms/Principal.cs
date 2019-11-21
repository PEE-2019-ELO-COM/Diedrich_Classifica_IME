using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace EuFaltei
{
    public partial class Principal : Form
    {
        //Dados para o Sistema
        List<Aluno> Alunos = new List<Aluno>();

        //Função de Abrir Formulario
        public void AbrirFormulario<Formulario>() where Formulario : Form, new()
        {
            Form FormAux;
            FormAux = Panel_Content.Controls.OfType<Formulario>().FirstOrDefault();

            if (FormAux != null) { FormAux.Close(); } 

            FormAux = new Formulario { TopLevel = false };
            Panel_Content.Controls.Add(FormAux);
            Panel_Content.Tag = FormAux;
            FormAux.Show();

            FormAux.BringToFront();
        }

        public Principal()
        {
            InitializeComponent();
            Alunos = new Aluno().Dados_Alunos();
            Properties.Settings.Default.UserAtivo = "";
            Properties.Settings.Default.Save();
        }

        private bool UsuarioAtivo()
        {
            try
            {
                Aluno aux = Alunos.FirstOrDefault(x => x.Codigo == Convert.ToInt64(Properties.Settings.Default.UserAtivo));
                if (aux == null) { MessageBox.Show("Usuario Ativo não encontrado."); return false; }
            }
            catch { MessageBox.Show("Não foi possivel detecctar o usuario ativo."); return false; }

            return true;
        }

        private void BtnConfig_Click(object sender, EventArgs e) { AbrirFormulario<Configuracao>(); }

        private void BtnAlunos_Click(object sender, EventArgs e) { }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                long codigoaux = Convert.ToInt64(TextUser.Text);

                Aluno Aux = Alunos.FirstOrDefault(x => x.Codigo == codigoaux);

                if(Aux == null) { MessageBox.Show("Aluno não encontrado"); return; }

                labeleng.Text = "ENG: " + Aux.Engenharia;
                LabelNome.Text = "Nome: " + Aux.Nome.Split(' ')[0];
                LabelTurma.Text = "Turma: " + Aux.AnoFormatura.ToString();
                LabelCR.Text = "CR: " + Math.Round(Aux.CR, 2);
                Properties.Settings.Default.UserAtivo = Aux.Codigo.ToString();
                Properties.Settings.Default.Save();
            }
            catch { MessageBox.Show("Favor digite apenas numeros!"); }         
        }

        private void BtnClassificaTurma_Click(object sender, EventArgs e) { if (UsuarioAtivo()) { AbrirFormulario<Classifica_Turma>(); } }

        private void BtnClassificaEng_Click(object sender, EventArgs e) { if (UsuarioAtivo()) { AbrirFormulario<Classifica_Engenharia>(); } }

        private void BtnNotasAluno_Click(object sender, EventArgs e) { if (UsuarioAtivo()){ AbrirFormulario<NotasIndividual>(); } }
    }
}
