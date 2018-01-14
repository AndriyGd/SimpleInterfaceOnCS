using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13CS.Model
{
    public class CurrencyConverter
    {
        private static readonly Dictionary<Currency, double> _courceCurrency;

        static CurrencyConverter()
        {
            _courceCurrency = new Dictionary<Currency, double>
            {
                { Currency.EUR, 34 },
                { Currency.USD, 28 }
            };
        }

        public static double Convert(IPrice price, ICurrency sourceCurrency, Currency targetCurrency)
        {
            try
            {
                switch (sourceCurrency.Currency)
                {
                    case Currency.UAH:
                        switch (targetCurrency)
                        {
                            case Currency.UAH:
                                return price.Price;
                            case Currency.USD:
                            case Currency.EUR:
                                var a = _courceCurrency[targetCurrency];
                                var newPrice = Math.Round(price.Price / a, 2, MidpointRounding.AwayFromZero);
                                return newPrice;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(targetCurrency), targetCurrency, null);
                        }
                    case Currency.USD:
                        break;
                    case Currency.EUR:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(sourceCurrency), sourceCurrency, null);
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return price.Price;
        }

        public static void ConvertD(IPrice price, ICurrency sourceCurrency, Currency targetCurrency)
        {
            try
            {
                switch (sourceCurrency.Currency)
                {
                    case Currency.UAH:
                        switch (targetCurrency)
                        {
                            case Currency.UAH:
                                price.Price = price.Price;
                                break;
                            case Currency.USD:
                            case Currency.EUR:
                                var a = _courceCurrency[targetCurrency];
                                var newPrice = Math.Round(price.Price / a, 2, MidpointRounding.AwayFromZero);
                                price.Price = newPrice;
                                sourceCurrency.Currency = targetCurrency;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(targetCurrency), targetCurrency, null);
                        }
                        break;
                    case Currency.USD:
                        break;
                    case Currency.EUR:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(sourceCurrency), sourceCurrency, null);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
