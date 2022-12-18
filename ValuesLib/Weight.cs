using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValuesLib;

namespace ConverterLib.Values
{
    internal class Weight : AnyValue
    {
        public Weight()
        {
            ValueName = "Вес";
            CoefficientsAndMeasuresList = new Dictionary<string, double>()
            {

                {"Килограммы", 1},
                {"граммы", 0.001},
                {"Тонны", 1000},
                {"Центнеры", 100},
            };
        }
    }
   
}
