using System;
using System.Collections.Generic;
using System.Text;

namespace Pensionato
{
    class Estudantes
    {
        public int Quarto { get; private set; }
        public string Nome { get; private set; }

        public string Email { get; private set; }

       
        public Estudantes(int quarto, string nome, string email)
        {
            
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

    }
}
