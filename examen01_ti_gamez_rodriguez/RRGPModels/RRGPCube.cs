using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen01_ti_gamez_rodriguez.RRGPInterfaces;

namespace examen01_ti_gamez_rodriguez.RRGPModels
{
    public class RRGPCube : RRGPArea, RRGPShape, RRGPVolume
    {
        private double side;
    public RRGPCube(double side) => this.side = side;

    public double RRGPCalculateArea() => 6 * side*side;

    public double RRGPCalculateVolume() => Math.Pow(side,3);


    }
}


