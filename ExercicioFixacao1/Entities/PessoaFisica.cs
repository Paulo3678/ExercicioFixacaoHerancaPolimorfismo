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
            double imposto = 0.0;

            if (RendaAnual < 20000.00)
            {
                imposto = 0.15 * RendaAnual;
            }
            else
            {
                imposto = 0.25 * RendaAnual;
            }

            if(GastosComSaude > 0)
            {
                imposto -= GastosComSaude * 0.50;
            }
            return imposto;
        }
    }
}
