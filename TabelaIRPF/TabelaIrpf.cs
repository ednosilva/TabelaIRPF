using System.Collections.Generic;
using System;
using System.Linq;

namespace TabelaIRPF
{
    public class TabelaIrpf
    {
        private IList<FaixaIrpf> faixas;

        public TabelaIrpf()
        {
            faixas = new List<FaixaIrpf>();
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
            this.faixas.Add(new FaixaIrpf(fim, aliquota, this.faixas.LastOrDefault()));
        }
    }
}
