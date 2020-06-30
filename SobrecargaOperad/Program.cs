using System;

namespace SobrecargaOperad
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo();
            Rectangulo r1 = new Rectangulo();

            r1 = c1;


            //var resultado = c1 + r1;
            ////Si intentamos sumar estos dos objetos diferentes, VS nos avisaría que el operador + no se puede aplicar a
            ////operandos de tipo Circulo y Rectangulo. Y esto es porqué el compilador no sabe que es lo que realmente queremos
            ////hacer: es decir, si queremos sumar las areas o queremos hacer otra cosa.

            //var resultado2 = c1 + 50;
            ////Ahora ya podemos llevar a cabo esta operación, ya que tenemos sobrecarga de operadores que nos permite hacerlo.

            //var resultado3 = 30 + c1;

            //c1 += c1;
            //Console.WriteLine(c1.Area);

            //r1 += r1;
            //Console.WriteLine(r1.Area);

            //c1 += 10;
            //c1 += r1;
            //c1 += 10.5;
            //Circulo c1 = new Circulo();
            //Circulo c3 = new Circulo();
            //c1 += c3;
            //Console.WriteLine(c1.Area);

            //Circulo c2 = new Circulo();
            //c2++;
            //Console.WriteLine(c2.Area);

            //if (c2==20)
            //{
            //    Console.WriteLine("El área del circulo es 20");
            //}

            //if (c2==c1)
            //{
            //    Console.WriteLine("Los dos circulos tienen la misma área");
            //}

            //HacerAlgo((int)2.5);

            Console.ReadLine();
        }
        static void HacerAlgo(int param)
        {

        }

    }
}
