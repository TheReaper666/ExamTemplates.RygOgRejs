using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RygOgRejse.Entities
{
    class Journey
    {
        protected int adults;
        protected int children;
        protected PriceDetails currentPriceDetails;
        protected DateTime departure;
        protected Destination destination;
        protected bool isFirstClass;
        protected double luggageAmount;
        
        public void AddLuggage(double amount)
        {
            luggageAmount =+ amount;
        }
        public void AddPersons(int adults, int children)
        {
            this.adults = adults;
            this.children = children;
        }
        public void ChangeDestinationTo(Destination NewDestination)
        {
            destination = NewDestination;
        }
        public decimal GetCurrentTotal()
        {
            return 0;
        }

    }
}
