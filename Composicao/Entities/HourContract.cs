using System;

namespace Composicao.Entities
{
    internal class HourContract
    {
        //atributos
        private DateTime _date;
        private double _valuePerHour;
        private int _hour;

        //construtor
        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {

            _date = date;
            _valuePerHour = valuePerHour;
            _hour = hour;


        }

        //get e set
        public DateTime GetDate()
        {

            return _date;

        }

        public void SetDate(DateTime date)
        {

            _date = date;

        }

        public double GetValuePerHour()
        {

            return _valuePerHour;

        }

        public void SetValuePerHour(double valuePerHour)
        {
            _valuePerHour = valuePerHour;
        }

        public int GetHour()
        {

            return _hour;

        }

        public void SetHour(int hour)
        {

            _hour = hour;

        }

        //methods
        public double TotalValue()
        {

            return GetHour() * GetValuePerHour();

        }
    }
}
