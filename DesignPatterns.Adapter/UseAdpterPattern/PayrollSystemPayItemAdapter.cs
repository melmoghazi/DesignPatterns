

using DesignPatterns.Adapter.Core;

namespace DesignPatterns.Adapter.UseAdpterPattern
{
    public class PayrollSystemPayItemAdapter
    {
        private readonly PayItem _payItem;
        public PayrollSystemPayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }

        public string Name => _payItem.Name;
        public decimal Value => _payItem.IsDedection ? _payItem.Value * -1 : _payItem.Value;
    }
}
