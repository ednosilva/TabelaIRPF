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
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tabelaInss = new TabelaInss();
            tabelaInss.AdicionarFaixa(1693.72m, 0.08m);
            tabelaInss.AdicionarFaixa(2822.90m, 0.09m);
            tabelaInss.AdicionarFaixa(5645.80m, 0.11m);

            var tabelaIrpfAtual = new TabelaIrpf();

            tabelaIrpfAtual.AdicionarFaixa(1903.98m, 0m);
            tabelaIrpfAtual.AdicionarFaixa(2826.65m, 0.075m);
            tabelaIrpfAtual.AdicionarFaixa(3751.05m, 0.150m);
            tabelaIrpfAtual.AdicionarFaixa(4664.68m, 0.225m);
            tabelaIrpfAtual.AdicionarFaixa(null, 0.275m);

            var tabelaIrpfNova = new TabelaIrpf();

            tabelaIrpfNova.AdicionarFaixa(3000.00m, 0.000m);
            tabelaIrpfNova.AdicionarFaixa(4000.00m, 0.150m);
            tabelaIrpfNova.AdicionarFaixa(5000.00m, 0.250m);
            tabelaIrpfNova.AdicionarFaixa(null, 0.300m);

            listBox1.Items.Clear();

            var salarios = new List<decimal>
            {
                2000m, 2500m, 3000m, 3500m, 4000m, 4500m, 5000m, 5500m, 6000m, 6500m, 7000m, 7500m, 8000m, 8500m, 9000m,
                9500m, 10000m, 11000m, 12000m, 13000m, 14000m, 15000m, 16000m, 18000m, 20000m, 25000m, 30000m, 35000m
            };

            foreach (var salario in salarios)
            {
                var contribuicaoInss = tabelaInss.ObterContribuicao(salario);

                var salarioTributavel = salario - contribuicaoInss;

                var impostoAtual = tabelaIrpfAtual.ObterImposto(salarioTributavel);
                var impostoNovo = tabelaIrpfNova.ObterImposto(salarioTributavel);

                listBox1.Items.Add($"Salário: {salario}. " +
                    $"Salário Tributável: {salarioTributavel}. " +
                    $"IRPF Atual: {impostoAtual}. " +
                    $"IRPF Novo: {impostoNovo}. " +
                    $"Diferença:{impostoNovo - impostoAtual}.");
            }
        }
    }
}
