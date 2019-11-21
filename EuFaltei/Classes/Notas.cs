using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuFaltei
{
    class Notas
    {
        public long Codigo_Materia { get; private set; }
        public string Nome_Materia { get; private set; }
        public long Codigo_Aluno { get; private set; }
        public long Ano_Consulta { get; private set; }
        public int Semestre { get; private set; }
        public decimal VE { get; private set; }
        public decimal VC { get; private set; }
        public decimal VF { get; private set; }
        public decimal RecEscrita { get; private set; }
        public decimal RecOral { get; private set; }

        public decimal Media
        {
            get
            {
                Decimal med = VE / 4 + VC / 4 + VF / 2;

                if(med >= 5 && VF >= 4) { return med; }
                else
                {
                    if (RecEscrita >= 7) { return RecEscrita / 2; }
                    else if(RecEscrita/2 + RecOral/2 > 5) { return RecEscrita / 4 + RecOral / 4; }
                    else { return 0; }
                } 
            }
        }

        private bool Reprovou
        {
            get
            {
                if(Media > 5) { return false; }
                else if(RecEscrita + RecOral >= 10) { return false; }
                else { return true; }
            }
        }

        public List<Notas> Dados_Notas()
        {
            string Caminho = Properties.Settings.Default.Txt_Notas;

            List<string> lines = new List<string>();
            List<Notas> Dados = new List<Notas>();

            //Tenta converter o Arquivo em Linhas
            lines = File.ReadAllLines(Caminho, Encoding.ASCII).ToList();

            //Converte Cada Linha do Arquivo na Class Cotistas
            foreach (string line in lines)
            {
                Notas Nota = new Notas
                {
                    Codigo_Materia = Convert.ToInt64(line.Split(',')[3]),
                    Nome_Materia = line.Split(',')[4],
                    Codigo_Aluno = Convert.ToInt64(line.Split(',')[0]),
                    Ano_Consulta = Convert.ToInt64(line.Split(',')[2]),
                    Semestre = Convert.ToInt16(line.Split(',')[1]),
                    VE = Convert.ToDecimal(line.Split(',')[5], new System.Globalization.CultureInfo("en-US")),
                    VC = Convert.ToDecimal(line.Split(',')[6], new System.Globalization.CultureInfo("en-US")),
                    VF = Convert.ToDecimal(line.Split(',')[7], new System.Globalization.CultureInfo("en-US")),
                    RecEscrita = Convert.ToDecimal(line.Split(',')[8], new System.Globalization.CultureInfo("en-US")),
                    RecOral = Convert.ToDecimal(line.Split(',')[9], new System.Globalization.CultureInfo("en-US"))
                };

                if(Nota.VE + Nota.VC + Nota.VF != 0) { Dados.Add(Nota); }                
            }

            return Dados;
        }

        public decimal CR_Aluno (long cod_aluno, List<Notas> Dados)
        {
            Dados = Dados.Where(x => x.Codigo_Aluno == cod_aluno).ToList();
            List<long> Anos = Dados.Select(x => x.Ano_Consulta).Distinct().ToList();
            List<int> Semestres = Dados.Select(x => x.Semestre).Distinct().ToList();

            foreach (long ano in Anos)
            {
                foreach (long semestre in Semestres)
                {
                    List<Notas> MediasSemestre = Dados.Where(x => x.Semestre == semestre && x.Ano_Consulta == ano).ToList();

                    if (MediasSemestre.Select(x => x.Reprovou).ToList().Contains(true))
                    {
                        foreach(Notas N in MediasSemestre) { Dados.Remove(N); }                    
                    }
                }
            }

            if(Dados.Count == 0) { return 0; }

            return Dados.Select(x => x.Media).ToList().Sum() / Dados.Count();
        }

    }
}
