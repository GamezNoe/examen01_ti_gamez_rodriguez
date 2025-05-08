using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen01_ti_gamez_rodriguez.RRGPInterfaces;

namespace examen01_ti_gamez_rodriguez.RRGPModels
{
    public class RRGPSquare : RRGPShape, RRGPArea
    {
        private double side;
        public RRGPSquare(double side) => this.side = side;

        public double RRGPCalculateArea() => side * side;
    }
}
