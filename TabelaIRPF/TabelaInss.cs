using System.Collections.Generic;
using System;
using System.Linq;

namespace TabelaIRPF
{
    public class TabelaInss
    {
        private IList<FaixaInss> faixas;

        public TabelaInss()
        {
            faixas = new List<FaixaInss>();
        }

        public decimal ObterContribuicao(decimal salario)
        {
            if (salario < 0)
                throw new ArgumentOutOfRangeException(nameof(salario));

            var faixa = faixas.SingleOrDefault(f => f.Contem(salario));

            if (faixa != null)
            {
                return faixa.ObterContribuicao(salario);
            }
            else
            {
                var ultimaFaixa = faixas.Last();
                return ultimaFaixa.ObterContribuicao(ultimaFaixa.Fim.Value);
            }
        }

        internal void AdicionarFaixa(decimal? fim, decimal aliquota)
        {
            this.faixas.Add(new FaixaInss(fim, aliquota, this.faixas.LastOrDefault()));
        }
    }
}
