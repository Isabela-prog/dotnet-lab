using Net.C_.Escola;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NET.C_.Escola
{
    //internal -> modificador de acesso que limita acesso dentro do mesmo assembly (dentro da mesma biblioteca ou executável)
    //protected -> modificador de acesso que limita acesso dentro da mesma classe ou classes derivadas
    //public -> modificador de acesso que permite acesso de qualquer lugar
    //private -> modificador de acesso que limita acesso apenas dentro da mesma classe
    //protected internal -> modificador de acesso que permite acesso dentro do mesmo assembly ou em classes derivadas

    //aluno recebe usuário por herança

    public class Aluno : Usuario
    {
        public int Matricula;
        //encapsulamento -> esconder detalhes internos e expor apenas o necessário
        //apenas dentro da classe é possível atribuir valor
        public decimal Media { get; private set; }
        private List<Materia> Materias;

        //método construtor adcir -> método especial usado para inicializar objetos de uma classe
        public Aluno() : base() //chama o construtor da classe base (Usuario)
        { 
            Materias = new List<Materia>();
        }

        //this -> garantir que um construtor chama outro construtor dentro da mesma classe
        public Aluno(string nome, int matricula, decimal media) : base(nome, "", "")
        {            
            Matricula = matricula;
            Media = media;
        }


        //método -> algo que a classe é capaz de fazer
        //void -> não retorna nenhum valor
        public void CalcularMedia(decimal p1, decimal p2, decimal p3)
        {
            decimal total = p1 + p2 + p3;
            Media = total / 3;
        }

        public string AdicionarMateria(Materia materia)
        {
            if (materia == null) throw new ArgumentNullException(nameof(materia));

            bool existe = Materias.Any(m =>
                string.Equals(m.Nome, materia.Nome, StringComparison.OrdinalIgnoreCase));

            if(existe)
                return "Matéria já adicionada.";
        
            Materias.Add(materia);
            return "Matéria adicionada com sucesso.";
        }

        //adc override, quando o aluno estanciado através da classe base (usuário), usará o método de Aluno
        public override void Logar()
        {
            Console.WriteLine("Aluno logado com sucesso!");
        }
    }
}
