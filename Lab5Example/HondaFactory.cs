using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class HondaFactory : ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSedan();

                case "full":
                    return new HondaFullSedan();

                default:
                    throw new Exception();
            }
        }

        public ISuv ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "full":
                    return new HondaFullSuv();

                case "compact":
                    return new ToyotaCompactSuv();

                default:
                    throw new Exception();
            }
        }
    }
}
