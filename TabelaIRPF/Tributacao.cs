namespace TabelaIRPF
{
    internal class Tributacao
    {
        public decimal Salario { get; internal set; }

        public decimal ContribuiocaoInss { get; internal set; }

        public decimal SalarioTributavel { get { return Salario - ContribuiocaoInss; } }

        public decimal IrpfAtual { get; internal set; }

        public decimal IrpfNovo { get; internal set; }

        public decimal DiferencaIrpf { get { return IrpfNovo - IrpfAtual; } }
    }
}