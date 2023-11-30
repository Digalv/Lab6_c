using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public abstract class CurrencyConverter : ICurrencyConverter
    {

        private float _exchangeRate;
        private readonly string? _bankName;

        public string BankName
        {
            get { return _bankName; }
            init
            {
                string newValue = value.Trim();
                if (!string.IsNullOrEmpty(newValue) && newValue.Length > 1)
                {
                    _bankName = newValue;
                }
                else
                {
                    throw new FormatException("Incorrect bankName.");
                }
            }
        }

        public float ExchangeRate
        {
            get { return _exchangeRate; }
            init
            {
                if (value > 0)
                {
                    _exchangeRate = value;
                }
                else
                {
                    throw new FormatException("Incorrect exchangeRate.");
                }
            }
        }
        protected CurrencyConverter(string bankName, float exchangeRate)
        {
            BankName = bankName;
            ExchangeRate = exchangeRate;
        }

        public abstract double ConvertToUSD(double amount);
        public abstract double ConvertToEUR(double amount);
    }
}
