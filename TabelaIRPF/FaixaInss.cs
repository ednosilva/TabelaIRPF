using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaIRPF
{
    public class FaixaInss
    {
        public decimal Incio { get; private set; }

        public decimal? Fim { get; private set; }

        public decimal Aliquota { get; private set; }

        public FaixaInss(decimal? fim, decimal aliquota, FaixaInss faixaAnterior)
        {
            if (faixaAnterior != null)
            {
                if (!faixaAnterior.Fim.HasValue)
                {
                    throw new ArgumentException("A Faixa anterior tem que ter um valor final.", nameof(faixaAnterior));
                }

                if (aliquota <= faixaAnterior.Aliquota)
                {
                    throw new ArgumentOutOfRangeException("A Alíquota tem que ser maior que a Alíquota da Faixa anterior.",
                        nameof(aliquota));
                }
            }

            this.Incio = faixaAnterior == null ? 0m : faixaAnterior.Fim.Value + 0.01m;
            this.Fim = fim;
            this.Aliquota = aliquota;
        }

        internal decimal ObterContribuicao(decimal salario)
        {
            return Math.Round(salario * this.Aliquota, 2);
        }

        public bool Contem(decimal valor)
        {
            return this.Incio <= valor && (valor <= this.Fim || !this.Fim.HasValue);
        }
    }
}
