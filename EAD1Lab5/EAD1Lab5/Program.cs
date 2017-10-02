using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab5
{
    class Program
    {
        public struct Money
        {

            public Currency CurrencyType { get; set; }
            public double TotalAmount { get; set; }

            public Money(Currency currencyIn, double amountIn)
            {
                CurrencyType = currencyIn;
                TotalAmount = amountIn;
            }

            public double convertCurrency(Currency newCurrency)
            {
               double  yenPerEuro = 0.0076;
               double  euroPerDollar = 1.17;
               double  yenPerDollar = 0.0089;

                    if(CurrencyType == Currency.Yen && newCurrency ==Currency.Us)
                    {
                        TotalAmount = TotalAmount * yenPerDollar;                       
                    }
                    else if (CurrencyType == Currency.Yen && newCurrency == Currency.Euro)
                    {
                        TotalAmount = TotalAmount * yenPerEuro;
                    }
                    else if (CurrencyType == Currency.Euro && newCurrency == Currency.Us)
                    {
                        TotalAmount = TotalAmount * euroPerDollar;
                    }
                    else if (CurrencyType == Currency.Euro && newCurrency == Currency.Yen)
                    {
                        TotalAmount = TotalAmount / yenPerEuro;
                    }
                    else if (CurrencyType == Currency.Us && newCurrency == Currency.Euro)
                    {
                        TotalAmount = TotalAmount / euroPerDollar;
                    }
                    else if (CurrencyType == Currency.Us && newCurrency == Currency.Yen)
                    {
                        TotalAmount = TotalAmount / yenPerDollar;
                    }                

                CurrencyType = newCurrency;
                return TotalAmount;

            }
        }
        public enum Currency { Euro, Yen, Us }

        public Money addTwoCurrencies(Money a, Money b)
        {
            b.convertCurrency(a.CurrencyType);

            double sumOfCurrency = a.TotalAmount + b.TotalAmount;
            Money result = new Money(a.CurrencyType, sumOfCurrency);
            return result;
        }

        static void Main(string[] args)
        {

             Money addTwoCurrencies(Money a, Money b)
        {
                if(a.CurrencyType != b.CurrencyType)
                {
                    b.convertCurrency(a.CurrencyType);
                }           

            double sumOfCurrency = a.TotalAmount + b.TotalAmount;
            Money result = new Money(a.CurrencyType, sumOfCurrency);
            return result;
        }
            Currency firstCurrency = Currency.Euro;
            Currency secondCurrency = Currency.Us;

            Money firstMoney = new Money(firstCurrency, 1000);
            Money secondMoney = new Money(secondCurrency, 1000);

            Money convertMoneyAndAddTotal = addTwoCurrencies(firstMoney, secondMoney);

            Console.WriteLine("Total when converted to euro is: " + convertMoneyAndAddTotal.TotalAmount);
        }
    }
}
