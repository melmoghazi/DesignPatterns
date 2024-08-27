using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    //make the constructor private
    public class CurrencyConverterSingleton
    {
        private static CurrencyConverterSingleton _instance;
        private static object _lock = new();
        public static CurrencyConverterSingleton Instance
        {
            get
            {
                //lock the creation of new instance to prevent 2 or more thead to create a new instance
                //if they reach the line in the same time.
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new();
                    }
                }
                return _instance;
            }
        }

        public IEnumerable<ExchangeRate> _exchangeRates;
        private CurrencyConverterSingleton()
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
