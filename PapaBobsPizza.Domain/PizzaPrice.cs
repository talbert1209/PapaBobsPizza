using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsPizza.Domain
{
    public class PizzaPrice
    {
        private const decimal SmallPizzaPrice = 12.00M;
        private const decimal MediumPizzaPrice = 14.00M;
        private const decimal LargePizzaPrice = 16.00M;

        private const decimal ThickCrustPrice = 2.00M;

        private const decimal SausageToppingPrice = 2.00M;
        private const decimal PepperoniToppingPrice = 1.50M;
        private const decimal OnionsToppingPrice = 1.00M;
        private const decimal GreenPeppersToppingPrice = 1.00M;

        public static decimal GetPizzaSizePrice(int value)
        {
            switch (value)
            {
                case 1:
                    return SmallPizzaPrice;
                case 2:
                    return MediumPizzaPrice;
                case 3:
                    return LargePizzaPrice;
                default:
                    return 0M;
            }
        }

        public static decimal GetCrustPrice(int value)
        {
            switch (value)
            {
                case 3:
                    return ThickCrustPrice;
                default:
                    return 0M;
            }
        }

        public static decimal GetToppingPrice(bool sausage, bool pepperoni, bool onions, bool greenPeppers)
        {
            var toppingPrice = 0M;

            if (sausage) toppingPrice += SausageToppingPrice;

            if (pepperoni) toppingPrice += PepperoniToppingPrice;

            if (onions) toppingPrice += OnionsToppingPrice;

            if (greenPeppers) toppingPrice += GreenPeppersToppingPrice;

            return toppingPrice;
        }

        public static decimal CalculateTotal(int sizeIndex, int crustIndex, bool sausage, bool pepperoni, bool onions, bool greenPeppers)
        {
            return Domain.PizzaPrice.GetPizzaSizePrice(sizeIndex) +
                   Domain.PizzaPrice.GetCrustPrice(crustIndex) +
                   Domain.PizzaPrice.GetToppingPrice(sausage, pepperoni, onions, greenPeppers);
        }
    }
}
