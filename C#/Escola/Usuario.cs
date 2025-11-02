using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.C_.Escola
{
    public class Usuario
    {
        public string Nome;
        public string Email;
        public string Senha;

        public Usuario()
        {
        }

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        //adc virutal o método será substituído na classe derivada
        public virtual void Logar()
        {
            Console.WriteLine("Usuário logado com sucesso!");
        }

    }
}
