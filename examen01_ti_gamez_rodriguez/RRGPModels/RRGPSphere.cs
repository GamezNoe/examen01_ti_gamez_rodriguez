using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen01_ti_gamez_rodriguez.RRGPInterfaces;

namespace examen01_ti_gamez_rodriguez.RRGPModels
{
    public class RRGPSphere : RRGPShape, RRGPArea , RRGPVolume
    {
        private double radius; 
        public RRGPSphere(double radius) => this.radius = radius;

        public double RRGPCalculateArea() => 4 * Math.PI * radius*radius;

        public double RRGPCalculateVolume() => (4/3) *Math.PI*Math.Pow(radius,3);
    }
}
