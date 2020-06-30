using System;

namespace SobrecargaOperad
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo();
            Rectangulo r1 = new Rectangulo();

            var resultado = c1 + r1;
            //Si intentamos sumar estos dos objetos diferentes, VS nos avisaría que el operador + no se puede aplicar a
            //operandos de tipo Circulo y Rectangulo. Y esto es porqué el compilador no sabe que es lo que realmente queremos
            //hacer: es decir, si queremos sumar las areas o queremos hacer otra cosa.

            var resultado2 = c1 + 50;
            //Ahora ya podemos llevar a cabo esta operación, ya que tenemos sobrecarga de operadores que nos permite hacerlo.

            var resultado3 = 30 + c1;


        }
    }
}
