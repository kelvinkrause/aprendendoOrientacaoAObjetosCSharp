using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Exercicios.IntegrandoClassesEDefinindoRelacionamentos.Modelos
{
    public class Disciplina
    {
        public string Nome {  get; set; }

        private List<Aluno> alunosMatriculados = new List<Aluno>();
    }
}
