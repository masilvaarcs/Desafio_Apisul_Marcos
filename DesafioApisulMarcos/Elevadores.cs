using System.Collections.Generic;
using System.Linq;

namespace DesafioApisulMarcos
{
    public class Elevadores : IElevadorService
    {
        public List<ElevadorModel> elevadores { get; set; }

        public ElevadorStatistics Statistics { get; set; } = new ElevadorStatistics();

        public Elevadores(List<ElevadorModel> elevadores)
        {
            this.elevadores = elevadores;
        }

        public List<int> andarMenosUtilizado()
        {
            var andaresMenosUtilizados = this.elevadores
                .GroupBy(e => e.Andar)
                .OrderBy(g => g.Count())
                .Select(g => g.Key)
                .ToList();

            Statistics.AndarMenosUtilizado = andaresMenosUtilizados.First().ToString();
            Statistics.OutrosAndaresMenosUtilizado = string.Join(", ", andaresMenosUtilizados.Skip(1));

            return andaresMenosUtilizados;
        }

        public List<string> elevadorMaisFrequentado()
        {
            var elevadorMaisFrequentado = this.elevadores
                .GroupBy(e => e.Elevador.ToString())
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .ToList();

            Statistics.ElevadorMaisFrequentadoMaiorFluxo = "Elevador: " + elevadorMaisFrequentado.First();

            return elevadorMaisFrequentado;
        }

        public List<string> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            string elevadorMaisFrequentado = this.elevadorMaisFrequentado().First();

            var periodos = this.elevadores
                .Where(e => e.Elevador.ToString() == elevadorMaisFrequentado)
                .GroupBy(e => e.Turno)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key.ToString())
                .ToList();

            Statistics.ElevadorMaisFrequentadoMaiorFluxo += " Turno: " + periodos.First();

            return periodos;
        }

        public List<string> elevadorMenosFrequentado()
        {
            var elevadorMenosFrequentado = this.elevadores
                .GroupBy(e => e.Elevador.ToString())
                .OrderBy(g => g.Count())
                .Select(g => g.Key)
                .ToList();

            Statistics.ElevadorMenosFrequentadoMenorFluxo = "Elevador: " + elevadorMenosFrequentado.First();

            return elevadorMenosFrequentado;
        }

        public List<string> periodoMenorFluxoElevadorMenosFrequentado()
        {
            string elevadorMenosFrequentado = this.elevadorMenosFrequentado().First();

            var periodos = this.elevadores
                .Where(e => e.Elevador.ToString() == elevadorMenosFrequentado)
                .GroupBy(e => e.Turno)
                .OrderBy(g => g.Count())
                .Select(g => g.Key.ToString())
                .ToList();

            Statistics.ElevadorMenosFrequentadoMenorFluxo += " Turno: " + periodos.First();

            return periodos;
        }

        public List<string> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            var periodos = this.elevadores
                .GroupBy(e => e.Turno)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key.ToString())
                .ToList();

            Statistics.PeriodoMaiorUtilizacaoConjuntoElevadores = periodos.First();

            return periodos;
        }

        public float percentualDeUsoElevadorA()
        {
            return CalculaPercentual('A');
        }

        public float percentualDeUsoElevadorB()
        {
            return CalculaPercentual('B');
        }

        public float percentualDeUsoElevadorC()
        {
            return CalculaPercentual('C');
        }

        public float percentualDeUsoElevadorD()
        {
            return CalculaPercentual('D');
        }

        public float percentualDeUsoElevadorE()
        {
            return CalculaPercentual('E');
        }

        public float percentualDeUsoElevadorF()
        {
            return CalculaPercentual('F');
        }


        private float CalculaPercentual(char elevador)
        {
            List<string> elevadores = new List<string>();
            this.elevadores.ForEach(e => elevadores.Add(e.Elevador));

            var percentual = ((float)elevadores.Count(i => i == elevador.ToString())) / elevadores.Count * 100;

            return float.Parse(percentual.ToString("F2"));
        }
    }

    public class ElevadorStatistics
    {
        public string AndarMenosUtilizado { get; set; }
        public string OutrosAndaresMenosUtilizado { get; set; }
        public string ElevadorMaisFrequentadoMaiorFluxo { get; set; }
        public string PeriodoMaiorFluxoElevadorMaisFrequentado { get; set; }
        public string ElevadorMenosFrequentadoMenorFluxo { get; set; }
        public string PeriodoMenorFluxoElevadorMenosFrequentado { get; set; }
        public string PeriodoMaiorUtilizacaoConjuntoElevadores { get; set; }
    }
}
