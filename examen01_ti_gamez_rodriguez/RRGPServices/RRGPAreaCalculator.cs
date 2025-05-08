using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen01_ti_gamez_rodriguez.RRGPInterfaces;


namespace examen01_ti_gamez_rodriguez.RRGPServices
{
    public  class RRGPAreaCalculator
    {
        public double Calculate(RRGPArea shape) => shape.RRGPCalculateArea();

    }
}
