using System;

namespace ExercicioFixacao1.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        protected double RendaAnual { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();



    }
}
