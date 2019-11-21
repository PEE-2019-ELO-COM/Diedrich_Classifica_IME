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
    public partial class Classifica_Engenharia : Form
    {
        public Classifica_Engenharia()
        {
            InitializeComponent();

            List<Aluno> AlunosAux = new Aluno().Dados_Alunos();

            Aluno AlunoAux = AlunosAux.FirstOrDefault(x => x.Codigo == Convert.ToInt64(Properties.Settings.Default.UserAtivo));

            AlunosAux = AlunosAux.Where(x => x.Engenharia == AlunoAux.Engenharia && x.AnoFormatura == AlunoAux.AnoFormatura).ToList();

            AlunosAux = AlunosAux.OrderBy(x => -x.CR).ToList();

            Int64 Pos = 1;

            foreach (Aluno Alu in AlunosAux)
            {
                DataGridClassifica.Rows.Add(new object[] { Pos++, Alu.Codigo, Alu.Nome, Math.Round(Alu.CR, 2) });
            }
        }
    }
}
