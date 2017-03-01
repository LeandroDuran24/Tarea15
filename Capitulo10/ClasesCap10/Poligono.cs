using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo10.Poligono
{
    public class Poligono
    {
        public Double Apotema { get; set; }
        public Poligono()
        {

        }
        public Poligono(Double Perimetro, Double Apotema)

        {
            Perimetro = Perimetro;
            Apotema = Apotema;
        }
    }
}
