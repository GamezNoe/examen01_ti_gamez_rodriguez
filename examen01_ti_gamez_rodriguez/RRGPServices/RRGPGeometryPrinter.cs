using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examen01_ti_gamez_rodriguez.RRGPInterfaces;

namespace examen01_ti_gamez_rodriguez.RRGPServices
{
    public class RRGPGeometryPrinter 
    {
        private RRGPAreaCalculator areaCalc;
        private RRGPVolumeCalculator volumeCalc;
        
        public RRGPGeometryPrinter (RRGPAreaCalculator areaCalc, RRGPVolumeCalculator volumeCalc)
        {
            this.areaCalc = areaCalc;
            this.volumeCalc = volumeCalc;
        }

        public void Area(RRGPArea shape,string name)
        {
            Console.WriteLine($"{name}:\nÁrea:{ areaCalc.Calculate(shape):F2}\n");
        }

        public void Volumen(RRGPVolume shape, string name)
        {
            Console.WriteLine($"Volume:{volumeCalc.Calculate(shape):F2}\n");
        }


    }
}
