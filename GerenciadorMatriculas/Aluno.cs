using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorMatriculas
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; }
        public string? Idade { get; set; }
        Guid Matricula { get; set; }

        public Aluno()
        {

        }

        public bool MatricularAluno()
        {
            if (this.Nome != null && this.Endereco != null && this.NomeMae != null && this.NomePai != null && this.Idade != null)
            {
                this.Matricula = Guid.NewGuid();
                return true;
            }
            return false;
        }
    }
}
