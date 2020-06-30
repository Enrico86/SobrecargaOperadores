using System;
using System.Collections.Generic;
using System.Text;

namespace SobrecargaOperad
{
    public class Rectangulo : Figura
    {
        public override void CalcularArea()
        {
            Area = 80;
            //Para no complicar el código el método CalcularArea asigna siempre la misma´´Area a las instancias de esta clase. 
            //Es para fines demostrativos de como sobrecargar operadores, no es para explicar cómo calcular el área de cada 
            //figura geometrica
        }

        public static Rectangulo operator +(Rectangulo lhs, Rectangulo rhs) => new Rectangulo { Area = lhs.Area + rhs.Area };
    }
}
