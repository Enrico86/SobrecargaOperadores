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

        public static Circulo operator +(Circulo lhs, Circulo rhs)
        { 
            lhs.Area += rhs.Area;
            return lhs;
        }
        //public static Circulo operator +(Circulo lhs, Circulo rhs) => new Circulo { Area = lhs.Area + rhs.Area };
        public static Circulo operator +(Circulo lhs, double rhs) => new Circulo { Area = lhs.Area + rhs};
        public static Circulo operator +(Circulo lhs, int rhs) => new Circulo { Area = lhs.Area + rhs};
        public static Circulo operator +(Circulo lhs, Rectangulo rhs) => new Circulo { Area = lhs.Area + rhs.Area };

        public static Circulo operator ++(Circulo circulo)
        { 
            circulo.Area++;
            return circulo;
        }
        public static Circulo operator --(Circulo op) => new Circulo { Area = --op.Area };

        public static bool operator ==(Circulo lhs, int rhs) => lhs.Area == rhs;
        public static bool operator !=(Circulo lhs, int rhs) => lhs.Area != rhs;
        public static bool operator ==(Circulo lhs, Circulo rhs) => lhs.Area == rhs.Area;
        public static bool operator !=(Circulo lhs, Circulo rhs) => lhs.Area != rhs.Area;

        public static bool operator <=(Circulo lhs, Circulo rhs) => lhs.Area <= rhs.Area;
        public static bool operator >=(Circulo lhs, Circulo rhs) => lhs.Area >= rhs.Area;


        public static implicit operator Rectangulo(Circulo circulo)=>new Rectangulo { Area = circulo.Area };
        //Primero hay que fijarse en que si queremos sobrecargar los operadores de conversión tendremos que especificar si
        //el compilador llevará a cabo implicitamente la conversión (palabra reservada implicit) o si exigirá al programador 
        //que especifique explicitamente que se trata de una conversión (palabra reservada explicit).
        //Y después de la palabra reservada operator tenemos que especificar el tipo da dato al que vamos a convertir el 
        //parametro que reciba el operador de conversión.
        //Por último en el cuerpo de expresión vamos a decirle que cuando el compilador lleve a cabo la conversión cogerá
        //el área del parametro circulo y la asignará al Area de una nueva instancia de la clase Rectangulo.

        
    }
}
