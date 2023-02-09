using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R48.IntroduceParameterObject.depois
{
    class Programa
    {
        void Main()
        {
            var hotel = new HotelFazenda(500, 200, 800);
            var valor5DiasNoVerao = hotel.GetValorTotal(new Periodo(new DateTime(2018, 1, 1), new DateTime(2018, 1, 6)));
            var valor7DiasAposVerao = hotel.GetValorTotal(new Periodo(new DateTime(2018, 4, 1), new DateTime(2018, 4, 8)));
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
            var dias = (int)(periodoHospedagem.Fim - periodoHospedagem.Inicio).TotalDays;

            if (NaoEhVerao(periodoHospedagem.Inicio))
                return TaxaInverno(dias);

            return TaxaVerao(dias); //early return
        }

        private decimal TaxaVerao(int dias)
        {
            return dias * _taxaVerao;
        }

        private decimal TaxaInverno(int dias)
        {
            return dias * _taxaInverno + _taxaServicoInverno;
        }

        private bool NaoEhVerao(DateTime data)
        {
            return data.EhAntesDe(INICIO_VERAO) || data.EhDepoisDe(FIM_VERAO);
        }
    }

    class Periodo
    {
        readonly DateTime inicio;
        readonly DateTime fim;
        public DateTime Inicio => inicio;
        public DateTime Fim => fim;

        public Periodo(DateTime inicio, DateTime fim)
        {
            if ((fim - inicio).TotalDays < 0)
            {
                throw new ArgumentException("Datas estão invertidas!");
            }

            this.inicio = inicio;
            this.fim = fim;
        }


        public int Dias()
        {
            return (int)(fim - inicio).TotalDays;
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
