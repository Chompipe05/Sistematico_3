using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class OperacionTridimensional : Operacion
    {
        public double volumen;
        public double CalculaCubo()
        {
            area = 6 * Math.Pow(lado,2);
            volumen = Math.Pow(lado,3);
            return 0;
        }

        public double CalculaTriangulo()
        {
            area = Math.Pow(lado,2) * Math.Sqrt(3);
            volumen = Math.Pow(lado, 3) * (Math.Sqrt(3)/12);
            return 0;
        }
        public double CalculaCirculo()
        {
            area = 4 * pi * Math.Pow(radio, 2);
            volumen = (4/3) * pi * Math.Pow(radio, 3);
            return 0;
        }
    }
}
