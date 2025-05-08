using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen01_ti_gamez_rodriguez.RRGPInterfaces;

namespace examen01_ti_gamez_rodriguez.RRGPModels
{
    public class RRGPCircle: RRGPShape , RRGPArea
    {
        private double radius; 
        public RRGPCircle (double radius) => this.radius = radius;

        public double RRGPCalculateArea()=> Math.PI*radius*radius;
    }
}
