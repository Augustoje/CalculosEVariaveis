using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosEVariaveis
{
    class Animal
    {
        private string Nome, Tipo;

        public Animal(string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;

        }

        public Animal()
        {

        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetTipo()
        {
            return Tipo;
        }

        public void SetTipo(string tipo)
        {
            Tipo = tipo;

            if (Tipo == "Cachorro" || Tipo == "Gato" || Tipo == "Peixe")
            {
                Tipo = tipo;
            } else
            {
                Tipo = "Peixe";
            }


        }
    }
}
