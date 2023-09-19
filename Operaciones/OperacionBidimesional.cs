using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class OperacionBidimesional : Operacion
    {
        public double altura;
        public double base_;
        public double perimetro;
        public decimal CalculaCuadrado()
        {
            area = Math.Pow(lado,2);
            perimetro = 4 * lado;
            return 0;
        }

        public decimal CalculaTriangulo()
        {
            area = base_ * altura;
            perimetro = 3 * lado;
            return 0;
        }
        public decimal CalculaCirculo()
        {
            area = pi * Math.Pow(radio,2);
            perimetro = 2 * pi * radio;
            return 0;
        }
        
    }
}
