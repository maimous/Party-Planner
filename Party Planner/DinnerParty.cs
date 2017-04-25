using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty : Party
    {
        
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
                

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return 5.0M;
            }
            else
            {
                return 20.0M;
            }
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += NumberOfPeople * CalculateCostOfBeveragesPerPerson();

                if (HealthyOption)
                {                    
                    return totalCost * 0.95M;
                }
                return totalCost;
            }
        }
        
    }
}
