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
            var tabelaAtual = new Tabela();

            tabelaAtual.AdicionarFaixa(1903.98m, 0m);
            tabelaAtual.AdicionarFaixa(2826.65m, 0.075m);
            tabelaAtual.AdicionarFaixa(3751.05m, 0.150m);
            tabelaAtual.AdicionarFaixa(4664.68m, 0.225m);
            tabelaAtual.AdicionarFaixa(null, 0.275m);

            var tabelaNova = new Tabela();

            tabelaNova.AdicionarFaixa(3000.00m, 0.000m);
            tabelaNova.AdicionarFaixa(4000.00m, 0.150m);
            tabelaNova.AdicionarFaixa(5000.00m, 0.250m);
            tabelaNova.AdicionarFaixa(8000.00m, 0.300m);
            tabelaNova.AdicionarFaixa(null, 0.350m);

            listBox1.Items.Clear();

            var salarios = new List<decimal>
            {
                2000m, 2500m, 3000m, 3500m, 4000m, 4500m, 5000m, 5500m, 6000m, 6500m, 7000m, 7500m, 8000m, 9000m,
                10000m, 12000m, 14000m, 16000m, 18000m, 20000m, 25000m, 30000m, 35000m
            };

            foreach (var salarioTributavel in salarios)
            {
                var impostoAtual = tabelaAtual.ObterImposto(salarioTributavel);
                var impostoNovo = tabelaNova.ObterImposto(salarioTributavel);

                listBox1.Items.Add($"Salário Tributável: {salarioTributavel}. " +
                    $"IRPF Atual: {impostoAtual}. " +
                    $"IRPF Novo: {impostoNovo}. " +
                    $"Diferença:{impostoNovo - impostoAtual}.");
            }
        }
    }
}
