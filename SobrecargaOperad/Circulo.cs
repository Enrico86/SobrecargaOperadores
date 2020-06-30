using System;
using System.Collections.Generic;
using System.Text;

namespace SobrecargaOperad
{
    public class Circulo : Figura
    {
        public override void CalcularArea()
        {
            Area = 50;
        }

        public static Circulo operator +(Circulo lhs, Circulo rhs) => new Circulo { Area = lhs.Area + rhs.Area };
        public static Circulo operator +(Circulo lhs, double rhs) => new Circulo { Area = lhs.Area + rhs};
        public static Circulo operator +(Circulo lhs, int rhs) => new Circulo { Area = lhs.Area + rhs};
        public static Circulo operator +(Circulo lhs, Rectangulo rhs) => new Circulo { Area = lhs.Area + rhs.Area };

    }
}
