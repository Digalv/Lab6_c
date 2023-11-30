using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class EuroCurrencyConverter : CurrencyConverter
    {

        public EuroCurrencyConverter(string bankName, float exchangeRate)
        : base(bankName, exchangeRate)
        { }
        
        public override double ConvertToUSD(double amount)
        {
            // Реализация конвертации в USD
            return amount / (ExchangeRate -(ExchangeRate * 0.1)); // Пример, реальная логика конвертации может отличаться
        }

        public override double ConvertToEUR(double amount)
        {
            // Реализация конвертации в EUR
            return amount / ExchangeRate; // Пример, реальная логика конвертации может отличаться
        }
        public override string ToString()
        {
            // Примерная реализация
            return $"EuroCurrencyConverter: BankName: {BankName}; ExchangeRate: {ExchangeRate}";
        }
    }
}
