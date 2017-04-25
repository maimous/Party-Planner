using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }      
        
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

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;
                
                return totalCost;
            }
        }
    }
}
