using System.Collections.Generic;
using System;
using System.Linq;

namespace TabelaIRPF
{
    public class Tabela
    {
        private IList<Faixa> faixas;

        public Tabela()
        {
            faixas = new List<Faixa>();
        }

        public decimal ObterImposto(decimal salarioTributavel)
        {
            if (salarioTributavel < 0)
                throw new ArgumentOutOfRangeException(nameof(salarioTributavel));

            return faixas.Single(f => f.Contem(salarioTributavel))
                .ObterImposto(salarioTributavel);
        }

        internal void AdicionarFaixa(decimal? fim, decimal aliquota)
        {
            this.faixas.Add(new Faixa(fim, aliquota, this.faixas.LastOrDefault()));
        }
    }
}
