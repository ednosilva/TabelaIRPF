using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabelaIRPF
{
    public partial class FormPrincipal : Form
    {
        private IList<Tuple<MaskedTextBox, MaskedTextBox>> textosFaixas;

        private TabelaInss tabelaInssAtual;

        private TabelaIrpf tabelaIrpfAtual;

        private TabelaIrpf tabelaIrpfNova;

        private IList<Tributacao> tributacoes;

        public FormPrincipal()
        {
            InitializeComponent();

            CriarListaComponentesFaixas();
            CriarTabelaInssAtual();
            CriarTabelaIrpfAtual();
        }

        private void CriarListaComponentesFaixas()
        {
            textosFaixas = new List<Tuple<MaskedTextBox, MaskedTextBox>>
            {
                new Tuple<MaskedTextBox, MaskedTextBox>(textoFimFaixa1, textoAliquotaFaixa1),
                new Tuple<MaskedTextBox, MaskedTextBox>(textoFimFaixa2, textoAliquotaFaixa2),
                new Tuple<MaskedTextBox, MaskedTextBox>(textoFimFaixa3, textoAliquotaFaixa3),
                new Tuple<MaskedTextBox, MaskedTextBox>(textoFimFaixa4, textoAliquotaFaixa4),
                new Tuple<MaskedTextBox, MaskedTextBox>(textoFimFaixa5, textoAliquotaFaixa5),
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CriarTabelaIrpfNova();
            CriarTributacoes();
            ExibirTributacoes();
        }

        private void ExibirTributacoes()
        {
            grid.DataSource = tributacoes;

            grid.Columns[0].HeaderText = "Salário";
            grid.Columns[1].HeaderText = "Contribução do INSS";
            grid.Columns[2].HeaderText = "Salário Tributável";
            grid.Columns[3].HeaderText = "IRPF Atual";
            grid.Columns[4].HeaderText = "IRPF Proposto";
            grid.Columns[5].HeaderText = "Diferença de IRPF";
        }

        private void CriarTributacoes()
        {
            var salarios = new List<decimal>
            {
                2000.00m, 2500.00m, 3000.00m, 3500.00m, 4000.00m, 4500.00m, 5000.00m, 5500.00m, 6000.00m, 6500.00m,
                7000.00m, 7500.00m, 8000.00m, 9000.00m, 10000.00m, 11000.00m, 12000.00m, 13000.00m, 14000.00m,
                15000.00m, 17000.00m, 20000.00m, 25000.00m, 30000.00m, 35000.00m
            };

            tributacoes = new List<Tributacao>();

            foreach (var salario in salarios)
            {
                var contribuicaoInss = tabelaInssAtual.ObterContribuicao(salario);
                var salarioTributavel = salario - contribuicaoInss;
                var irpfAtual = tabelaIrpfAtual.ObterImposto(salarioTributavel);
                var irpfNovo = tabelaIrpfNova.ObterImposto(salarioTributavel);

                var tributacao = new Tributacao
                {
                    Salario = salario,
                    ContribuiocaoInss = contribuicaoInss,
                    IrpfAtual = irpfAtual,
                    IrpfNovo = irpfNovo,
                };

                tributacoes.Add(tributacao);
            }
        }

        private void CriarTabelaInssAtual()
        {
            tabelaInssAtual = new TabelaInss();
            tabelaInssAtual.AdicionarFaixa(1693.72m, 0.08m);
            tabelaInssAtual.AdicionarFaixa(2822.90m, 0.09m);
            tabelaInssAtual.AdicionarFaixa(5645.80m, 0.11m);
        }

        private void CriarTabelaIrpfAtual()
        {
            tabelaIrpfAtual = new TabelaIrpf();
            tabelaIrpfAtual.AdicionarFaixa(1903.98m, 0m);
            tabelaIrpfAtual.AdicionarFaixa(2826.65m, 0.075m);
            tabelaIrpfAtual.AdicionarFaixa(3751.05m, 0.150m);
            tabelaIrpfAtual.AdicionarFaixa(4664.68m, 0.225m);
            tabelaIrpfAtual.AdicionarFaixa(null, 0.275m);
        }

        private void CriarTabelaIrpfNova()
        {
            tabelaIrpfNova = new TabelaIrpf();

            foreach (var textos in textosFaixas)
            {
                decimal aliquota;
                if (!decimal.TryParse(textos.Item2.Text, out aliquota))
                    break;

                decimal? fimFaixa = string.IsNullOrEmpty(textos.Item1.Text) ?
                    (decimal?)null : decimal.Parse(textos.Item1.Text);

                tabelaIrpfNova.AdicionarFaixa(fimFaixa, aliquota);
            }
        }

        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            CriarTabelaIrpfNova();
            CriarTributacoes();
            ExibirTributacoes();
        }
    }
}
