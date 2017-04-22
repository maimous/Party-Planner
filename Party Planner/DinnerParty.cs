using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
            {
                return (NumberOfPeople * 15.0M) + 50M;
            }
            else
            {
                return (NumberOfPeople * 7.50M) + 30M;
            }
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

        public decimal Cost
        {
            get
            {
                decimal totalCost = NumberOfPeople * (CostOfFoodPerPerson
                        + CalculateCostOfBeveragesPerPerson())
                        + CalculateCostOfDecorations();

                if (HealthyOption)
                {                    
                    return totalCost * 0.95M;
                }
                return totalCost;
            }
        }
        
    }
}
