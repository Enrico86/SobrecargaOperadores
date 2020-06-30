using System;
using System.Collections.Generic;
using System.Text;

namespace SobrecargaOperad
{
    public abstract class Figura
    {
        public double Area { get; set; }

        public abstract void CalcularArea();

        public Figura()
        {
            CalcularArea();
            //Esto es con el propósito que cada vez que se creen instancias de las clases que hereden de esta 
            //clase figura, inmediatamente se lleve a cabo el calculo de su área.
            //Y ya que cada figura tiene una implementación diferente de este método (cada figura calcula el
            //area de manera diferente) lo dejamos de esta manera para que en cada clase que herede de Digura se 
            //tenga que sobrescribir este método.
        }

        public static double operator +(Figura lhs, Figura rhs) => lhs.Area + rhs.Area;
        //Para la sobrecarga de operadores
        //Es importante especificar el modificador de acceso public y es obligatorio utilizar la palabra static
        //Luego tenemos que especificar el tipo de dato a devolver cuando aplicamos este operador en estas clase.
        //Y para nuestro ejemplo deseamos devolver la suma de las dos Areas, que son dos datos de tipo double, por
        //lo tanto también el resultado lo será.
        //Después va la palabra reservada operator, para indicar que estamos sobrecargando un operador, y seguidamente
        //el operador a sobrecargar, en nuestro caso el +. Vimos anteiormente que cuando queremos aplicar una operación
        //de suma, se necesitan dos operandos. Entre parentesis por lo tanto le decimos que parametros se necesitan
        //y en nuestro caso son dos objetos de tipo Figura (estamos utilizando el concepto de polimorfismo). Los llamaremos
        //por convención lhs (operando de izquierda, left) y rhs (operando de derecha, right)
        //Y en el cuerpo del método (métodos con cuerpo de expresión, con el operador lambda) definimos que este método
        //irá a coger el area del operando Figura de la izquierda y lo sumará al area del operando de la derecha.

        public static double operator +(Figura lhs, int rhs) => lhs.Area + rhs;
        public static double operator +(int lhs, Figura rhs) => lhs+ rhs.Area;



    }
}
