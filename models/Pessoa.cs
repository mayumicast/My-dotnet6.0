using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticando.models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Name = nome;
            Sobrenome = sobrenome;
        }
        private string _name;
        // private string _idade;

        public string Name { 
            get => _name.ToUpper();

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _name = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Name} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"{NomeCompleto}");
        }
    }
}