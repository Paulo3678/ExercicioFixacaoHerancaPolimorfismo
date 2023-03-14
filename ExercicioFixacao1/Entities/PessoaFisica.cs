using System;

namespace ExercicioFixacao1.Entities
{
    class PessoaFisica : Pessoa
    {
        private double GastosComSaude { get; set; }
        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude)
        : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalcularImposto()
        {
            if (RendaAnual < 20000.00)
            {
                return 0.15 * RendaAnual - GastosComSaude * 0.50;
            }
            else
            {
                return 0.25 * RendaAnual - GastosComSaude * 0.50;
            }
        }
    }
}
