using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RygOgRejse.Entities
{
    class PriceDetails
    {
        private decimal DestinationPrice;
        private decimal FirstClassPrice;
        private decimal LuggagePrice;
        private decimal TaxRate;
        public PriceDetails(decimal DestinationPrice, decimal FirstClassPrice, decimal LuggagePrice, decimal TaxRate)
        {
            this.DestinationPrice = DestinationPrice;
            this.FirstClassPrice = FirstClassPrice;
            this.LuggagePrice = LuggagePrice;
            this.TaxRate = TaxRate;
        }
        public decimal GetTaxAmount()
        {
            return (DestinationPrice) ;
        }
        public decimal GetTotalWithoutTax()
        {
            return 0;
        }
        public decimal GetTotalWithTax()
        {
            return 0;
        }


    }
}
