using DesafioApisulMarcos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace DesafioApisul
{
    public partial class FrmTelaEstatisticas : Form
    {
        private List<ElevadorModel> dadosExternos;
        public FrmTelaEstatisticas()
        {
            InitializeComponent();
        }

        private void BtnLerJSON_Click(object sender, EventArgs e)
        {
            LoadJson();

        }

        private void Limpeza_Tela()
        {
            txtMenosUtilizado.Text = string.Empty;
            txtOutrosMenosUtilizados.Text = string.Empty;
            txtMaisFrequentadoMaiorFluxo.Text = string.Empty;
            txtMenosFrequentadoMenorFluxo.Text = string.Empty;
            txtMaiorUtilizacaoConjuntoElevadores.Text = string.Empty;
            txtPercentualCadaElevadorA.Text = string.Empty;
            txtPercentualCadaElevadorB.Text = string.Empty;
            txtPercentualCadaElevadorC.Text = string.Empty;
            txtPercentualCadaElevadorD.Text = string.Empty;

            txtPercentualCadaElevadorE.Text = string.Empty;
            txtPercentualCadaElevadorF.Text = string.Empty;
        }

        public void Respostas(Elevadores elevadores)
        {
            Limpeza_Tela();

            //Resposta A
            elevadores.andarMenosUtilizado(); // Atualizando as estatísticas
            txtMenosUtilizado.Text = elevadores.Statistics.AndarMenosUtilizado; // A1
            txtOutrosMenosUtilizados.Text = elevadores.Statistics.OutrosAndaresMenosUtilizado; // A2

            //Resposta B1 e B2
            elevadores.elevadorMaisFrequentado(); // Atualizando as estatísticas
            elevadores.periodoMaiorFluxoElevadorMaisFrequentado(); // Atualizando as estatísticas
            txtMaisFrequentadoMaiorFluxo.Text = elevadores.Statistics.ElevadorMaisFrequentadoMaiorFluxo;

            //Resposta C1 e C2
            elevadores.elevadorMenosFrequentado(); // Atualizando as estatísticas
            elevadores.periodoMenorFluxoElevadorMenosFrequentado(); // Atualizando as estatísticas
            txtMenosFrequentadoMenorFluxo.Text = elevadores.Statistics.ElevadorMenosFrequentadoMenorFluxo;

            //Resposta D
            elevadores.periodoMaiorUtilizacaoConjuntoElevadores(); // Atualizando as estatísticas
            txtMaiorUtilizacaoConjuntoElevadores.Text = elevadores.Statistics.PeriodoMaiorUtilizacaoConjuntoElevadores;

            //Resposta E - Percentuais de Cada Elevador
            var perUsoElevA = elevadores.percentualDeUsoElevadorA();
            decimal d;
            if (decimal.TryParse(perUsoElevA.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out d))
            {
                decimal t = Math.Truncate(d * 100) / 100;
                txtPercentualCadaElevadorA.Text = "Elevador A:" + t.ToString("0.##");
            }

            var perUsoElevB = elevadores.percentualDeUsoElevadorB();
            if (decimal.TryParse(perUsoElevB.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out d))
            {
                decimal t = Math.Truncate(d * 100) / 100;
                txtPercentualCadaElevadorB.Text = "Elevador B:" + t.ToString("0.##");
            }

            var perUsoElevC = elevadores.percentualDeUsoElevadorC();
            if (decimal.TryParse(perUsoElevC.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out d))
            {
                decimal t = Math.Truncate(d * 100) / 100;
                txtPercentualCadaElevadorC.Text = "Elevador C:" + t.ToString("0.##");
            }

            var perUsoElevD = elevadores.percentualDeUsoElevadorD();
            if (decimal.TryParse(perUsoElevD.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out d))
            {
                decimal t = Math.Truncate(d * 100) / 100;
                txtPercentualCadaElevadorD.Text = "Elevador D:" + t.ToString("0.##");
            }

            var perUsoElevE = elevadores.percentualDeUsoElevadorE();
            if (decimal.TryParse(perUsoElevE.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out d))
            {
                decimal t = Math.Truncate(d * 100) / 100;
                txtPercentualCadaElevadorE.Text = "Elevador E:" + t.ToString("0.##");
            }

            var perUsoElevF = elevadores.percentualDeUsoElevadorF();
            if (decimal.TryParse(perUsoElevF.ToString(), System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("pt-BR"), out d))
            {
                decimal t = Math.Truncate(d * 100) / 100;
                txtPercentualCadaElevadorF.Text = "Elevador F:" + t.ToString("0.##");
            }

        }
        public void LoadJson()
        {
            Entradas ent = new Entradas();

            List<ElevadorModel> elevadoresModel = new List<ElevadorModel>();

            elevadoresModel = ent.RecebeEntradas();

            Elevadores elevadores = new Elevadores(elevadoresModel);

            Respostas(elevadores);

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnJsonService_Click(object sender, EventArgs e)
        {
            dadosExternos = DataService.LerDadosExternos(@"C:\JsonService\dados_ext.json");

            if (dadosExternos.Count == 0)
            {
                MessageBox.Show("Não foi possível carregar os dados externos.");
                return;
            }

            AtualizarEstatisticas();
        }
        private void AtualizarEstatisticas()
        //Atualiza as Estatísticas com base em um Json externo, alimentado por outro sistema.
        {
            if (dadosExternos == null)
            {
                MessageBox.Show("Carregue os dados externos antes de atualizar as estatísticas.");
                return;
            }

            Elevadores elevadores = new Elevadores(dadosExternos);

            Respostas(elevadores);
        }
    }
}
