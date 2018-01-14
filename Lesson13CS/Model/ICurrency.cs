using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13CS.Model
{
    public enum Currency
    {
        UAH, USD, EUR
    }

    public interface ICurrency
    {
        Currency Currency { get; set; }
    }
}
