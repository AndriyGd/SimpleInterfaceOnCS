using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13CS.Model
{
    public enum AppleColor
    {
        Green,
        Red,
        Yellow
    }

    public interface IApple: ICurrency, IPrice
    {
        string Kind { get; set; }
        AppleColor Color { get; set; }
    }
}
