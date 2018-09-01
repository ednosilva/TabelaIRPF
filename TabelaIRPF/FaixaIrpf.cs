using System;

namespace TabelaIRPF
{
    public class FaixaIrpf
    {
        public decimal Incio { get; private set; }

        public decimal? Fim { get; private set; }

        public decimal Aliquota { get; private set; }

        public decimal ParcelaDeduzir { get; private set; }

        public FaixaIrpf(decimal? fim, decimal aliquota, FaixaIrpf faixaAnterior)
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
            this.ParcelaDeduzir = faixaAnterior == null ? 0.00m : faixaAnterior.ParcelaDeduzir +
                Math.Round(faixaAnterior.Fim.Value * (aliquota - faixaAnterior.Aliquota), 2);
        }

        internal decimal ObterImposto(decimal salarioTributavel)
        {
            return Math.Round(salarioTributavel * this.Aliquota - this.ParcelaDeduzir, 2);
        }

        public bool Contem(decimal valor)
        {
            return this.Incio <= valor && (valor <= this.Fim || !this.Fim.HasValue);
        }
    }
}
