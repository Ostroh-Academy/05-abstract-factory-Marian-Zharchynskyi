using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class ToyotaFactory : ICarFactory
    {
        public ISedan ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSedan();
                case "full":
                    return new ToyotaFullSedan();
                default:
                    throw new Exception();
            }
        }

        public ISuv ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSuv();
                case "full":
                    return new ToyotaFullSuv();
                default:
                    throw new Exception();
            }
        }
    }
}
