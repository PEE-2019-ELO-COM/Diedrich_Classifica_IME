using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuFaltei
{
    class Aluno
    {
        public string Nome { get; set; }
        public long Codigo { get; set; }
        public string Engenharia { get; set; }
        public long AnoFormatura { get; set; }
        public decimal CR { get; set; }

        public List<Aluno> Dados_Alunos()
        {
            List<Notas> Notas = new Notas().Dados_Notas();

            string Caminho = Properties.Settings.Default.Txt_Alunos;

            List<string> lines = new List<string>();
            List<Aluno> Dados = new List<Aluno>();

            lines = File.ReadAllLines(Caminho, Encoding.Default).ToList();

            foreach (string line in lines)
            {
                long codigo = Convert.ToInt64(line.Split(',')[0]);
                long anoforma = Convert.ToInt64(line.Split(',')[5]) + 5 - Convert.ToInt64(line.Split(',')[4]);

                Aluno Existe = Dados.FirstOrDefault(x => x.Codigo == codigo);

                if(Existe == null)
                {
                    Aluno NewAluno = new Aluno
                    {
                        Nome = line.Split(',')[1],
                        Codigo = codigo,
                        Engenharia = line.Split(',')[3],
                        AnoFormatura = anoforma,
                        CR = new Notas().CR_Aluno(codigo, Notas)
                    };

                    Dados.Add(NewAluno);
                }
                else
                {
                    if(anoforma > Existe.AnoFormatura)
                    {
                        Dados.Remove(Existe);
                        Existe.AnoFormatura = anoforma;
                        Dados.Add(Existe);
                    }  
                }
            }

            return Dados;
        }
    }
}
