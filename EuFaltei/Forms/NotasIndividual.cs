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
    public partial class NotasIndividual : Form
    {
        public NotasIndividual()
        {
            InitializeComponent();

            List<Notas> NotasAux = new Notas().Dados_Notas();

            NotasAux = NotasAux.Where(x => x.Codigo_Aluno == Convert.ToInt64(Properties.Settings.Default.UserAtivo)).ToList();

            foreach(Notas Nota in NotasAux)
            {
                DataGridNotas.Rows.Add(new object[] { Nota.Codigo_Materia, Nota.Nome_Materia, Nota.Media});
            }
        }
    }
}
