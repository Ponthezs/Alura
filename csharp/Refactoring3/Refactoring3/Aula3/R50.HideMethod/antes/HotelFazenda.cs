using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R50.HideMethod.antes
{
    class Programa
    {
        void Main()
        {
            var hotel = new HotelFazenda(500, 200, 800);

            Periodo periodo1 = new Periodo(new DateTime(2018, 1, 1), new DateTime(2018, 1, 6));
            var valor5DiasNoVerao = hotel.GetValorTotal(periodo1);

            Periodo periodo2 = new Periodo(new DateTime(2018, 4, 1), new DateTime(2018, 4, 8));
            var valor7DiasAposVerao = hotel.GetValorTotal(periodo2);
        }
    }

    class HotelFazenda
    {
        private decimal _taxaInverno;
        private decimal _taxaServicoInverno;
        private decimal _taxaVerao;

        public HotelFazenda(decimal taxaInverno, decimal taxaServicoInverno, decimal taxaVerao)
        {
            _taxaInverno = taxaInverno;
            _taxaServicoInverno = taxaServicoInverno;
            _taxaVerao = taxaVerao;
        }

        private DateTime INICIO_VERAO = new DateTime(2017, 12, 23);
        private DateTime FIM_VERAO = new DateTime(2018, 03, 21);

        public decimal GetValorTotal(Periodo periodoHospedagem)
        {
            if (NaoEhVerao(periodoHospedagem.DataInicial))
                return TaxaInverno(periodoHospedagem.Dias);

            return TaxaVerao(periodoHospedagem.Dias); //early return
        }

        public decimal TaxaVerao(int dias)
        {
            return dias * _taxaVerao;
        }

        private decimal TaxaInverno(int dias)
        {
            return dias * _taxaInverno + _taxaServicoInverno;
        }

        public bool NaoEhVerao(DateTime data)
        {
            return data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO);
        }
    }

    class Periodo
    {
        readonly DateTime dataInicial;
        readonly DateTime dataFinal;
        public DateTime DataInicial => dataInicial;
        public DateTime DataFinal => dataFinal;

        public int Dias
        {
            get
            {
                return (int)(dataFinal - dataInicial).TotalDays;
            }
        }

        public Periodo(DateTime dataInicio, DateTime dataFinal)
        {
            if ((dataFinal - dataInicio).TotalDays < 0)
            {
                throw new ArgumentException("Data final não pode ser anterior à data inicial");
            }

            this.dataInicial = dataInicio;
            this.dataFinal = dataFinal;
        }
    }

    static class DateTimeExtensions
    {
        public static bool EhAntesDe(this DateTime estaData, DateTime aquelaData)
        {
            return DateTime.Compare(aquelaData, estaData) < 0;
        }

        public static bool EhDepoisDe(this DateTime estaData, DateTime aquelaData)
        {
            return DateTime.Compare(aquelaData, estaData) > 0;
        }
    }

}
