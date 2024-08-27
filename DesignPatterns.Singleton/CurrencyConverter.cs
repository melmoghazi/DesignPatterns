using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class CurrencyConverter
    {
        public IEnumerable<ExchangeRate> _exchangeRates;
        public CurrencyConverter()
        {
            LoadExchangeRate();
        }
        private void LoadExchangeRate()
        {
            //simulate that you read the exchange rate from external bank api
            //and chache them from 24 hours.
            Thread.Sleep(3000);
            _exchangeRates = new[]
            {
                 new ExchangeRate("USD", "SAR", 3.75m),
                 new ExchangeRate("USD", "EGP", 48.5m),
                 new ExchangeRate("SAR", "EGP", 13m),

            };
        }
        public decimal Convert(string baseCurrency, string targeCurrency, decimal amount)
        {
            var exchangeRate = _exchangeRates.FirstOrDefault(r => r.BaseCurrency == baseCurrency
                                                            && r.TargeCurrency == targeCurrency);
            if (exchangeRate == null)
                return 0;
            return (exchangeRate.Rate * amount);
        }
    }
}
