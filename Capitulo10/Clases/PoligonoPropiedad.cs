﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo10.Clases
{
    public class PoligonoPropiedad
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }
        public PoligonoPropiedad()
        {

        }
        public PoligonoPropiedad(Double Perimetro, Double Apotema)

        {
            this.Perimetro = Perimetro;
            this.Apotema = Apotema;
        }

        public double Area
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 15; Apotema = 3.25; }
        }

    }
}
