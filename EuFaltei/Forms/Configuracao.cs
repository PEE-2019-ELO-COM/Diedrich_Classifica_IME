using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuFaltei
{
    public partial class Configuracao : Form
    {
        public Configuracao()
        {
            InitializeComponent();

            TextAlunos.Text = Properties.Settings.Default.Txt_Alunos;
            TextNotas.Text = Properties.Settings.Default.Txt_Notas;
            TextUser.Text = Properties.Settings.Default.Usuario;
            TextSenha.Text = Properties.Settings.Default.Senha;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Txt_Alunos = TextAlunos.Text;
            Properties.Settings.Default.Txt_Notas = TextNotas.Text;
            Properties.Settings.Default.Usuario = TextUser.Text;
            Properties.Settings.Default.Senha = TextSenha.Text;

            Properties.Settings.Default.Save();
        }
    }
}
