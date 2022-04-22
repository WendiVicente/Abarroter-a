using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Helper
{
    public class ConvertirPeso
    {
        const decimal ConversionQLb = 220.46m;
        const decimal ConversionQOnz = 3527.40m;
        const int ConversionLOnz = 16;

        public ConvertirPeso(){}

        public decimal ConvertirQLibra(decimal cantidad)
        {
            return decimal.Round((cantidad * ConversionQLb), 3);
        }

        public decimal ConvertirQOnza(decimal cantidad)
        {
            return decimal.Round((cantidad * ConversionQOnz), 3);
        }

        public decimal ConvertirLQuintal(decimal cantidad)
        {
            return decimal.Round((cantidad / ConversionQLb), 3);
        }

        public decimal ConvertirLOnza(decimal cantidad)
        {
            return decimal.Round((cantidad * ConversionLOnz), 3);
        }

        public decimal ConvertirOQuintal(decimal cantidad)
        {
            return decimal.Round((cantidad / ConversionQOnz), 3);
        }

        public decimal ConvertirOLibra(decimal cantidad)
        {
            return decimal.Round((cantidad / ConversionLOnz), 3);
        }
    }
}
