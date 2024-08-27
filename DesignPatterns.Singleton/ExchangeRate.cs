using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class ExchangeRate
    {
        public ExchangeRate(string baseCurrency,string targeCurrency,decimal rate)
        {
            BaseCurrency = baseCurrency;
            TargeCurrency = targeCurrency;
            Rate = rate;
        }
        public string BaseCurrency { get; set; }
        public string TargeCurrency { get; set; }
        public decimal Rate { get; set; }
    }
}
