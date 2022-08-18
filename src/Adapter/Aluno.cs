using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Aluno
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Curso { get; private set; }
        public decimal Mensalidade { get; private set; }

        public Aluno(int id, string nome, string curso, decimal mensalidade)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
            Mensalidade = mensalidade;
        }
    }
}
